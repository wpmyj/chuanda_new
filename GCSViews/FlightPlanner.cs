using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using DotSpatial.Data;
using DotSpatial.Projections;
using GeoUtility.GeoSystem;
using GeoUtility.GeoSystem.Base;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Ionic.Zip;
using log4net;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Controls.Waypoints;
using ByAeroBeHero.Maps;
using ByAeroBeHero.Properties;
using ByAeroBeHero.Utilities;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using SharpKml.Base;
using SharpKml.Dom;
using Feature = SharpKml.Dom.Feature;
using ILog = log4net.ILog;
using Placemark = SharpKml.Dom.Placemark;
using Point = System.Drawing.Point;

namespace ByAeroBeHero.GCSViews
{
    public partial class FlightPlanner : MyUserControl, IDeactivate, IActivate
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        int selectedrow;
        public bool quickadd;
        bool isonline = true;
        bool sethome;
        bool polygongridmode;
        bool polygonlimitmode;
        Hashtable param = new Hashtable();
        bool splinemode;
        altmode currentaltmode = altmode.Relative;

        bool grid;

        public static FlightPlanner instance;

        public bool autopan { get; set; }

        public List<PointLatLngAlt> pointlist = new List<PointLatLngAlt>(); // used to calc distance
        public List<PointLatLngAlt> fullpointlist = new List<PointLatLngAlt>();
        public GMapRoute route = new GMapRoute("wp route");
        public GMapRoute homeroute = new GMapRoute("home route");
        public GMapRoute flyRoute = new GMapRoute("fly route");
        static public Object thisLock = new Object();
        private ComponentResourceManager rm = new ComponentResourceManager(typeof(FlightPlanner));

        private Dictionary<string, string[]> cmdParamNames = new Dictionary<string, string[]>();
        

        List<List<Locationwp>> history = new List<List<Locationwp>>();

        List<int> groupmarkers = new List<int>();

        public enum altmode
        {
            Relative = MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT,
            Absolute = MAVLink.MAV_FRAME.GLOBAL,
            Terrain = MAVLink.MAV_FRAME.GLOBAL_TERRAIN_ALT
        }

        private void poieditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentGMapMarker == null)
                return;

            POI.POIEdit(CurrentGMapMarker.Position);
        }

        private void poideleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentGMapMarker == null)
                return;

            POI.POIDelete(CurrentGMapMarker.Position);
        }

        private void poiaddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POI.POIAdd(MouseDownStart);
        }

        /// <summary>
        /// used to adjust existing point in the datagrid including "H"
        /// </summary>
        /// <param name="pointno"></param>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <param name="alt"></param>
        public void callMeDrag(string pointno, double lat, double lng, int alt)
        {
            if (pointno == "")
            {
                return;
            }

            // dragging a WP
            if (pointno == "H")
            {
                if (isonline && CHK_verifyheight.Checked)
                {
                    TXT_homealt.Text = getGEAlt(lat, lng).ToString();
                }
                TXT_homelat.Text = lat.ToString();
                TXT_homelng.Text = lng.ToString();
                return;
            }

            if (pointno == "Tracker Home")
            {
                MainV2.comPort.MAV.cs.TrackerLocation = new PointLatLngAlt(lat, lng, alt, "");
                return;
            }

            try
            {
                selectedrow = int.Parse(pointno) - 1;
                Commands.CurrentCell = Commands[1, selectedrow];
            }
            catch
            {
                return;
            }

            setfromMap(lat, lng, alt);
        }
        /// <summary>
        /// Actualy Sets the values into the datagrid and verifys height if turned on
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <param name="alt"></param>
        public void setfromMap(double lat, double lng, float alt, double p1 = 0)
        {
            if (selectedrow > Commands.RowCount)
            {
                //Invalid coord, How did you do this?
                CustomMessageBox.Show("无效坐标！");
                return;
            }

            // add history
            history.Add(GetCommandList());

            // remove more than 20 revisions
            if (history.Count > 20)
            {
                history.RemoveRange(0, history.Count - 20);
            }

            DataGridViewTextBoxCell cell;

            if (Commands.Columns[Lat.Index].HeaderText.Equals(cmdParamNames["航点"][4]/*"Lat"*/))
            {
                cell = Commands.Rows[selectedrow].Cells[Lat.Index] as DataGridViewTextBoxCell;
                cell.Value = lat.ToString("0.0000000");
                cell.DataGridView.EndEdit();
            }
            if (Commands.Columns[Lon.Index].HeaderText.Equals(cmdParamNames["航点"][5]/*"Long"*/))
            {
                cell = Commands.Rows[selectedrow].Cells[Lon.Index] as DataGridViewTextBoxCell;
                cell.Value = lng.ToString("0.0000000");
                cell.DataGridView.EndEdit();
            }
            if (alt != -1 && Commands.Columns[Alt.Index].HeaderText.Equals(cmdParamNames["航点"][6]/*"Alt"*/))
            {
                cell = Commands.Rows[selectedrow].Cells[Alt.Index] as DataGridViewTextBoxCell;

                {
                    double result;
                    bool pass = double.TryParse(TXT_homealt.Text, out result);

                    if (pass == false)
                    {
                        CustomMessageBox.Show("你必须有一个初始的高度！");
                        string homealt = "100";
                        if (DialogResult.Cancel == InputBox.Show("初始高度", "初始高度", ref homealt))
                            return;
                        TXT_homealt.Text = homealt;
                    }
                    int results1;
                    if (!int.TryParse(TXT_DefaultAlt.Text, out results1))
                    {
                        //Your default alt is not valid
                        CustomMessageBox.Show("默认的高度是无效的！");
                        return;
                    }

                    if (results1 == 0)
                    {
                        string defalt = "100";

                        if (DialogResult.Cancel == InputBox.Show("默认高度", "默认高度", ref defalt))
                            return;
                        TXT_DefaultAlt.Text = defalt;
                    }
                }

                cell.Value = TXT_DefaultAlt.Text;

                float ans;
                if (float.TryParse(cell.Value.ToString(), out ans))
                {
                    ans = (int)ans;
                    if (alt != 0) // use passed in value;
                        cell.Value = alt.ToString();
                    if (ans == 0) // default
                        cell.Value = 50;
                    if (ans == 0 && (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2))
                        cell.Value = 15;

                    // not online and verify alt via srtm
                    if (CHK_verifyheight.Checked) // use srtm data
                    {
                        // is absolute but no verify
                        if ((altmode)CMB_altmode.SelectedValue == altmode.Absolute)
                        {
                            //abs
                            cell.Value = ((srtm.getAltitude(lat, lng).alt) * CurrentState.multiplierdist + int.Parse(TXT_DefaultAlt.Text)).ToString();
                        }
                        else
                        {
                            //relative and verify
                            cell.Value = ((int)(srtm.getAltitude(lat, lng).alt) * CurrentState.multiplierdist + int.Parse(TXT_DefaultAlt.Text) - (int)srtm.getAltitude(MainV2.comPort.MAV.cs.HomeLocation.Lat, MainV2.comPort.MAV.cs.HomeLocation.Lng).alt * CurrentState.multiplierdist).ToString();

                        }
                    }

                    cell.DataGridView.EndEdit();
                }
                else
                {
                    CustomMessageBox.Show("Invalid Home or wp Alt");
                    cell.Style.BackColor = Color.Red;
                }

            }

            // Add more for other params
            if (Commands.Columns[Param1.Index].HeaderText.Equals(cmdParamNames["航点"][0]/*"Delay"*/))
            {
                cell = Commands.Rows[selectedrow].Cells[Param1.Index] as DataGridViewTextBoxCell;
                cell.Value = p1;
                cell.DataGridView.EndEdit();
            }

            writeKML();
            Commands.EndEdit();
        }

        PointLatLngAlt mouseposdisplay = new PointLatLngAlt(0, 0);

        /// <summary>
        /// Used for current mouse position
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <param name="alt"></param>
        public void SetMouseDisplay(double lat, double lng, float alt)
        {
            mouseposdisplay.Lat = lat;
            mouseposdisplay.Lng = lng;
            mouseposdisplay.Alt = alt;

            coords1.Lat = mouseposdisplay.Lat;
            coords1.Lng = mouseposdisplay.Lng;
            coords1.Alt = srtm.getAltitude(mouseposdisplay.Lat, mouseposdisplay.Lng, MainMap.Zoom).alt;

            try
            {
                PointLatLng last;

                if (pointlist[pointlist.Count - 1] == null)
                    return;

                last = pointlist[pointlist.Count - 1];

                double lastdist = MainMap.MapProvider.Projection.GetDistance(last, currentMarker.Position);

                double lastbearing = 0;

                if (pointlist.Count > 0)
                {
                    lastbearing = MainMap.MapProvider.Projection.GetBearing(last, currentMarker.Position);
                }

                lbl_prevdist.Text = rm.GetString("lbl_prevdist.Text") + ":" + FormatDistance(lastdist, true);

                this.lblhxj.Text = "航向角:" + lastbearing.ToString("0") + "度";


                // 0 is home
                if (pointlist[0] != null)
                {
                    double homedist = MainMap.MapProvider.Projection.GetDistance(currentMarker.Position, pointlist[0]);

                    lbl_homedist.Text = rm.GetString("lbl_homedist.Text") + ":" + FormatDistance(homedist, true);
                }
            }
            catch { }
        }

        /// <summary>
        /// Used to create a new WP
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <param name="alt"></param>
        public void AddWPToMap(double lat, double lng, int alt)
        {
            if (polygongridmode)
            {
                addPolygonPointToolStripMenuItem_Click(null, null);
                return;
            }

            if (sethome)
            {
                sethome = false;
                callMeDrag("H", lat, lng, alt);
                return;
            }
            // creating a WP

            selectedrow = Commands.Rows.Add();

            if (splinemode)
            {
                Commands.Rows[selectedrow].Cells[Command.Index].Value = mavcndchange(MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString());
                ChangeColumnHeader(mavcndchange(MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString()));
            }
            else
            {
                Commands.Rows[selectedrow].Cells[Command.Index].Value = "航点";
                //ChangeColumnHeader(MAVLink.MAV_CMD.WAYPOINT.ToString());
                ChangeColumnHeader("航点");
            }

            setfromMap(lat, lng, alt);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // undo
            if (keyData == (Keys.Control | Keys.Z))
            {
                if (history.Count > 0)
                {
                    int no = history.Count - 1;
                    var pop = history[no];
                    history.RemoveAt(no);
                    WPtoScreen(pop);
                }
                return true;
            }

            // open wp file
            if (keyData == (Keys.Control | Keys.O))
            {
                loadWPFileToolStripMenuItem_Click(null, null);
                return true;
            }

            // save wp file
            if (keyData == (Keys.Control | Keys.S))
            {
                saveWPFileToolStripMenuItem_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public FlightPlanner()
        {
            instance = this;

            InitializeComponent();

            // config map             
            MainMap.CacheLocation = Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + "gmapcache" + Path.DirectorySeparatorChar;
            MainMap.MapProvider = GoogleChinaHybridMapProvider.Instance;
            // map events
            MainMap.OnPositionChanged += MainMap_OnCurrentPositionChanged;
            MainMap.OnTileLoadStart += MainMap_OnTileLoadStart;
            MainMap.OnTileLoadComplete += MainMap_OnTileLoadComplete;
            MainMap.OnMarkerClick += MainMap_OnMarkerClick;
            MainMap.OnMapZoomChanged += MainMap_OnMapZoomChanged;
            MainMap.OnMapTypeChanged += MainMap_OnMapTypeChanged;
            MainMap.MouseMove += MainMap_MouseMove;
            MainMap.MouseDown += MainMap_MouseDown;
            MainMap.MouseUp += MainMap_MouseUp;
            MainMap.OnMarkerEnter += MainMap_OnMarkerEnter;
            MainMap.OnMarkerLeave += MainMap_OnMarkerLeave;

            MainMap.MapScaleInfoEnabled = false;
            MainMap.ScalePen = new Pen(Color.Red);

            MainMap.DisableFocusOnMouseEnter = true;

            MainMap.ForceDoubleBuffer = false;

            //WebRequest.DefaultWebProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;

            // get map type
            //获取地面站使用的五种地图
            System.Collections.ArrayList Map = new System.Collections.ArrayList();
            for (int i = 1; i < GMapProviders.List.Count; i++)
            {
                if (GMapProviders.List[i].Id == new Guid("b8a2a78d-1c49-45d0-8f03-9b95c83116b7")
                    ||GMapProviders.List[i].Id == new Guid("ef3dd303-3f74-4938-bf40-232d0595ee88")
                    || GMapProviders.List[i].Id == new Guid("fca94af4-3467-47c6-bda2-6f52e4a145bc")
                    || GMapProviders.List[i].Id == new Guid("d0ceb371-f10a-4e12-a2c1-df617d6674a8")
                    || GMapProviders.List[i].Id == new Guid("3ac742dd-966b-4cfb-b67d-33e7f82f2d37")
                    || GMapProviders.List[i].Id == new Guid("94e2fcb4-caac-45ea-a1f9-8147c4b14970")
                    )
                {
                    Map.Add(GMapProviders.List[i]);
                }
            }
            comboBoxMapType.ValueMember = "Name";
            comboBoxMapType.DataSource = Map;
            comboBoxMapType.SelectedItem = MainMap.MapProvider;

            comboBoxMapType.SelectedValueChanged += comboBoxMapType_SelectedValueChanged;

            MainMap.RoutesEnabled = true;

            //MainMap.MaxZoom = 18;

            // get zoom  
            MainMap.MinZoom = 5;
            MainMap.MaxZoom = 24;

            // draw this layer first
            kmlpolygonsoverlay = new GMapOverlay("kmlpolygons");
            MainMap.Overlays.Add(kmlpolygonsoverlay);

            geofenceoverlay = new GMapOverlay("geofence");
            MainMap.Overlays.Add(geofenceoverlay);

            rallypointoverlay = new GMapOverlay("rallypoints");
            MainMap.Overlays.Add(rallypointoverlay);

            routesoverlay = new GMapOverlay("routes");
            MainMap.Overlays.Add(routesoverlay);

            flyRoutesoverlay = new GMapOverlay("flyRoutes");
            MainMap.Overlays.Add(flyRoutesoverlay);

            polygonsoverlay = new GMapOverlay("polygons");
            MainMap.Overlays.Add(polygonsoverlay);

            airportsoverlay = new GMapOverlay("airports");
            MainMap.Overlays.Add(airportsoverlay);

            objectsoverlay = new GMapOverlay("objects");
            MainMap.Overlays.Add(objectsoverlay);

            drawnpolygonsoverlay = new GMapOverlay("drawnpolygons");
            MainMap.Overlays.Add(drawnpolygonsoverlay);

            drawnlimitpolygonsoverlay = new GMapOverlay("drawnlimitpolygons");
            MainMap.Overlays.Add(drawnlimitpolygonsoverlay);

            breakploygonsoverlay = new GMapOverlay("breakploygons");
            MainMap.Overlays.Add(breakploygonsoverlay);

            MainMap.Overlays.Add(poioverlay);



            top = new GMapOverlay("top");
            //MainMap.Overlays.Add(top);

            objectsoverlay.Markers.Clear();

            // set current marker
            currentMarker = new GMarkerGoogle(MainMap.Position, GMarkerGoogleType.red);
            //top.Markers.Add(currentMarker);

            // map center
            center = new GMarkerGoogle(MainMap.Position, GMarkerGoogleType.none);
            top.Markers.Add(center);

            MainMap.Zoom = 3;

            MainMap.Position = new PointLatLng(40.0648192363, 116.3455521063);

            CMB_altmode.DisplayMember = "Value";
            CMB_altmode.ValueMember = "Key";
            CMB_altmode.DataSource = EnumTranslator.EnumToList<altmode>();

            //set default
            CMB_altmode.SelectedItem = altmode.Relative;

            RegeneratePolygon();

            if (MainV2.getConfig("MapType") != "")
            {
                try
                {
                    var index = GMapProviders.List.FindIndex(x => (x.Name == MainV2.getConfig("MapType")));

                    if (index != -1)
                        comboBoxMapType.SelectedIndex = index;
                }
                catch { }
            }

            updateCMDParams();

            Up.Image = Resources.up;
            Down.Image = Resources.down;

            // hide the map to prevent redraws when its loaded
            panelMap.Visible = false;
            comboBoxMapType.SelectedIndex = 5;
        }

        void updateCMDParams()
        {

            cmdParamNames = readCMDXML();

            List<string> cmds = new List<string>();

            //foreach (string item in cmdParamNames.Keys)
            //{
            //    cmds.Add(item);
            //}
            //cmds.Add("WAYPOINT");
            //cmds.Add("LOITER_TURNS");
            //cmds.Add("LOITER_TIME");
            //cmds.Add("RETURN_TO_LAUNCH");
            //cmds.Add("LAND");
            //cmds.Add("TAKEOFF");
            //cmds.Add("DO_JUMP");
            //cmds.Add("UNKNOWN");

            cmds.Add("航点");
            cmds.Add("曲线航点");
            cmds.Add("盘旋_圈数");
            cmds.Add("悬停_时间");
            cmds.Add("返航");
            cmds.Add("降落");
            cmds.Add("起飞");
            cmds.Add("执行跳转");
            cmds.Add("悬停_持续");
            cmds.Add("速度_改变");
            cmds.Add("未知");

            Command.DataSource = cmds;
        }

        Dictionary<string, string[]> readCMDXML()
        {
            Dictionary<string, string[]> cmd = new Dictionary<string, string[]>();

            // do lang stuff here

            string file = Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + "mavcmd.xml";

            if (!File.Exists(file))
            {
                CustomMessageBox.Show("Missing mavcmd.xml file");
                return cmd;
            }

            using (XmlReader reader = XmlReader.Create(file))
            {
                reader.Read();
                reader.ReadStartElement("CMD");
                if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduPlane || MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Ateryx)
                {
                    reader.ReadToFollowing("APM");
                }
                else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduRover)
                {
                    reader.ReadToFollowing("APRover");
                }
                else
                {
                    reader.ReadToFollowing("AC2");
                }

                XmlReader inner = reader.ReadSubtree();

                inner.Read();

                inner.MoveToElement();

                inner.Read();

                while (inner.Read())
                {
                    inner.MoveToElement();
                    if (inner.IsStartElement())
                    {
                        string cmdname = inner.Name;
                        string[] cmdarray = new string[7];
                        int b = 0;

                        XmlReader inner2 = inner.ReadSubtree();

                        inner2.Read();

                        while (inner2.Read())
                        {
                            inner2.MoveToElement();
                            if (inner2.IsStartElement())
                            {
                                cmdarray[b] = inner2.ReadString();
                                b++;
                            }
                        }

                        cmd[cmdname] = cmdarray;
                    }
                }
            }

            return cmd;
        }

        void Commands_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            log.Info(e.Exception + " " + e.Context + " col " + e.ColumnIndex);
            e.Cancel = false;
            e.ThrowException = false;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a new row to the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BUT_Add_Click(object sender, EventArgs e)
        {
            if (Commands.CurrentRow == null)
            {
                selectedrow = 0;
            }
            else
            {
                selectedrow = Commands.CurrentRow.Index;
            }

            if (Commands.RowCount <= 1)
            {
                selectedrow = Commands.Rows.Add();
            }
            else
            {
                if (Commands.RowCount == selectedrow + 1)
                {
                    DataGridViewRow temp = Commands.Rows[selectedrow];
                    selectedrow = Commands.Rows.Add();
                }
                else
                {
                    Commands.Rows.Insert(selectedrow + 1, 1);
                }
            }
            writeKML();
        }

        private void FlightPlanner_Load(object sender, EventArgs e)
        {
            InitControl(); 
            quickadd = true;

            config(false);

            quickadd = false;

            POI.POIModified += POI_POIModified;

            if (MainV2.config["WMSserver"] != null)
                WMSProvider.CustomWMSURL = MainV2.config["WMSserver"].ToString();

            trackBar1.Value = (int)MainMap.Zoom;

            // check for net and set offline if needed
            try
            {
                IPAddress[] addresslist = Dns.GetHostAddresses("www.google.com");
            }
            catch (Exception)
            { // here if dns failed
                isonline = false;
            }

            // setup geofence
            List<PointLatLng> polygonPoints = new List<PointLatLng>();
            geofencepolygon = new GMapPolygon(polygonPoints, "geofence");
            geofencepolygon.Stroke = new Pen(Color.Pink, 5);
            geofencepolygon.Fill = Brushes.Transparent;

            //setup drawnpolgon
            List<PointLatLng> polygonPoints2 = new List<PointLatLng>();
            drawnpolygon = new GMapPolygon(polygonPoints2, "drawnpoly");
            drawnpolygon.Stroke = new Pen(Color.Red, 2);
            drawnpolygon.Fill = Brushes.Transparent;

            //setup drawnpolgon
            List<PointLatLng> polygonPoints3 = new List<PointLatLng>();
            drawnpolygonlimit = new GMapPolygon(polygonPoints2, "drawnpolylimit");
            drawnpolygonlimit.Stroke = new Pen(Color.Orange, 2);
            drawnpolygonlimit.Fill = Brushes.Transparent;

            updateCMDParams();

            panelMap.Visible = false;       

            // mono
            panelMap.Dock = DockStyle.None;
            panelMap.Dock = DockStyle.Fill;
            panelMap_Resize(null, null);          

            //set home
            try
            {
                if (TXT_homelat.Text != "")
                {
                    //MainMap.Position = new PointLatLng(double.Parse(TXT_homelat.Text), double.Parse(TXT_homelng.Text));
                    //MainMap.Zoom = 7;
                }

            }
            catch (Exception) { }

            panelMap.Refresh();

            panelMap.Visible = true;

            writeKML();        

            // switch the action and wp table
            //if (MainV2.getConfig("FP_docking") == "Bottom")
            //{
                switchDockingToolStripMenuItem_Click(null, null);
            //}

            addbreakWayPoint(true);

            timer1.Start();
            timer_getbreakpoint.Start();
            timer_time.Start();
        }

        /// <summary>
        /// 控制控件属性
        /// </summary>
        private void InitControl() 
        {
            MainV2.instance.controlMainMenuColor("MenuFlightPlanner");
        }
        void POI_POIModified(object sender, EventArgs e)
        {
            POI.UpdateOverlay(poioverlay);
        }

        void parser_ElementAdded(object sender, ElementEventArgs e)
        {
            processKML(e.Element);
        }

        private void processKML(Element Element)
        {
            try
            {
                //  log.Info(Element.ToString() + " " + Element.Parent);
            }
            catch { }

            Document doc = Element as Document;
            Placemark pm = Element as Placemark;
            Folder folder = Element as Folder;
            Polygon polygon = Element as Polygon;
            LineString ls = Element as LineString;

            if (doc != null)
            {
                foreach (var feat in doc.Features)
                {
                    //Console.WriteLine("feat " + feat.GetType());
                    //processKML((Element)feat);
                }
            }
            else
                if (folder != null)
                {
                    foreach (Feature feat in folder.Features)
                    {
                        //Console.WriteLine("feat "+feat.GetType());
                        //processKML(feat);
                    }
                }
                else if (pm != null)
                {

                }
                else if (polygon != null)
                {
                    GMapPolygon kmlpolygon = new GMapPolygon(new List<PointLatLng>(), "kmlpolygon");

                    kmlpolygon.Stroke.Color = Color.Purple;

                    foreach (var loc in polygon.OuterBoundary.LinearRing.Coordinates)
                    {
                        kmlpolygon.Points.Add(new PointLatLng(loc.Latitude, loc.Longitude));
                    }

                    kmlpolygonsoverlay.Polygons.Add(kmlpolygon);
                }
                else if (ls != null)
                {
                    GMapRoute kmlroute = new GMapRoute(new List<PointLatLng>(), "kmlroute");

                    kmlroute.Stroke.Color = Color.Purple;

                    foreach (var loc in ls.Coordinates)
                    {
                        kmlroute.Points.Add(new PointLatLng(loc.Latitude, loc.Longitude));
                    }

                    kmlpolygonsoverlay.Routes.Add(kmlroute);
                }
        }

        private void ChangeColumnHeader(string command)
        {

            try
            {
                if (cmdParamNames.ContainsKey(command))
                    for (int i = 1; i <= 7; i++)
                        Commands.Columns[i].HeaderText = cmdParamNames[command][i - 1];
                else
                    for (int i = 1; i <= 7; i++)
                        Commands.Columns[i].HeaderText = "";
            }
            catch (Exception ex) { CustomMessageBox.Show(ex.ToString()); }
        }

        /// <summary>
        /// Used to update column headers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Commands_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (quickadd)
                return;
            try
            {
                selectedrow = e.RowIndex;
                string option = Commands[Command.Index, selectedrow].EditedFormattedValue.ToString();
                string cmd;
                try
                {
                    cmd = Commands[Command.Index, selectedrow].Value.ToString();
                }
                catch { cmd = option; }
                //Console.WriteLine("editformat " + option + " value " + cmd);
                ChangeColumnHeader(cmd);

                setgradanddistandaz();

                if (cmd == "航点")
                {

                }

                //  writeKML();
            }
            catch (Exception ex) { CustomMessageBox.Show(ex.ToString()); }
        }

        private void Commands_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < Commands.ColumnCount; i++)
            {
                DataGridViewCell tcell = Commands.Rows[e.RowIndex].Cells[i];
                if (tcell.GetType() == typeof(DataGridViewTextBoxCell))
                {
                    if (tcell.Value == null)
                        tcell.Value = "0";
                }
            }

            DataGridViewComboBoxCell cell = Commands.Rows[e.RowIndex].Cells[Command.Index] as DataGridViewComboBoxCell;
            if (cell.Value == null)
            {
                cell.Value = "航点";
                cell.DropDownWidth = 200;
                Commands.Rows[e.RowIndex].Cells[Delete.Index].Value = "X";
                if (!quickadd)
                {
                    Commands_RowEnter(sender, new DataGridViewCellEventArgs(0, e.RowIndex - 0)); // do header labels
                    Commands_RowValidating(sender, new DataGridViewCellCancelEventArgs(0, e.RowIndex)); // do default values
                }
            }

            if (quickadd)
                return;

            try
            {
                Commands.CurrentCell = Commands.Rows[e.RowIndex].Cells[0];

                if (Commands.Rows.Count > 1)
                {

                    if (Commands.Rows[e.RowIndex - 1].Cells[Command.Index].Value.ToString() == "WAYPOINT")
                    {
                        Commands.Rows[e.RowIndex].Selected = true; // highlight row
                    }
                    else
                    {
                        Commands.CurrentCell = Commands[1, e.RowIndex - 1];
                        //Commands_RowEnter(sender, new DataGridViewCellEventArgs(0, e.RowIndex-1));
                    }
                }
            }
            catch (Exception) { }
            // Commands.EndEdit();
        }
        private void Commands_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            selectedrow = e.RowIndex;
            Commands_RowEnter(sender, new DataGridViewCellEventArgs(0, e.RowIndex - 0)); // do header labels - encure we dont 0 out valid colums
            int cols = Commands.Columns.Count;
            for (int a = 1; a < cols; a++)
            {
                DataGridViewTextBoxCell cell;
                cell = Commands.Rows[selectedrow].Cells[a] as DataGridViewTextBoxCell;

                if (Commands.Columns[a].HeaderText.Equals("") && cell != null && cell.Value == null)
                {
                    cell.Value = "0";
                }
                else
                {
                    if (cell != null && (cell.Value == null || cell.Value.ToString() == ""))
                    {
                        cell.Value = "?";
                    }
                }
            }
        }

        /// <summary>
        /// used to add a marker to the map display
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="lng"></param>
        /// <param name="lat"></param>
        /// <param name="alt"></param>
        private void addpolygonmarker(string tag, double lng, double lat, int alt, Color? color)
        {
            try
            {
                PointLatLng point = new PointLatLng(lat, lng);
                GMapMarkerWP m = new GMapMarkerWP(point, tag);
                m.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                m.ToolTipText = "Alt: " + alt.ToString("0");
                m.Tag = tag;

                try
                {
                    // preselect groupmarker
                    if (groupmarkers.Contains(int.Parse(tag)))
                        m.selected = true;
                }
                catch { }

                //ByAeroBeHero.GMapMarkerRectWPRad mBorders = new ByAeroBeHero.GMapMarkerRectWPRad(point, (int)float.Parse(TXT_WPRad.Text), MainMap);
                GMapMarkerRect mBorders = new GMapMarkerRect(point);
                {
                    mBorders.InnerMarker = m;
                    mBorders.Tag = tag;
                    mBorders.wprad = (int)(float.Parse(TXT_WPRad.Text) / CurrentState.multiplierdist);
                    if (color.HasValue)
                    {
                        mBorders.Color = color.Value;
                    }
                }

                objectsoverlay.Markers.Add(m);
                objectsoverlay.Markers.Add(mBorders);
            }
            catch (Exception) { }
        }

        private void addpolygonmarkergrid(string tag, double lng, double lat, double alt)
        {
            try
            {
                PointLatLng point = new PointLatLng(lat, lng);
                GMarkerGoogle m = new GMarkerGoogle(point, GMarkerGoogleType.red);
                m.ToolTipMode = MarkerTooltipMode.OnMouseOver;

                ShowDistance(drawnpolygon.Points); 

                string lineDistance = " |" + "距离"+ tag + "-" + (Convert.ToInt16(tag) - 1).ToString() +": " + currentDistance
                    + bearing;
                if (tag == "1")
                    lineDistance = string.Empty;
                m.ToolTipText = "区域航点" + tag + lineDistance;
                m.Tag = "区域航点" + tag;

                //ByAeroBeHero.GMapMarkerRectWPRad mBorders = new ByAeroBeHero.GMapMarkerRectWPRad(point, (int)float.Parse(TXT_WPRad.Text), MainMap);
                GMapMarkerRect mBorders = new GMapMarkerRect(point);
                {
                    mBorders.InnerMarker = m;
                }

                drawnpolygonsoverlay.Markers.Add(m);
                drawnpolygonsoverlay.Markers.Add(mBorders);
                
            }
            catch (Exception ex) { log.Info(ex.ToString()); }
        }


        void updateRowNumbers()
        {
            // number rows 
            Thread t1 = new Thread(delegate()
            {
                // thread for updateing row numbers
                for (int a = 0; a < Commands.Rows.Count - 0; a++)
                {
                    // this.BeginInvoke((MethodInvoker)delegate
                    {
                        try
                        {
                            if (Commands.Rows[a].HeaderCell.Value == null)
                            {
                                Commands.Rows[a].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                                Commands.Rows[a].HeaderCell.Value = (a + 1).ToString();
                            }
                            // skip rows with the correct number
                            string rowno = Commands.Rows[a].HeaderCell.Value.ToString();
                            if (!rowno.Equals((a + 1).ToString()))
                            {
                                // this code is where the delay is when deleting.
                                Commands.Rows[a].HeaderCell.Value = (a + 1).ToString();
                            }
                        }
                        catch (Exception) { }
                    }//);
                }
            });
            t1.Name = "行数更新";
            t1.IsBackground = true;
            t1.Start();
        }

        /// <summary>
        /// used to write a KML, update the Map view polygon, and update the row headers
        /// </summary>
        public void writeKML()
        {
            // quickadd is for when loading wps from eeprom or file, to prevent slow, loading times
            if (quickadd)
                return;

            // this is to share the current mission with the data tab
            pointlist = new List<PointLatLngAlt>();

            fullpointlist.Clear();

            Debug.WriteLine(DateTime.Now);
            try
            {
                if (objectsoverlay != null) // hasnt been created yet
                {
                    objectsoverlay.Markers.Clear();
                }

                // process and add home to the list
                string home;
                if (TXT_homealt.Text != "" && TXT_homelat.Text != "" && TXT_homelng.Text != "")
                {
                    home = string.Format("{0},{1},{2}\r\n", TXT_homelng.Text, TXT_homelat.Text, TXT_DefaultAlt.Text);
                    if (objectsoverlay != null) // during startup
                    {
                        pointlist.Add(new PointLatLngAlt(double.Parse(TXT_homelat.Text), double.Parse(TXT_homelng.Text), (int)double.Parse(TXT_homealt.Text), "H"));
                        fullpointlist.Add(pointlist[pointlist.Count - 1]);
                        addpolygonmarker("H", double.Parse(TXT_homelng.Text), double.Parse(TXT_homelat.Text), 0, null);
                    }
                }
                else
                {
                    home = "";
                    pointlist.Add(null);
                    fullpointlist.Add(pointlist[pointlist.Count - 1]);
                }

                // setup for centerpoint calc etc.
                double avglat = 0;
                double avglong = 0;
                double maxlat = -180;
                double maxlong = -180;
                double minlat = 180;
                double minlong = 180;
                double homealt = 0;
                try
                {
                    if (!String.IsNullOrEmpty(TXT_homealt.Text))
                        homealt = (int)double.Parse(TXT_homealt.Text);
                }
                catch { }
                if ((altmode)CMB_altmode.SelectedValue == altmode.Absolute)
                {
                    homealt = 0; // for absolute we dont need to add homealt
                }

                int usable = 0;

                updateRowNumbers();

                long temp = Stopwatch.GetTimestamp();

                string lookat = "";
                for (int a = 0; a < Commands.Rows.Count - 0; a++)
                {
                    try
                    {
                        if (Commands.Rows[a].Cells[Command.Index].Value.ToString().Contains("未知"))
                            continue;

                        string commandValue = Commands.Rows[a].Cells[Command.Index].Value.ToString();

                        int command = (byte)(int)Enum.Parse(typeof(MAVLink.MAV_CMD),mavcnd(commandValue) , false);
                        if (command < (byte)MAVLink.MAV_CMD.LAST && 
                            command != (byte)MAVLink.MAV_CMD.TAKEOFF && 
                            command != (byte)MAVLink.MAV_CMD.RETURN_TO_LAUNCH && 
                            command != (byte)MAVLink.MAV_CMD.CONTINUE_AND_CHANGE_ALT &&
                            command != (byte)MAVLink.MAV_CMD.GUIDED_ENABLE
                            || command == (byte)MAVLink.MAV_CMD.DO_SET_ROI)
                        {
                            string cell2 = Commands.Rows[a].Cells[Alt.Index].Value.ToString(); // alt
                            string cell3 = Commands.Rows[a].Cells[Lat.Index].Value.ToString(); // lat
                            string cell4 = Commands.Rows[a].Cells[Lon.Index].Value.ToString(); // lng

                            // land can be 0,0 or a lat,lng
                            if (command == (byte)MAVLink.MAV_CMD.LAND && cell3 == "0" && cell4 == "0")
                                continue;

                            if (cell4 == "?" || cell3 == "?")
                                continue;

                            if (command == (byte)MAVLink.MAV_CMD.DO_SET_ROI)
                            {
                                pointlist.Add(new PointLatLngAlt(double.Parse(cell3), double.Parse(cell4), (int)double.Parse(cell2) + homealt, "ROI" + (a + 1)) { color = Color.Red });
                                // do set roi is not a nav command. so we dont route through it
                                //fullpointlist.Add(pointlist[pointlist.Count - 1]);
                                GMarkerGoogle m = new GMarkerGoogle(new PointLatLng(double.Parse(cell3), double.Parse(cell4)), GMarkerGoogleType.red);
                                m.ToolTipMode = MarkerTooltipMode.Always;
                                m.ToolTipText = (a + 1).ToString();
                                m.Tag = (a + 1).ToString();

                                GMapMarkerRect mBorders = new GMapMarkerRect(m.Position);
                                {
                                    mBorders.InnerMarker = m;
                                    mBorders.Tag = "不画线";
                                }

                                // check for clear roi, and hide it
                                if (m.Position.Lat != 0 && m.Position.Lng != 0)
                                {
                                    // order matters
                                    objectsoverlay.Markers.Add(m);
                                    objectsoverlay.Markers.Add(mBorders);
                                }
                            }
                            else if (command == (byte)MAVLink.MAV_CMD.LOITER_TIME || command == (byte)MAVLink.MAV_CMD.LOITER_TURNS || command == (byte)MAVLink.MAV_CMD.LOITER_UNLIM)
                            {
                                pointlist.Add(new PointLatLngAlt(double.Parse(cell3), double.Parse(cell4), (int)double.Parse(cell2) + homealt, (a + 1).ToString()) { color = Color.Teal });
                                fullpointlist.Add(pointlist[pointlist.Count - 1]);
                                addpolygonmarker((a + 1).ToString(), double.Parse(cell4), double.Parse(cell3), (int)double.Parse(cell2), Color.Teal);
                            }
                            else if (command == (byte)MAVLink.MAV_CMD.SPLINE_WAYPOINT)
                            {
                                pointlist.Add(new PointLatLngAlt(double.Parse(cell3), double.Parse(cell4), (int)double.Parse(cell2) + homealt, (a + 1).ToString()) { Tag2 = "spline" });
                                fullpointlist.Add(pointlist[pointlist.Count - 1]);
                                addpolygonmarker((a + 1).ToString(), double.Parse(cell4), double.Parse(cell3), (int)double.Parse(cell2), Color.Green);
                            }
                            else
                            {
                                pointlist.Add(new PointLatLngAlt(double.Parse(cell3), double.Parse(cell4), (int)double.Parse(cell2) + homealt, (a + 1).ToString()));
                                fullpointlist.Add(pointlist[pointlist.Count - 1]);
                                addpolygonmarker((a + 1).ToString(), double.Parse(cell4), double.Parse(cell3), (int)double.Parse(cell2), null);
                            }

                            avglong += double.Parse(Commands.Rows[a].Cells[Lon.Index].Value.ToString());
                            avglat += double.Parse(Commands.Rows[a].Cells[Lat.Index].Value.ToString());
                            usable++;

                            maxlong = Math.Max(double.Parse(Commands.Rows[a].Cells[Lon.Index].Value.ToString()), maxlong);
                            maxlat = Math.Max(double.Parse(Commands.Rows[a].Cells[Lat.Index].Value.ToString()), maxlat);
                            minlong = Math.Min(double.Parse(Commands.Rows[a].Cells[Lon.Index].Value.ToString()), minlong);
                            minlat = Math.Min(double.Parse(Commands.Rows[a].Cells[Lat.Index].Value.ToString()), minlat);

                            Debug.WriteLine(temp - Stopwatch.GetTimestamp());
                        }
                        else if (command == (byte)MAVLink.MAV_CMD.DO_JUMP) // fix do jumps into the future
                        {
                            pointlist.Add(null);

                            int wpno = int.Parse(Commands.Rows[a].Cells[Param1.Index].Value.ToString());
                            int repeat = int.Parse(Commands.Rows[a].Cells[Param2.Index].Value.ToString());

                            List<PointLatLngAlt> list = new List<PointLatLngAlt>();

                            // cycle through reps
                            for (int repno = repeat; repno > 0; repno--)
                            {
                                // cycle through wps
                                for (int no = wpno; no <= a; no++)
                                {
                                    if (pointlist[no] != null)
                                        list.Add(pointlist[no]);
                                }
                            }

                            fullpointlist.AddRange(list);
                        }
                        else
                        {
                            pointlist.Add(null);
                        }
                    }
                    catch (Exception e) { log.Info("writekml - bad wp data " + e); }
                }

                if (usable > 0)
                {
                    avglat = avglat / usable;
                    avglong = avglong / usable;
                    double latdiff = maxlat - minlat;
                    double longdiff = maxlong - minlong;
                    float range = 4000;

                    Locationwp loc1 = new Locationwp();
                    loc1.lat = (minlat);
                    loc1.lng = (minlong);
                    Locationwp loc2 = new Locationwp();
                    loc2.lat = (maxlat);
                    loc2.lng = (maxlong);

                    //double distance = getDistance(loc1, loc2);  // same code as ardupilot
                    double distance = 2000;

                    if (usable > 1)
                    {
                        range = (float)(distance * 2);
                    }
                    else
                    {
                        range = 4000;
                    }

                    if (avglong != 0 && usable < 3)
                    {
                        // no autozoom
                        lookat = "<LookAt>     <longitude>" + (minlong + longdiff / 2).ToString(new CultureInfo("en-US")) + "</longitude>     <latitude>" + (minlat + latdiff / 2).ToString(new CultureInfo("en-US")) + "</latitude> <range>" + range + "</range> </LookAt>";
                        //MainMap.ZoomAndCenterMarkers("objects");
                        //MainMap.Zoom -= 1;
                        //MainMap_OnMapZoomChanged();
                    }
                }
                else if (home.Length > 5 && usable == 0)
                {
                    lookat = "<LookAt>     <longitude>" + TXT_homelng.Text.ToString(new CultureInfo("en-US")) + "</longitude>     <latitude>" + TXT_homelat.Text.ToString(new CultureInfo("en-US")) + "</latitude> <range>4000</range> </LookAt>";

                    RectLatLng? rect = MainMap.GetRectOfAllMarkers("objects");
                    if (rect.HasValue)
                    {
                        //MainMap.Position = rect.Value.LocationMiddle;
                    }

                    //MainMap.Zoom = 17;

                    MainMap_OnMapZoomChanged();
                }

                //RegeneratePolygon();

                RegenerateWPRoute(fullpointlist);

                if (fullpointlist.Count > 0)
                {
                    double homedist = 0;

                    if (home.Length > 5)
                    {
                        homedist = MainMap.MapProvider.Projection.GetDistance(fullpointlist[fullpointlist.Count - 1], fullpointlist[0]);
                    }

                    double dist = 0;

                    for (int a = 1; a < fullpointlist.Count; a++)
                    {
                        if (fullpointlist[a - 1] == null)
                            continue;

                        if (fullpointlist[a] == null)
                            continue;

                        dist += MainMap.MapProvider.Projection.GetDistance(fullpointlist[a - 1], fullpointlist[a]);
                    }

                    lbl_distance.Text = rm.GetString("lbl_distance.Text") + ":" + FormatDistance(dist + homedist, false);
                }

                setgradanddistandaz();
            }
            catch (Exception ex)
            {
                log.Info(ex.ToString());
            }

            Debug.WriteLine(DateTime.Now);

        }

        private  string mavcnd(string mode)
        {
            string _mode = string.Empty;
            if (mode == "航点")
            {
                _mode = "WAYPOINT";
            }
            else if (mode == "盘旋_圈数")
            {
                _mode = "LOITER_TURNS";
            }
            else if (mode == "悬停_时间")
            {
                _mode = "LOITER_TIME";
            }
            else if (mode == "返航")
            {
                _mode = "RETURN_TO_LAUNCH";
            }
            else if (mode == "降落")
            {
                _mode = "LAND";
            }
            else if (mode == "起飞")
            {
                _mode = "TAKEOFF";
            }
            else if (mode == "执行跳转")
            {
                _mode = "DO_JUMP";
            }
            else if (mode == "悬停_持续")
            {
                _mode = "LOITER_UNLIM";
            }
            else if (mode == "速度_改变")
            {
                _mode = "DO_CHANGE_SPEED";
            }
            else if (mode == "航向_保持")
            {
                _mode = "CONDITION_YAW";
            }
            else if (mode == "曲线航点")
            {
                _mode = "SPLINE_WAYPOINT";
            }
            else 
            {
                _mode = mode;
            }

            return _mode;
        }

        private string mavcndchange(string mode)
        {
            string _mode = string.Empty;
            if (mode == "WAYPOINT")
            {
                _mode = "航点";
            }
            else if (mode == "LOITER_TURNS")
            {
                _mode = "盘旋_圈数";
            }
            else if (mode == "LOITER_TIME")
            {
                _mode = "悬停_时间";
            }
            else if (mode == "RETURN_TO_LAUNCH")
            {
                _mode = "返航";
            }
            else if (mode == "LAND")
            {
                _mode = "降落";
            }
            else if (mode == "TAKEOFF")
            {
                _mode = "起飞";
            }
            else if (mode == "DO_JUMP")
            {
                _mode = "执行跳转";
            }
            else if (mode == "LOITER_UNLIM") 
            {
                _mode = "悬停_持续";            
            }
            else if (mode == "DO_CHANGE_SPEED")
            {
                _mode = "速度_改变";
            }
            else if (mode == "CONDITION_YAW")
            {
                _mode = "航向_保持";
            }
            else if (mode == "SPLINE_WAYPOINT")
            {
                _mode = "曲线航点";
            }

            return _mode;
        } 
        private void RegenerateWPRoute(List<PointLatLngAlt> fullpointlist)
        {


            route.Clear();
            homeroute.Clear();

            polygonsoverlay.Routes.Clear();

            PointLatLngAlt lastpnt = fullpointlist[0];
            PointLatLngAlt lastpnt2 = fullpointlist[0];
            PointLatLngAlt lastnonspline = fullpointlist[0];
            List<PointLatLngAlt> splinepnts = new List<PointLatLngAlt>();
            List<PointLatLngAlt> wproute = new List<PointLatLngAlt>();

            // add home - this causeszx the spline to always have a straight finish
            fullpointlist.Add(fullpointlist[0]);

            for (int a = 0; a < fullpointlist.Count; a++)
            {
                if (fullpointlist[a] == null)
                    continue;

                if (fullpointlist[a].Tag2 == "spline")
                {
                    if (splinepnts.Count == 0)
                        splinepnts.Add(lastpnt);

                    splinepnts.Add(fullpointlist[a]);
                }
                else
                {
                    if (splinepnts.Count > 0)
                    {
                        List<PointLatLng> list = new List<PointLatLng>();

                        splinepnts.Add(fullpointlist[a]);

                        Spline2 sp = new Spline2();

                        //sp._flags.segment_type = ByAeroBeHero.Controls.Waypoints.Spline2.SegmentType.SEGMENT_STRAIGHT;
                        //sp._flags.reached_destination = true;
                        //sp._origin = sp.pv_location_to_vector(lastpnt);
                        //sp._destination = sp.pv_location_to_vector(fullpointlist[0]);

                        // sp._spline_origin_vel = sp.pv_location_to_vector(lastpnt) - sp.pv_location_to_vector(lastnonspline);

                        sp.set_wp_origin_and_destination(sp.pv_location_to_vector(lastpnt2), sp.pv_location_to_vector(lastpnt));

                        sp._flags.reached_destination = true;

                        for (int no = 1; no < (splinepnts.Count - 1); no++)
                        {
                            Spline2.spline_segment_end_type segtype = Spline2.spline_segment_end_type.SEGMENT_END_STRAIGHT;

                            if (no < (splinepnts.Count - 2))
                            {
                                segtype = Spline2.spline_segment_end_type.SEGMENT_END_SPLINE;
                            }

                            sp.set_spline_destination(sp.pv_location_to_vector(splinepnts[no]), false, segtype, sp.pv_location_to_vector(splinepnts[no + 1]));

                            //sp.update_spline();

                            while (sp._flags.reached_destination == false)
                            {
                                float t = 1f;
                                //sp.update_spline();
                                sp.advance_spline_target_along_track(t);
                                // Console.WriteLine(sp.pv_vector_to_location(sp.target_pos).ToString());
                                list.Add(sp.pv_vector_to_location(sp.target_pos));
                            }

                            list.Add(splinepnts[no]);

                        }

                        list.ForEach(x =>
                            {
                                wproute.Add(x);
                            });


                        splinepnts.Clear();

                        /*
                        ByAeroBeHero.Controls.Waypoints.Spline sp = new Controls.Waypoints.Spline();
                        
                        var spline = sp.doit(splinepnts, 20, lastlastpnt.GetBearing(splinepnts[0]),false);

                  
                         */

                        lastnonspline = fullpointlist[a];
                    }

                    wproute.Add(fullpointlist[a]);

                    lastpnt2 = lastpnt;
                    lastpnt = fullpointlist[a];
                }
            }
            /*

           List<PointLatLng> list = new List<PointLatLng>();
           fullpointlist.ForEach(x => { list.Add(x); });
           route.Points.AddRange(list);
           */
            // route is full need to get 1, 2 and last point as "HOME" route

            int count = wproute.Count;
            int counter = 0;
            PointLatLngAlt homepoint = new PointLatLngAlt();
            PointLatLngAlt firstpoint = new PointLatLngAlt();
            PointLatLngAlt lastpoint = new PointLatLngAlt();

            if (count > 2)
            {
                // homeroute = last, home, first
                wproute.ForEach(x =>
                {
                    counter++;
                    if (counter == 1) { homepoint = x; return; }
                    if (counter == 2) { firstpoint = x; }
                    if (counter == count - 1) { lastpoint = x; }
                    if (counter == count) { homeroute.Points.Add(lastpoint); homeroute.Points.Add(homepoint); homeroute.Points.Add(firstpoint); return; }
                    route.Points.Add(x);
                });

                homeroute.Stroke = new Pen(Color.Yellow, 2);
                // if we have a large distance between home and the first/last point, it hangs on the draw of a the dashed line.
                if (homepoint.GetDistance(lastpoint) < 5000 && homepoint.GetDistance(firstpoint) < 5000)
                    homeroute.Stroke.DashStyle = DashStyle.Dash;

                polygonsoverlay.Routes.Add(homeroute);

                route.Stroke = new Pen(Color.Yellow, 4);
                route.Stroke.DashStyle = DashStyle.Custom;
                polygonsoverlay.Routes.Add(route);
            }
        }

        /// <summary>
        /// used to redraw the polygon
        /// </summary>
        void RegeneratePolygon()
        {
            List<PointLatLng> polygonPoints = new List<PointLatLng>();

            if (objectsoverlay == null)
                return;

            foreach (GMapMarker m in objectsoverlay.Markers)
            {
                if (m is GMapMarkerRect)
                {
                    if (m.Tag == null)
                    {
                        m.Tag = polygonPoints.Count;
                        polygonPoints.Add(m.Position);
                    }
                }
            }

            if (wppolygon == null)
            {
                wppolygon = new GMapPolygon(polygonPoints, "polygon test");
                polygonsoverlay.Polygons.Add(wppolygon);
            }
            else
            {
                wppolygon.Points.Clear();
                wppolygon.Points.AddRange(polygonPoints);

                wppolygon.Stroke = new Pen(Color.Yellow, 4);
                wppolygon.Stroke.DashStyle = DashStyle.Custom;
                wppolygon.Fill = Brushes.Transparent;

                if (polygonsoverlay.Polygons.Count == 0)
                {
                    polygonsoverlay.Polygons.Add(wppolygon);
                }
                else
                {
                    lock (thisLock)
                    {
                        MainMap.UpdatePolygonLocalPosition(wppolygon);
                    }
                }
            }
        }

        void setgradanddistandaz()
        {
            int a = 0;
            PointLatLngAlt last = MainV2.comPort.MAV.cs.HomeLocation;
            foreach (var lla in pointlist)
            {
                if (lla == null)
                    continue;
                try
                {
                    if (lla.Tag != null && lla.Tag != "H" && !lla.Tag.Contains("ROI"))
                    {
                        Commands.Rows[int.Parse(lla.Tag) - 1].Cells[Grad.Index].Value = (((lla.Alt - last.Alt) / (lla.GetDistance(last) * CurrentState.multiplierdist)) * 100).ToString("0.0");

                        Commands.Rows[int.Parse(lla.Tag) - 1].Cells[Dist.Index].Value = (lla.GetDistance(last) * CurrentState.multiplierdist).ToString("0.0");

                        Commands.Rows[int.Parse(lla.Tag) - 1].Cells[AZ.Index].Value = ((lla.GetBearing(last) + 180) % 360).ToString("0");
                    }
                }
                catch { }
                a++;
                last = lla;
            }
        }

        #region 分隔航点文件
        /// <summary>
        /// Saves a waypoint writer file
        /// </summary>
        private void savewaypoints(int SplitWP,string path)
        {
            string speed = string.Empty;
            string takeoffhight = string.Empty;
            string rtlhigh = string.Empty;
            for (int i = 1; i <= SplitWP; i++) 
            {
                int wpCounts = 0;
                int iSplitedWP = 0;
                int StartPoint = 0 ;

                //分隔航点数目（除航向锁定）
                 wpCounts = Commands.Rows.Count - 3;

                //单个部分航点数目
                 iSplitedWP = wpCounts / SplitWP;
                
                //文件开始循环数
                 if (i != 1) { StartPoint = iSplitedWP * (i - 1) + 2; }


                 using (StreamWriter sw = new StreamWriter(path + i.ToString() + ".txt"))
                {
                    try
                    { 
                        sw.WriteLine("By Aero Save Points");
                        try
                        {
                            sw.WriteLine("0\t1\t0\t16\t0\t0\t0\t0\t" + double.Parse(TXT_homelat.Text).ToString("0.0000000", new CultureInfo("en-US")) + "\t" + double.Parse(TXT_homelng.Text).ToString("0.0000000", new CultureInfo("en-US")) + "\t" + double.Parse(TXT_homealt.Text).ToString("0.000000", new CultureInfo("en-US")) + "\t1");
                        }
                        catch
                        {
                            sw.WriteLine("0\t1\t0\t0\t0\t0\t0\t0\t0\t0\t0\t1");
                        }

                        if (i != 1)
                        {
                            sw.WriteLine("1\t0\t3\t22\t0.000000\t0.000000\t0.000000\t0.000000\t0.000000\t0.000000\t" + takeoffhight + "\t1");
                            sw.WriteLine("2\t0\t3\t178\t0.000000\t" + speed + "\t0.000000\t0.000000\t0.000000\t0.000000\t0.000000\t1");
                        }

                        int icount;
                        if (i == 1) { icount = -2; } else { icount = 0;}
                        for (int a = StartPoint; a < Commands.Rows.Count - 0; a++)
                        {

                            if (i < SplitWP && a > iSplitedWP * i+1)
                                break;

                            byte mode = (byte)(MAVLink.MAV_CMD)Enum.Parse(typeof(MAVLink.MAV_CMD), mavcnd(Commands.Rows[a].Cells[0].Value.ToString()));

                            sw.Write((icount + 3)); // seq
                            sw.Write("\t" + 0); // current
                            sw.Write("\t" + CMB_altmode.SelectedValue); //frame 
                            sw.Write("\t" + mode);
                            sw.Write("\t" + double.Parse(Commands.Rows[a].Cells[Param1.Index].Value.ToString()).ToString("0.000000", new CultureInfo("en-US")));
                            sw.Write("\t" + double.Parse(Commands.Rows[a].Cells[Param2.Index].Value.ToString()).ToString("0.000000", new CultureInfo("en-US")));
                            sw.Write("\t" + double.Parse(Commands.Rows[a].Cells[Param3.Index].Value.ToString()).ToString("0.000000", new CultureInfo("en-US")));
                            sw.Write("\t" + double.Parse(Commands.Rows[a].Cells[Param4.Index].Value.ToString()).ToString("0.000000", new CultureInfo("en-US")));
                            sw.Write("\t" + double.Parse(Commands.Rows[a].Cells[Lat.Index].Value.ToString()).ToString("0.0000000", new CultureInfo("en-US")));
                            sw.Write("\t" + double.Parse(Commands.Rows[a].Cells[Lon.Index].Value.ToString()).ToString("0.0000000", new CultureInfo("en-US")));
                            sw.Write("\t" + (double.Parse(Commands.Rows[a].Cells[Alt.Index].Value.ToString()) / CurrentState.multiplierdist).ToString("0.000000", new CultureInfo("en-US")));
                            sw.Write("\t" + 1);
                            sw.WriteLine("");

                            if (i == 1 && mode ==178) 
                            {
                                speed = double.Parse(Commands.Rows[a].Cells[Param2.Index].Value.ToString()).ToString("0.000000", new CultureInfo("en-US"));
                            }

                            if (i == 1 && mode == 22)
                            {
                                takeoffhight = (double.Parse(Commands.Rows[a].Cells[Alt.Index].Value.ToString()) / CurrentState.multiplierdist).ToString("0.000000", new CultureInfo("en-US"));
                            }

                            if (i == 1 && mode == 20)
                            {
                                rtlhigh = (double.Parse(Commands.Rows[a].Cells[Alt.Index].Value.ToString()) / CurrentState.multiplierdist).ToString("0.000000", new CultureInfo("en-US"));
                            }

                            icount ++;

                            if (i == SplitWP && a == Commands.Rows.Count - 0)
                                break;
                        }

                        int seqtotal;
                        if (i != SplitWP)
                        {
                            seqtotal = icount + 3;
                        }
                        else 
                        {
                            seqtotal = icount;
                        }

                        if (i != SplitWP) 
                        {
                            sw.WriteLine(seqtotal.ToString() + "\t0\t3\t20\t0.000000\t0.000000\t0.000000\t0.000000\t0.000000\t0.000000\t" + rtlhigh + "\t1"); 
                        }
                        sw.Close();

                        //lbl_wpfile.Text = "Saved " + Path.GetFileName(file);
                    }
                    catch (Exception) { CustomMessageBox.Show(Strings.ERROR); }
                }
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            string counts = "1";

            if (DialogResult.Cancel == InputBox.Show("规划区域分割", "请输入平均分割规划区域的数量", ref counts))
                return;

            string path = string.Empty;  //文件路径
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
                path = save.FileName;

            int countsi = 1;
            if (!int.TryParse(counts, out countsi))
            {
                MessageBox.Show("输入格式不正确,请重新输入！");
                return;
            }
            try
            {
                savewaypoints(countsi, path);
                MessageBox.Show("保存航点成功！");
            }
            catch 
            {
                
            }

            writeKML();
        }

        #endregion

        /// <summary>
        /// Reads the EEPROM from a com port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void BUT_read_Click(object sender, EventArgs e)
        {

            if (Commands.Rows.Count > 0)
            {
                if (sender is FlightData)
                {

                }
                else
                {
                    if (CustomMessageBox.Show("这将清除您现有的计划任务，继续?", "清除计划任务", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    {
                        return;
                    }
                }
            }

            try
            {
                ProgressReporterDialogue frmProgressReporter = new ProgressReporterDialogue
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    Text = "接收航点",
                    Tag = "WayPoints"
                };

                frmProgressReporter.DoWork += getWPs;
                frmProgressReporter.UpdateProgressAndStatus(-1, "Receiving WP's");

                ThemeManager.ApplyThemeTo(frmProgressReporter);

                frmProgressReporter.RunBackgroundOperationAsync();

                frmProgressReporter.Dispose();
            }
            catch
            {
                CustomMessageBox.Show("读取航点失败！");
            }

            try 
            {
                ReadAeroPoints();
            }
            catch { CustomMessageBox.Show("读取区域航点失败！"); }
        }

        void getWPs(object sender, ProgressWorkerEventArgs e, object passdata = null)
        {
            List<Locationwp> cmds = new List<Locationwp>();

            try
            {
                MAVLinkInterface port = MainV2.comPort;

                if (!port.BaseStream.IsOpen)
                {
                    throw new Exception("请先链接地面站!");
                }

                MainV2.comPort.giveComport = true;

                param = port.MAV.param;

                log.Info("Getting Break_WP #");

                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(0, "获取航点数量");

                int cmdcount = port.getWPCount();
                for (ushort a = 0; a < cmdcount; a++)
                {
                    if (((ProgressReporterDialogue)sender).doWorkArgs.CancelRequested)
                    {
                        ((ProgressReporterDialogue)sender).doWorkArgs.CancelAcknowledged = true;
                        throw new Exception("取消请求");
                    }

                    log.Info("Getting WP" + a);
                    ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(a * 100 / cmdcount, "Getting WP " + a);
                    cmds.Add(port.getWP(a));
                }

                port.setWPACK();

                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(100, "完成");

                log.Info("Done");
            }
            catch { throw; }

            WPtoScreen(cmds);
        }

        public void WPtoScreen(List<Locationwp> cmds, bool withrally = true)
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        log.Info("Process " + cmds.Count);
                        processToScreen(cmds);
                    }
                    catch (Exception exx) { log.Info(exx.ToString()); }

                    try
                    {
                        if (withrally && MainV2.comPort.MAV.param.ContainsKey("RALLY_TOTAL") && int.Parse(MainV2.comPort.MAV.param["RALLY_TOTAL"].ToString()) >= 1)
                            getRallyPointsToolStripMenuItem_Click(null, null);
                    }
                    catch { }

                    MainV2.comPort.giveComport = false;

                    BUT_read.Enabled = true;

                    writeKML();

                });
            }
            catch (Exception exx) { log.Info(exx.ToString()); }
        }

        /// <summary>
        /// Writes the mission from the datagrid and values to the EEPROM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BUT_write_Click(object sender, EventArgs e)
        {

            if ((altmode)CMB_altmode.SelectedValue == altmode.Absolute)
            {
                if (DialogResult.No == CustomMessageBox.Show("确认选择海拔高度?", "高度模式", MessageBoxButtons.YesNo))
                {
                    CMB_altmode.SelectedValue = (int)altmode.Relative;
                }
            }

            if (drawnpolygon.Points.Count <= 0)
            {
                CustomMessageBox.Show(("请上传与飞行航点对应的工作区域!"));
                return;
            }

            // check for invalid grid data
            for (int a = 0; a < Commands.Rows.Count - 0; a++)
            {
                for (int b = 0; b < Commands.ColumnCount - 0; b++)
                {
                    double answer;
                    if (b >= 1 && b <= 7)
                    {
                        if (!double.TryParse(mavcnd(Commands[b, a].Value.ToString()), out answer))
                        {
                            CustomMessageBox.Show("任务中存在错误！");
                            return;
                        }
                    }

                    if (TXT_altwarn.Text == "")
                        TXT_altwarn.Text = (0).ToString();

                    if (Commands.Rows[a].Cells[Command.Index].Value.ToString().Contains("未知"))
                        continue;

                    byte cmd = (byte)(int)Enum.Parse(typeof(MAVLink.MAV_CMD), mavcnd(Commands.Rows[a].Cells[Command.Index].Value.ToString()), false);

                    if (cmd < (byte)MAVLink.MAV_CMD.LAST && double.Parse(Commands[Alt.Index, a].Value.ToString()) < double.Parse(TXT_altwarn.Text))
                    {
                        if (cmd != (byte)MAVLink.MAV_CMD.TAKEOFF &&
                            cmd != (byte)MAVLink.MAV_CMD.LAND &&
                            cmd != (byte)MAVLink.MAV_CMD.RETURN_TO_LAUNCH)
                        {
                            CustomMessageBox.Show("航点高度过低" + (a + 1) + "\n请降低高度的警告，或增加高度。");
                            return;
                        }
                    }
                }
            }

            try
            {
                ProgressReporterDialogue frmProgressReporter = new ProgressReporterDialogue
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    Text = "发送航点",
                    Tag = "WayPoints"
                };

                frmProgressReporter.DoWork += saveWPs;
                frmProgressReporter.UpdateProgressAndStatus(-1, "Sending WP's");

                ThemeManager.ApplyThemeTo(frmProgressReporter);

                frmProgressReporter.RunBackgroundOperationAsync();

                frmProgressReporter.Dispose();

                breakploygonsoverlay.Markers.Clear();
                MainMap.Focus();
            }
            catch
            {
                CustomMessageBox.Show("写入航点失败！");
            }

            try
            {
                SendAeroPoints();
            }
            catch 
            {
                CustomMessageBox.Show("写入区域航点失败！");
            }

        }

        Locationwp DataViewtoLocationwp(int a)
        {
            Locationwp temp = new Locationwp();
            if (Commands.Rows[a].Cells[Command.Index].Value.ToString().Contains("未知"))
            {
                temp.id = (byte)Commands.Rows[a].Cells[Command.Index].Tag;
            }
            else
            {
                temp.id = (byte)(int)Enum.Parse(typeof(MAVLink.MAV_CMD),mavcnd(Commands.Rows[a].Cells[Command.Index].Value.ToString()), false);
            }
            temp.p1 = float.Parse(Commands.Rows[a].Cells[Param1.Index].Value.ToString());
            
            temp.alt = (float)(double.Parse(Commands.Rows[a].Cells[Alt.Index].Value.ToString()) / CurrentState.multiplierdist);
            temp.lat = (double.Parse(Commands.Rows[a].Cells[Lat.Index].Value.ToString()));
            temp.lng = (double.Parse(Commands.Rows[a].Cells[Lon.Index].Value.ToString()));

            temp.p2 = (float)(double.Parse(Commands.Rows[a].Cells[Param2.Index].Value.ToString()));
            temp.p3 = (float)(double.Parse(Commands.Rows[a].Cells[Param3.Index].Value.ToString()));
            temp.p4 = (float)(double.Parse(Commands.Rows[a].Cells[Param4.Index].Value.ToString()));

            return temp;
        }

        List<Locationwp> GetCommandList()
        {
            List<Locationwp> commands = new List<Locationwp>();

            for (int a = 0; a < Commands.Rows.Count - 0; a++)
            {
                var temp = DataViewtoLocationwp(a);

                commands.Add(temp);
            }

            return commands;
        }

        void saveWPs(object sender, ProgressWorkerEventArgs e, object passdata = null)
        {
            try
            {
                MAVLinkInterface port = MainV2.comPort;

                if (!port.BaseStream.IsOpen)
                {
                    throw new Exception("请先连接地面站!");
                }

                if(CurrentState.flightmode =="自动")
                {
                    CustomMessageBox.Show(("请先切换模式，在写入航点!"));
                    return ;
                }

                MainV2.comPort.giveComport = true;
                int a = 0;

                // define the home point
                Locationwp home = new Locationwp();
                try
                {
                    home.id = (byte)MAVLink.MAV_CMD.WAYPOINT;
                    home.lat = (double.Parse(TXT_homelat.Text));
                    string abcd = TXT_homelng.Text;
                    home.lng = (double.Parse(TXT_homelng.Text));
                    home.alt = (float.Parse(TXT_homealt.Text) / CurrentState.multiplierdist); // use saved home
                }
                catch { throw new Exception("飞行器的起始位置无效！"); }

                // log
                log.Info("wps values " + MainV2.comPort.MAV.wps.Values.Count);
                log.Info("cmd rows " + (Commands.Rows.Count + 1)); // + home

                // check for changes / future mod to send just changed wp's
                if (MainV2.comPort.MAV.wps.Values.Count == (Commands.Rows.Count + 1))
                {
                    Hashtable wpstoupload = new Hashtable();

                    a = -1;
                    foreach (var item in MainV2.comPort.MAV.wps.Values)
                    {
                        // skip home
                        if (a == -1)
                        {
                            a++;
                            continue;
                        }

                        MAVLink.mavlink_mission_item_t temp = DataViewtoLocationwp(a);

                        if (temp.command == item.command &&
                            temp.x == item.x &&
                            temp.y == item.y &&
                            temp.z == item.z &&
                            temp.param1 == item.param1 &&
                            temp.param2 == item.param2 &&
                            temp.param3 == item.param3 &&
                            temp.param4 == item.param4
                            )
                        {
                            log.Info("wp match " + (a + 1));
                        }
                        else
                        {
                            log.Info("wp no match" + (a + 1));
                            wpstoupload[a] = "";
                        }

                        a++;
                    }
                }

                // set wp total
                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(0, "Set total wps ");

                ushort totalwpcountforupload = (ushort)(Commands.Rows.Count + 1);

                port.setWPTotal(totalwpcountforupload); // + home

                // set home location - overwritten/ignored depending on firmware.
                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(0, "Set home");

                var homeans = port.setWP(home, 0, MAVLink.MAV_FRAME.GLOBAL, 0);

                if (homeans != MAVLink.MAV_MISSION_RESULT.MAV_MISSION_ACCEPTED)
                {
                    CustomMessageBox.Show(Strings.ErrorRejectedByMAV, Strings.ERROR);
                    return;
                }

                // define the default frame.
                MAVLink.MAV_FRAME frame = MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT;

                // get the command list from the datagrid
                var commandlist = GetCommandList();

                // upload from wp1, as home is alreadey sent
                a = 1;
                // process commandlist to the mav
                foreach (var temp in commandlist)
                {
                    // this code below fails
                    //a = commandlist.IndexOf(temp) + 1;

                    ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(a * 100 / Commands.Rows.Count, "Setting WP " + a);

                    // make sure we are using the correct frame for these commands
                    if (temp.id < (byte)MAVLink.MAV_CMD.LAST || temp.id == (byte)MAVLink.MAV_CMD.DO_SET_HOME)
                    {
                        var mode = currentaltmode;

                        if (mode == altmode.Terrain)
                        {
                            frame = MAVLink.MAV_FRAME.GLOBAL_TERRAIN_ALT;
                        }
                        else if (mode == altmode.Absolute)
                        {
                            frame = MAVLink.MAV_FRAME.GLOBAL;
                        }
                        else
                        {
                            frame = MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT;
                        }
                    }

                    // try send the wp
                    MAVLink.MAV_MISSION_RESULT ans = port.setWP(temp, (ushort)(a), frame, 0);

                    // we timed out while uploading wps/ command wasnt replaced/ command wasnt added
                    if (ans == MAVLink.MAV_MISSION_RESULT.MAV_MISSION_ERROR)
                    {
                        // resend for partial upload
                        port.setWPPartialUpdate((ushort)(a), totalwpcountforupload);
                        // reupload this point.
                        ans = port.setWP(temp, (ushort)(a), frame, 0);
                    }
                    
                    if (ans == MAVLink.MAV_MISSION_RESULT.MAV_MISSION_NO_SPACE)
                    {
                        e.ErrorMessage = "上传失败，请减少航点的数量！";
                        return;
                    }
                    if (ans == MAVLink.MAV_MISSION_RESULT.MAV_MISSION_INVALID)
                    {
                        e.ErrorMessage = "上传失败，航点文件中存在错误的航点！" + a + " " + ans;
                        return;
                    }
                    if (ans == MAVLink.MAV_MISSION_RESULT.MAV_MISSION_INVALID_SEQUENCE)
                    {
                        // invalid sequence can only occur if we failed to see a response from the apm when we sent the request.
                        // therefore it did see the request and has moved on that step, and so do we.
                        a++;
                        continue;
                    }
                    if (ans != MAVLink.MAV_MISSION_RESULT.MAV_MISSION_ACCEPTED)
                    {
                        e.ErrorMessage = "更显航点失败 " + Enum.Parse(typeof(MAVLink.MAV_CMD), temp.id.ToString()) + " " + Enum.Parse(typeof(MAVLink.MAV_MISSION_RESULT), ans.ToString());
                        return;
                    }

                    a++;
                }

                port.setWPACK();

                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(95, "Setting params");

                // m
                port.setParam("WP_RADIUS", (byte)int.Parse(TXT_WPRad.Text) / CurrentState.multiplierdist);

                // cm's
                port.setParam("WPNAV_RADIUS", (byte)int.Parse(TXT_WPRad.Text) / CurrentState.multiplierdist * 100);

                try
                {
                    port.setParam(new[] { "LOITER_RAD", "WP_LOITER_RAD" }, int.Parse(TXT_loiterrad.Text) / CurrentState.multiplierdist);
                }
                catch
                {

                }

                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(100, "Done.");
            }
            catch (Exception ex) { log.Error(ex); MainV2.comPort.giveComport = false; throw; }

            MainV2.comPort.giveComport = false;
        }

        /// <summary>
        /// Processes a loaded EEPROM to the map and datagrid
        /// </summary>
        void processToScreen(List<Locationwp> cmds, bool append = false)
        {
            quickadd = true;


            // mono fix
            Commands.CurrentCell = null;

            while (Commands.Rows.Count > 0 && !append)
                Commands.Rows.Clear();

            if (cmds.Count == 0)
            {
                quickadd = false;
                return;
            }

            int i = Commands.Rows.Count - 1;
            foreach (Locationwp temp in cmds)
            {
                i++;
                //Console.WriteLine("FP processToScreen " + i);
                if (temp.id == 0 && i != 0) // 0 and not home
                    break;
                if (temp.id == 255 && i != 0) // bad record - never loaded any WP's - but have started the board up.
                    break;
                if (i + 1 >= Commands.Rows.Count)
                {
                    selectedrow = Commands.Rows.Add();
                }
                //if (i == 0 && temp.alt == 0) // skip 0 home
                //  continue;
                DataGridViewTextBoxCell cell;
                DataGridViewComboBoxCell cellcmd;
                cellcmd = Commands.Rows[i].Cells[   Command.Index] as DataGridViewComboBoxCell;
                cellcmd.Value = "未知";
                cellcmd.Tag = temp.id;

                foreach (object value in Enum.GetValues(typeof(MAVLink.MAV_CMD)))
                {
                    if ((int)value == temp.id)
                    {
                        cellcmd.Value = mavcndchange(value.ToString());
                        break;
                    }
                }

                // from ap_common.h
                if (temp.id < (byte)MAVLink.MAV_CMD.LAST || temp.id == (byte)MAVLink.MAV_CMD.DO_SET_HOME)
                {
                    // check ralatice and terrain flags
                    if ((temp.options & 0x9) == 0 && i != 0)
                    {
                        CMB_altmode.SelectedValue = (int)altmode.Absolute;
                    }// check terrain flag
                    else if ((temp.options & 0x8) != 0 && i != 0)
                    {
                        CMB_altmode.SelectedValue = (int)altmode.Terrain;
                    }// check relative flag
                    else if ((temp.options & 0x1) != 0 && i != 0)
                    {
                        CMB_altmode.SelectedValue = (int)altmode.Relative;
                    }
                }

                cell = Commands.Rows[i].Cells[Alt.Index] as DataGridViewTextBoxCell;
                cell.Value = Math.Round((temp.alt * CurrentState.multiplierdist), 2);
                cell = Commands.Rows[i].Cells[Lat.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.lat;
                cell = Commands.Rows[i].Cells[Lon.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.lng;

                cell = Commands.Rows[i].Cells[Param1.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.p1;
                cell = Commands.Rows[i].Cells[Param2.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.p2;
                cell = Commands.Rows[i].Cells[Param3.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.p3;
                cell = Commands.Rows[i].Cells[Param4.Index] as DataGridViewTextBoxCell;
                cell.Value = temp.p4;
            }

            setWPParams();

            try
            {

                DataGridViewTextBoxCell cellhome;
                cellhome = Commands.Rows[0].Cells[Lat.Index] as DataGridViewTextBoxCell;
                if (cellhome.Value != null)
                {
                    if (cellhome.Value.ToString() != TXT_homelat.Text && cellhome.Value.ToString() != "0")
                    {
                        DialogResult dr = CustomMessageBox.Show("重新设置家的坐标", "重新设置家的坐标", MessageBoxButtons.YesNo);

                        if (dr == DialogResult.Yes)
                        {
                            TXT_homelat.Text = (double.Parse(cellhome.Value.ToString())).ToString();
                            cellhome = Commands.Rows[0].Cells[Lon.Index] as DataGridViewTextBoxCell;
                            TXT_homelng.Text = (double.Parse(cellhome.Value.ToString())).ToString();
                            cellhome = Commands.Rows[0].Cells[Alt.Index] as DataGridViewTextBoxCell;
                            TXT_homealt.Text = (double.Parse(cellhome.Value.ToString()) * CurrentState.multiplierdist).ToString();
                        }
                    }
                }
            }
            catch (Exception ex) { log.Error(ex.ToString()); } // if there is no valid home

            if (Commands.RowCount > 0)
            {
                log.Info("remove home from list");
                Commands.Rows.Remove(Commands.Rows[0]); // remove home row
            }

            quickadd = false;

            writeKML();

            MainMap.ZoomAndCenterMarkers("objects");

            MainMap_OnMapZoomChanged();
        }

        private readonly Hashtable changes = new Hashtable();
        internal bool startup = true;
        void setWPParams()
        {
            try
            {
                log.Info("Loading wp params");

                Hashtable param = new Hashtable((Hashtable)MainV2.comPort.MAV.param);

                if (param["WP_RADIUS"] != null)
                {
                    TXT_WPRad.Text = ((int)((float)param["WP_RADIUS"] * CurrentState.multiplierdist)).ToString();
                }
                if (param["WPNAV_RADIUS"] != null)
                {
                    //float fDadius = (float)param["WPNAV_RADIUS"];
                    //float fCurrentState = (float)CurrentState.multiplierdist;
                    //float fWprad = fDadius * fCurrentState / 100;

                    TXT_WPRad.Text = ((double)param["WPNAV_RADIUS"] * CurrentState.multiplierdist / 100).ToString();
                }

                log.Info("param WP_RADIUS " + TXT_WPRad.Text);

                try
                {
                    TXT_loiterrad.Enabled = false;
                    if (param["LOITER_RADIUS"] != null)
                    {
                        TXT_loiterrad.Text = ((int)((float)param["LOITER_RADIUS"] * CurrentState.multiplierdist)).ToString();
                        TXT_loiterrad.Enabled = true;
                    }
                    else if (param["WP_LOITER_RAD"] != null)
                    {
                        TXT_loiterrad.Text = ((int)((float)param["WP_LOITER_RAD"] * CurrentState.multiplierdist)).ToString();
                        TXT_loiterrad.Enabled = true;
                    }

                    log.Info("param LOITER_RADIUS " + TXT_loiterrad.Text);
                }
                catch
                {

                }

                if (!MainV2.comPort.BaseStream.IsOpen)
                {
                    WPNAV_LOIT_SPEED.Enabled = false;
                    WPNAV_RADIUS.Enabled = false;
                    WPNAV_SPEED.Enabled = false;
                    WPNAV_SPEED_DN.Enabled = false;
                    WPNAV_SPEED_UP.Enabled = false;
                }
                else 
                {
                    startup = true;
                    changes.Clear();

                    WPNAV_LOIT_SPEED.setup(0, 0, 1, 0.001f, "WPNAV_LOIT_SPEED", MainV2.comPort.MAV.param);
                    WPNAV_RADIUS.setup(0, 0, 1, 0.001f, "WPNAV_RADIUS", MainV2.comPort.MAV.param);
                    WPNAV_SPEED.setup(0, 0, 1, 0.001f, "WPNAV_SPEED", MainV2.comPort.MAV.param);
                    WPNAV_SPEED_DN.setup(0, 0, 1, 0.001f, "WPNAV_SPEED_DN", MainV2.comPort.MAV.param);
                    WPNAV_SPEED_UP.setup(0, 0, 1, 0.001f, "WPNAV_SPEED_UP", MainV2.comPort.MAV.param);
                    startup = false;
                } 
            }
            catch (Exception ex) { log.Error(ex); }
        }

        #region
        private void numeric_ValueUpdated(object sender, EventArgs e)
        {
            EEPROM_View_float_TextChanged(sender, e);
        }

        private void BUT_writePIDS_Click(object sender, EventArgs e)
        {
            var temp = (Hashtable)changes.Clone();

            bool IsSetParam = false;
            foreach (string value in temp.Keys)
            {
                try
                {
                     IsSetParam =MainV2.comPort.setParam(value, (float)changes[value]);
                    changes.Remove(value);
                    try
                    {
                        // set control as well
                        var textControls = Controls.Find(value, true);
                        if (textControls.Length > 0)
                        {
                            textControls[0].BackColor = Color.FromArgb(0x43, 0x44, 0x45);
                        }
                    }
                    catch{}
                }
                catch{CustomMessageBox.Show(string.Format(Strings.ErrorSetValueFailed, value), Strings.ERROR);}
            }

            if (IsSetParam)
            {
                CustomMessageBox.Show(Strings.SetValueSuccess, Strings.Success);
            }
        }

        internal void EEPROM_View_float_TextChanged(object sender, EventArgs e)
        {
            if (startup)
                return;

            float value = 0;
            var name = ((Control)sender).Name;

            // do domainupdown state check
            try
            {
                if (sender.GetType() == typeof(MavlinkNumericUpDown))
                {
                    value = ((MAVLinkParamChanged)e).value;
                    changes[name] = value;
                }
                ((Control)sender).BackColor = Color.Green;
            }
            catch (Exception)
            {
                ((Control)sender).BackColor = Color.Red;
            }
        }

        private void BUT_refreshpart_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
                return;

            ((Control)sender).Enabled = false;


            updateparam(this);

            ((Control)sender).Enabled = true;


            Activate();
            this.Refresh();
        }

        private void updateparam(Control parentctl)
        {
            foreach (Control ctl in parentctl.Controls)
            {
                if (typeof(MavlinkNumericUpDown) == ctl.GetType())
                {
                    try
                    {
                        MainV2.comPort.GetParam(ctl.Name);
                    }
                    catch
                    {
                    }
                }

                if (ctl.Controls.Count > 0)
                {
                    updateparam(ctl);
                }
            }
        }

        #endregion
        /// <summary>
        /// Saves this forms config to MAIN, where it is written in a global config
        /// </summary>
        /// <param name="write">true/false</param>
        private void config(bool write)
        {
            if (write)
            {
                MainV2.config["TXT_homelat"] = TXT_homelat.Text;
                MainV2.config["TXT_homelng"] = TXT_homelng.Text;
                MainV2.config["TXT_homealt"] = TXT_homealt.Text;


                MainV2.config["TXT_WPRad"] = TXT_WPRad.Text;

                MainV2.config["TXT_loiterrad"] = TXT_loiterrad.Text;

                MainV2.config["TXT_DefaultAlt"] = TXT_DefaultAlt.Text;

                MainV2.config["CMB_altmode"] = CMB_altmode.Text;

                MainV2.config["fpminaltwarning"] = TXT_altwarn.Text;

                MainV2.config["fpcoordmouse"] = coords1.Sys;
            }
            else
            {
                Hashtable temp = new Hashtable((Hashtable)MainV2.config.Clone());

                foreach (string key in temp.Keys)
                {
                    switch (key)
                    {
                        case "TXT_WPRad":
                            TXT_WPRad.Text = MainV2.config[key].ToString();
                            break;
                        case "TXT_loiterrad":
                            TXT_loiterrad.Text = MainV2.config[key].ToString();
                            break;
                        case "TXT_DefaultAlt":
                            TXT_DefaultAlt.Text = MainV2.config[key].ToString();
                            break;
                        case "CMB_altmode":
                            CMB_altmode.Text = MainV2.config[key].ToString();
                            break;
                        case "fpminaltwarning":
                            TXT_altwarn.Text = MainV2.getConfig("fpminaltwarning");
                            break;
                        case "fpcoordmouse":
                            coords1.Sys = MainV2.config[key].ToString();
                            break;
                        default:
                            break;
                    }
                }

            }
        }

        private void TXT_WPRad_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            if (e.KeyChar.ToString() == "\b")
                return;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void TXT_WPRad_Leave(object sender, EventArgs e)
        {
            int isNumber = 0;
            if (!int.TryParse(TXT_WPRad.Text, out isNumber))
            {
                TXT_WPRad.Text = "30";
            }
            if (isNumber > (127 * CurrentState.multiplierdist))
            {
                //CustomMessageBox.Show("The value can only be between 0 and 127 m");
                //TXT_WPRad.Text = (127 * CurrentState.multiplierdist).ToString();
            }
            writeKML();
        }

        private void TXT_loiterrad_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            if (e.KeyChar.ToString() == "\b")
                return;

            if (e.KeyChar == '-')
                return;

            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void TXT_loiterrad_Leave(object sender, EventArgs e)
        {
            int isNumber = 0;
            if (!int.TryParse(TXT_loiterrad.Text, out isNumber))
            {
                TXT_loiterrad.Text = "45";
            }
        }

        private void TXT_DefaultAlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            if (e.KeyChar.ToString() == "\b")
                return;
            e.Handled = !int.TryParse(e.KeyChar.ToString(), out isNumber);
        }

        private void TXT_DefaultAlt_Leave(object sender, EventArgs e)
        {
            int isNumber = 0;
            if (!int.TryParse(TXT_DefaultAlt.Text, out isNumber))
            {
                TXT_DefaultAlt.Text = "100";
            }
        }


        /// <summary>
        /// used to control buttons in the datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Commands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (e.ColumnIndex == Delete.Index && (e.RowIndex + 0) < Commands.RowCount) // delete
                {
                    quickadd = true;
                    Commands.Rows.RemoveAt(e.RowIndex);
                    quickadd = false;
                    writeKML();
                }
                if (e.ColumnIndex == Up.Index && e.RowIndex != 0) // up
                {
                    DataGridViewRow myrow = Commands.CurrentRow;
                    Commands.Rows.Remove(myrow);
                    Commands.Rows.Insert(e.RowIndex - 1, myrow);
                    writeKML();
                }
                if (e.ColumnIndex == Down.Index && e.RowIndex < Commands.RowCount - 1) // down
                {
                    DataGridViewRow myrow = Commands.CurrentRow;
                    Commands.Rows.Remove(myrow);
                    Commands.Rows.Insert(e.RowIndex + 1, myrow);
                    writeKML();
                }
                setgradanddistandaz();
            }
            catch (Exception) { CustomMessageBox.Show("错误的数据行！"); }
        }

        private void Commands_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[Delete.Index].Value = "删除";
            e.Row.Cells[Up.Index].Value = Resources.up;
            e.Row.Cells[Down.Index].Value = Resources.down;
        }

        private void TXT_homelat_TextChanged(object sender, EventArgs e)
        {
            sethome = false;
            try
            {
                MainV2.comPort.MAV.cs.HomeLocation.Lat = double.Parse(TXT_homelat.Text);
            }
            catch { }
            writeKML();

        }

        private void TXT_homelng_TextChanged(object sender, EventArgs e)
        {
            sethome = false;
            try
            {
                MainV2.comPort.MAV.cs.HomeLocation.Lng = double.Parse(TXT_homelng.Text);
            }
            catch { }
            writeKML();
        }

        private void TXT_homealt_TextChanged(object sender, EventArgs e)
        {
            sethome = false;
            try
            {
                MainV2.comPort.MAV.cs.HomeLocation.Alt = double.Parse(TXT_homealt.Text);
            }
            catch { }
            writeKML();
        }

        private void BUT_loadwpfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "All Supported Types|*.txt;*.shp|By Aero (*.txt)|*.*|Shape file|*.shp";
                DialogResult result = fd.ShowDialog();
                string file = fd.FileName;

                if (File.Exists(file))
                {
                    if (file.ToLower().EndsWith(".shp"))
                    {
                        LoadSHPFile(file);
                    }
                    else
                    {
                        wpfilename = file;
                        readQGC110wpfile(file);
                    }

                    //lbl_wpfile.Text = "Loaded " + Path.GetFileName(file);
                }
            }
        }

        public void readQGC110wpfile(string file, bool append = false)
        {
            int wp_count = 0;
            bool error = false;
            List<Locationwp> cmds = new List<Locationwp>();

            try
            {
                StreamReader sr = new StreamReader(file); //"defines.h"
                string header = sr.ReadLine();
                if (header == null || !header.Contains("By Aero"))
                {
                    CustomMessageBox.Show("无效的路点文件");
                    return;
                }

                while (!error && !sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // waypoints

                    if (line.StartsWith("#"))
                        continue;

                    string[] items = line.Split(new[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    if (items.Length <= 9)
                        continue;

                    try
                    {

                        Locationwp temp = new Locationwp();
                        if (items[2] == "3")
                        { // abs MAV_FRAME_GLOBAL_RELATIVE_ALT=3
                            temp.options = 1;
                        }
                        else
                        {
                            temp.options = 0;
                        }
                        temp.id = (byte)(int)Enum.Parse(typeof(MAVLink.MAV_CMD), items[3], false);
                        temp.p1 = float.Parse(items[4], new CultureInfo("en-US"));

                        if (temp.id == 99)
                            temp.id = 0;

                        temp.alt = (float)(double.Parse(items[10], new CultureInfo("en-US")));
                        temp.lat = (double.Parse(items[8], new CultureInfo("en-US")));
                        temp.lng = (double.Parse(items[9], new CultureInfo("en-US")));

                        temp.p2 = (float)(double.Parse(items[5], new CultureInfo("en-US")));
                        temp.p3 = (float)(double.Parse(items[6], new CultureInfo("en-US")));
                        temp.p4 = (float)(double.Parse(items[7], new CultureInfo("en-US")));

                        cmds.Add(temp);

                        wp_count++;

                    }
                    catch { CustomMessageBox.Show("无效的行\n" + line); }
                }

                sr.Close();

                processToScreen(cmds, append);

                writeKML();

                MainMap.ZoomAndCenterMarkers("objects");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("不能打开当前文件! ");
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                lock (thisLock)
                {
                    MainMap.Zoom = trackBar1.Value;
                }
            }
            catch { }
        }

        double calcpolygonarea(List<PointLatLng> polygon)
        {
            // should be a closed polygon
            // coords are in lat long
            // need utm to calc area

            if (polygon.Count == 0)
            {
                CustomMessageBox.Show("请定义一个多边形！!");
                return 0;
            }

            // close the polygon
            if (polygon[0] != polygon[polygon.Count - 1])
                polygon.Add(polygon[0]); // make a full loop

            CoordinateTransformationFactory ctfac = new CoordinateTransformationFactory();

            GeographicCoordinateSystem wgs84 = GeographicCoordinateSystem.WGS84;

            int utmzone = (int)((polygon[0].Lng - -186.0) / 6.0);

            IProjectedCoordinateSystem utm = ProjectedCoordinateSystem.WGS84_UTM(utmzone, polygon[0].Lat < 0 ? false : true);

            ICoordinateTransformation trans = ctfac.CreateFromCoordinateSystems(wgs84, utm);

            double prod1 = 0;
            double prod2 = 0;

            for (int a = 0; a < (polygon.Count - 1); a++)
            {
                double[] pll1 = { polygon[a].Lng, polygon[a].Lat };
                double[] pll2 = { polygon[a + 1].Lng, polygon[a + 1].Lat };

                double[] p1 = trans.MathTransform.Transform(pll1);
                double[] p2 = trans.MathTransform.Transform(pll2);

                prod1 += p1[0] * p2[1];
                prod2 += p1[1] * p2[0];
            }

            double answer = (prod1 - prod2) / 2;

            if (polygon[0] == polygon[polygon.Count - 1])
                polygon.RemoveAt(polygon.Count - 1); // unmake a full loop

            return answer;
        }

        // marker
        GMapMarker currentMarker;
        GMapMarker center = new GMarkerGoogle(new PointLatLng(0.0, 0.0), GMarkerGoogleType.none);

        // polygons
        GMapPolygon wppolygon;
        internal GMapPolygon drawnpolygon;
        GMapPolygon geofencepolygon;
        internal GMapPolygon drawnpolygonlimit;

        // layers
        GMapOverlay top; // not currently used
        public static GMapOverlay objectsoverlay; // where the markers a drawn
        public static GMapOverlay routesoverlay;// static so can update from gcs
        public static GMapOverlay polygonsoverlay; // where the track is drawn
        public static GMapOverlay airportsoverlay;
        public static GMapOverlay poioverlay = new GMapOverlay("POI"); // poi layer
        GMapOverlay drawnpolygonsoverlay;
        GMapOverlay kmlpolygonsoverlay;
        GMapOverlay geofenceoverlay;
        //返航断点
        GMapOverlay breakploygonsoverlay;
        //集结点
        static GMapOverlay rallypointoverlay;
        //障碍点
        static GMapOverlay drawnlimitpolygonsoverlay;
        //时时飞行航点
        public static GMapOverlay flyRoutesoverlay;

         
        // etc
        readonly Random rnd = new Random();
        string mobileGpsLog = string.Empty;
        public static  GMapMarkerRect CurentRectMarker;
        GMapMarkerRallyPt CurrentRallyPt;
        GMapMarker CurrentGMapMarker;
        GMapMarkerLimitPt CurrentLimitPt;
        GMapMarkerBreakPt CurrentBreakPt;
        bool isMouseDown;
        bool isMouseDraging;
        bool isMouseClickOffMenu;
        PointLatLng MouseDownStart;
        internal PointLatLng MouseDownEnd;

        //public long ElapsedMilliseconds;

        #region -- map events --
        void MainMap_OnMarkerLeave(GMapMarker item)
        {
            if (!isMouseDown)
            {
                if (item is GMapMarkerRect)
                {
                    CurentRectMarker = null;
                    GMapMarkerRect rc = item as GMapMarkerRect;
                    rc.ResetColor();
                    MainMap.Invalidate(false);
                }
                if (item is GMapMarkerRallyPt)
                {
                    CurrentRallyPt = null;
                }
                if (item is GMapMarker)
                {
                    // when you click the context menu this triggers and causes problems
                    CurrentGMapMarker = null;
                }

            }
        }

        void MainMap_OnMarkerEnter(GMapMarker item)
        {
            if (!isMouseDown)
            {
                if (item is GMapMarkerRect)
                {
                    GMapMarkerRect rc = item as GMapMarkerRect;
                    rc.Pen.Color = Color.Red;
                    MainMap.Invalidate(false);

                    int answer;
                    if (item.Tag != null && rc.InnerMarker != null && int.TryParse(rc.InnerMarker.Tag.ToString(), out answer))
                    {
                        try
                        {
                            Commands.CurrentCell = Commands[0, answer - 1];
                            item.ToolTipText = "Alt: " + Commands[Alt.Index, answer - 1].Value;
                            item.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        }
                        catch { }
                    }

                    CurentRectMarker = rc;
                }
                if (item is GMapMarkerRallyPt)
                {
                    CurrentRallyPt = item as GMapMarkerRallyPt;
                }
                if (item is GMapMarkerAirport)
                {
                    // do nothing - readonly
                    return;
                }
                if (item is GMapMarker)
                {
                    CurrentGMapMarker = item;
                }

                if (item is GMapMarkerLimitPt) 
                {
                    CurrentLimitPt = item as GMapMarkerLimitPt;
                }

                if (item is GMapMarkerBreakPt)
                {
                    CurrentBreakPt = item as GMapMarkerBreakPt;
                }
            }
        }

        // click on some marker
        void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            int answer;
            try // when dragging item can sometimes be null
            {
                if (item.Tag == null)
                {
                    // home.. etc
                    return;
                }

                if (ModifierKeys == Keys.Control)
                {
                    try
                    {
                        groupmarkeradd(item);

                        log.Info("add marker to group");
                    }
                    catch { }
                }
                if (int.TryParse(item.Tag.ToString(), out answer))
                {

                    Commands.CurrentCell = Commands[0, answer - 1];
                }
            }
            catch { }
        }

        void MainMap_OnMapTypeChanged(GMapProvider type)
        {
            comboBoxMapType.SelectedItem = MainMap.MapProvider;

            MainMap.ZoomAndCenterMarkers("objects");

            if (type == WMSProvider.Instance)
            {
                string url = "";
                if (MainV2.config["WMSserver"] != null)
                    url = MainV2.config["WMSserver"].ToString();
                if (DialogResult.Cancel == InputBox.Show("WMS Server", "Enter the WMS server URL", ref url))
                    return;

                string szCapabilityRequest = url + "?version=1.1.0&Request=GetCapabilities&service=WMS";

                XmlDocument xCapabilityResponse = MakeRequest(szCapabilityRequest);
                ProcessWmsCapabilitesRequest(xCapabilityResponse);

                MainV2.config["WMSserver"] = url;
                WMSProvider.CustomWMSURL = url;
            }
        }

        /**
        * This function requests an XML document from a webserver.
        * @param requestUrl The request url as a string including. Example: http://129.206.228.72/cached/hillshade?Request=GetCapabilities
        * @return An XML document containing the response.
        */
        private XmlDocument MakeRequest(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;


                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(response.GetResponseStream());
                return (xmlDoc);


            }
            catch (Exception e)
            {


                CustomMessageBox.Show("Failed to make WMS Server request: " + e.Message);
                return null;
            }
        }


        /**
         * This function parses a WMS server capabilites response.
         */
        private void ProcessWmsCapabilitesRequest(XmlDocument xCapabilitesResponse)
        {
            //Create namespace manager
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xCapabilitesResponse.NameTable);

            //check if the response is a valid xml document - if not, the server might still be able to serve us but all the checks below would fail. example: http://tiles.kartat.kapsi.fi/peruskartta
            //best sign is that there is no node WMT_MS_Capabilities
            if (xCapabilitesResponse.SelectNodes("//WMT_MS_Capabilities", nsmgr).Count == 0)
                return;


            //first, we have to make sure that the server is able to send us png imagery
            bool bPngCapable = false;
            XmlNodeList getMapElements = xCapabilitesResponse.SelectNodes("//GetMap", nsmgr);
            if (getMapElements.Count != 1)
                CustomMessageBox.Show("Invalid WMS Server response: Invalid number of GetMap elements.");
            else
            {
                XmlNode getMapNode = getMapElements.Item(0);
                //search through all format nodes for image/png
                foreach (XmlNode formatNode in getMapNode.SelectNodes("//Format", nsmgr))
                {
                    if (formatNode.InnerText.Contains("image/png"))
                    {
                        bPngCapable = true;
                        break;
                    }
                }
            }


            if (!bPngCapable)
            {
                CustomMessageBox.Show("Invalid WMS Server response: Server unable to return PNG images.");
                return;
            }


            //now search through all layer -> srs nodes for EPSG:4326 compatibility
            bool bEpsgCapable = false;
            XmlNodeList srsELements = xCapabilitesResponse.SelectNodes("//SRS", nsmgr);
            foreach (XmlNode srsNode in srsELements)
            {
                if (srsNode.InnerText.Contains("EPSG:4326"))
                {
                    bEpsgCapable = true;
                    break;
                }
            }


            if (!bEpsgCapable)
            {
                CustomMessageBox.Show("Invalid WMS Server response: Server unable to return EPSG:4326 / WGS84 compatible images.");
                return;
            }


            //the server is capable of serving our requests - now check if there is a layer to be selected
            //format: layer -> layer -> name
            string szLayerSelection = "";
            int iSelect = 0;
            List<string> szListLayerName = new List<string>();
            XmlNodeList layerELements = xCapabilitesResponse.SelectNodes("//Layer/Layer/Name", nsmgr);
            foreach (XmlNode nameNode in layerELements)
            {
                szLayerSelection += string.Format("{0}: " + nameNode.InnerText + ", ", iSelect); //mixing control and formatting is not optimal...
                szListLayerName.Add(nameNode.InnerText);
                iSelect++;
            }


            //only select layer if there is one
            if (szListLayerName.Count != 0)
            {
                //now let the user select a layer
                string szUserSelection = "";
                if (DialogResult.Cancel == InputBox.Show("WMS Server", "The following layers were detected: " + szLayerSelection + "please choose one by typing the associated number.", ref szUserSelection))
                    return;
                int iUserSelection = 0;
                try
                {
                    iUserSelection = Convert.ToInt32(szUserSelection);
                }
                catch
                {
                    iUserSelection = 0; //ignore all errors and default to first layer
                }

                WMSProvider.szWmsLayer = szListLayerName[iUserSelection];
            }
        }

        void groupmarkeradd(GMapMarker marker)
        {
            groupmarkers.Add(int.Parse(marker.Tag.ToString()));
            if (marker is GMapMarkerWP)
            {
                ((GMapMarkerWP)marker).selected = true;
            }
            if (marker is GMapMarkerRect)
            {
                ((GMapMarkerWP)((GMapMarkerRect)marker).InnerMarker).selected = true;
            }
        }

        void MainMap_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseClickOffMenu)
            {
                isMouseClickOffMenu = false;
                return;
            }

            MouseDownEnd = MainMap.FromLocalToLatLng(e.X, e.Y);

            // Console.WriteLine("MainMap MU");

            if (e.Button == MouseButtons.Right) // ignore right clicks
            {
                return;
            }

            if (isMouseDown) // mouse down on some other object and dragged to here.
            {
                if (e.Button == MouseButtons.Left)
                {
                    isMouseDown = false;
                }
                if (ModifierKeys == Keys.Control)
                {
                    // group select wps
                    GMapPolygon poly = new GMapPolygon(new List<PointLatLng>(),"temp");

                    poly.Points.Add(MouseDownStart);
                    poly.Points.Add(new PointLatLng(MouseDownStart.Lat,MouseDownEnd.Lng));
                    poly.Points.Add(MouseDownEnd);
                    poly.Points.Add(new PointLatLng(MouseDownEnd.Lat,MouseDownStart.Lng));

                    foreach (var marker in objectsoverlay.Markers)
                    {
                        if (poly.IsInside(marker.Position))
                        {
                            try
                            {
                                if (marker.Tag != null)
                                {
                                    groupmarkeradd(marker);
                                }
                            }
                            catch { }
                        }
                    }

                    isMouseDraging = false;
                    return;
                }
                if (!isMouseDraging)
                {
                    if (CurentRectMarker != null)
                    {
                        // cant add WP in existing rect
                    }
                    else
                    {
                        //禁止鼠标添加航点
                        //AddWPToMap(currentMarker.Position.Lat, currentMarker.Position.Lng, 0);
                    }
                }
                else
                {
                    if (groupmarkers.Count > 0)
                    {
                        Dictionary<string, PointLatLng> dest = new Dictionary<string, PointLatLng>();

                        foreach (var markerid in groupmarkers)
                        {
                            for (int a = 0; a < objectsoverlay.Markers.Count; a++)
                            {
                                var marker = objectsoverlay.Markers[a];

                                if (marker.Tag != null && marker.Tag.ToString() == markerid.ToString())
                                {
                                    dest[marker.Tag.ToString()] = marker.Position;
                                    break;
                                }
                            }
                        }

                        foreach (KeyValuePair<string, PointLatLng> item in dest)
                        {
                            var value = item.Value;
                            callMeDrag(item.Key, value.Lat, value.Lng, -1);
                        }

                        MainMap.SelectedArea = RectLatLng.Empty;
                        groupmarkers.Clear();
                        // redraw to remove selection
                        writeKML();

                        CurentRectMarker = null;
                    }

                    if (CurentRectMarker != null)
                    {
                        if (CurentRectMarker.InnerMarker.Tag.ToString().Contains("区域航点"))
                        {
                            try
                            {
                                drawnpolygon.Points[int.Parse(CurentRectMarker.InnerMarker.Tag.ToString().Replace("区域航点", "")) - 1] = new PointLatLng(MouseDownEnd.Lat, MouseDownEnd.Lng);
                                MainMap.UpdatePolygonLocalPosition(drawnpolygon);
                                MainMap.Invalidate();
                            }
                            catch { }
                        }
                        else if (CurentRectMarker.InnerMarker.Tag.ToString().Contains("障碍航点"))
                        {
                            try
                            {
                                //drawnpolygonlimit.Points[int.Parse(CurentRectMarker.InnerMarker.Tag.ToString().Replace("障碍航点", "")) - 1] = new PointLatLng(MouseDownEnd.Lat, MouseDownEnd.Lng);
                                //MainMap.UpdatePolygonLocalPosition(drawnpolygonlimit);
                                //MainMap.Invalidate();
                            }
                            catch { }
                        }
                        else
                        {
                                callMeDrag(CurentRectMarker.InnerMarker.Tag.ToString(), currentMarker.Position.Lat, currentMarker.Position.Lng, -1);
                        }
                        CurentRectMarker = null;
                    }
                }
            }

            isMouseDraging = false;
        }

        void MainMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (isMouseClickOffMenu)
                return;

            MouseDownStart = MainMap.FromLocalToLatLng(e.X, e.Y);

            //   Console.WriteLine("MainMap MD");

            if (e.Button == MouseButtons.Left && (groupmarkers.Count > 0 || ModifierKeys == Keys.Control))
            {
                // group move
                isMouseDown = true;
                isMouseDraging = false;

                return;
            }

            if (e.Button == MouseButtons.Left && ModifierKeys != Keys.Alt && ModifierKeys != Keys.Control)
            {
                isMouseDown = true;
                isMouseDraging = false;

                if (currentMarker.IsVisible)
                {
                    currentMarker.Position = MainMap.FromLocalToLatLng(e.X, e.Y);
                }
            }
        }

        // move current marker with left holding
        void MainMap_MouseMove(object sender, MouseEventArgs e)
        {
            PointLatLng point = MainMap.FromLocalToLatLng(e.X, e.Y);

            if (MouseDownStart == point)
                return;

            //  Console.WriteLine("MainMap MM " + point);

            currentMarker.Position = point;

            if (!isMouseDown)
            {
                // update mouse pos display
                SetMouseDisplay(point.Lat, point.Lng, 0);
            }



            //draging
            if (e.Button == MouseButtons.Left && isMouseDown)
            {
                isMouseDraging = true;
                if (CurrentRallyPt != null)
                {
                    PointLatLng pnew = MainMap.FromLocalToLatLng(e.X, e.Y);

                    CurrentRallyPt.Position = pnew;
                }
                else if (groupmarkers.Count > 0)
                {
                    // group drag

                    double latdif = MouseDownStart.Lat - point.Lat;
                    double lngdif = MouseDownStart.Lng - point.Lng;

                    MouseDownStart = point;

                    Hashtable seen = new Hashtable();

                    foreach (var markerid in groupmarkers)
                    {
                        if (seen.ContainsKey(markerid))
                            continue;

                        seen[markerid] = 1;
                        for (int a = 0; a < objectsoverlay.Markers.Count; a++)
                        {
                            var marker = objectsoverlay.Markers[a];

                            if (marker.Tag != null && marker.Tag.ToString() == markerid.ToString())
                            {
                                var temp = new PointLatLng(marker.Position.Lat, marker.Position.Lng);
                                temp.Offset(latdif, -lngdif);
                                marker.Position = temp;
                            }
                        }
                    }
                }
                else if (CurentRectMarker != null) // left click pan
                {
                    try
                    {
                        // check if this is a grid point
                        if (CurentRectMarker.InnerMarker.Tag.ToString().Contains("区域航点"))
                        {
                            drawnpolygon.Points[int.Parse(CurentRectMarker.InnerMarker.Tag.ToString().Replace("区域航点", "")) - 1] = new PointLatLng(point.Lat, point.Lng);
                            updatePointsMarks(int.Parse(CurentRectMarker.InnerMarker.Tag.ToString().Replace("区域航点", "")));
                            MainMap.UpdatePolygonLocalPosition(drawnpolygon);
                            MainMap.Invalidate();
                        }
                        else if (CurentRectMarker.InnerMarker.Tag.ToString().Contains("障碍航点")) 
                        {
                            drawnpolygonlimit.Points[int.Parse(CurentRectMarker.InnerMarker.Tag.ToString().Replace("障碍航点", "")) - 1] = new PointLatLng(point.Lat, point.Lng);
                            MainMap.UpdatePolygonLocalPosition(drawnpolygonlimit);
                            MainMap.Invalidate();
                        }
                    }
                    catch { }

                    PointLatLng pnew = MainMap.FromLocalToLatLng(e.X, e.Y);

                    // adjust polyline point while we drag
                    try
                    {
                        if (CurrentGMapMarker != null && CurrentGMapMarker.Tag is int)
                        {

                            int? pIndex = (int?)CurentRectMarker.Tag;
                            if (pIndex.HasValue)
                            {
                                if (pIndex < wppolygon.Points.Count)
                                {
                                    wppolygon.Points[pIndex.Value] = pnew;
                                    lock (thisLock)
                                    {
                                        MainMap.UpdatePolygonLocalPosition(wppolygon);
                                    }
                                }
                            }
                        }
                    }
                    catch { }

                    // update rect and marker pos.
                    if (currentMarker.IsVisible)
                    {
                        currentMarker.Position = pnew;
                    }
                    CurentRectMarker.Position = pnew;

                    if (CurentRectMarker.InnerMarker != null)
                    {
                        CurentRectMarker.InnerMarker.Position = pnew;
                    }
                }
                else if (CurrentGMapMarker != null)
                {
                    PointLatLng pnew = MainMap.FromLocalToLatLng(e.X, e.Y);

                    CurrentGMapMarker.Position = pnew;
                }
                else if (ModifierKeys == Keys.Control)
                {
                    // draw selection box
                    double latdif = MouseDownStart.Lat - point.Lat;
                    double lngdif = MouseDownStart.Lng - point.Lng;

                    MainMap.SelectedArea = new RectLatLng(Math.Max(MouseDownStart.Lat, point.Lat), Math.Min(MouseDownStart.Lng, point.Lng), Math.Abs(lngdif), Math.Abs(latdif));
                }
                else // left click pan
                {
                    double latdif = MouseDownStart.Lat - point.Lat;
                    double lngdif = MouseDownStart.Lng - point.Lng;

                    try
                    {
                        lock (thisLock)
                        {
                            MainMap.Position = new PointLatLng(center.Position.Lat + latdif, center.Position.Lng + lngdif);
                        }
                    }
                    catch { }
                }
            }
        }

        // MapZoomChanged
        void MainMap_OnMapZoomChanged()
        {
            if (MainMap.Zoom > 0)
            {
                try
                {
                    trackBar1.Value = (int)(MainMap.Zoom);
                }
                catch { }
                //textBoxZoomCurrent.Text = MainMap.Zoom.ToString();
                center.Position = MainMap.Position;
            }
        }



        // loader start loading tiles
        void MainMap_OnTileLoadStart()
        {
            MethodInvoker m = delegate {
                //lbl_status.Text = "Status: loading tiles...";
            };
            try
            {
                BeginInvoke(m);
            }
            catch
            {
            }
        }

        // loader end loading tiles
        void MainMap_OnTileLoadComplete(long ElapsedMilliseconds)
        {

            //MainMap.ElapsedMilliseconds = ElapsedMilliseconds;

            MethodInvoker m = delegate
            {
                //lbl_status.Text = "Status: loaded tiles";

                //panelMenu.Text = "Menu, last load in " + MainMap.ElapsedMilliseconds + "ms";

                //textBoxMemory.Text = string.Format(CultureInfo.InvariantCulture, "{0:0.00}MB of {1:0.00}MB", MainMap.Manager.MemoryCacheSize, MainMap.Manager.MemoryCacheCapacity);
            };
            try
            {
                if (!IsDisposed)
                    BeginInvoke(m);
            }
            catch
            {
            }

        }

        // current point changed
        void MainMap_OnCurrentPositionChanged(PointLatLng point)
        {
            if (point.Lat > 90) { point.Lat = 90; }
            if (point.Lat < -90) { point.Lat = -90; }
            if (point.Lng > 180) { point.Lng = 180; }
            if (point.Lng < -180) { point.Lng = -180; }
            center.Position = point;

            coords1.Lat = point.Lat;
            coords1.Lng = point.Lng;

            // always show on planner view
            //if (MainV2.ShowAirports)
            {
                airportsoverlay.Clear();
                foreach (var item in Airports.getAirports(MainMap.Position))
                {
                    airportsoverlay.Markers.Add(new GMapMarkerAirport(item) { ToolTipText = item.Tag, ToolTipMode = MarkerTooltipMode.OnMouseOver });
                }
            }
        }

        // center markers on start
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (objectsoverlay.Markers.Count > 0)
            {
                MainMap.ZoomAndCenterMarkers(null);
            }
            trackBar1.Value = (int)MainMap.Zoom;
        }

        // ensure focus on map, trackbar can have it too
        private void MainMap_MouseEnter(object sender, EventArgs e)
        {
            // MainMap.Focus();
        }
        #endregion


        private void comboBoxMapType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                MainMap.MapProvider = (GMapProvider)comboBoxMapType.SelectedItem;
                FlightData.mymap.MapProvider = (GMapProvider)comboBoxMapType.SelectedItem;
                MainV2.config["MapType"] = comboBoxMapType.Text;
            }
            catch { CustomMessageBox.Show("Map change failed. try zooming out first."); }
        }

        private void Commands_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control.GetType() == typeof(DataGridViewComboBoxEditingControl))
            {
                var temp = ((ComboBox)e.Control);
                ((ComboBox)e.Control).SelectionChangeCommitted -= Commands_SelectionChangeCommitted;
                ((ComboBox)e.Control).SelectionChangeCommitted += Commands_SelectionChangeCommitted;
                ((ComboBox)e.Control).ForeColor = Color.Black;
                ((ComboBox)e.Control).BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
                Debug.WriteLine("Setting event handle");
            }
        }

        void Commands_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // update row headers
            ((ComboBox)sender).ForeColor = Color.Black;
            ChangeColumnHeader(((ComboBox)sender).Text);
            try
            {
                // default takeoff to non 0 alt
                if (((ComboBox)sender).Text == "TAKEOFF")
                {
                    if (Commands.Rows[selectedrow].Cells[Alt.Index].Value != null && Commands.Rows[selectedrow].Cells[Alt.Index].Value.ToString() == "0")
                        Commands.Rows[selectedrow].Cells[Alt.Index].Value = TXT_DefaultAlt.Text;
                }

                for (int i = 0; i < Commands.ColumnCount; i++)
                {
                    DataGridViewCell tcell = Commands.Rows[selectedrow].Cells[i];
                    if (tcell.GetType() == typeof(DataGridViewTextBoxCell))
                    {
                        if (tcell.Value.ToString() == "?")
                            tcell.Value = "0";
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// Get the Google earth ALT for a given coord
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <returns>Altitude</returns>
        double getGEAlt(double lat, double lng)
        {
            double alt = 0;
            //http://maps.google.com/maps/api/elevation/xml

            try
            {
                using (XmlTextReader xmlreader = new XmlTextReader("http://maps.google.com/maps/api/elevation/xml?locations=" + lat.ToString(new CultureInfo("en-US")) + "," + lng.ToString(new CultureInfo("en-US")) + "&sensor=true"))
                {
                    while (xmlreader.Read())
                    {
                        xmlreader.MoveToElement();
                        switch (xmlreader.Name)
                        {
                            case "elevation":
                                alt = double.Parse(xmlreader.ReadString(), new CultureInfo("en-US"));
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch { }

            return alt * CurrentState.multiplierdist;
        }

        private void TXT_homelat_Enter(object sender, EventArgs e)
        {
            sethome = true;
            CustomMessageBox.Show("请点击地图设置初始化参数！");
        }

        private void Planner_Resize(object sender, EventArgs e)
        {
            MainMap.Zoom = trackBar1.Value;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            try
            {
                base.OnPaint(pe);
            }
            catch (Exception)
            {
            }
        }

        private void Commands_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Commands_RowEnter(null, new DataGridViewCellEventArgs(Commands.CurrentCell.ColumnIndex, Commands.CurrentCell.RowIndex));

            writeKML();
        }

        private void MainMap_Resize(object sender, EventArgs e)
        {
            MainMap.Zoom = MainMap.Zoom + 0.01;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                lock (thisLock)
                {
                    MainMap.Zoom = trackBar1.Value;
                }
            }
            catch { }
        }


        private void BUT_Prefetch_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// from http://stackoverflow.com/questions/1119451/how-to-tell-if-a-line-intersects-a-polygon-in-c
        /// </summary>
        /// <param name="start1"></param>
        /// <param name="end1"></param>
        /// <param name="start2"></param>
        /// <param name="end2"></param>
        /// <returns></returns>
        public PointLatLng FindLineIntersection(PointLatLng start1, PointLatLng end1, PointLatLng start2, PointLatLng end2)
        {
            double denom = ((end1.Lng - start1.Lng) * (end2.Lat - start2.Lat)) - ((end1.Lat - start1.Lat) * (end2.Lng - start2.Lng));
            //  AB & CD are parallel         
            if (denom == 0)
                return PointLatLng.Empty;
            double numer = ((start1.Lat - start2.Lat) * (end2.Lng - start2.Lng)) - ((start1.Lng - start2.Lng) * (end2.Lat - start2.Lat));
            double r = numer / denom;
            double numer2 = ((start1.Lat - start2.Lat) * (end1.Lng - start1.Lng)) - ((start1.Lng - start2.Lng) * (end1.Lat - start1.Lat));
            double s = numer2 / denom;
            if ((r < 0 || r > 1) || (s < 0 || s > 1))
                return PointLatLng.Empty;
            // Find intersection point      
            PointLatLng result = new PointLatLng();
            result.Lng = start1.Lng + (r * (end1.Lng - start1.Lng));
            result.Lat = start1.Lat + (r * (end1.Lat - start1.Lat));
            return result;
        }

        RectLatLng getPolyMinMax(GMapPolygon poly)
        {
            if (poly.Points.Count == 0)
                return new RectLatLng();

            double minx, miny, maxx, maxy;

            minx = maxx = poly.Points[0].Lng;
            miny = maxy = poly.Points[0].Lat;

            foreach (PointLatLng pnt in poly.Points)
            {
                //Console.WriteLine(pnt.ToString());
                minx = Math.Min(minx, pnt.Lng);
                maxx = Math.Max(maxx, pnt.Lng);

                miny = Math.Min(miny, pnt.Lat);
                maxy = Math.Max(maxy, pnt.Lat);
            }

            return new RectLatLng(maxy, minx, Math.Abs(maxx - minx), Math.Abs(miny - maxy));
        }

        const float rad2deg = (float)(180 / Math.PI);
        const float deg2rad = (float)(1.0 / rad2deg);

        private void BUT_grid_Click(object sender, EventArgs e)
        {

        }

        private void label4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MainV2.comPort.MAV.cs.lat != 0)
            {
                TXT_homealt.Text = (MainV2.comPort.MAV.cs.altasl).ToString("0");
                TXT_homelat.Text = MainV2.comPort.MAV.cs.lat.ToString();
                TXT_homelng.Text = MainV2.comPort.MAV.cs.lng.ToString();
            }
            else
            {
                CustomMessageBox.Show("If you're at the field, connect to your APM and wait for GPS lock. Then click 'Home Location' link to set home to your location");
            }
        }


        /// <summary>
        /// Format distance according to prefer distance unit
        /// </summary>
        /// <param name="distInKM">distance in kilometers</param>
        /// <param name="toMeterOrFeet">convert distance to meter or feet if true, covert to km or miles if false</param>
        /// <returns>formatted distance with unit</returns>
        private string FormatDistance(double distInKM, bool toMeterOrFeet)
        {
            string sunits = MainV2.getConfig("distunits");
            Common.distances units = Common.distances.Meters;

            if (sunits != "")
                try
                {
                    units = (Common.distances)Enum.Parse(typeof(Common.distances), sunits);
                }
                catch (Exception) { }

            switch (units)
            {
                case Common.distances.Feet:
                    return toMeterOrFeet ? string.Format((distInKM * 3280.8399).ToString("0.00 ft")) :
                        string.Format((distInKM * 0.621371).ToString("0.0000 miles"));
                case Common.distances.Meters:
                default:
                    return toMeterOrFeet ? string.Format((distInKM * 1000).ToString("0.00 米")) :
                        string.Format(distInKM.ToString("0.0000 千米"));
            }
        }

        PointLatLng startmeasure;

        private void ContextMeasure_Click(object sender, EventArgs e)
        {
            if (startmeasure.IsEmpty)
            {
                startmeasure = MouseDownStart;
                polygonsoverlay.Markers.Add(new GMarkerGoogle(MouseDownStart, GMarkerGoogleType.red));
                MainMap.Invalidate();
                Common.MessageShowAgain("测量距离", "你现在可以平移或者缩放当前位置\n点击选定位置获取当前距离.");
            }
            else
            {
                List<PointLatLng> polygonPoints = new List<PointLatLng>();
                polygonPoints.Add(startmeasure);
                polygonPoints.Add(MouseDownStart);

                GMapPolygon line = new GMapPolygon(polygonPoints, "measure dist");
                line.Stroke.Color = Color.Green;

                polygonsoverlay.Polygons.Add(line);

                polygonsoverlay.Markers.Add(new GMarkerGoogle(MouseDownStart, GMarkerGoogleType.red));
                MainMap.Invalidate();
                CustomMessageBox.Show("距离: " + FormatDistance(MainMap.MapProvider.Projection.GetDistance(startmeasure, MouseDownStart), true) + " 区域带: " + (MainMap.MapProvider.Projection.GetBearing(startmeasure, MouseDownStart).ToString("0")));
                polygonsoverlay.Polygons.Remove(line);
                polygonsoverlay.Markers.Clear();
                startmeasure = new PointLatLng();
            }
        }

        private void rotateMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string heading = "0";
            if (DialogResult.Cancel == InputBox.Show("旋转地图", "输入新的航向", ref heading))
                return;
            float ans = 0;
            if (float.TryParse(heading, out ans))
            {
                MainMap.Bearing = ans;
                FlightData.mymap.Bearing = ans;
            }
        }

        private double currentLat;
        private double currentLng;
        private string currentDistance;
        private string bearing;
        private void addPolygonPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPolygonPoint(currentLat = MouseDownStart.Lat, currentLng=MouseDownStart.Lng);
        }

        /// <summary>
        /// wjch手动添加GPS航点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myBtnAddPoint_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                CustomMessageBox.Show("请连接地面接收器再添加区域航点。");
            }
            else 
            {
                DialogResult res = CustomMessageBox.Show("是否要添加当前区域航点？", "区域航点", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    AddPolygonPoint(currentLat=MainV2.comPort.MAV.cs.lat, currentLng = MainV2.comPort.MAV.cs.lng);
                }
                else 
                {
                    return;
                }
            }
        }

        private void AddPolygonPoint(double lat,double lng) 
        {
            if (polygongridmode == false)
            {
                CustomMessageBox.Show("你将保持在规划工作区域模式,直到你清除工作区域或者创建/上传一个供作区域。");
            }

            polygongridmode = true;

            List<PointLatLng> polygonPoints = new List<PointLatLng>();
            if (drawnpolygonsoverlay.Polygons.Count == 0)
            {
                drawnpolygon.Points.Clear();
                drawnpolygonsoverlay.Polygons.Add(drawnpolygon);
            }

            drawnpolygon.Fill = Brushes.Transparent;

            // remove full loop is exists
            if (drawnpolygon.Points.Count > 1 && drawnpolygon.Points[0] == drawnpolygon.Points[drawnpolygon.Points.Count - 1])
                drawnpolygon.Points.RemoveAt(drawnpolygon.Points.Count - 1); // unmake a full loop

            drawnpolygon.Points.Add(new PointLatLng(lat, lng));

            addpolygonmarkergrid(drawnpolygon.Points.Count.ToString(), lng, lat, 0);

            MainMap.UpdatePolygonLocalPosition(drawnpolygon);

            MainMap.Invalidate();
        }

        /// <summary>
        /// 添加区域航点间的距离和航向角
        /// </summary>
        /// <param name="points"></param>
        private void ShowDistance(List<PointLatLng> points) 
        {
            if (points.Count <= 1)
                return;
            PointLatLng startpoint = new PointLatLng(points[points.Count - 2].Lat, points[points.Count - 2].Lng);
            PointLatLng endpoint = new PointLatLng(points[points.Count-1].Lat, points[points.Count-1].Lng);
            //两点距离
            currentDistance = FormatDistance(MainMap.MapProvider.Projection.GetDistance(startpoint, endpoint), true);
            //两点航向角
            bearing = "  航向角:" + MainMap.MapProvider.Projection.GetBearing(endpoint, startpoint).ToString("0") + "度";

        }

        public void redrawPolygonSurvey(List<PointLatLngAlt> list)
        {
            drawnpolygon.Points.Clear();
            drawnpolygonsoverlay.Clear();

            int tag = 0;
            list.ForEach(x =>
            {
                tag++;
                drawnpolygon.Points.Add(x);
                addpolygonmarkergrid(tag.ToString(), x.Lng, x.Lat, 0);
            });

            drawnpolygonsoverlay.Polygons.Add(drawnpolygon);
            MainMap.UpdatePolygonLocalPosition(drawnpolygon);
            MainMap.Invalidate();
        }

        private void clearPolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polygongridmode = false;
            if (drawnpolygon == null)
                return;
            //wjch20160527
            if (CustomMessageBox.Show("确定清除工作区域！", "清除工作区域", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            drawnpolygon.Points.Clear();
            drawnpolygonsoverlay.Markers.Clear();
            startmeasure = new PointLatLng();
            ClearRouteInfo();
            MainMap.Invalidate();
            writeKML();
        }

        private void clearMissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quickadd = true;

            // mono fix
            Commands.CurrentCell = null;

            Commands.Rows.Clear();

            selectedrow = 0;
            quickadd = false;
            writeKML();
        }

        private void loiterForeverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value =mavcndchange(MAVLink.MAV_CMD.LOITER_UNLIM.ToString());

            ChangeColumnHeader(mavcndchange(MAVLink.MAV_CMD.LOITER_UNLIM.ToString()));

            setfromMap(MouseDownEnd.Lat, MouseDownEnd.Lng, (int)float.Parse(TXT_DefaultAlt.Text));

            writeKML();
        }

        private void jumpstartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string repeat = "2";
            if (DialogResult.Cancel == InputBox.Show("重复跳转", "重复跳转次数", ref repeat))
                return;

            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value = mavcndchange(MAVLink.MAV_CMD.DO_JUMP.ToString());

            Commands.Rows[selectedrow].Cells[Param1.Index].Value = 1;

            Commands.Rows[selectedrow].Cells[Param2.Index].Value = repeat;

            writeKML();
        }

        private void jumpwPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wp = "1";
            if (DialogResult.Cancel == InputBox.Show("航点编号", "跳转到航点的编号", ref wp))
                return;
            string repeat = "2";
            if (DialogResult.Cancel == InputBox.Show("重复跳转", "重复的次数", ref repeat))
                return;

            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value = mavcndchange(MAVLink.MAV_CMD.DO_JUMP.ToString());

            Commands.Rows[selectedrow].Cells[Param1.Index].Value = wp;

            Commands.Rows[selectedrow].Cells[Param2.Index].Value = repeat;

            writeKML();
        }

        private void deleteWPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CustomMessageBox.Show("确定是否删除航点！", "删除航点", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int no = 0;
            if (CurentRectMarker != null)
            {
                if (int.TryParse(CurentRectMarker.InnerMarker.Tag.ToString(), out no))
                {
                    try
                    {
                        Commands.Rows.RemoveAt(no - 1); // home is 0
                    }
                    catch { CustomMessageBox.Show("选择的航点错误,请再次尝试。"); }
                }
                else if (int.TryParse(CurentRectMarker.InnerMarker.Tag.ToString().Replace("区域航点", ""), out no))
                {
                    try
                    {
                        drawnpolygon.Points.RemoveAt(no - 1);
                        drawnpolygonsoverlay.Markers.Clear();

                        int a = 1;
                        foreach (PointLatLng pnt in drawnpolygon.Points)
                        {
                            addpolygonmarkergrid(a.ToString(), pnt.Lng, pnt.Lat, 0);
                            a++;
                        }

                        MainMap.UpdatePolygonLocalPosition(drawnpolygon);

                        MainMap.Invalidate();
                    }
                    catch
                    {
                        CustomMessageBox.Show("清除失败的航点，请再次尝试。");
                    }
                }
            }
            else if (CurrentRallyPt != null)
            {
                rallypointoverlay.Markers.Remove(CurrentRallyPt);
                MainMap.Invalidate(true);

                CurrentRallyPt = null;
            }
            else if (CurrentLimitPt != null) 
            {
                drawnlimitpolygonsoverlay.Markers.Remove(CurrentLimitPt);
                MainMap.Invalidate(true);

                CurrentLimitPt = null;
            }
            else if (CurrentBreakPt != null) 
            {
                breakploygonsoverlay.Markers.Remove(CurrentBreakPt);
                MainMap.Invalidate(true);

                CurrentBreakPt = null;
            }


            if (currentMarker != null)
                CurentRectMarker = null;

            writeKML();
        }

        private void loitertimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string time = "5";
            if (DialogResult.Cancel == InputBox.Show("盘旋时间", "盘旋时间(S)", ref time))
                return;

            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value = mavcndchange(MAVLink.MAV_CMD.LOITER_TIME.ToString());

            Commands.Rows[selectedrow].Cells[Param1.Index].Value = time;

            ChangeColumnHeader(mavcndchange(MAVLink.MAV_CMD.LOITER_TIME.ToString()));

            setfromMap(MouseDownEnd.Lat, MouseDownEnd.Lng, (int)float.Parse(TXT_DefaultAlt.Text));

            writeKML();
        }

        private void loitercirclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string turns = "3";
            if (DialogResult.Cancel == InputBox.Show("盘旋圈数", "盘旋圈数", ref turns))
                return;

            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value = mavcndchange(MAVLink.MAV_CMD.LOITER_TURNS.ToString());

            Commands.Rows[selectedrow].Cells[Param1.Index].Value = turns;

            ChangeColumnHeader(mavcndchange(MAVLink.MAV_CMD.LOITER_TURNS.ToString()));

            setfromMap(MouseDownEnd.Lat, MouseDownEnd.Lng, (int)float.Parse(TXT_DefaultAlt.Text));

            writeKML();
        }

        private void panelMap_Resize(object sender, EventArgs e)
        {
            // this is a mono fix for the zoom bar
            //Console.WriteLine("panelmap "+panelMap.Size.ToString());
            MainMap.Size = new Size(panelMap.Size.Width - 50, panelMap.Size.Height);
            trackBar1.Location = new Point(panelMap.Size.Width - 50, trackBar1.Location.Y);
            trackBar1.Size = new Size(trackBar1.Size.Width, panelMap.Size.Height - trackBar1.Location.Y);
            //label11.Location = new Point(panelMap.Size.Width - 50, label11.Location.Y);
        }

        DateTime mapupdate = DateTime.MinValue;

        /// <summary>
        /// Draw an mav icon, and update tracker location icon and guided mode wp on FP screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                ControlInit();

                if (isMouseDown)
                    return;

                routesoverlay.Markers.Clear();

                if (MainV2.comPort.MAV.cs.TrackerLocation != MainV2.comPort.MAV.cs.HomeLocation && MainV2.comPort.MAV.cs.TrackerLocation.Lng != 0)
                {
                    addpolygonmarker("Tracker Home", MainV2.comPort.MAV.cs.TrackerLocation.Lng, MainV2.comPort.MAV.cs.TrackerLocation.Lat, (int)MainV2.comPort.MAV.cs.TrackerLocation.Alt, Color.Blue, routesoverlay);
                }

                if (MainV2.comPort.MAV.cs.lat == 0 || MainV2.comPort.MAV.cs.lng == 0)
                    return;

                PointLatLng currentloc = new PointLatLng(MainV2.comPort.MAV.cs.lat, MainV2.comPort.MAV.cs.lng);

                if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduPlane || MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Ateryx)
                {
                    routesoverlay.Markers.Add(new GMapMarkerPlane(currentloc, MainV2.comPort.MAV.cs.yaw, MainV2.comPort.MAV.cs.groundcourse, MainV2.comPort.MAV.cs.nav_bearing, MainV2.comPort.MAV.cs.target_bearing));
                }
                else if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduRover)
                {
                    routesoverlay.Markers.Add(new GMapMarkerRover(currentloc, MainV2.comPort.MAV.cs.yaw, MainV2.comPort.MAV.cs.groundcourse, MainV2.comPort.MAV.cs.nav_bearing, MainV2.comPort.MAV.cs.target_bearing));
                }
                else if (MainV2.comPort.MAV.aptype == MAVLink.MAV_TYPE.HELICOPTER)
                {
                    routesoverlay.Markers.Add((new GMapMarkerHeli(currentloc, MainV2.comPort.MAV.cs.yaw, MainV2.comPort.MAV.cs.groundcourse, MainV2.comPort.MAV.cs.nav_bearing)));
                }
                else if (MainV2.comPort.MAV.aptype == MAVLink.MAV_TYPE.ANTENNA_TRACKER)
                {
                    routesoverlay.Markers.Add(new GMapMarkerAntennaTracker(currentloc, MainV2.comPort.MAV.cs.yaw, MainV2.comPort.MAV.cs.target_bearing));
                }
                else
                {
                    routesoverlay.Markers.Add(new GMapMarkerQuad(currentloc, MainV2.comPort.MAV.cs.yaw, MainV2.comPort.MAV.cs.groundcourse, MainV2.comPort.MAV.cs.nav_bearing,MainV2.comPort.MAV.sysid));
                }

                if (MainV2.comPort.MAV.cs.mode.ToLower() == "guided" && MainV2.comPort.MAV.GuidedMode.x != 0)
                {
                    addpolygonmarker("Guided Mode", MainV2.comPort.MAV.GuidedMode.y, MainV2.comPort.MAV.GuidedMode.x, (int)MainV2.comPort.MAV.GuidedMode.z, Color.Blue, routesoverlay);
                }



                //时时飞行航线
                routePoints(currentloc);

                //页面初始化参数
                initParams();
               
                //计时器
                addTimer();

                //计算区域信息及其飞行参数
                addAnyTimeInfo();
            }
            catch (Exception ex) { log.Warn(ex); }
        }



        /// <summary>
        /// Try to reduce the number of map position changes generated by the code
        /// </summary>
        DateTime lastmapposchange = DateTime.MinValue;

        private void updateMapPosition(PointLatLng currentloc)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                try
                {
                    if (lastmapposchange.Second != DateTime.Now.Second)
                    {
                        MainMap.Position = currentloc;
                        lastmapposchange = DateTime.Now;
                    }
                }
                catch { }
            });
        }

        private void addpolygonmarker(string tag, double lng, double lat, int alt, Color? color, GMapOverlay overlay)
        {
            try
            {
                PointLatLng point = new PointLatLng(lat, lng);
                GMarkerGoogle m = new GMarkerGoogle(point, GMarkerGoogleType.green);
                m.ToolTipMode = MarkerTooltipMode.Always;
                m.ToolTipText = tag;
                m.Tag = tag;

                GMapMarkerRect mBorders = new GMapMarkerRect(point);
                {
                    mBorders.InnerMarker = m;
                    try
                    {
                        mBorders.wprad = (int)(float.Parse(MainV2.config["TXT_WPRad"].ToString()) / CurrentState.multiplierdist);
                    }
                    catch { }
                    if (color.HasValue)
                    {
                        mBorders.Color = color.Value;
                    }
                }

                overlay.Markers.Add(m);
                overlay.Markers.Add(mBorders);
            }
            catch (Exception) { }
        }

        private void GeoFenceuploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polygongridmode = false;
            //FENCE_TOTAL
            if (MainV2.comPort.MAV.param["FENCE_ACTION"] == null)
            {
                CustomMessageBox.Show("Not Supported");
                return;
            }

            if (drawnpolygon == null)
            {
                CustomMessageBox.Show("No polygon to upload");
                return;
            }

            if (geofenceoverlay.Markers.Count == 0)
            {
                CustomMessageBox.Show("No return location set");
                return;
            }

            if (drawnpolygon.Points.Count == 0)
            {
                CustomMessageBox.Show("No polygon drawn");
                return;
            }

            // check if return is inside polygon
            List<PointLatLng> plll = new List<PointLatLng>(drawnpolygon.Points.ToArray());
            // close it
            plll.Add(plll[0]);
            // check it
            if (!pnpoly(plll.ToArray(), geofenceoverlay.Markers[0].Position.Lat, geofenceoverlay.Markers[0].Position.Lng))
            {
                CustomMessageBox.Show("Your return location is outside the polygon");
                return;
            }

            string minalts = (int.Parse(MainV2.comPort.MAV.param["FENCE_MINALT"].ToString()) * CurrentState.multiplierdist).ToString("0");
            if (DialogResult.Cancel == InputBox.Show("Min Alt", "Box Minimum Altitude?", ref minalts))
                return;

            string maxalts = (int.Parse(MainV2.comPort.MAV.param["FENCE_MAXALT"].ToString()) * CurrentState.multiplierdist).ToString("0");
            if (DialogResult.Cancel == InputBox.Show("Max Alt", "Box Maximum Altitude?", ref maxalts))
                return;

            int minalt = 0;
            int maxalt = 0;

            if (!int.TryParse(minalts, out minalt))
            {
                CustomMessageBox.Show("Bad Min Alt");
                return;
            }

            if (!int.TryParse(maxalts, out maxalt))
            {
                CustomMessageBox.Show("Bad Max Alt");
                return;
            }

            try
            {
                MainV2.comPort.setParam("FENCE_MINALT", minalt);
                MainV2.comPort.setParam("FENCE_MAXALT", maxalt);
            }
            catch
            {
                CustomMessageBox.Show("Failed to set min/max fence alt");
                return;
            }

            float oldaction = (float)MainV2.comPort.MAV.param["FENCE_ACTION"];

            try
            {
                MainV2.comPort.setParam("FENCE_ACTION", 0);
            }
            catch
            {
                CustomMessageBox.Show("Failed to set FENCE_ACTION");
                return;
            }

            // points + return + close
            byte pointcount = (byte)(drawnpolygon.Points.Count + 2);


            try
            {
                MainV2.comPort.setParam("FENCE_TOTAL", pointcount);
            }
            catch
            {
                CustomMessageBox.Show("Failed to set FENCE_TOTAL");
                return;
            }

            try
            {
                byte a = 0;
                // add return loc
                MainV2.comPort.setFencePoint(a, new PointLatLngAlt(geofenceoverlay.Markers[0].Position), pointcount);
                a++;
                // add points
                foreach (var pll in drawnpolygon.Points)
                {
                    MainV2.comPort.setFencePoint(a, new PointLatLngAlt(pll), pointcount);
                    a++;
                }

                // add polygon close
                MainV2.comPort.setFencePoint(a, new PointLatLngAlt(drawnpolygon.Points[0]), pointcount);

                try
                {
                    MainV2.comPort.setParam("FENCE_ACTION", oldaction);
                }
                catch
                {
                    CustomMessageBox.Show("Failed to restore FENCE_ACTION");
                    return;
                }

                // clear everything
                drawnpolygonsoverlay.Polygons.Clear();
                drawnpolygonsoverlay.Markers.Clear();
                geofenceoverlay.Polygons.Clear();
                geofencepolygon.Points.Clear();

                // add polygon
                geofencepolygon.Points.AddRange(drawnpolygon.Points.ToArray());

                drawnpolygon.Points.Clear();

                geofenceoverlay.Polygons.Add(geofencepolygon);

                // update flightdata
                FlightData.geofence.Markers.Clear();
                FlightData.geofence.Polygons.Clear();
                FlightData.geofence.Polygons.Add(new GMapPolygon(geofencepolygon.Points, "gf fd") { Stroke = geofencepolygon.Stroke });
                FlightData.geofence.Markers.Add(new GMarkerGoogle(geofenceoverlay.Markers[0].Position, GMarkerGoogleType.red) { ToolTipText = geofenceoverlay.Markers[0].ToolTipText, ToolTipMode = geofenceoverlay.Markers[0].ToolTipMode });

                MainMap.UpdatePolygonLocalPosition(geofencepolygon);
                MainMap.UpdateMarkerLocalPosition(geofenceoverlay.Markers[0]);

                MainMap.Invalidate();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Failed to send new fence points " + ex, Strings.ERROR);
            }
        }

        private void GeoFencedownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polygongridmode = false;
            int count = 1;

            if (MainV2.comPort.MAV.param["FENCE_ACTION"] == null || MainV2.comPort.MAV.param["FENCE_TOTAL"] == null)
            {
                CustomMessageBox.Show("Not Supported");
                return;
            }

            if (int.Parse(MainV2.comPort.MAV.param["FENCE_TOTAL"].ToString()) <= 1)
            {
                CustomMessageBox.Show("Nothing to download");
                return;
            }

            geofenceoverlay.Polygons.Clear();
            geofenceoverlay.Markers.Clear();
            geofencepolygon.Points.Clear();


            for (int a = 0; a < count; a++)
            {
                try
                {
                    PointLatLngAlt plla = MainV2.comPort.getFencePoint(a, ref count);
                    geofencepolygon.Points.Add(new PointLatLng(plla.Lat, plla.Lng));
                }
                catch { CustomMessageBox.Show("Failed to get fence point", Strings.ERROR); return; }
            }

            // do return location
            geofenceoverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(geofencepolygon.Points[0].Lat, geofencepolygon.Points[0].Lng), GMarkerGoogleType.red) { ToolTipMode = MarkerTooltipMode.OnMouseOver, ToolTipText = "GeoFence Return" });
            geofencepolygon.Points.RemoveAt(0);

            // add now - so local points are calced
            geofenceoverlay.Polygons.Add(geofencepolygon);

            // update flight data
            FlightData.geofence.Markers.Clear();
            FlightData.geofence.Polygons.Clear();
            FlightData.geofence.Polygons.Add(new GMapPolygon(geofencepolygon.Points, "gf fd") { Stroke = geofencepolygon.Stroke, Fill = Brushes.Transparent });
            FlightData.geofence.Markers.Add(new GMarkerGoogle(geofenceoverlay.Markers[0].Position, GMarkerGoogleType.red) { ToolTipText = geofenceoverlay.Markers[0].ToolTipText, ToolTipMode = geofenceoverlay.Markers[0].ToolTipMode });

            MainMap.UpdatePolygonLocalPosition(geofencepolygon);
            MainMap.UpdateMarkerLocalPosition(geofenceoverlay.Markers[0]);

            MainMap.Invalidate();
        }

        private void setReturnLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            geofenceoverlay.Markers.Clear();
            geofenceoverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(MouseDownStart.Lat, MouseDownStart.Lng), GMarkerGoogleType.red) { ToolTipMode = MarkerTooltipMode.OnMouseOver, ToolTipText = "GeoFence Return" });

            MainMap.Invalidate();
        }

        /// <summary>
        /// from http://www.ecse.rpi.edu/Homepages/wrf/Research/Short_Notes/pnpoly.html
        /// </summary>
        /// <param name="array"> a closed polygon</param>
        /// <param name="testx"></param>
        /// <param name="testy"></param>
        /// <returns> true = outside</returns>
        bool pnpoly(PointLatLng[] array, double testx, double testy)
        {
            int nvert = array.Length;
            int i, j = 0;
            bool c = false;
            for (i = 0, j = nvert - 1; i < nvert; j = i++)
            {
                if (((array[i].Lng > testy) != (array[j].Lng > testy)) &&
                 (testx < (array[j].Lat - array[i].Lat) * (testy - array[i].Lng) / (array[j].Lng - array[i].Lng) + array[i].Lat))
                    c = !c;
            }
            return c;
        }

        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Fence (*.fen)|*.fen";
                fd.ShowDialog();
                if (File.Exists(fd.FileName))
                {
                    StreamReader sr = new StreamReader(fd.OpenFile());

                    drawnpolygonsoverlay.Markers.Clear();
                    drawnpolygonsoverlay.Polygons.Clear();
                    drawnpolygon.Points.Clear();

                    int a = 0;

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.StartsWith("#"))
                        {
                        }
                        else
                        {
                            string[] items = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                            if (a == 0)
                            {
                                geofenceoverlay.Markers.Clear();
                                geofenceoverlay.Markers.Add(new GMarkerGoogle(new PointLatLng(double.Parse(items[0]), double.Parse(items[1])), GMarkerGoogleType.red) { ToolTipMode = MarkerTooltipMode.OnMouseOver, ToolTipText = "GeoFence Return" });
                                MainMap.UpdateMarkerLocalPosition(geofenceoverlay.Markers[0]);
                            }
                            else
                            {
                                drawnpolygon.Points.Add(new PointLatLng(double.Parse(items[0]), double.Parse(items[1])));
                                addpolygonmarkergrid(drawnpolygon.Points.Count.ToString(), double.Parse(items[1]), double.Parse(items[0]), 0);
                            }
                            a++;
                        }
                    }

                    // remove loop close
                    if (drawnpolygon.Points.Count > 1 && drawnpolygon.Points[0] == drawnpolygon.Points[drawnpolygon.Points.Count - 1])
                    {
                        drawnpolygon.Points.RemoveAt(drawnpolygon.Points.Count - 1);
                    }

                    drawnpolygonsoverlay.Polygons.Add(drawnpolygon);

                    MainMap.UpdatePolygonLocalPosition(drawnpolygon);

                    MainMap.Invalidate();
                }
            }
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (geofenceoverlay.Markers.Count == 0)
            {
                CustomMessageBox.Show("Please set a return location");
                return;
            }


            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Fence (*.fen)|*.fen";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(sf.OpenFile());

                        sw.WriteLine("#saved by APM Planner " + Application.ProductVersion);

                        sw.WriteLine(geofenceoverlay.Markers[0].Position.Lat + " " + geofenceoverlay.Markers[0].Position.Lng);
                        if (drawnpolygon.Points.Count > 0)
                        {
                            foreach (var pll in drawnpolygon.Points)
                            {
                                sw.WriteLine(pll.Lat + " " + pll.Lng);
                            }

                            PointLatLng pll2 = drawnpolygon.Points[0];

                            sw.WriteLine(pll2.Lat + " " + pll2.Lng);
                        }
                        else
                        {
                            foreach (var pll in geofencepolygon.Points)
                            {
                                sw.WriteLine(pll.Lat + " " + pll.Lng);
                            }

                            PointLatLng pll2 = geofencepolygon.Points[0];

                            sw.WriteLine(pll2.Lat + " " + pll2.Lng);
                        }

                        sw.Close();
                    }
                    catch { CustomMessageBox.Show("Failed to write fence file"); }
                }
            }
        }

        public T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();

                formatter.Serialize(ms, obj);

                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }

        private void createWpCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string RadiusIn = "50";
            if (DialogResult.Cancel == InputBox.Show("半径", "半径", ref RadiusIn))
                return;

            string Pointsin = "20";
            if (DialogResult.Cancel == InputBox.Show("航点", "在圆上生成的行点数", ref Pointsin))
                return;

            string Directionin = "1";
            if (DialogResult.Cancel == InputBox.Show("航点", "圆的方向 (-1 or 1)", ref Directionin))
                return;

            string startanglein = "0";
            if (DialogResult.Cancel == InputBox.Show("角度", "第一点角度（全度）", ref startanglein))
                return;

            int Points = 0;
            int Radius = 0;
            int Direction = 1;
            int startangle = 0;

            if (!int.TryParse(RadiusIn, out Radius))
            {
                CustomMessageBox.Show("错误半径");
                return;
            }

            if (!int.TryParse(Pointsin, out Points))
            {
                CustomMessageBox.Show("错误的航点");
                return;
            }

            if (!int.TryParse(Directionin, out Direction))
            {
                CustomMessageBox.Show("错误的方向");
                return;
            }

            if (!int.TryParse(startanglein, out startangle))
            {
                CustomMessageBox.Show("错误的开始角度");
                return;
            }

            double a = startangle;
            double step = 360.0f / Points;
            if (Direction == -1)
            {
                a += 360;
                step *= -1;
            }

            quickadd = true;

            for (; a <= (startangle + 360) && a >= 0; a += step)
            {

                selectedrow = Commands.Rows.Add();

                Commands.Rows[selectedrow].Cells[Command.Index].Value = MAVLink.MAV_CMD.WAYPOINT.ToString();

                ChangeColumnHeader(MAVLink.MAV_CMD.WAYPOINT.ToString());

                float d = Radius;
                float R = 6371000;

                var lat2 = Math.Asin(Math.Sin(MouseDownEnd.Lat * deg2rad) * Math.Cos(d / R) +
              Math.Cos(MouseDownEnd.Lat * deg2rad) * Math.Sin(d / R) * Math.Cos(a * deg2rad));
                var lon2 = MouseDownEnd.Lng * deg2rad + Math.Atan2(Math.Sin(a * deg2rad) * Math.Sin(d / R) * Math.Cos(MouseDownEnd.Lat * deg2rad),
                                     Math.Cos(d / R) - Math.Sin(MouseDownEnd.Lat * deg2rad) * Math.Sin(lat2));

                PointLatLng pll = new PointLatLng(lat2 * rad2deg, lon2 * rad2deg);

                setfromMap(pll.Lat, pll.Lng, (int)float.Parse(TXT_DefaultAlt.Text));

            }

            quickadd = false;
            writeKML();

            //drawnpolygon.Points.Add(new PointLatLng(start.Lat, start.Lng));
        }

        public void Activate()
        {
            InitControl();
            timer1.Start();
            timer_getbreakpoint.Start();
            timer_time.Start();

            if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2)
            {
                CMB_altmode.Visible = false;
            }
            else
            {
                CMB_altmode.Visible = false;
            }

            //switchDockingToolStripMenuItem_Click(null, null);

            updateHome();

            setWPParams();

            updateCMDParams();

            try
            {
                int.Parse(TXT_DefaultAlt.Text);
            }
            catch { CustomMessageBox.Show("请先确定高度的默认值"); TXT_DefaultAlt.Text = (50 * CurrentState.multiplierdist).ToString("0"); }
        }

        public void updateHome()
        {
            quickadd = true;
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate { updateHomeText(); });
            }
            else
            {
                updateHomeText();
            }
            quickadd = false;
        }

        private void updateHomeText()
        {
            // set home location
            if (MainV2.comPort.MAV.cs.HomeLocation.Lat != 0 && MainV2.comPort.MAV.cs.HomeLocation.Lng != 0)
            {
                TXT_homelat.Text = MainV2.comPort.MAV.cs.HomeLocation.Lat.ToString();

                TXT_homelng.Text = MainV2.comPort.MAV.cs.HomeLocation.Lng.ToString();

                TXT_homealt.Text = MainV2.comPort.MAV.cs.HomeLocation.Alt.ToString();

                writeKML();
            }

        }

        public void Deactivate()
        {
            config(true);
            timer1.Stop();
            timer_getbreakpoint.Stop();
            timer_time.Stop();
        }

        private void FlightPlanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer_getbreakpoint.Stop();
            timer_time.Stop();
        }

        private void setROIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!cmdParamNames.ContainsKey("DO_SET_ROI"))
            {
                CustomMessageBox.Show(Strings.ErrorFeatureNotEnabled, Strings.ERROR);
                return;
            }

            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value = MAVLink.MAV_CMD.DO_SET_ROI.ToString();

            //Commands.Rows[selectedrow].Cells[Param1.Index].Value = time;

            ChangeColumnHeader(MAVLink.MAV_CMD.DO_SET_ROI.ToString());

            setfromMap(MouseDownEnd.Lat, MouseDownEnd.Lng, (int)float.Parse(TXT_DefaultAlt.Text));

            writeKML();
        }

        private void zoomToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string place = "";
            if (DialogResult.OK == InputBox.Show("位置", "输入你的位置", ref place))
            {

                GeoCoderStatusCode status = MainMap.SetPositionByKeywords(place);
                if (status != GeoCoderStatusCode.G_GEO_SUCCESS)
                {
                    CustomMessageBox.Show("地图地理编码找不到: '" + place + "', 原因: " + status, "地图", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MainMap.Zoom = 15;
                }
            }
        }

        bool fetchpathrip;

        private void FetchPath()
        {
            PointLatLngAlt lastpnt = null;

            DialogResult res = CustomMessageBox.Show("准备好对选定的航线进行放大 = " + (int)MainMap.Zoom + " ?", "地图", MessageBoxButtons.YesNo);

            fetchpathrip = true;

            foreach (var pnt in pointlist)
            {
                if (pnt == null)
                    continue;

                // exit if reqested
                if (!fetchpathrip)
                    break;

                // setup initial enviroment
                if (lastpnt == null)
                {
                    lastpnt = pnt;
                    continue;
                }

                RectLatLng area = new RectLatLng();
                double top = Math.Max(lastpnt.Lat, pnt.Lat);
                double left = Math.Min(lastpnt.Lng, pnt.Lng);
                double bottom = Math.Min(lastpnt.Lat, pnt.Lat);
                double right = Math.Max(lastpnt.Lng, pnt.Lng);

                area.LocationTopLeft = new PointLatLng(top, left);
                area.HeightLat = top - bottom;
                area.WidthLng = right - left;



                int todo;
                // todo
                // split up pull area to smaller chunks

                for (int i = 1; i <= MainMap.MaxZoom; i++)
                {
                    if (res == DialogResult.Yes)
                    {
                        TilePrefetcher obj = new TilePrefetcher();
                        obj.KeyDown += obj_KeyDown;
                        obj.ShowCompleteMessage = false;
                        obj.Start(area, i, MainMap.MapProvider, 100, 0);

                    }
                    else if (res == DialogResult.No)
                    {
                    }
                    else
                    {
                        break;
                    }
                }

                if (res == DialogResult.Cancel || res == DialogResult.None)
                {
                    break;
                }

                lastpnt = pnt;
            }
        }

        void obj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                fetchpathrip = false;
            }
        }

        private void prefetchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectLatLng area = MainMap.SelectedArea;
            if (area.IsEmpty)
            {
                DialogResult res = CustomMessageBox.Show("选定的区域不明确, 是否显示在屏幕？", "选定区域", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    area = MainMap.ViewArea;
                }
            }

            if (!area.IsEmpty)
            {
                DialogResult res = CustomMessageBox.Show("准备选定的区域放大 = " + (int)MainMap.Zoom + " ?", "地图", MessageBoxButtons.YesNo);

                for (int i = 1; i <= MainMap.MaxZoom; i++)
                {
                    if (res == DialogResult.Yes)
                    {
                        TilePrefetcher obj = new TilePrefetcher();
                        obj.ShowCompleteMessage = false;
                        obj.Start(area, i, MainMap.MapProvider, 100, 0);
                    }
                    else if (res == DialogResult.No)
                    {
                    }
                    else if (res == DialogResult.Cancel)
                    {
                        break;
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("按住ALT选择地图区域", "地图", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void kMLOverlayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Google Earth KML |*.kml;*.kmz";
                DialogResult result = fd.ShowDialog();
                string file = fd.FileName;
                if (file != "")
                {
                    try
                    {
                        kmlpolygonsoverlay.Polygons.Clear();
                        kmlpolygonsoverlay.Routes.Clear();

                        FlightData.kmlpolygons.Routes.Clear();
                        FlightData.kmlpolygons.Polygons.Clear();

                        string kml = "";
                        string tempdir = "";
                        if (file.ToLower().EndsWith("kmz"))
                        {
                            ZipFile input = new ZipFile(file);

                            tempdir = Path.GetTempPath() + Path.DirectorySeparatorChar + Path.GetRandomFileName();
                            input.ExtractAll(tempdir, ExtractExistingFileAction.OverwriteSilently);

                            string[] kmls = Directory.GetFiles(tempdir, "*.kml");

                            if (kmls.Length > 0)
                            {
                                file = kmls[0];

                                input.Dispose();
                            }
                            else
                            {
                                input.Dispose();
                                return;
                            }
                        }

                        var sr = new StreamReader(File.OpenRead(file));
                        kml = sr.ReadToEnd();
                        sr.Close();

                        // cleanup after out
                        if (tempdir != "")
                            Directory.Delete(tempdir, true);

                        kml = kml.Replace("<Snippet/>", "");

                        var parser = new Parser();

                        parser.ElementAdded += parser_ElementAdded;
                        parser.ParseString(kml, false);

                        if (DialogResult.Yes == CustomMessageBox.Show("你想把这个加载到飞行数据?", "加载数据", MessageBoxButtons.YesNo))
                        {
                            foreach (var temp in kmlpolygonsoverlay.Polygons)
                            {
                                FlightData.kmlpolygons.Polygons.Add(temp);
                            }
                            foreach (var temp in kmlpolygonsoverlay.Routes)
                            {
                                FlightData.kmlpolygons.Routes.Add(temp);
                            }
                        }

                    }
                    catch (Exception ex) { CustomMessageBox.Show("错误的KML文件 :" + ex); }
                }
            }
        }

        private void elevationGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeKML();
            double homealt = MainV2.comPort.MAV.cs.HomeAlt;
            Form temp = new ElevationProfile(pointlist, homealt, (altmode)CMB_altmode.SelectedValue);
            ThemeManager.ApplyThemeTo(temp);
            temp.ShowDialog();
        }

        private void rTLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value = mavcndchange(MAVLink.MAV_CMD.RETURN_TO_LAUNCH.ToString());

            //Commands.Rows[selectedrow].Cells[Param1.Index].Value = time;

            ChangeColumnHeader(mavcndchange(MAVLink.MAV_CMD.RETURN_TO_LAUNCH.ToString()));

            writeKML();
        }

        private void landToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value = mavcndchange(MAVLink.MAV_CMD.LAND.ToString());

            //Commands.Rows[selectedrow].Cells[Param1.Index].Value = time;

            ChangeColumnHeader(mavcndchange(MAVLink.MAV_CMD.LAND.ToString()));

            setfromMap(MouseDownEnd.Lat, MouseDownEnd.Lng, 1);

            writeKML();
        }

        private void AddDigicamControlPhoto()
        {
            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value = MAVLink.MAV_CMD.DO_DIGICAM_CONTROL.ToString();

            ChangeColumnHeader(MAVLink.MAV_CMD.DO_DIGICAM_CONTROL.ToString());

            writeKML();
        }

        public void AddCommand(MAVLink.MAV_CMD cmd, double p1, double p2, double p3, double p4, double x, double y, double z)
        {
            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value = mavcndchange(cmd.ToString());
            ChangeColumnHeader(mavcndchange(cmd.ToString()));

            // switch wp to spline if spline checked
            if (splinemode && cmd == MAVLink.MAV_CMD.WAYPOINT)
            {
                Commands.Rows[selectedrow].Cells[Command.Index].Value = mavcndchange(MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString());
                ChangeColumnHeader(mavcndchange(MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString()));
            }

            if (cmd == MAVLink.MAV_CMD.WAYPOINT)
            {
                setfromMap(y, x, (float)z, Math.Round(p1, 1));
            }
            else
            {
                Commands.Rows[selectedrow].Cells[Param1.Index].Value = p1;
                Commands.Rows[selectedrow].Cells[Param2.Index].Value = p2;
                Commands.Rows[selectedrow].Cells[Param3.Index].Value = p3;
                Commands.Rows[selectedrow].Cells[Param4.Index].Value = p4;
                Commands.Rows[selectedrow].Cells[Lat.Index].Value = y;
                Commands.Rows[selectedrow].Cells[Lon.Index].Value = x;
                Commands.Rows[selectedrow].Cells[Alt.Index].Value = z;
            }

            writeKML();
        }

        private void takeoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // altitude
            string alt = "10";

            if (DialogResult.Cancel == InputBox.Show("高度", "请输入飞行器起飞高度", ref alt))
                return;

            int alti = -1;

            if (!int.TryParse(alt, out alti))
            {
                MessageBox.Show("输入格式不正确,请重新输入！");
                return;
            }

            // take off pitch
            int topi = 0;

            if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduPlane || MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Ateryx)
            {
                string top = "15";

                if (DialogResult.Cancel == InputBox.Show("起飞俯仰角", "请输入起飞俯仰角", ref top))
                    return;

                if (!int.TryParse(top, out topi))
                {
                    MessageBox.Show("错误的俯仰角");
                    return;
                }
            }

            selectedrow = Commands.Rows.Add();

            Commands.Rows[selectedrow].Cells[Command.Index].Value =mavcndchange(MAVLink.MAV_CMD.TAKEOFF.ToString());

            Commands.Rows[selectedrow].Cells[Param1.Index].Value = topi;

            Commands.Rows[selectedrow].Cells[Alt.Index].Value = alti;

            ChangeColumnHeader(mavcndchange(MAVLink.MAV_CMD.TAKEOFF.ToString()));

            writeKML();
        }

        internal string wpfilename;

        private void loadWPFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BUT_loadwpfile_Click(null, null);
        }

        private void saveWPFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile_Click(null, null);
        }

        private void trackerHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainV2.comPort.MAV.cs.TrackerLocation = new PointLatLngAlt(MouseDownEnd) { Alt = MainV2.comPort.MAV.cs.HomeAlt };
        }

        private void reverseWPsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRowCollection rows = Commands.Rows;
            //Commands.Rows.Clear();

            int count = rows.Count;

            quickadd = true;

            for (int a = count; a > 0; a--)
            {
                DataGridViewRow row = Commands.Rows[a - 1];
                Commands.Rows.Remove(row);
                Commands.Rows.Add(row);
            }

            quickadd = false;

            writeKML();
        }

        private void loadAndAppendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "By Aero (*.txt)|*.*";
                fd.DefaultExt = ".txt";
                DialogResult result = fd.ShowDialog();
                string file = fd.FileName;
                if (file != "")
                {
                    readQGC110wpfile(file, true);
                }
            }
        }

        private void savePolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (drawnpolygon.Points.Count == 0)
            {
                return;
            }


            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Polygon (*.poly)|*.poly";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(sf.OpenFile());

                        sw.WriteLine("#saved by By Aero " + Application.ProductVersion);

                        if (drawnpolygon.Points.Count > 0)
                        {
                            foreach (var pll in drawnpolygon.Points)
                            {
                                sw.WriteLine(pll.Lat + " " + pll.Lng);
                            }

                            //PointLatLng pll2 = drawnpolygon.Points[0];

                            //sw.WriteLine(pll2.Lat + " " + pll2.Lng);
                        }

                        sw.Close();
                    }
                    catch { CustomMessageBox.Show("Failed to write fence file"); }
                }
            }
        }

        private void loadPolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Polygon (*.poly)|*.poly";
                fd.ShowDialog();
                if (File.Exists(fd.FileName))
                {
                    StreamReader sr = new StreamReader(fd.OpenFile());

                    drawnpolygonsoverlay.Markers.Clear();
                    drawnpolygonsoverlay.Polygons.Clear();
                    drawnpolygon.Points.Clear();

                    int a = 0;

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.StartsWith("#"))
                        {
                        }
                        else
                        {
                            if (line != "") 
                            {
                                string[] items = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                                drawnpolygon.Points.Add(new PointLatLng(double.Parse(items[0]), double.Parse(items[1])));
                                addpolygonmarkergrid(drawnpolygon.Points.Count.ToString(), double.Parse(items[1]), double.Parse(items[0]), 0);

                                a++;
                            }
                        }
                    }

                    // remove loop close
                    if (drawnpolygon.Points.Count > 1 && drawnpolygon.Points[0] == drawnpolygon.Points[drawnpolygon.Points.Count - 1])
                    {
                        drawnpolygon.Points.RemoveAt(drawnpolygon.Points.Count - 1);
                    }

                    drawnpolygonsoverlay.Polygons.Add(drawnpolygon);

                    MainMap.UpdatePolygonLocalPosition(drawnpolygon);

                    MainMap.Invalidate();

                    MainMap.ZoomAndCenterMarkers(drawnpolygonsoverlay.Id);
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (MainV2.comPort.MAV.cs.firmware != MainV2.Firmwares.ArduPlane)
            {
                geoFenceToolStripMenuItem.Enabled = false;
            }
            else
            {
                geoFenceToolStripMenuItem.Enabled = true;
            }
            isMouseClickOffMenu = false; // Just incase
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            if (e.CloseReason.ToString() == "AppClicked")
                isMouseClickOffMenu = true;
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double aream2 = Math.Abs(calcpolygonarea(drawnpolygon.Points));

            double areaa = aream2 * 0.000247105;

            double areaha = aream2 * 1e-4;

            double areasqf = aream2 * 10.7639;

            double aremu = aream2 * 0.0015; 
            //+ areasqf.ToString("0") + " 平方英尺"； areaa.ToString("0.00") + " 英亩\n\t" + 
            CustomMessageBox.Show("区域: " + aream2.ToString("0.00") + " 平方米\n\t" + "      " + aremu.ToString("0.00") + " 亩\n\t", "区域");
        }

        private void MainMap_Paint(object sender, PaintEventArgs e)
        {
            // draw utm grid
            {
                if (!grid)
                    return;

                if (MainMap.Zoom < 10)
                    return;

                var rect = MainMap.ViewArea;

                var plla1 = new PointLatLngAlt(rect.LocationTopLeft);
                var plla2 = new PointLatLngAlt(rect.LocationRightBottom);

                var zone = plla1.GetUTMZone();

                var utm1 = plla1.ToUTM(zone);
                var utm2 = plla2.ToUTM(zone);

                var deltax = utm1[0] - utm2[0];
                var deltay = utm1[1] - utm2[1];

                //if (deltax)

                var gridsize = 1000.0;


                if (Math.Abs(deltax) / 100000 < 40)
                    gridsize = 100000;

                if (Math.Abs(deltax) / 10000 < 40)
                    gridsize = 10000;

                if (Math.Abs(deltax) / 1000 < 40)
                    gridsize = 1000;

                if (Math.Abs(deltax) / 100 < 40)
                    gridsize = 100;



                // round it - x
                utm1[0] = utm1[0] - (utm1[0] % gridsize);
                // y
                utm2[1] = utm2[1] - (utm2[1] % gridsize);

                // x's
                for (double x = utm1[0]; x < utm2[0]; x += gridsize)
                {
                    var p1 = MainMap.FromLatLngToLocal(PointLatLngAlt.FromUTM(zone, x, utm1[1]));
                    var p2 = MainMap.FromLatLngToLocal(PointLatLngAlt.FromUTM(zone, x, utm2[1]));

                    int x1 = (int)p1.X;
                    int y1 = (int)p1.Y;
                    int x2 = (int)p2.X;
                    int y2 = (int)p2.Y;

                    e.Graphics.DrawLine(new Pen(MainMap.SelectionPen.Color, 1), x1, y1, x2, y2);
                }

                // y's
                for (double y = utm2[1]; y < utm1[1]; y += gridsize)
                {
                    var p1 = MainMap.FromLatLngToLocal(PointLatLngAlt.FromUTM(zone, utm1[0], y));
                    var p2 = MainMap.FromLatLngToLocal(PointLatLngAlt.FromUTM(zone, utm2[0], y));

                    int x1 = (int)p1.X;
                    int y1 = (int)p1.Y;
                    int x2 = (int)p2.X;
                    int y2 = (int)p2.Y;

                    e.Graphics.DrawLine(new Pen(MainMap.SelectionPen.Color, 1), x1, y1, x2, y2);
                }
            }
        }

        private void chk_grid_CheckedChanged(object sender, EventArgs e)
        {
            //grid = chk_grid.Checked;
        }

        private void insertWpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wpno = (selectedrow + 1).ToString("0");
            if (InputBox.Show("插入航点", "请插入航点", ref wpno) == DialogResult.OK)
            {
                try
                {
                    Commands.Rows.Insert(int.Parse(wpno), 1);
                }
                catch { CustomMessageBox.Show("无效的插入位置", Strings.ERROR); return; }

                selectedrow = int.Parse(wpno);

                ChangeColumnHeader(mavcndchange(MAVLink.MAV_CMD.WAYPOINT.ToString()));

                setfromMap(MouseDownStart.Lat, MouseDownStart.Lng, (int)float.Parse(TXT_DefaultAlt.Text));
            }
        }

        public void getRallyPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainV2.comPort.MAV.param["RALLY_TOTAL"] == null)
            {
                CustomMessageBox.Show("不支持！");
                return;
            }

            if (int.Parse(MainV2.comPort.MAV.param["RALLY_TOTAL"].ToString()) < 1)
            {
                CustomMessageBox.Show("没有备用降落点下载！");
                return;
            }

            rallypointoverlay.Markers.Clear();

            int count = int.Parse(MainV2.comPort.MAV.param["RALLY_TOTAL"].ToString());

            for (int a = 0; a < (count); a++)
            {
                try
                {
                    PointLatLngAlt plla = MainV2.comPort.getRallyPoint(a, ref count);
                    rallypointoverlay.Markers.Add(new GMapMarkerRallyPt(new PointLatLng(plla.Lat, plla.Lng)) { Alt = (int)plla.Alt, ToolTipMode = MarkerTooltipMode.OnMouseOver, ToolTipText = "Rally Point" + "\nAlt: " + (plla.Alt * CurrentState.multiplierdist) });
                }
                catch { CustomMessageBox.Show("没有备用降落点下载！", Strings.ERROR); return; }
            }

            MainMap.UpdateMarkerLocalPosition(rallypointoverlay.Markers[0]);

            MainMap.Invalidate();
        }

        private void saveRallyPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte count = 0;

            MainV2.comPort.setParam("RALLY_TOTAL", rallypointoverlay.Markers.Count);

            foreach (GMapMarkerRallyPt pnt in rallypointoverlay.Markers)
            {
                try
                {
                    MainV2.comPort.setRallyPoint(count, new PointLatLngAlt(pnt.Position) { Alt = pnt.Alt }, 0, 0, 0, (byte)(float)MainV2.comPort.MAV.param["RALLY_TOTAL"]);
                    count++;
                }
                catch { CustomMessageBox.Show("未能保存备用降落点", Strings.ERROR); return; }
            }
        }

        private void setRallyPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string altstring = TXT_DefaultAlt.Text;

            if (InputBox.Show("高度", "高度(米)", ref altstring) == DialogResult.Cancel)
                return;

            int alt = 0;

            if (int.TryParse(altstring, out alt))
            {
                PointLatLngAlt rallypt = new PointLatLngAlt(MouseDownStart.Lat, MouseDownStart.Lng, alt / CurrentState.multiplierdist, "备用降落点");
                rallypointoverlay.Markers.Add(
                        new GMapMarkerRallyPt(rallypt)
                        {
                            ToolTipMode = MarkerTooltipMode.OnMouseOver,
                            ToolTipText = "备用降落点" + "\n高度: " + alt,
                            Tag = rallypointoverlay.Markers.Count,
                            Alt = (int)rallypt.Alt
                        }
                );
            }
            else
            {
                CustomMessageBox.Show(Strings.InvalidAlt, Strings.ERROR);
            }
        }

        private void clearRallyPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("RALLY_TOTAL", 0);
            }
            catch { }
            rallypointoverlay.Markers.Clear();
            MainV2.comPort.MAV.rallypoints.Clear();
        }

        private void loadKMLFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Google Earth KML |*.kml;*.kmz";
                DialogResult result = fd.ShowDialog();
                string file = fd.FileName;
                if (file != "")
                {
                    try
                    {
                        string kml = "";
                        string tempdir = "";
                        if (file.ToLower().EndsWith("kmz"))
                        {
                            ZipFile input = new ZipFile(file);

                            tempdir = Path.GetTempPath() + Path.DirectorySeparatorChar + Path.GetRandomFileName();
                            input.ExtractAll(tempdir, ExtractExistingFileAction.OverwriteSilently);

                            string[] kmls = Directory.GetFiles(tempdir, "*.kml");

                            if (kmls.Length > 0)
                            {
                                file = kmls[0];

                                input.Dispose();
                            }
                            else
                            {
                                input.Dispose();
                                return;
                            }
                        }

                        var sr = new StreamReader(File.OpenRead(file));
                        kml = sr.ReadToEnd();
                        sr.Close();

                        // cleanup after out
                        if (tempdir != "")
                            Directory.Delete(tempdir, true);

                        kml = kml.Replace("<Snippet/>", "");

                        var parser = new Parser();

                        parser.ElementAdded += processKMLMission;
                        parser.ParseString(kml, false);

                    }
                    catch (Exception ex) { CustomMessageBox.Show("Bad KML File :" + ex); }
                }
            }
        }

        private void processKMLMission(object sender, ElementEventArgs e)
        {
            Element element = e.Element;
            try
            {
                //  log.Info(Element.ToString() + " " + Element.Parent);
            }
            catch { }

            Document doc = element as Document;
            Placemark pm = element as Placemark;
            Folder folder = element as Folder;
            Polygon polygon = element as Polygon;
            LineString ls = element as LineString;

            if (doc != null)
            {
                foreach (var feat in doc.Features)
                {
                    //Console.WriteLine("feat " + feat.GetType());
                    //processKML((Element)feat);
                }
            }
            else
                if (folder != null)
                {
                    foreach (Feature feat in folder.Features)
                    {
                        //Console.WriteLine("feat "+feat.GetType());
                        //processKML(feat);
                    }
                }
                else if (pm != null)
                {

                }
                else if (polygon != null)
                {

                }
                else if (ls != null)
                {
                    foreach (var loc in ls.Coordinates)
                    {
                        selectedrow = Commands.Rows.Add();
                        setfromMap(loc.Latitude, loc.Longitude, (int)loc.Altitude);
                    }
                }
        }

        private void lnk_kml_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("http://127.0.0.1:56781/network.kml");
            }
            catch { CustomMessageBox.Show("Failed to open url http://127.0.0.1:56781/network.kml"); }
        }

        private void modifyAltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string altdif = "0";
            InputBox.Show("高度设置", "请在当前高度加上或者减去你所输入的高度值", ref altdif);

            int altchange = 0;
            float multiplyer = 1;

            try
            {
                if (altdif.Contains("*"))
                {
                    multiplyer = float.Parse(altdif.Replace('*', ' '));
                }
                else
                {
                    altchange = int.Parse(altdif);
                }
            }
            catch
            {
                CustomMessageBox.Show(Strings.InvalidNumberEntered, Strings.ERROR);
                return;
            }


            foreach (DataGridViewRow line in Commands.Rows)
            {
                line.Cells[Alt.Index].Value = (int)(float.Parse(line.Cells[Alt.Index].Value.ToString()) * multiplyer + altchange);
            }
        }

        private void saveToFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (rallypointoverlay.Markers.Count == 0)
            {
                CustomMessageBox.Show("请设置备用降落点");
                return;
            }
            /*
            Column 1: Field type (RALLY is the only one at the moment -- may have RALLY_LAND in the future)
             Column 2,3: Lat, lon
             Column 4: Loiter altitude
             Column 5: Break altitude (when landing from rally is implemented, this is the altitude to break out of loiter from)
             Column 6: Landing heading (also for future when landing from rally is implemented)
             Column 7: Flags (just 0 for now, also future use).
             */

            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Rally (*.ral)|*.ral";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sf.OpenFile()))
                        {

                            sw.WriteLine("#saved by By Aero " + Application.ProductVersion);


                            foreach (GMapMarkerRallyPt mark in rallypointoverlay.Markers)
                            {
                                sw.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", "RALLY", mark.Position.Lat, mark.Position.Lng, mark.Alt, 0, 0, 0);
                            }
                        }
                    }
                    catch { CustomMessageBox.Show("写入备用降落点文件失败"); }
                }
            }
        }

        private void loadFromFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Rally (*.ral)|*.ral";
                fd.ShowDialog();
                if (File.Exists(fd.FileName))
                {
                    StreamReader sr = new StreamReader(fd.OpenFile());

                    int a = 0;

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.StartsWith("#"))
                        {
                        }
                        else
                        {
                            string[] items = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                            MAVLink.mavlink_rally_point_t rally = new MAVLink.mavlink_rally_point_t();

                            rally.lat = (int)(float.Parse(items[1]) * 1e7);
                            rally.lng = (int)(float.Parse(items[2]) * 1e7);
                            rally.alt = (short)float.Parse(items[3]);
                            rally.break_alt = (short)float.Parse(items[4]);
                            rally.land_dir = (ushort)float.Parse(items[5]);
                            rally.flags = byte.Parse(items[6]);

                            if (a == 0)
                            {
                                rallypointoverlay.Markers.Clear();

                                rallypointoverlay.Markers.Add(new GMapMarkerRallyPt(rally));
                            }
                            else
                            {
                                rallypointoverlay.Markers.Add(new GMapMarkerRallyPt(rally));
                            }
                            a++;
                        }
                    }
                    MainMap.Invalidate();
                }
            }
        }

        private void prefetchWPPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FetchPath();
        }

        static string zone = "50s";

        private void enterUTMCoordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string easting = "578994";
            string northing = "6126244";

            if (InputBox.Show("Zone", "Enter Zone. (eg 50S, 11N)", ref zone) != DialogResult.OK)
                return;
            if (InputBox.Show("Easting", "Easting", ref easting) != DialogResult.OK)
                return;
            if (InputBox.Show("Northing", "Northing", ref northing) != DialogResult.OK)
                return;

            string newzone = zone.ToLower().Replace('s', ' ');
            newzone = newzone.ToLower().Replace('n', ' ');

            int zoneint = int.Parse(newzone);

            UTM utm = new UTM(zoneint, double.Parse(easting), double.Parse(northing), zone.ToLower().Contains("N") ? Geocentric.Hemisphere.North : Geocentric.Hemisphere.South);

            PointLatLngAlt ans = ((Geographic)utm);

            selectedrow = Commands.Rows.Add();

            ChangeColumnHeader(MAVLink.MAV_CMD.WAYPOINT.ToString());

            setfromMap(ans.Lat, ans.Lng, (int)ans.Alt);
        }

        private void loadSHPFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Shape file|*.shp";
                DialogResult result = fd.ShowDialog();
                string file = fd.FileName;

                LoadSHPFile(file);
            }
        }

        private void LoadSHPFile(string file)
        {
            ProjectionInfo pStart = new ProjectionInfo();
            ProjectionInfo pESRIEnd = KnownCoordinateSystems.Geographic.World.WGS1984;
            bool reproject = false;

            if (File.Exists(file))
            {
                string prjfile = Path.GetDirectoryName(file) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(file) + ".prj";
                if (File.Exists(prjfile))
                {

                    using (StreamReader re = File.OpenText(Path.GetDirectoryName(file) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(file) + ".prj"))
                    {
                        pStart.ParseEsriString(re.ReadLine());

                        reproject = true;
                    }
                }

                IFeatureSet fs = FeatureSet.Open(file);

                fs.FillAttributes();

                int rows = fs.NumRows();

                DataTable dtOriginal = fs.DataTable;
                for (int row = 0; row < dtOriginal.Rows.Count; row++)
                {
                    object[] original = dtOriginal.Rows[row].ItemArray;
                }

                foreach (DataColumn col in dtOriginal.Columns)
                {
                    Console.WriteLine(col.ColumnName + " " + col.DataType);
                }

                quickadd = true;

                bool dosort = false;

                List<PointLatLngAlt> wplist = new List<PointLatLngAlt>();

                for (int row = 0; row < dtOriginal.Rows.Count; row++)
                {
                    double x = fs.Vertex[row * 2];
                    double y = fs.Vertex[row * 2 + 1];

                    double z = -1;
                    float wp = 0;

                    try
                    {
                        if (dtOriginal.Columns.Contains("ELEVATION"))
                            z = (float)Convert.ChangeType(dtOriginal.Rows[row]["ELEVATION"], TypeCode.Single);
                    }
                    catch { }

                    try
                    {
                        if (z == -1 && dtOriginal.Columns.Contains("alt"))
                            z = (float)Convert.ChangeType(dtOriginal.Rows[row]["alt"], TypeCode.Single);
                    }
                    catch { }

                    try
                    {
                        if (z == -1)
                            z = fs.Z[row];
                    }
                    catch { }


                    try
                    {
                        if (dtOriginal.Columns.Contains("wp"))
                        {
                            wp = (float)Convert.ChangeType(dtOriginal.Rows[row]["wp"], TypeCode.Single);
                            dosort = true;
                        }
                    }
                    catch { }

                    if (reproject)
                    {
                        double[] xyarray = { x, y };
                        double[] zarray = { z };

                        Reproject.ReprojectPoints(xyarray, zarray, pStart, pESRIEnd, 0, 1);


                        x = xyarray[0];
                        y = xyarray[1];
                        z = zarray[0];
                    }

                    PointLatLngAlt pnt = new PointLatLngAlt(x, y, z, wp.ToString());

                    wplist.Add(pnt);
                }

                if (dosort)
                    wplist.Sort();

                foreach (var item in wplist)
                {
                    AddCommand(MAVLink.MAV_CMD.WAYPOINT, 0, 0, 0, 0, item.Lat, item.Lng, item.Alt);
                }

                quickadd = false;

                writeKML();

                MainMap.ZoomAndCenterMarkers("objects");
            }
        }

        private void BUT_saveWPFile_Click(object sender, EventArgs e)
        {
            SaveFile_Click(null, null);
        }

        private void switchDockingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelWaypoints.Expand = false;
            //if (panelAction.Dock == DockStyle.Bottom)
            //{
            //    panelAction.Dock = DockStyle.Right;
            //    panelWaypoints.Dock = DockStyle.Bottom;
            //}
            //else
            //{
                //panelAction.Dock = DockStyle.Bottom;
                //panelAction.Height = 120;
                //panelWaypoints.Dock = DockStyle.Right;
                //panelWaypoints.Width = Width / 3;
            //}
            
            //MainV2.config["FP_docking"] = panelAction.Dock;
        }

        private void insertSplineWPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wpno = (selectedrow + 1).ToString("0");
            if (InputBox.Show("插入航点", "请插入航点", ref wpno) == DialogResult.OK)
            {
                try
                {
                    Commands.Rows.Insert(int.Parse(wpno), 1);
                }
                catch { CustomMessageBox.Show(Strings.InvalidNumberEntered, Strings.ERROR); return; }

                selectedrow = int.Parse(wpno);

                try
                {
                    Commands.Rows[selectedrow].Cells[Command.Index].Value = mavcndchange(MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString());
                }
                catch { CustomMessageBox.Show("SPLINE_WAYPOINT command not supported."); Commands.Rows.RemoveAt(selectedrow); return; }

                ChangeColumnHeader(mavcndchange(MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString()));

                setfromMap(MouseDownStart.Lat, MouseDownStart.Lng, (int)float.Parse(TXT_DefaultAlt.Text));
            }
        }

        private void CHK_splinedefault_CheckedChanged(object sender, EventArgs e)
        {
            splinemode = CHK_splinedefault.Checked;
        }

        private void createSplineCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string RadiusIn = "50";
            if (DialogResult.Cancel == InputBox.Show("半径", "半径", ref RadiusIn))
                return;

            string minaltin = "5";
            if (DialogResult.Cancel == InputBox.Show("最小高度", "最小高度", ref minaltin))
                return;

            string maxaltin = "20";
            if (DialogResult.Cancel == InputBox.Show("最大高度", "最大高度", ref maxaltin))
                return;

            string altstepin = "5";
            if (DialogResult.Cancel == InputBox.Show("起始高度", "起始高度", ref altstepin))
                return;

            string startanglein = "0";
            if (DialogResult.Cancel == InputBox.Show("角度", "第一点角度（全度）", ref startanglein))
                return;

            int Points = 4;
            int Radius = 0;
            int Direction = 1;
            int startangle = 0;
            int minalt = 5;
            int maxalt = 20;
            int altstep = 5;
            if (!int.TryParse(RadiusIn, out Radius))
            {
                CustomMessageBox.Show("错误半径");
                return;
            }

            if (!int.TryParse(minaltin, out minalt))
            {
                CustomMessageBox.Show("错误的最小高度");
                return;
            }
            if (!int.TryParse(maxaltin, out maxalt))
            {
                CustomMessageBox.Show("错误的最大高度");
                return;
            }
            if (!int.TryParse(altstepin, out altstep))
            {
                CustomMessageBox.Show("错误的起始高度");
                return;
            }
           
            double a = startangle;
            double step = 360.0f / Points;

            quickadd = true;

            AddCommand(MAVLink.MAV_CMD.DO_SET_ROI, 0, 0, 0, 0, MouseDownStart.Lng, MouseDownStart.Lat, 0);

            bool startup = true;

            for (int stepalt = minalt; stepalt <= maxalt; )
            {

                for (a = 0; a <= (startangle + 360) && a >= 0; a += step)
                {

                    selectedrow = Commands.Rows.Add();

                    Commands.Rows[selectedrow].Cells[Command.Index].Value = mavcndchange(MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString());

                    ChangeColumnHeader(mavcndchange(MAVLink.MAV_CMD.SPLINE_WAYPOINT.ToString()));

                    float d = Radius;
                    float R = 6371000;

                    var lat2 = Math.Asin(Math.Sin(MouseDownEnd.Lat * deg2rad) * Math.Cos(d / R) +
                  Math.Cos(MouseDownEnd.Lat * deg2rad) * Math.Sin(d / R) * Math.Cos(a * deg2rad));
                    var lon2 = MouseDownEnd.Lng * deg2rad + Math.Atan2(Math.Sin(a * deg2rad) * Math.Sin(d / R) * Math.Cos(MouseDownEnd.Lat * deg2rad),
                                         Math.Cos(d / R) - Math.Sin(MouseDownEnd.Lat * deg2rad) * Math.Sin(lat2));

                    PointLatLng pll = new PointLatLng(lat2 * rad2deg, lon2 * rad2deg);

                    setfromMap(pll.Lat, pll.Lng, stepalt);

                    if (!startup)
                        stepalt += altstep / Points;

                }

                // reset back to the start
                if (startup)
                    stepalt = minalt;

                // we have finsihed the first run
                startup = false;
            }

            quickadd = false;
            writeKML();

        }

        private void CMB_altmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CMB_altmode.SelectedValue == null)
            {
                CMB_altmode.SelectedIndex = 0;
            }
            else
            {
                currentaltmode = (altmode)CMB_altmode.SelectedValue;
            }
        }

        private void fromSHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Shape file|*.shp";
                DialogResult result = fd.ShowDialog();
                string file = fd.FileName;
                ProjectionInfo pStart = new ProjectionInfo();
                ProjectionInfo pESRIEnd = KnownCoordinateSystems.Geographic.World.WGS1984;
                bool reproject = false;
                // Poly Clear
                drawnpolygonsoverlay.Markers.Clear();
                drawnpolygonsoverlay.Polygons.Clear();
                drawnpolygon.Points.Clear();
                if (File.Exists(file))
                {
                    string prjfile = Path.GetDirectoryName(file) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(file) + ".prj";
                    if (File.Exists(prjfile))
                    {
                        using (StreamReader re = File.OpenText(Path.GetDirectoryName(file) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(file) + ".prj"))
                        {
                            pStart.ParseEsriString(re.ReadLine());
                            reproject = true;
                        }
                    }
                    try
                    {
                        IFeatureSet fs = FeatureSet.Open(file);
                        fs.FillAttributes();
                        int rows = fs.NumRows();
                        DataTable dtOriginal = fs.DataTable;
                        for (int row = 0; row < dtOriginal.Rows.Count; row++)
                        {
                            object[] original = dtOriginal.Rows[row].ItemArray;
                        }
                        string path = Path.GetDirectoryName(file);
                        foreach (var feature in fs.Features)
                        {
                            foreach (var point in feature.Coordinates)
                            {
                                if (reproject)
                                {
                                    double[] xyarray = { point.X, point.Y };
                                    double[] zarray = { point.Z };
                                    Reproject.ReprojectPoints(xyarray, zarray, pStart, pESRIEnd, 0, 1);
                                    point.X = xyarray[0];
                                    point.Y = xyarray[1];
                                    point.Z = zarray[0];
                                }
                                drawnpolygon.Points.Add(new PointLatLng(point.Y, point.X));
                                addpolygonmarkergrid(drawnpolygon.Points.Count.ToString(), point.X, point.Y, 0);
                            }
                            // remove loop close
                            if (drawnpolygon.Points.Count > 1 && drawnpolygon.Points[0] == drawnpolygon.Points[drawnpolygon.Points.Count - 1])
                            {
                                drawnpolygon.Points.RemoveAt(drawnpolygon.Points.Count - 1);
                            }
                            drawnpolygonsoverlay.Polygons.Add(drawnpolygon);
                            MainMap.UpdatePolygonLocalPosition(drawnpolygon);
                            MainMap.Invalidate();
                            MainMap.ZoomAndCenterMarkers(drawnpolygonsoverlay.Id);
                        }
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show(Strings.ERROR + "\n" + ex, Strings.ERROR);
                    }
                }
            }
        }

        private void panelWaypoints_ExpandClick(object sender, EventArgs e)
        {
            Commands.AutoResizeColumns();
        }

        #region 添加规划显示信息

        public void showFlyInfo(string area, string distance, string strips, string distbetweenlines, string flighttime, string headinghold) 
        {
            //wjch20160527 
            lblArea.Text = area;
            lblDistance.Text = distance;
            lblStrips.Text = strips + " 条";
            lblDistbetweenlines.Text = distbetweenlines;
            lblFlighttime.Text = flighttime;
            lblHeadinghold.Text = headinghold + "度";
        }

        private void ClearRouteInfo()
        {
            lblArea.Text = "0亩";
            lblDistance.Text = "0千米";
            lblStrips.Text = " 0条";
            lblDistbetweenlines.Text = "0米";
            lblFlighttime.Text = "0分";
        }

        #endregion 添加规划显示信息

        #region 障碍点

        /// <summary>
        /// 添加障碍点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myBtnAddLimit_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                CustomMessageBox.Show("请连接地面接收器再添加障碍航点。");
                return;
            }
            string altstring = "3";

            string radiusstring = "3";

            if (InputBox.Show("高度", "高度(米)", ref altstring) == DialogResult.Cancel)
                return;

            if (InputBox.Show("半径", "半径(米)", ref radiusstring) == DialogResult.Cancel)
                return;

            float alt = 0;
            float fradius = 0;

            if (float.TryParse(altstring, out alt) && float.TryParse(radiusstring, out fradius))
            {
                PointLatLngAlt limitpt = new PointLatLngAlt(MainV2.comPort.MAV.cs.lat, MainV2.comPort.MAV.cs.lng, alt / CurrentState.multiplierdist, "障碍行点", fradius);
                drawnlimitpolygonsoverlay.Markers.Add(
                        new GMapMarkerLimitPt(limitpt)
                        {
                            ToolTipMode = MarkerTooltipMode.OnMouseOver,
                            ToolTipText = "障碍航点" + "\n高度: " + alt + " |半径" + fradius,
                            Tag = drawnlimitpolygonsoverlay.Markers.Count,
                            Alt = (float)limitpt.Alt,
                            Radius = (float)limitpt.radius
                        }
                );
            }
            else
            {
                CustomMessageBox.Show(Strings.InvalidAlt, Strings.ERROR);
            }
        }

        /// <summary>
        /// 写入障碍航点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myBtnSendLimitPoint_Click(object sender, EventArgs e)
        {
            byte count = 0;

            MainV2.comPort.setParam("OBSTACLE_TOTAL", drawnlimitpolygonsoverlay.Markers.Count);

            foreach (GMapMarkerLimitPt pnt in drawnlimitpolygonsoverlay.Markers)
            {
                try
                {
                    MainV2.comPort.setObstaclePoint(count, new PointLatLngAlt(pnt.Position) { Alt = pnt.Alt }, pnt.Radius, 0, 0, (byte)(float)MainV2.comPort.MAV.param["OBSTACLE_TOTAL"]);
                    count++;
                }
                catch { CustomMessageBox.Show("未能保存障碍点", Strings.ERROR); return; }
            }
        }

        /// <summary>
        /// 读取障碍点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void getObstaclePointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainV2.comPort.MAV.param["OBSTACLE_TOTAL"] == null)
            {
                CustomMessageBox.Show("不支持！");
                return;
            }

            if (int.Parse(MainV2.comPort.MAV.param["OBSTACLE_TOTAL"].ToString()) < 1)
            {
                CustomMessageBox.Show("没有障碍航点下载！");
                return;
            }

            drawnlimitpolygonsoverlay.Markers.Clear();

            int count = int.Parse(MainV2.comPort.MAV.param["OBSTACLE_TOTAL"].ToString());

            for (int a = 0; a < (count); a++)
            {
                try
                {
                    PointLatLngAlt plla = MainV2.comPort.getObstaclePoint(a, ref count);
                    drawnlimitpolygonsoverlay.Markers.Add(new GMapMarkerLimitPt(new PointLatLng(plla.Lat, plla.Lng)) { Alt = (int)plla.Alt, ToolTipMode = MarkerTooltipMode.OnMouseOver, ToolTipText = "障碍航点" + "\n高度: " + (plla.Alt * CurrentState.multiplierdist) + " |半径" + (plla.radius * CurrentState.multiplierdist) });
                }
                catch { CustomMessageBox.Show("获取障碍航点失败！", Strings.ERROR); return; }
            }

            MainMap.UpdateMarkerLocalPosition(drawnlimitpolygonsoverlay.Markers[0]);

            MainMap.Invalidate();
        }

        /// <summary>
        /// 清除障碍航点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearObstaclePointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam("OBSTACLE_TOTAL", 0);
            }
            catch { }
            drawnlimitpolygonsoverlay.Markers.Clear();
            //MainV2.comPort.MAV.obstacles.Clear();
        }

        /// <summary>
        /// 加载障碍航点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myButton_loadlimitpoint_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "Obstacle (*.ral)|*.ral";
                fd.ShowDialog();
                if (File.Exists(fd.FileName))
                {
                    StreamReader sr = new StreamReader(fd.OpenFile());

                    int a = 0;

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.StartsWith("#"))
                        {
                        }
                        else
                        {
                            string[] items = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                            MAVLink.mavlink_obstacle_point_t obstacle = new MAVLink.mavlink_obstacle_point_t();

                            obstacle.lat = (int)(float.Parse(items[1]) * 1e7);
                            obstacle.lng = (int)(float.Parse(items[2]) * 1e7);
                            obstacle.alt = (short)float.Parse(items[3]);
                            obstacle.radius = (short)float.Parse(items[4]);
                            obstacle.flags = byte.Parse(items[5]);

                            if (a == 0)
                            {
                                drawnlimitpolygonsoverlay.Markers.Clear();

                                drawnlimitpolygonsoverlay.Markers.Add(new GMapMarkerLimitPt(obstacle));
                            }
                            else
                            {
                                drawnlimitpolygonsoverlay.Markers.Add(new GMapMarkerLimitPt(obstacle));
                            }
                            a++;
                        }
                    }
                    MainMap.Invalidate();
                }
            }
        }

        /// <summary>
        /// 保存障碍航点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myButton_savelimitpoint_Click(object sender, EventArgs e)
        {
            if (drawnlimitpolygonsoverlay.Markers.Count == 0)
            {
                CustomMessageBox.Show("请设置备用降落点");
                return;
            }

            using (SaveFileDialog sf = new SaveFileDialog())
            {
                sf.Filter = "Obstacle (*.ral)|*.ral";
                sf.ShowDialog();
                if (sf.FileName != "")
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sf.OpenFile()))
                        {

                            sw.WriteLine("#saved by By Aero " + Application.ProductVersion);


                            foreach (GMapMarkerLimitPt mark in drawnlimitpolygonsoverlay.Markers)
                            {
                                sw.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", "Obstacle", mark.Position.Lat, mark.Position.Lng, mark.Alt, mark.Radius, 0);
                            }
                        }
                    }
                    catch { CustomMessageBox.Show("保存障碍点文件失败"); }
                }
            }
        }
        #endregion

        #region 备用降落点
        private void setRallyPoint_Click(object sender, EventArgs e)
        {
            string altstring = TXT_DefaultAlt.Text;

            if (InputBox.Show("高度", "高度(米)", ref altstring) == DialogResult.Cancel)
                return;

            int alt = 0;

            if (int.TryParse(altstring, out alt))
            {
                PointLatLngAlt rallypt = new PointLatLngAlt(MainV2.comPort.MAV.cs.lat, MainV2.comPort.MAV.cs.lng, alt / CurrentState.multiplierdist, "备用降落点");
                rallypointoverlay.Markers.Add(
                        new GMapMarkerRallyPt(rallypt)
                        {
                            ToolTipMode = MarkerTooltipMode.OnMouseOver,
                            ToolTipText = "备用降落点" + "\n高度: " + alt,
                            Tag = rallypointoverlay.Markers.Count,
                            Alt = (int)rallypt.Alt
                        }
                );
            }
            else
            {
                CustomMessageBox.Show(Strings.InvalidAlt, Strings.ERROR);
            }
        }
        #endregion

        #region 集成航点设置

        private bool Isshow;

        private void myBtnFunction_Click(object sender, EventArgs e)
        {
            if (Isshow)
            {
                this.panelShowPoint.Visible = false;
                this.panelShowInfo.Visible = false;
                Isshow = false;
            }
            else
            {
                this.panelShowPoint.Visible = true;
                this.panelShowInfo.Visible = true;
                Isshow = true;
            }
        }


        private void ControlInit() 
        {
            panelShowPoint.BackColor = groupBoxAeroPoint.BackColor = CHK_autopan.BackColor = breakpointgroupBox.BackColor
             = groupBoxBasePoint.BackColor = groupboxOPoint.BackColor = groupBoxRellyPoint.BackColor = Color.Black;
            groupBoxAeroPoint.ForeColor = CHK_autopan.ForeColor
                = groupBoxBasePoint.ForeColor = groupboxOPoint.ForeColor = groupBoxRellyPoint.ForeColor = breakpointgroupBox.ForeColor
            =Color.White;

            this.panelShowInfo.BackColor = Color.Black;
        }

        #endregion

        #region 清楚飞行时时航线
        public void clearFlyRoute() 
        {
            if (flyRoute != null)
                flyRoute.Points.Clear();
        }
        #endregion

        #region 初始化参数
        public void initParams() 
        {
            this.lblHorizontalError.Text = "GPS水平精度:"+ CurrentState.gpsaccuracy.ToString();
            this.lblSataCount.Text = "卫星数量:" + CurrentState.gpscount.ToString();
        }
        #endregion

        #region 追踪家的位置
        private void CHK_autopan_CheckedChanged(object sender, EventArgs e)
        {
            autopan = CHK_autopan.Checked;
        }
        #endregion

        #region 添加飞行时时轨迹
        private void routePoints(PointLatLng currentloc)
        {
            //MainMap.inOnPaint = true;

            MainMap.HoldInvalidation = true;

            int cnt = 0;

            while (MainMap.inOnPaint)
            {
                Thread.Sleep(1);
                cnt++;
            }

            // add new route point
            if (MainV2.comPort.MAV.cs.lat != 0)
            {
                //trackPoints.Add(currentloc);
                flyRoute.Points.Add(currentloc);
            }

            while (MainMap.inOnPaint)
            {
                Thread.Sleep(1);
                cnt++;
            }


            flyRoute.Stroke = new Pen(Color.FromArgb(144, Color.Purple), 5);
            //route.Stroke.DashStyle = DashStyle.Dash;
            flyRoute.Tag = "track";


            //autopan
            if (autopan)
            {
                if (flyRoute.Points[flyRoute.Points.Count - 1].Lat != 0 && (mapupdate.AddSeconds(3) < DateTime.Now))
                {
                    updateMapPosition(currentloc);
                    mapupdate = DateTime.Now;
                }
            }

            updateClearRoutes();
            MainMap.UpdateRouteLocalPosition(flyRoute);
            MainMap.Invalidate();
        }

        private void updateClearRoutes()
        {
            // not async
            Invoke((MethodInvoker)delegate
            {
                flyRoutesoverlay.Routes.Clear();
                flyRoutesoverlay.Routes.Add(flyRoute);
            });
        }


        #endregion

        #region 添加返航断点

        enum LandStatus
        {
            药物喷完 = 1,
            电量过低 = 2,
            信号丢失 = 3,
            手动触发 = 0
        }

        private void timer_getbreakpoint_Tick(object sender, EventArgs e)
        {
            addbreakWayPoint(false);
            updatehome();
            addTimer(); 
        }

        public void addbreakWayPoint(bool isshowbreakpoint)
        {
            if (MainV2.comPort.BaseStream.IsOpen)
            {
                if ((CurrentState.isChange || isshowbreakpoint))
                {
                    Locationwp secondbreakpoint = getBreak_WP(CurrentState.breakpoint_lat, CurrentState.breakpoint_lng, CurrentState.breakpoint_alt, CurrentState.breakpoint_p1);
                    breakploygonsoverlay.Markers.Clear();
                    if (CurrentState.breakpoint_lat != 0 && CurrentState.breakpoint_lng != 0)
                        addpolygonmarkerBreakPoint(secondbreakpoint);
                }
            }
        }

        /// <summary>
        /// 获取断点
        /// </summary>
        /// <param name="index"></param>
        /// <returns>break_point</returns>
        public Locationwp getBreak_WP(double breakpoint_lat, double breakpoint_lng, double breakpoint_alt, double breakpoint_p1)
        {
            Locationwp loc = new Locationwp();

            loc.options = 3;
            loc.id = 1;
            loc.p1 = (float)breakpoint_p1;
            loc.p2 = 0;
            loc.p3 = 0;
            loc.p4 = 0;

            loc.alt = (float)((breakpoint_alt));
            loc.lat = (double)((breakpoint_lat));
            loc.lng = (double)((breakpoint_lng));
            
            return loc;
        }

        private void addpolygonmarkerBreakPoint(Locationwp break_point)
        {

            PointLatLngAlt breakpt = new PointLatLngAlt(break_point.lat, break_point.lng, break_point.alt, break_point.p1,Enum.Parse(typeof(LandStatus), CurrentState.breakpointreason.ToString()).ToString(), "返航断点");
            breakploygonsoverlay.Markers.Add(
                    new GMapMarkerBreakPt(breakpt)
                    {
                        //Enum.Parse(typeof(LandStatus), CurrentState.breakpointreason.ToString()).ToString()wjch20160527
                        ToolTipMode = MarkerTooltipMode.OnMouseOver,
                        ToolTipText = "返航断点" + "\n纬度:" + break_point.lat + "\n经度:" + break_point.lng + "\n高度:" + break_point.alt + Enum.Parse(typeof(LandStatus), CurrentState.breakpointreason.ToString()).ToString(),
                        Tag = breakploygonsoverlay.Markers.Count,
                        Alt = (float)breakpt.Alt,
                        BreakPointParam1 = break_point.p1
                    }
            );

            MainMap.UpdateMarkerLocalPosition(breakploygonsoverlay.Markers[0]);
            MainMap.Invalidate();
        }

        /// <summary>
        /// 写入断点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myBtn_write_break_point_Click(object sender, EventArgs e)
        {
            if (breakploygonsoverlay.Markers.Count <= 0)
                return;

            if (saveBreak_WPs())
            {
                CustomMessageBox.Show("发送飞行断点成功！");
            }
            else 
            {
                CustomMessageBox.Show("发送飞行断点失败！");
            };
        }

        /// <summary>
        /// 读取断点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void myBtn_read_break_point_Click(object sender, EventArgs e)
        {
            addbreakWayPoint(true);
        }

        //写入断点
        private bool isSeccessSend;
        private bool saveBreak_WPs()
        {
            try
            {
                MAVLinkInterface port = MainV2.comPort;

                if (!port.BaseStream.IsOpen)
                {
                    throw new Exception("请先连接地面站!");
                }

                MainV2.comPort.giveComport = true;
                int a = 1;
                // define the break_point point
                Locationwp break_point = new Locationwp();

                foreach (GMapMarkerBreakPt pnt in breakploygonsoverlay.Markers)
                {
                    try
                    {
                        break_point.id = (byte)MAVLink.MAV_CMD.WAYPOINT;
                        break_point.lat = pnt.Position.Lat;
                        break_point.lng = pnt.Position.Lng;
                        break_point.alt = pnt.Alt;
                        break_point.p1 = pnt.BreakPointParam1;
                    }
                    catch 
                    { 
                        throw new Exception("飞行器的断点位置无效！"); 
                    }
                }


                // 发送航点
                port.setBreak_WP(break_point, (ushort)(a), MAVLink.MAV_FRAME.GLOBAL_RELATIVE_ALT, 0);

                isSeccessSend = true;
            }
            catch (Exception ex) 
            { 
                log.Error(ex);
                isSeccessSend =false;
                MainV2.comPort.giveComport = false;
                throw; 
            }

            MainV2.comPort.giveComport = false;
            return isSeccessSend;
        }

        /// <summary>
        /// 保存断点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBreak_File_Click(object sender, EventArgs e)
        {
            savebreakwaypoints();
            writeKML();
        }

        /// <summary>
        /// Saves a waypoint writer file
        /// </summary>
        private void savebreakwaypoints()
        {
            using (SaveFileDialog fd = new SaveFileDialog())
            {
                fd.Filter = "By Aero (*.txt)|*.*";
                fd.DefaultExt = ".txt";
                fd.FileName = wpfilename;
                DialogResult result = fd.ShowDialog();
                string file = fd.FileName;
                if (file != "")
                {
                    try
                    {
                        StreamWriter sw = new StreamWriter(file);
                        sw.WriteLine("ByAero Break Point");
                        foreach (GMapMarkerBreakPt pnt in breakploygonsoverlay.Markers)
                        {
                            try
                            {
                                sw.WriteLine("1\t0\t3\t16\t" + pnt.BreakPointParam1 + "\t0.000000\t0.000000\t0.000000\t" + pnt.Position.Lat.ToString("0.0000000", new CultureInfo("en-US")) + "\t" + pnt.Position.Lng.ToString("0.0000000", new CultureInfo("en-US")) + "\t" + pnt.Alt.ToString("0.000000", new CultureInfo("en-US")) + "\t1");
                            }
                            catch
                            {
                                sw.WriteLine("0\t1\t0\t0\t0\t0\t0\t0\t0\t0\t0\t1");
                            }
                        }
                       
                        sw.Close();
                    }
                    catch (Exception) { CustomMessageBox.Show(Strings.ERROR); }
                }
            }
        }

        /// <summary>
        /// 加载断点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadBreak_File_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fd = new OpenFileDialog())
            {
                fd.Filter = "All Supported Types|*.txt;*.shp|By Aero (*.txt)|*.*|Shape file|*.shp";
                DialogResult result = fd.ShowDialog();
                string file = fd.FileName;

                if (File.Exists(file))
                {
                    wpfilename = file;
                    readbreakwpfile(file);
                }
            }
        }

        public void readbreakwpfile(string file, bool append = false)
        {
            bool error = false;

            try
            {
                StreamReader sr = new StreamReader(file); //"defines.h"
                string header = sr.ReadLine();
                if (header == null || !header.Contains("ByAero"))
                {
                    CustomMessageBox.Show("无效的路点文件");
                    return;
                }

                while (!error && !sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    // waypoints

                    if (line.StartsWith("#"))
                        continue;

                    string[] items = line.Split(new[] { '\t', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                    if (items.Length <= 9)
                        continue;

                    try
                    {

                        Locationwp temp = new Locationwp();
                        if (items[2] == "3")
                        { 
                            temp.options = 1;
                        }
                        else
                        {
                            temp.options = 0;
                        }
                        temp.id = (byte)(int)Enum.Parse(typeof(MAVLink.MAV_CMD), items[3], false);
                        temp.p1 = float.Parse(items[4], new CultureInfo("en-US"));

                        if (temp.id == 99)
                            temp.id = 0;

                        temp.alt = (float)(double.Parse(items[10], new CultureInfo("en-US")));
                        temp.lat = (double.Parse(items[8], new CultureInfo("en-US")));
                        temp.lng = (double.Parse(items[9], new CultureInfo("en-US")));

                        temp.p2 = (float)(double.Parse(items[5], new CultureInfo("en-US")));
                        temp.p3 = (float)(double.Parse(items[6], new CultureInfo("en-US")));
                        temp.p4 = (float)(double.Parse(items[7], new CultureInfo("en-US")));
                        addpolygonmarkerBreakPoint(temp);
                    }
                    catch { CustomMessageBox.Show("无效的行\n" + line); }
                }

                sr.Close();

                writeKML();

                MainMap.ZoomAndCenterMarkers("objects");
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("不能打开当前文件! ");
            }
        }
        #endregion

        #region 添加飞行时间

        private void addTimer() 
        {
            //CurrentState.isArm
            if (CurrentState.isArm)
            {
                timer_time.Enabled = true;
            }
            else
            {
                timer_time.Enabled = false;
            }
        }

        private int t = 0;

        //计时器清零 
        void BtnClearClick(object sender, System.EventArgs e)
        {
            t = 0;
            //如何正在计时，则先停止再清零，否则直接清零 
            if (this.timer_time.Enabled == true)
            {
                CustomMessageBox.Show("飞机正在飞行，不能执行清除！", "提示");
            }
            else
            {
                this.timer_time.Dispose();
                lblShowTime.Text = GetAllTime(t);
            }

        }


        private void timer_time_Tick(object sender, EventArgs e)
        {
            t = t + 1;//得到总的毫秒数    
            this.lblShowTime.Text = GetAllTime(t);

        }

        //计时函数 
        public string GetAllTime(int time)
        {
            string hh, mm, ss, fff;

            int f = time % 60; // 毫秒    
            int s = time / 60; // 转化为秒 
            int m = s / 60;     // 分 
            int h = m / 60;     // 时 
            s = s % 60;     // 秒  

            //毫秒格式00 
            if (f < 10)
            {
                fff = "0" + f.ToString();
            }
            else
            {
                fff = f.ToString();
            }

            //秒格式00 
            if (s < 10)
            {
                ss = "0" + s.ToString();
            }
            else
            {
                ss = s.ToString();
            }

            //分格式00 
            if (m < 10)
            {
                mm = "0" + m.ToString();
            }
            else
            {
                mm = m.ToString();
            }

            //时格式00 
            if (h < 10)
            {
                hh = "0" + h.ToString();
            }
            else
            {
                hh = h.ToString();
            }

            //返回 hh:mm:ss.ff             
            return mm + ":" + ss + ":" + fff;
        }
        #endregion

        #region 控件传递参数
        public void SendInitParams(double lat ,double lon,double alt) 
        {
            mouseposdisplay.Lat = lat;
            mouseposdisplay.Lng = lon;
            mouseposdisplay.Alt = alt;
        }
        #endregion

        #region 加解锁，自主模式，悬停模式，自动返航，清楚轨迹

        private DateTime dtBegin;
        private void BUT_ARM_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
                return;

            // arm the MAV
            try
            {
                if (MainV2.comPort.MAV.cs.armed)
                    if (CustomMessageBox.Show("确定对飞行器加锁！", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;

                bool ans = MainV2.comPort.doARM(!MainV2.comPort.MAV.cs.armed);
                if (ans == false)
                    CustomMessageBox.Show(Strings.ErrorRejectedByMAV, Strings.ERROR);
                else
                    dtBegin = DateTime.Now;
            }
            catch { CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR); }
        }

        private void BUT_quickauto_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
                return;

            DialogResult re = CustomMessageBox.Show("确定是否启用自主模式！", "提示", MessageBoxButtons.YesNo);

            if (re == DialogResult.No)
                return;

            try
            {
                ((Button)sender).Enabled = false;
                MainV2.comPort.setMode("自动");
            }
            catch { CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR); }
            ((Button)sender).Enabled = true;
        }

        private void btnLoiterUnlim_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
                return;

            DialogResult re = CustomMessageBox.Show("确定是否进行悬停！", "提示", MessageBoxButtons.YesNo);

            if (re == DialogResult.No)
                return;
            try
            {
                ((Button)sender).Enabled = false;
                MainV2.comPort.setMode("悬停");
            }
            catch { CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR); }
            ((Button)sender).Enabled = true;
        }

        private void BUT_clear_track_Click(object sender, EventArgs e)
        {
            clearFlyRoute();
        }

        private void BUT_quickrtl_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
                return;

            DialogResult re = CustomMessageBox.Show("确定是否进行自动返航！", "提示", MessageBoxButtons.YesNo);

            if (re == DialogResult.No)
                return;
            try
            {
                ((Button)sender).Enabled = false;
                MainV2.comPort.setMode("返航");
            }
            catch { CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR); }
            ((Button)sender).Enabled = true;
        }

        #endregion

        #region 更新区域航点距离和方向
        private void updatePointsMarks(int iPoint)
        {
             if (drawnpolygon.Points.Count <= 1)
             {
                return;
             }
             else if(drawnpolygon.Points.Count == 2)
             {
                 PointLatLng startpoint = new PointLatLng(drawnpolygon.Points[drawnpolygon.Points.Count - 2].Lat, drawnpolygon.Points[drawnpolygon.Points.Count - 2].Lng);
                 PointLatLng endpoint = new PointLatLng(drawnpolygon.Points[drawnpolygon.Points.Count - 1].Lat, drawnpolygon.Points[drawnpolygon.Points.Count - 1].Lng);
                 //两点距离
                 currentDistance = FormatDistance(MainMap.MapProvider.Projection.GetDistance(startpoint, endpoint), true);
                 //两点航向角
                 bearing = "  航向角:" + MainMap.MapProvider.Projection.GetBearing(startpoint, endpoint).ToString("0") + "度";

                 drawnpolygonsoverlay.Markers[drawnpolygon.Points.Count].ToolTipText ="区域航点 2" +" |" + "距离 2-1: " + currentDistance
                    + bearing;
             }
             else if (drawnpolygon.Points.Count >=3) 
             {
                 if (iPoint == 1) 
                 {
                     PointLatLng startpoint = new PointLatLng(drawnpolygon.Points[0].Lat, drawnpolygon.Points[0].Lng);
                     PointLatLng endpoint = new PointLatLng(drawnpolygon.Points[1].Lat, drawnpolygon.Points[1].Lng);
                     //两点距离
                     currentDistance = FormatDistance(MainMap.MapProvider.Projection.GetDistance(startpoint, endpoint), true);
                     //两点航向角
                     bearing = "  航向角:" + MainMap.MapProvider.Projection.GetBearing(startpoint, endpoint).ToString("0") + "度";

                     drawnpolygonsoverlay.Markers[2].ToolTipText = "区域航点 2" + " |" + "距离 2-1: " + currentDistance
                        + bearing;
                 }
                 else if (iPoint == drawnpolygon.Points.Count)
                 {
                     PointLatLng startpoint = new PointLatLng(drawnpolygon.Points[drawnpolygon.Points.Count - 2].Lat, drawnpolygon.Points[drawnpolygon.Points.Count - 2].Lng);
                     PointLatLng endpoint = new PointLatLng(drawnpolygon.Points[drawnpolygon.Points.Count - 1].Lat, drawnpolygon.Points[drawnpolygon.Points.Count - 1].Lng);
                     //两点距离
                     currentDistance = FormatDistance(MainMap.MapProvider.Projection.GetDistance(startpoint, endpoint), true);
                     //两点航向角
                     bearing = "  航向角:" + MainMap.MapProvider.Projection.GetBearing(endpoint, startpoint).ToString("0") + "度";

                     drawnpolygonsoverlay.Markers[2*drawnpolygon.Points.Count-2].ToolTipText =  "区域航点 "+ iPoint+" |" + "距离" + iPoint + "-" + (Convert.ToInt16(iPoint) - 1).ToString() + ": " + currentDistance + bearing;
                 }
                 else 
                 {
                     PointLatLng startpoint = new PointLatLng(drawnpolygon.Points[iPoint - 2].Lat, drawnpolygon.Points[iPoint - 2].Lng);
                     PointLatLng point = new PointLatLng(drawnpolygon.Points[iPoint - 1].Lat, drawnpolygon.Points[iPoint - 1].Lng);
                     PointLatLng endpoint = new PointLatLng(drawnpolygon.Points[iPoint].Lat, drawnpolygon.Points[iPoint - 1].Lng);

                     string startToMidDis = FormatDistance(MainMap.MapProvider.Projection.GetDistance(startpoint, point), true);
                     //两点航向角
                     string startToMidbearing = "  航向角:" + MainMap.MapProvider.Projection.GetBearing(point, startpoint).ToString("0") + "度";

                     string startToMidDis2 = FormatDistance(MainMap.MapProvider.Projection.GetDistance(point, endpoint), true);
                     //两点航向角
                     string startToMidbearing2 = "  航向角:" + MainMap.MapProvider.Projection.GetBearing(endpoint, point).ToString("0") + "度";

                     drawnpolygonsoverlay.Markers[iPoint * 2 - 2].ToolTipText = "区域航点 " + (iPoint) + " |" + "距离" + iPoint.ToString() + "-" + (Convert.ToInt16(iPoint) - 1).ToString() + ": " + startToMidDis + startToMidbearing;
                     drawnpolygonsoverlay.Markers[(iPoint+1)*2 -2].ToolTipText = "区域航点 "+ (iPoint +1)+ " |" + "距离" + (iPoint + 1).ToString() + "-" + (iPoint).ToString() + ": " + startToMidDis2 + startToMidbearing2;
                 }

             }
        
        }
        #endregion

        #region 展开航点
        private void panelWaypoints_Click(object sender, EventArgs e)
        {
            //panelWaypoints.Expand = true;
        }
        #endregion

        #region 时时更新家的位置
        private void updatehome()
        {
            if (MainV2.comPort.MAV.cs.armed && MainV2.comPort.MAV.cs.mode == "自动" && MainV2.instance.isupdatehome)
            {
                MainV2.comPort.MAV.cs.HomeLocation = new PointLatLngAlt(MainV2.comPort.getWP(0));
                updateHome();
                MainV2.instance.isupdatehome = false;
                writeKML();
            }
        }
        #endregion

        #region 发送区域航点的坐标
        private void SendAeroPoints()
        {
            try
            {
                ProgressReporterDialogue frmProgressReporter = new ProgressReporterDialogue
                {
                    StartPosition = FormStartPosition.CenterScreen,
                    Text = "发送区域航点",
                    Tag = "AeroPoints"
                };

                if (MainV2.comPort.MAV.param.ContainsKey("AREAPOINT_TOTAL"))
                {
                    int a = int.Parse(MainV2.comPort.MAV.param["AREAPOINT_TOTAL"].ToString());
                }

                frmProgressReporter.DoWork += saveAeroPoints;
                frmProgressReporter.UpdateProgressAndStatus(-1, "Sending AeroPoints");

                ThemeManager.ApplyThemeTo(frmProgressReporter);

                frmProgressReporter.RunBackgroundOperationAsync();

                frmProgressReporter.Dispose();

                breakploygonsoverlay.Markers.Clear();
                MainMap.Focus();
            }
            catch
            {
                CustomMessageBox.Show("写入航点失败！");
            }
        }

        void saveAeroPoints(object sender, ProgressWorkerEventArgs e, object passdata = null)
        {
            try
            {
                MainV2.comPort.setParam("AREAPOINT_TOTAL", drawnpolygon.Points.Count);

                int a = 1;
                // process commandlist to the mav
                foreach (var temp in drawnpolygon.Points)
                {

                    ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(a * 100 / drawnpolygon.Points.Count, "Setting AP " + a);

                    // try send the wp
                    MainV2.comPort.setAP(temp, (ushort)(a - 1));
                    a++;
                }

                ((ProgressReporterDialogue)sender).UpdateProgressAndStatus(100, "Done.");
            }
            catch (Exception ex) { log.Error(ex); MainV2.comPort.giveComport = false; throw; }

            MainV2.comPort.giveComport = false;
        }
        #endregion
      
        #region 读取区域航点的坐标
        private void ReadAeroPoints()
        {

            if (MainV2.comPort.MAV.param["AREAPOINT_TOTAL"] == null)
            {
                CustomMessageBox.Show("不支持区域航点下载！");
                return;
            }

            if (int.Parse(MainV2.comPort.MAV.param["AREAPOINT_TOTAL"].ToString()) < 1)
            {
                CustomMessageBox.Show("没有区域航点下载！");
                return;
            }

            drawnpolygonsoverlay.Markers.Clear();

            int count = int.Parse(MainV2.comPort.MAV.param["AREAPOINT_TOTAL"].ToString());

            for (ushort a = 0; a < (count); a++)
            {
                try
                {
                    PointLatLngAlt plla = MainV2.comPort.getAeraPoint(a, ref count);
                    //addpolygonmarkergrid(a.ToString(), plla.Lng, plla.Lat, plla.Alt);
                    AddAeraPoints(plla.Lat, plla.Lng);
                }
                catch { CustomMessageBox.Show("没有区域航点下载！", Strings.ERROR); return; }
            }


            MainMap.UpdateMarkerLocalPosition(drawnpolygonsoverlay.Markers[0]);

            MainMap.Invalidate();

            getAreaInfo(wppolygon.Points, drawnpolygon.Points);
        }

        private void  AddAeraPoints(double lat,double lng)
        {
            polygongridmode = true;

            List<PointLatLng> polygonPoints = new List<PointLatLng>();
            if (drawnpolygonsoverlay.Polygons.Count == 0)
            {
                drawnpolygon.Points.Clear();
                drawnpolygonsoverlay.Polygons.Add(drawnpolygon);
            }

            drawnpolygon.Fill = Brushes.Transparent;

            // remove full loop is exists
            if (drawnpolygon.Points.Count > 1 && drawnpolygon.Points[0] == drawnpolygon.Points[drawnpolygon.Points.Count - 1])
                drawnpolygon.Points.RemoveAt(drawnpolygon.Points.Count - 1); // unmake a full loop

            drawnpolygon.Points.Add(new PointLatLng(lat, lng));

            addpolygonmarkergrid(drawnpolygon.Points.Count.ToString(), lng, lat, 0);

            MainMap.UpdatePolygonLocalPosition(drawnpolygon);
            MainMap.Invalidate();
            MainMap.ZoomAndCenterMarkers(drawnpolygonsoverlay.Id);
        }
        #endregion

        #region 下载区域航点显示区域信息 

        private double dist = 0;
        private double Area = 0;
        private void getAreaInfo(List<PointLatLng> WayPoints,List<PointLatLng> AreaPoints) 
        {
            if(drawnpolygon.Points.Count <= 0)
                return;

            lblArea.Text = Math.Round((double)(calcpolygonarea(AreaPoints) / 666.67),2).ToString("#") + "亩";//区域面积
            lblStrips.Text = ((int)((Commands.RowCount - 3) / 4)).ToString() + " 条";//轨迹数
            Area = Math.Round((double)(calcpolygonarea(AreaPoints) / 666.67), 2);
           
            for (int a = 1; a <= fullpointlist.Count - 3; a++)
            {
                dist += MainMap.MapProvider.Projection.GetDistance(fullpointlist[a], fullpointlist[a + 1]);
            }
            lblDistance.Text = Math.Round(dist,2).ToString() + "千米";

            lblDistbetweenlines.Text = Math.Round((MainMap.MapProvider.Projection.GetDistance(fullpointlist[2], fullpointlist[3])*1000),1).ToString() +"米";

            float speed = (float)Commands.Rows[1].Cells[2].Value;

            double seconds = ((dist * 1000.0) / ((speed) * 0.8));

            lblFlighttime.Text = secondsToNice(seconds);

            lblHeadinghold.Text = Commands.Rows[2].Cells[1].Value +"度";
        }

        /// <summary>
        /// 计算区域面积
        /// </summary>
        /// <param name="polygon"></param>
        /// <returns></returns>
        double calcpolygonarea(List<PointLatLngAlt> polygon)
        {
            // should be a closed polygon
            // coords are in lat long
            // need utm to calc area

            if (polygon.Count == 0)
            {
                CustomMessageBox.Show("请定义一个多边形!");
                return 0;
            }

            // close the polygon
            if (polygon[0] != polygon[polygon.Count - 1])
                polygon.Add(polygon[0]); // make a full loop

            CoordinateTransformationFactory ctfac = new CoordinateTransformationFactory();

            GeographicCoordinateSystem wgs84 = GeographicCoordinateSystem.WGS84;

            int utmzone = (int)((polygon[0].Lng - -186.0) / 6.0);

            IProjectedCoordinateSystem utm = ProjectedCoordinateSystem.WGS84_UTM(utmzone, polygon[0].Lat < 0 ? false : true);

            ICoordinateTransformation trans = ctfac.CreateFromCoordinateSystems(wgs84, utm);

            double prod1 = 0;
            double prod2 = 0;

            for (int a = 0; a < (polygon.Count - 1); a++)
            {
                double[] pll1 = { polygon[a].Lng, polygon[a].Lat };
                double[] pll2 = { polygon[a + 1].Lng, polygon[a + 1].Lat };

                double[] p1 = trans.MathTransform.Transform(pll1);
                double[] p2 = trans.MathTransform.Transform(pll2);

                prod1 += p1[0] * p2[1];
                prod2 += p1[1] * p2[0];
            }

            double answer = (prod1 - prod2) / 2;

            if (polygon[0] == polygon[polygon.Count - 1])
                polygon.RemoveAt(polygon.Count - 1); // unmake a full loop

            return Math.Abs(answer);
        }

        //飞行时间
        string secondsToNice(double seconds)
        {
            if (seconds < 0)
                return "Infinity Seconds";

            double secs = seconds % 60;
            int mins = (int)(seconds / 60) % 60;
            int hours = (int)(seconds / 3600) % 24;

            if (hours > 0)
            {
                return hours + ":" + mins.ToString("00") + ":" + secs.ToString("00") + " 小时";
            }
            else if (mins > 0)
            {
                return mins + ":" + secs.ToString("00") + " 分钟";
            }
            else
            {
                return secs.ToString("0.00") + " 秒";
            }
        }
        #endregion

        #region 添加飞机和区域信息时时信息
        private void addAnyTimeInfo() 
        {
            if (MainV2.comPort.MAV.cs.lat == 0 || MainV2.comPort.MAV.cs.lng == 0)
                return;

            PointLatLng homeloc =new PointLatLng();
            if (pointlist[0] != null)
            {
                homeloc = pointlist[0];            
            }
            else
            {
                homeloc = new PointLatLng(double.Parse(TXT_homelat.Text), double.Parse(TXT_homelng.Text));
            }

            PointLatLng currentloc = new PointLatLng(MainV2.comPort.MAV.cs.lat, MainV2.comPort.MAV.cs.lng);
            // home至飞机位置距离时时变化　
            double homedist = MainMap.MapProvider.Projection.GetDistance(currentloc, homeloc);

            //两点航向角
            string BearHomeToCurrentF = MainMap.MapProvider.Projection.GetBearing(currentloc, homeloc).ToString("0.0") + "度";
            lblDisToHome1.Text = FormatDistance(homedist, true);
            lblBearToHome1.Text = BearHomeToCurrentF;


            double FlyDist = 0;
            double CurrentDist = 0;
            if (MainV2.comPort.MAV.cs.armed && MainV2.comPort.MAV.cs.mode == "自动" && fullpointlist.Count >= 0 && MainV2.comPort.MAV.cs.GoToPoints >= 3)
            {
                for (int a = 1; a <= MainV2.comPort.MAV.cs.GoToPoints - 2; a++)
                {
                    FlyDist += MainMap.MapProvider.Projection.GetDistance(fullpointlist[a], fullpointlist[a + 1]);
                }
                CurrentDist = MainMap.MapProvider.Projection.GetDistance(currentloc, fullpointlist[MainV2.comPort.MAV.cs.GoToPoints - 1]);

                double persent = Math.Round(((FlyDist + CurrentDist) / float.Parse(lblDistance.Text.Replace("千米", ""))), 2);

                lblDoneArea1.Text = (persent * 100).ToString() + "% /" + (Area * persent).ToString("0.0") + "亩";
            }
        }

        #endregion

        #region 坐标平移

        enum MoveDirection
        {
            向上移动 = 1,
            向下移动 = 2,
            向左移动 = 3,
            向右移动 = 4 
        }

        private void movePointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string moveDirection = Convert.ToString(((ToolStripMenuItem)sender).Tag);

            string moveDistance = "0.5";

            //if (DialogResult.Cancel == InputBox.Show("坐标平移", "请输入航点"+Enum.Parse(typeof(MoveDirection),moveDirection).ToString() +"平移距离(米)", ref moveDistance))
            //    return;

            int no = 0;
            if (CurentRectMarker != null)
            {
                PointLatLng movePoint = MovingPoints(CurentRectMarker.Position, float.Parse(moveDistance), moveDirection);

                if (int.TryParse(CurentRectMarker.InnerMarker.Tag.ToString(), out no))
                {
                    try
                    {
                        callMeDrag(CurentRectMarker.InnerMarker.Tag.ToString(), movePoint.Lat, movePoint.Lng, -1);
                    }
                    catch { CustomMessageBox.Show("航点平移失败，请再次尝试。"); }
                }
                else if (int.TryParse(CurentRectMarker.InnerMarker.Tag.ToString().Replace("区域航点", ""), out no))
                {
                    try
                    {
                        drawnpolygon.Points[int.Parse(CurentRectMarker.InnerMarker.Tag.ToString().Replace("区域航点", "")) - 1] = movePoint;
                        updatePointsMarks(int.Parse(CurentRectMarker.InnerMarker.Tag.ToString().Replace("区域航点", "")));

                        drawnpolygonsoverlay.Markers.Clear();
                        int a = 1;
                        foreach (PointLatLng pnt in drawnpolygon.Points)
                        {
                            addpolygonmarkergrid(a.ToString(), pnt.Lng, pnt.Lat, 0);
                            a++;
                        }


                        MainMap.UpdatePolygonLocalPosition(drawnpolygon);
                        MainMap.Invalidate();
                    }
                    catch
                    {
                        CustomMessageBox.Show("区域航点平移失败，请再次尝试。");
                    }
                }
            }

            if (currentMarker != null)
                CurentRectMarker = null;

            writeKML();
        }

        private PointLatLng MovingPoints(PointLatLng movePoint,float moveDistance,string MoveDirection)
        {
            List<PointLatLngAlt> polygon = new List<PointLatLngAlt>();
            polygon.Add(movePoint);

            // utm zone distance calcs will be done in
            int utmzone = polygon[0].GetUTMZone();

            List<utmpos> utmpositions = utmpos.ToList(PointLatLngAlt.ToUTM(utmzone, polygon), utmzone);

            polygon.Clear();

            float dx = 0;
            float dy = 0;
            if (MoveDirection == "1") { dy = moveDistance; }
            else if (MoveDirection == "2") { dy = -moveDistance; }
            else if (MoveDirection == "3") { dx = -moveDistance; }
            else if (MoveDirection == "4") { dx = moveDistance; }

            polygon.Add((new utmpos(utmpositions[0].x + dx, utmpositions[0].y + dy, utmzone) { Tag = "M" }));

            return polygon[0];
        }
        #endregion
    }
}
