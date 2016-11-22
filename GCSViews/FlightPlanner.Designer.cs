using System.Drawing;
namespace ByAeroBeHero.GCSViews
{
    partial class FlightPlanner
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (currentMarker != null)
                currentMarker.Dispose();
            if (drawnpolygon != null)
                drawnpolygon.Dispose();
            if (kmlpolygonsoverlay != null)
                kmlpolygonsoverlay.Dispose();
            if (wppolygon != null)
                wppolygon.Dispose();
            if (top != null)
                top.Dispose();
            if (geofencepolygon != null)
                geofencepolygon.Dispose();
            if (geofenceoverlay != null)
                geofenceoverlay.Dispose();
            if (drawnpolygonsoverlay != null)
                drawnpolygonsoverlay.Dispose();
            if (center != null)
                center.Dispose(); 

            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightPlanner));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Commands = new System.Windows.Forms.DataGridView();
            this.Command = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waypno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Up = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.Grad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHK_verifyheight = new System.Windows.Forms.CheckBox();
            this.TXT_WPRad = new System.Windows.Forms.TextBox();
            this.TXT_DefaultAlt = new System.Windows.Forms.TextBox();
            this.LBL_WPRad = new System.Windows.Forms.Label();
            this.LBL_defalutalt = new System.Windows.Forms.Label();
            this.TXT_loiterrad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BUT_write = new ByAeroBeHero.Controls.MyButton();
            this.BUT_read = new ByAeroBeHero.Controls.MyButton();
            this.lblHAlt = new System.Windows.Forms.Label();
            this.lbljd = new System.Windows.Forms.Label();
            this.lblwd = new System.Windows.Forms.Label();
            this.TXT_homealt = new System.Windows.Forms.TextBox();
            this.TXT_homelng = new System.Windows.Forms.TextBox();
            this.TXT_homelat = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.coords1 = new ByAeroBeHero.Controls.Coords();
            this.panelWaypoints = new BSE.Windows.Forms.Panel();
            this.splitter1 = new BSE.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CMB_altmode = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.lbl_homedist = new System.Windows.Forms.Label();
            this.lbl_prevdist = new System.Windows.Forms.Label();
            this.lblhxj = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblKeepLiter = new System.Windows.Forms.Label();
            this.TXT_altwarn = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BUT_quickrtl1 = new ByAeroBeHero.Controls.MyButton();
            this.BUT_ARM1 = new ByAeroBeHero.Controls.MyButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.myButton1 = new ByAeroBeHero.Controls.MyButton();
            this.CHK_splinedefault = new System.Windows.Forms.CheckBox();
            this.BUT_writePIDS = new ByAeroBeHero.Controls.MyButton();
            this.BUT_Add = new ByAeroBeHero.Controls.MyButton();
            this.BUT_loadwpfile = new ByAeroBeHero.Controls.MyButton();
            this.BUT_saveWPFile = new ByAeroBeHero.Controls.MyButton();
            this.panelMap = new System.Windows.Forms.Panel();
            this.trackBar1 = new ByAeroBeHero.Controls.MyTrackBar();
            this.panelShowPoint = new BSE.Windows.Forms.Panel();
            this.groupboxOPoint = new System.Windows.Forms.GroupBox();
            this.myButton_savelimitpoint = new ByAeroBeHero.Controls.MyButton();
            this.myButton_loadlimitpoint = new ByAeroBeHero.Controls.MyButton();
            this.myButtonReadLimitPoint = new ByAeroBeHero.Controls.MyButton();
            this.myButtonClearLimitPoint = new ByAeroBeHero.Controls.MyButton();
            this.myBtnLimit = new ByAeroBeHero.Controls.MyButton();
            this.myBtnSendPoint = new ByAeroBeHero.Controls.MyButton();
            this.breakpointgroupBox = new System.Windows.Forms.GroupBox();
            this.myBtn_write_break_point = new ByAeroBeHero.Controls.MyButton();
            this.myBtn_read_break_point = new ByAeroBeHero.Controls.MyButton();
            this.groupBoxBasePoint = new System.Windows.Forms.GroupBox();
            this.groupBoxRellyPoint = new System.Windows.Forms.GroupBox();
            this.myButtonDonwloadRallyPoint = new ByAeroBeHero.Controls.MyButton();
            this.myButton_loadRallypoint = new ByAeroBeHero.Controls.MyButton();
            this.myButton2 = new ByAeroBeHero.Controls.MyButton();
            this.myBtnSetRallyPoint = new ByAeroBeHero.Controls.MyButton();
            this.groupBoxAeroPoint = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelRoute = new System.Windows.Forms.TableLayoutPanel();
            this.myBtnLoadAeroPoint = new ByAeroBeHero.Controls.MyButton();
            this.myBtnAddPoint = new ByAeroBeHero.Controls.MyButton();
            this.btnMeterInfo = new ByAeroBeHero.Controls.MyButton();
            this.btnWarnning = new ByAeroBeHero.Controls.MyButton();
            this.btnPlanInfo = new ByAeroBeHero.Controls.MyButton();
            this.btnFlyingInfo = new ByAeroBeHero.Controls.MyButton();
            this.btnAutoPan = new ByAeroBeHero.Controls.MyButton();
            this.ebsPanelMeter = new BSE.Windows.Forms.Panel();
            this.hud1 = new ByAeroBeHero.Controls.HUD();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ebsPanelFlyingInfo = new BSE.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Qvalt = new ByAeroBeHero.Controls.QuickView();
            this.Qvverspeed = new ByAeroBeHero.Controls.QuickView();
            this.Qvgroundspeed = new ByAeroBeHero.Controls.QuickView();
            this.QVSonarRange = new ByAeroBeHero.Controls.QuickView();
            this.Qvtohome = new ByAeroBeHero.Controls.QuickView();
            this.Qvdist = new ByAeroBeHero.Controls.QuickView();
            this.qvpitch = new ByAeroBeHero.Controls.QuickView();
            this.qvyaw = new ByAeroBeHero.Controls.QuickView();
            this.qvroll = new ByAeroBeHero.Controls.QuickView();
            this.ebsPanelPlanInfo = new BSE.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblFlighttime = new System.Windows.Forms.Label();
            this.lblDoneArea = new System.Windows.Forms.Label();
            this.lblFlyTime = new System.Windows.Forms.Label();
            this.lblDistance1 = new System.Windows.Forms.Label();
            this.lblStrip = new System.Windows.Forms.Label();
            this.lblAero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblStrips = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblHeadinghold = new System.Windows.Forms.Label();
            this.lblBearToHome = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblDistance = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDoneArea1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblArea = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblBearToHome1 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lblDisToHome1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDistbetweenlines = new System.Windows.Forms.Label();
            this.myButtonLand = new ByAeroBeHero.Controls.MyButton();
            this.myBtnFunction = new ByAeroBeHero.Controls.MyButton();
            this.BUT_quickauto1 = new ByAeroBeHero.Controls.MyButton();
            this.BUT_clear_track1 = new ByAeroBeHero.Controls.MyButton();
            this.btnLoiterUnlim = new ByAeroBeHero.Controls.MyButton();
            this.lblDisToHome = new System.Windows.Forms.Label();
            this.ebsPanelWarning = new BSE.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lblHorizontalError = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSataCount = new System.Windows.Forms.Label();
            this.BtnClear = new ByAeroBeHero.Controls.MyButton();
            this.lblStaCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLD = new System.Windows.Forms.Label();
            this.lblvibez = new System.Windows.Forms.Label();
            this.pictureBoxLD = new System.Windows.Forms.PictureBox();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.lblGyro = new System.Windows.Forms.Label();
            this.lblCompass = new System.Windows.Forms.Label();
            this.pictureBoxGPS = new System.Windows.Forms.PictureBox();
            this.lblAccel = new System.Windows.Forms.Label();
            this.lblGPS = new System.Windows.Forms.Label();
            this.pictureBoxLevel = new System.Windows.Forms.PictureBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.pictureBoxAccel = new System.Windows.Forms.PictureBox();
            this.pictureBoxReceiver = new System.Windows.Forms.PictureBox();
            this.pictureBoxvibez = new System.Windows.Forms.PictureBox();
            this.pictureBoxGyro = new System.Windows.Forms.PictureBox();
            this.pictureBoxCompass = new System.Windows.Forms.PictureBox();
            this.lblHorizontal = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txt_messagebox = new System.Windows.Forms.TextBox();
            this.MainMap = new ByAeroBeHero.Controls.myGMAP();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertWpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSplineWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiterForeverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitertimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loitercirclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpstartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpwPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setROIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movePointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolygonPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRallyPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRallyPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.limitPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readLimitPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeLimitPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLimitPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLimitPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLimitPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakpointtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getbreakpointtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendbreakpointtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavebreakpointtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadbreakpointtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geoFenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.GeoFenceuploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeoFencedownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setReturnLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoWPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createWpCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSplineCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prefetchWPPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMLOverlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevationGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseWPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileLoadSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAndAppendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadKMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSHPFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poiaddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poideleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poieditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyToHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterUTMCoordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchDockingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.timer_getbreakpoint = new System.Windows.Forms.Timer(this.components);
            this.timer_GetMapPoint = new System.Windows.Forms.Timer(this.components);
            this.Messagetabtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).BeginInit();
            this.panelWaypoints.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panelMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelShowPoint.SuspendLayout();
            this.groupboxOPoint.SuspendLayout();
            this.breakpointgroupBox.SuspendLayout();
            this.groupBoxBasePoint.SuspendLayout();
            this.groupBoxRellyPoint.SuspendLayout();
            this.groupBoxAeroPoint.SuspendLayout();
            this.ebsPanelMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.ebsPanelFlyingInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ebsPanelPlanInfo.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel4.SuspendLayout();
            this.ebsPanelWarning.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvibez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGyro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompass)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Commands
            // 
            this.Commands.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Commands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Commands.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Commands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.Commands, "Commands");
            this.Commands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Command,
            this.Param1,
            this.Param2,
            this.Param3,
            this.Param4,
            this.Lat,
            this.Lon,
            this.Alt,
            this.Waypno,
            this.Delete,
            this.Up,
            this.Down,
            this.Grad,
            this.Dist,
            this.AZ});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Commands.DefaultCellStyle = dataGridViewCellStyle16;
            this.Commands.EnableHeadersVisualStyles = false;
            this.Commands.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Commands.Name = "Commands";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = "0";
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Commands.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.Commands.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.Commands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellContentClick);
            this.Commands.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_CellEndEdit);
            this.Commands.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.Commands_DataError);
            this.Commands.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.Commands_DefaultValuesNeeded);
            this.Commands.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Commands_EditingControlShowing);
            this.Commands.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Commands_RowEnter);
            this.Commands.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Commands_RowsAdded);
            this.Commands.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.Commands_RowValidating);
            // 
            // Command
            // 
            this.Command.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.Command.DefaultCellStyle = dataGridViewCellStyle3;
            this.Command.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            resources.ApplyResources(this.Command, "Command");
            this.Command.Name = "Command";
            // 
            // Param1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Param1.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.Param1, "Param1");
            this.Param1.Name = "Param1";
            this.Param1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param2
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Param2.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.Param2, "Param2");
            this.Param2.Name = "Param2";
            this.Param2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param3
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Param3.DefaultCellStyle = dataGridViewCellStyle6;
            resources.ApplyResources(this.Param3, "Param3");
            this.Param3.Name = "Param3";
            this.Param3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Param4
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Param4.DefaultCellStyle = dataGridViewCellStyle7;
            resources.ApplyResources(this.Param4, "Param4");
            this.Param4.Name = "Param4";
            this.Param4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lat
            // 
            this.Lat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Lat.DefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.Lat, "Lat");
            this.Lat.Name = "Lat";
            this.Lat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Lon
            // 
            this.Lon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Lon.DefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.Lon, "Lon");
            this.Lon.Name = "Lon";
            this.Lon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Alt
            // 
            this.Alt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Alt.DefaultCellStyle = dataGridViewCellStyle10;
            resources.ApplyResources(this.Alt, "Alt");
            this.Alt.Name = "Alt";
            this.Alt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Waypno
            // 
            resources.ApplyResources(this.Waypno, "Waypno");
            this.Waypno.Name = "Waypno";
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.Text = "删除";
            // 
            // Up
            // 
            this.Up.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Up.DefaultCellStyle = dataGridViewCellStyle11;
            resources.ApplyResources(this.Up, "Up");
            this.Up.Image = ((System.Drawing.Image)(resources.GetObject("Up.Image")));
            this.Up.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Up.Name = "Up";
            // 
            // Down
            // 
            this.Down.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Down.DefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.Down, "Down");
            this.Down.Image = ((System.Drawing.Image)(resources.GetObject("Down.Image")));
            this.Down.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Down.Name = "Down";
            // 
            // Grad
            // 
            this.Grad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Grad.DefaultCellStyle = dataGridViewCellStyle13;
            resources.ApplyResources(this.Grad, "Grad");
            this.Grad.Name = "Grad";
            this.Grad.ReadOnly = true;
            this.Grad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Dist
            // 
            this.Dist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dist.DefaultCellStyle = dataGridViewCellStyle14;
            resources.ApplyResources(this.Dist, "Dist");
            this.Dist.Name = "Dist";
            this.Dist.ReadOnly = true;
            this.Dist.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AZ
            // 
            this.AZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AZ.DefaultCellStyle = dataGridViewCellStyle15;
            resources.ApplyResources(this.AZ, "AZ");
            this.AZ.Name = "AZ";
            this.AZ.ReadOnly = true;
            this.AZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CHK_verifyheight
            // 
            resources.ApplyResources(this.CHK_verifyheight, "CHK_verifyheight");
            this.CHK_verifyheight.BackColor = System.Drawing.Color.Black;
            this.CHK_verifyheight.Name = "CHK_verifyheight";
            this.CHK_verifyheight.UseVisualStyleBackColor = false;
            // 
            // TXT_WPRad
            // 
            resources.ApplyResources(this.TXT_WPRad, "TXT_WPRad");
            this.TXT_WPRad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TXT_WPRad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_WPRad.Name = "TXT_WPRad";
            this.TXT_WPRad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_WPRad_KeyPress);
            this.TXT_WPRad.Leave += new System.EventHandler(this.TXT_WPRad_Leave);
            // 
            // TXT_DefaultAlt
            // 
            resources.ApplyResources(this.TXT_DefaultAlt, "TXT_DefaultAlt");
            this.TXT_DefaultAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TXT_DefaultAlt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_DefaultAlt.Name = "TXT_DefaultAlt";
            this.TXT_DefaultAlt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_DefaultAlt_KeyPress);
            this.TXT_DefaultAlt.Leave += new System.EventHandler(this.TXT_DefaultAlt_Leave);
            // 
            // LBL_WPRad
            // 
            resources.ApplyResources(this.LBL_WPRad, "LBL_WPRad");
            this.LBL_WPRad.BackColor = System.Drawing.Color.Black;
            this.LBL_WPRad.Name = "LBL_WPRad";
            // 
            // LBL_defalutalt
            // 
            resources.ApplyResources(this.LBL_defalutalt, "LBL_defalutalt");
            this.LBL_defalutalt.BackColor = System.Drawing.Color.Black;
            this.LBL_defalutalt.Name = "LBL_defalutalt";
            // 
            // TXT_loiterrad
            // 
            resources.ApplyResources(this.TXT_loiterrad, "TXT_loiterrad");
            this.TXT_loiterrad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TXT_loiterrad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_loiterrad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TXT_loiterrad.Name = "TXT_loiterrad";
            this.TXT_loiterrad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_loiterrad_KeyPress);
            this.TXT_loiterrad.Leave += new System.EventHandler(this.TXT_loiterrad_Leave);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // BUT_write
            // 
            this.BUT_write.BGGradBot = System.Drawing.Color.White;
            this.BUT_write.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.BUT_write, "BUT_write");
            this.BUT_write.Name = "BUT_write";
            this.BUT_write.UseVisualStyleBackColor = true;
            this.BUT_write.Click += new System.EventHandler(this.BUT_write_Click);
            // 
            // BUT_read
            // 
            this.BUT_read.BGGradBot = System.Drawing.Color.White;
            this.BUT_read.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.BUT_read, "BUT_read");
            this.BUT_read.Name = "BUT_read";
            this.BUT_read.UseVisualStyleBackColor = true;
            this.BUT_read.Click += new System.EventHandler(this.BUT_read_Click);
            // 
            // lblHAlt
            // 
            resources.ApplyResources(this.lblHAlt, "lblHAlt");
            this.lblHAlt.ForeColor = System.Drawing.Color.White;
            this.lblHAlt.Name = "lblHAlt";
            // 
            // lbljd
            // 
            resources.ApplyResources(this.lbljd, "lbljd");
            this.lbljd.ForeColor = System.Drawing.Color.White;
            this.lbljd.Name = "lbljd";
            // 
            // lblwd
            // 
            resources.ApplyResources(this.lblwd, "lblwd");
            this.lblwd.ForeColor = System.Drawing.Color.White;
            this.lblwd.Name = "lblwd";
            // 
            // TXT_homealt
            // 
            this.TXT_homealt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TXT_homealt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.TXT_homealt, "TXT_homealt");
            this.TXT_homealt.Name = "TXT_homealt";
            this.TXT_homealt.TextChanged += new System.EventHandler(this.TXT_homealt_TextChanged);
            // 
            // TXT_homelng
            // 
            this.TXT_homelng.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TXT_homelng.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.TXT_homelng, "TXT_homelng");
            this.TXT_homelng.Name = "TXT_homelng";
            this.TXT_homelng.TextChanged += new System.EventHandler(this.TXT_homelng_TextChanged);
            // 
            // TXT_homelat
            // 
            resources.ApplyResources(this.TXT_homelat, "TXT_homelat");
            this.TXT_homelat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TXT_homelat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_homelat.Name = "TXT_homelat";
            this.TXT_homelat.TextChanged += new System.EventHandler(this.TXT_homelat_TextChanged);
            this.TXT_homelat.Enter += new System.EventHandler(this.TXT_homelat_Enter);
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle19;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle20;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // coords1
            // 
            this.coords1.Alt = 0D;
            this.coords1.AltUnit = "m";
            this.coords1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.coords1, "coords1");
            this.coords1.ForeColor = System.Drawing.Color.White;
            this.coords1.Lat = 0D;
            this.coords1.Lng = 0D;
            this.coords1.Name = "coords1";
            this.coords1.Vertical = true;
            // 
            // panelWaypoints
            // 
            this.panelWaypoints.AssociatedSplitter = this.splitter1;
            this.panelWaypoints.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panelWaypoints, "panelWaypoints");
            this.panelWaypoints.CaptionFont = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWaypoints.CaptionHeight = 27;
            this.panelWaypoints.Controls.Add(this.panel1);
            this.panelWaypoints.Controls.Add(this.Commands);
            this.panelWaypoints.CustomColors.BorderColor = System.Drawing.Color.Black;
            this.panelWaypoints.CustomColors.CaptionCloseIcon = System.Drawing.Color.White;
            this.panelWaypoints.CustomColors.CaptionExpandIcon = System.Drawing.Color.White;
            this.panelWaypoints.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelWaypoints.CustomColors.CaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelWaypoints.CustomColors.CaptionGradientMiddle = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.Transparent;
            this.panelWaypoints.CustomColors.CaptionText = System.Drawing.Color.DarkSlateGray;
            this.panelWaypoints.CustomColors.CollapsedCaptionText = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.panelWaypoints.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelWaypoints.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelWaypoints.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panelWaypoints.ForeColor = System.Drawing.Color.White;
            this.panelWaypoints.Image = null;
            this.panelWaypoints.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.panelWaypoints.Name = "panelWaypoints";
            this.panelWaypoints.ShowExpandIcon = true;
            this.panelWaypoints.ToolTipTextCloseIcon = null;
            this.panelWaypoints.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelWaypoints.ToolTipTextExpandIconPanelExpanded = null;
            this.panelWaypoints.ExpandClick += new System.EventHandler<System.EventArgs>(this.panelWaypoints_ExpandClick);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Transparent;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CMB_altmode);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.myButton1);
            this.panel1.Controls.Add(this.CHK_splinedefault);
            this.panel1.Controls.Add(this.BUT_writePIDS);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // CMB_altmode
            // 
            this.CMB_altmode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.CMB_altmode, "CMB_altmode");
            this.CMB_altmode.FormattingEnabled = true;
            this.CMB_altmode.Name = "CMB_altmode";
            this.CMB_altmode.SelectedIndexChanged += new System.EventHandler(this.CMB_altmode_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.LBL_defalutalt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label17, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.TXT_loiterrad, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.CHK_verifyheight, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.LBL_WPRad, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.TXT_altwarn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.TXT_WPRad, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TXT_DefaultAlt, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.lbl_distance, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_homedist, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.lbl_prevdist, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.coords1, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblhxj, 2, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // lbl_distance
            // 
            resources.ApplyResources(this.lbl_distance, "lbl_distance");
            this.lbl_distance.BackColor = System.Drawing.Color.Transparent;
            this.lbl_distance.ForeColor = System.Drawing.Color.White;
            this.lbl_distance.Name = "lbl_distance";
            // 
            // lbl_homedist
            // 
            resources.ApplyResources(this.lbl_homedist, "lbl_homedist");
            this.lbl_homedist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_homedist.ForeColor = System.Drawing.Color.White;
            this.lbl_homedist.Name = "lbl_homedist";
            // 
            // lbl_prevdist
            // 
            resources.ApplyResources(this.lbl_prevdist, "lbl_prevdist");
            this.lbl_prevdist.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prevdist.ForeColor = System.Drawing.Color.White;
            this.lbl_prevdist.Name = "lbl_prevdist";
            // 
            // lblhxj
            // 
            resources.ApplyResources(this.lblhxj, "lblhxj");
            this.lblhxj.BackColor = System.Drawing.Color.Transparent;
            this.lblhxj.ForeColor = System.Drawing.Color.White;
            this.lblhxj.Name = "lblhxj";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Black;
            this.label17.Name = "label17";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label33, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label34, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblKeepLiter, 5, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // lblKeepLiter
            // 
            resources.ApplyResources(this.lblKeepLiter, "lblKeepLiter");
            this.lblKeepLiter.Name = "lblKeepLiter";
            // 
            // TXT_altwarn
            // 
            resources.ApplyResources(this.TXT_altwarn, "TXT_altwarn");
            this.TXT_altwarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TXT_altwarn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_altwarn.Name = "TXT_altwarn";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.BUT_quickrtl1);
            this.panel6.Controls.Add(this.BUT_ARM1);
            this.panel6.Controls.Add(this.tableLayoutPanel4);
            this.panel6.Controls.Add(this.comboBoxMapType);
            this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // BUT_quickrtl1
            // 
            resources.ApplyResources(this.BUT_quickrtl1, "BUT_quickrtl1");
            this.BUT_quickrtl1.Name = "BUT_quickrtl1";
            this.BUT_quickrtl1.UseVisualStyleBackColor = true;
            this.BUT_quickrtl1.Click += new System.EventHandler(this.BUT_quickrtl_Click);
            // 
            // BUT_ARM1
            // 
            resources.ApplyResources(this.BUT_ARM1, "BUT_ARM1");
            this.BUT_ARM1.Name = "BUT_ARM1";
            this.BUT_ARM1.UseVisualStyleBackColor = true;
            this.BUT_ARM1.Click += new System.EventHandler(this.BUT_ARM_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.lblwd, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbljd, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblHAlt, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.TXT_homelng, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.TXT_homealt, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.TXT_homelat, 1, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // comboBoxMapType
            // 
            this.comboBoxMapType.BackColor = System.Drawing.Color.Black;
            this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMapType.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxMapType, "comboBoxMapType");
            this.comboBoxMapType.Name = "comboBoxMapType";
            this.toolTip1.SetToolTip(this.comboBoxMapType, resources.GetString("comboBoxMapType.ToolTip"));
            // 
            // myButton1
            // 
            this.myButton1.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myButton1.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.Name = "myButton1";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.BUT_refreshpart_Click);
            // 
            // CHK_splinedefault
            // 
            resources.ApplyResources(this.CHK_splinedefault, "CHK_splinedefault");
            this.CHK_splinedefault.BackColor = System.Drawing.Color.Black;
            this.CHK_splinedefault.Name = "CHK_splinedefault";
            this.CHK_splinedefault.UseVisualStyleBackColor = false;
            this.CHK_splinedefault.CheckedChanged += new System.EventHandler(this.CHK_splinedefault_CheckedChanged);
            // 
            // BUT_writePIDS
            // 
            this.BUT_writePIDS.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BUT_writePIDS.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.BUT_writePIDS, "BUT_writePIDS");
            this.BUT_writePIDS.Name = "BUT_writePIDS";
            this.BUT_writePIDS.UseVisualStyleBackColor = true;
            this.BUT_writePIDS.Click += new System.EventHandler(this.BUT_writePIDS_Click);
            // 
            // BUT_Add
            // 
            this.BUT_Add.BGGradBot = System.Drawing.Color.White;
            this.BUT_Add.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.BUT_Add, "BUT_Add");
            this.BUT_Add.Name = "BUT_Add";
            this.toolTip1.SetToolTip(this.BUT_Add, resources.GetString("BUT_Add.ToolTip"));
            this.BUT_Add.UseVisualStyleBackColor = true;
            this.BUT_Add.Click += new System.EventHandler(this.BUT_Add_Click);
            // 
            // BUT_loadwpfile
            // 
            this.BUT_loadwpfile.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BUT_loadwpfile.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.BUT_loadwpfile, "BUT_loadwpfile");
            this.BUT_loadwpfile.Name = "BUT_loadwpfile";
            this.BUT_loadwpfile.UseVisualStyleBackColor = true;
            this.BUT_loadwpfile.Click += new System.EventHandler(this.BUT_loadwpfile_Click);
            // 
            // BUT_saveWPFile
            // 
            this.BUT_saveWPFile.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BUT_saveWPFile.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.BUT_saveWPFile, "BUT_saveWPFile");
            this.BUT_saveWPFile.Name = "BUT_saveWPFile";
            this.BUT_saveWPFile.UseVisualStyleBackColor = true;
            this.BUT_saveWPFile.Click += new System.EventHandler(this.BUT_saveWPFile_Click);
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.Color.Transparent;
            this.panelMap.Controls.Add(this.trackBar1);
            this.panelMap.Controls.Add(this.panelShowPoint);
            this.panelMap.Controls.Add(this.btnMeterInfo);
            this.panelMap.Controls.Add(this.btnWarnning);
            this.panelMap.Controls.Add(this.btnPlanInfo);
            this.panelMap.Controls.Add(this.btnFlyingInfo);
            this.panelMap.Controls.Add(this.btnAutoPan);
            this.panelMap.Controls.Add(this.ebsPanelMeter);
            this.panelMap.Controls.Add(this.ebsPanelFlyingInfo);
            this.panelMap.Controls.Add(this.ebsPanelPlanInfo);
            this.panelMap.Controls.Add(this.ebsPanelWarning);
            this.panelMap.Controls.Add(this.MainMap);
            resources.ApplyResources(this.panelMap, "panelMap");
            this.panelMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMap.Name = "panelMap";
            this.panelMap.Resize += new System.EventHandler(this.panelMap_Resize);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.BackColor = System.Drawing.Color.Black;
            this.trackBar1.LargeChange = 0.005F;
            this.trackBar1.Maximum = 24F;
            this.trackBar1.Minimum = 1F;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.SmallChange = 0.001F;
            this.trackBar1.TickFrequency = 1F;
            this.trackBar1.Value = 2F;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panelShowPoint
            // 
            this.panelShowPoint.AssociatedSplitter = null;
            this.panelShowPoint.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panelShowPoint, "panelShowPoint");
            this.panelShowPoint.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panelShowPoint.CaptionHeight = 27;
            this.panelShowPoint.Controls.Add(this.groupboxOPoint);
            this.panelShowPoint.Controls.Add(this.breakpointgroupBox);
            this.panelShowPoint.Controls.Add(this.groupBoxBasePoint);
            this.panelShowPoint.Controls.Add(this.groupBoxRellyPoint);
            this.panelShowPoint.Controls.Add(this.groupBoxAeroPoint);
            this.panelShowPoint.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panelShowPoint.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panelShowPoint.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panelShowPoint.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelShowPoint.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panelShowPoint.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelShowPoint.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panelShowPoint.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panelShowPoint.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panelShowPoint.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panelShowPoint.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panelShowPoint.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panelShowPoint.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panelShowPoint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelShowPoint.Image = null;
            this.panelShowPoint.Name = "panelShowPoint";
            this.panelShowPoint.ToolTipTextCloseIcon = null;
            this.panelShowPoint.ToolTipTextExpandIconPanelCollapsed = null;
            this.panelShowPoint.ToolTipTextExpandIconPanelExpanded = null;
            this.panelShowPoint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelShowPoint_MouseDown);
            this.panelShowPoint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelShowPoint_MouseMove);
            this.panelShowPoint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelShowPoint_MouseUp);
            // 
            // groupboxOPoint
            // 
            this.groupboxOPoint.Controls.Add(this.myButton_savelimitpoint);
            this.groupboxOPoint.Controls.Add(this.myButton_loadlimitpoint);
            this.groupboxOPoint.Controls.Add(this.myButtonReadLimitPoint);
            this.groupboxOPoint.Controls.Add(this.myButtonClearLimitPoint);
            this.groupboxOPoint.Controls.Add(this.myBtnLimit);
            this.groupboxOPoint.Controls.Add(this.myBtnSendPoint);
            this.groupboxOPoint.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.groupboxOPoint, "groupboxOPoint");
            this.groupboxOPoint.Name = "groupboxOPoint";
            this.groupboxOPoint.TabStop = false;
            // 
            // myButton_savelimitpoint
            // 
            resources.ApplyResources(this.myButton_savelimitpoint, "myButton_savelimitpoint");
            this.myButton_savelimitpoint.Name = "myButton_savelimitpoint";
            this.myButton_savelimitpoint.UseVisualStyleBackColor = true;
            this.myButton_savelimitpoint.Click += new System.EventHandler(this.myButton_savelimitpoint_Click);
            // 
            // myButton_loadlimitpoint
            // 
            resources.ApplyResources(this.myButton_loadlimitpoint, "myButton_loadlimitpoint");
            this.myButton_loadlimitpoint.Name = "myButton_loadlimitpoint";
            this.myButton_loadlimitpoint.UseVisualStyleBackColor = true;
            this.myButton_loadlimitpoint.Click += new System.EventHandler(this.myButton_loadlimitpoint_Click);
            // 
            // myButtonReadLimitPoint
            // 
            resources.ApplyResources(this.myButtonReadLimitPoint, "myButtonReadLimitPoint");
            this.myButtonReadLimitPoint.Name = "myButtonReadLimitPoint";
            this.myButtonReadLimitPoint.UseVisualStyleBackColor = true;
            this.myButtonReadLimitPoint.Click += new System.EventHandler(this.getObstaclePointsToolStripMenuItem_Click);
            // 
            // myButtonClearLimitPoint
            // 
            resources.ApplyResources(this.myButtonClearLimitPoint, "myButtonClearLimitPoint");
            this.myButtonClearLimitPoint.Name = "myButtonClearLimitPoint";
            this.myButtonClearLimitPoint.UseVisualStyleBackColor = true;
            this.myButtonClearLimitPoint.Click += new System.EventHandler(this.clearObstaclePointsToolStripMenuItem_Click);
            // 
            // myBtnLimit
            // 
            resources.ApplyResources(this.myBtnLimit, "myBtnLimit");
            this.myBtnLimit.Name = "myBtnLimit";
            this.myBtnLimit.UseVisualStyleBackColor = true;
            this.myBtnLimit.Click += new System.EventHandler(this.myBtnAddLimit_Click);
            // 
            // myBtnSendPoint
            // 
            resources.ApplyResources(this.myBtnSendPoint, "myBtnSendPoint");
            this.myBtnSendPoint.Name = "myBtnSendPoint";
            this.myBtnSendPoint.UseVisualStyleBackColor = true;
            this.myBtnSendPoint.Click += new System.EventHandler(this.myBtnSendLimitPoint_Click);
            // 
            // breakpointgroupBox
            // 
            resources.ApplyResources(this.breakpointgroupBox, "breakpointgroupBox");
            this.breakpointgroupBox.Controls.Add(this.myBtn_write_break_point);
            this.breakpointgroupBox.Controls.Add(this.myBtn_read_break_point);
            this.breakpointgroupBox.ForeColor = System.Drawing.Color.Black;
            this.breakpointgroupBox.Name = "breakpointgroupBox";
            this.breakpointgroupBox.TabStop = false;
            // 
            // myBtn_write_break_point
            // 
            this.myBtn_write_break_point.BGGradBot = System.Drawing.Color.White;
            this.myBtn_write_break_point.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.myBtn_write_break_point, "myBtn_write_break_point");
            this.myBtn_write_break_point.Name = "myBtn_write_break_point";
            this.myBtn_write_break_point.UseVisualStyleBackColor = true;
            this.myBtn_write_break_point.Click += new System.EventHandler(this.myBtn_write_break_point_Click);
            // 
            // myBtn_read_break_point
            // 
            this.myBtn_read_break_point.BGGradBot = System.Drawing.Color.White;
            this.myBtn_read_break_point.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.myBtn_read_break_point, "myBtn_read_break_point");
            this.myBtn_read_break_point.Name = "myBtn_read_break_point";
            this.myBtn_read_break_point.UseVisualStyleBackColor = true;
            this.myBtn_read_break_point.Click += new System.EventHandler(this.myBtn_read_break_point_Click);
            // 
            // groupBoxBasePoint
            // 
            resources.ApplyResources(this.groupBoxBasePoint, "groupBoxBasePoint");
            this.groupBoxBasePoint.Controls.Add(this.BUT_loadwpfile);
            this.groupBoxBasePoint.Controls.Add(this.BUT_write);
            this.groupBoxBasePoint.Controls.Add(this.BUT_read);
            this.groupBoxBasePoint.Controls.Add(this.BUT_saveWPFile);
            this.groupBoxBasePoint.Controls.Add(this.BUT_Add);
            this.groupBoxBasePoint.ForeColor = System.Drawing.Color.Black;
            this.groupBoxBasePoint.Name = "groupBoxBasePoint";
            this.groupBoxBasePoint.TabStop = false;
            // 
            // groupBoxRellyPoint
            // 
            this.groupBoxRellyPoint.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.groupBoxRellyPoint, "groupBoxRellyPoint");
            this.groupBoxRellyPoint.Controls.Add(this.myButtonDonwloadRallyPoint);
            this.groupBoxRellyPoint.Controls.Add(this.myButton_loadRallypoint);
            this.groupBoxRellyPoint.Controls.Add(this.myButton2);
            this.groupBoxRellyPoint.Controls.Add(this.myBtnSetRallyPoint);
            this.groupBoxRellyPoint.ForeColor = System.Drawing.Color.Black;
            this.groupBoxRellyPoint.Name = "groupBoxRellyPoint";
            this.groupBoxRellyPoint.TabStop = false;
            // 
            // myButtonDonwloadRallyPoint
            // 
            this.myButtonDonwloadRallyPoint.BGGradBot = System.Drawing.Color.White;
            this.myButtonDonwloadRallyPoint.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.myButtonDonwloadRallyPoint, "myButtonDonwloadRallyPoint");
            this.myButtonDonwloadRallyPoint.Name = "myButtonDonwloadRallyPoint";
            this.myButtonDonwloadRallyPoint.UseVisualStyleBackColor = true;
            this.myButtonDonwloadRallyPoint.Click += new System.EventHandler(this.getRallyPointsToolStripMenuItem_Click);
            // 
            // myButton_loadRallypoint
            // 
            resources.ApplyResources(this.myButton_loadRallypoint, "myButton_loadRallypoint");
            this.myButton_loadRallypoint.Name = "myButton_loadRallypoint";
            this.myButton_loadRallypoint.UseVisualStyleBackColor = true;
            this.myButton_loadRallypoint.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem1_Click);
            // 
            // myButton2
            // 
            this.myButton2.BGGradBot = System.Drawing.Color.White;
            this.myButton2.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.Name = "myButton2";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.saveRallyPointsToolStripMenuItem_Click);
            // 
            // myBtnSetRallyPoint
            // 
            this.myBtnSetRallyPoint.BGGradBot = System.Drawing.Color.White;
            this.myBtnSetRallyPoint.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.myBtnSetRallyPoint, "myBtnSetRallyPoint");
            this.myBtnSetRallyPoint.Name = "myBtnSetRallyPoint";
            this.myBtnSetRallyPoint.UseVisualStyleBackColor = true;
            this.myBtnSetRallyPoint.Click += new System.EventHandler(this.setRallyPoint_Click);
            // 
            // groupBoxAeroPoint
            // 
            resources.ApplyResources(this.groupBoxAeroPoint, "groupBoxAeroPoint");
            this.groupBoxAeroPoint.Controls.Add(this.tableLayoutPanelRoute);
            this.groupBoxAeroPoint.Controls.Add(this.myBtnLoadAeroPoint);
            this.groupBoxAeroPoint.Controls.Add(this.myBtnAddPoint);
            this.groupBoxAeroPoint.ForeColor = System.Drawing.Color.Black;
            this.groupBoxAeroPoint.Name = "groupBoxAeroPoint";
            this.groupBoxAeroPoint.TabStop = false;
            // 
            // tableLayoutPanelRoute
            // 
            resources.ApplyResources(this.tableLayoutPanelRoute, "tableLayoutPanelRoute");
            this.tableLayoutPanelRoute.Name = "tableLayoutPanelRoute";
            // 
            // myBtnLoadAeroPoint
            // 
            resources.ApplyResources(this.myBtnLoadAeroPoint, "myBtnLoadAeroPoint");
            this.myBtnLoadAeroPoint.Name = "myBtnLoadAeroPoint";
            this.myBtnLoadAeroPoint.UseVisualStyleBackColor = true;
            this.myBtnLoadAeroPoint.Click += new System.EventHandler(this.loadPolygonToolStripMenuItem_Click);
            // 
            // myBtnAddPoint
            // 
            this.myBtnAddPoint.BGGradBot = System.Drawing.Color.White;
            this.myBtnAddPoint.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.myBtnAddPoint, "myBtnAddPoint");
            this.myBtnAddPoint.Name = "myBtnAddPoint";
            this.myBtnAddPoint.UseVisualStyleBackColor = true;
            this.myBtnAddPoint.Click += new System.EventHandler(this.myBtnAddPoint_Click);
            // 
            // btnMeterInfo
            // 
            this.btnMeterInfo.BGGradBot = System.Drawing.Color.White;
            this.btnMeterInfo.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.btnMeterInfo, "btnMeterInfo");
            this.btnMeterInfo.Name = "btnMeterInfo";
            this.btnMeterInfo.Tag = "";
            this.btnMeterInfo.UseVisualStyleBackColor = true;
            this.btnMeterInfo.Click += new System.EventHandler(this.btnMeterInfo_Click);
            // 
            // btnWarnning
            // 
            this.btnWarnning.BGGradBot = System.Drawing.Color.White;
            this.btnWarnning.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.btnWarnning, "btnWarnning");
            this.btnWarnning.Name = "btnWarnning";
            this.btnWarnning.Tag = "";
            this.btnWarnning.UseVisualStyleBackColor = true;
            this.btnWarnning.Click += new System.EventHandler(this.btnWarnning_Click);
            // 
            // btnPlanInfo
            // 
            this.btnPlanInfo.BGGradBot = System.Drawing.Color.White;
            this.btnPlanInfo.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.btnPlanInfo, "btnPlanInfo");
            this.btnPlanInfo.Name = "btnPlanInfo";
            this.btnPlanInfo.Tag = "";
            this.btnPlanInfo.UseVisualStyleBackColor = true;
            this.btnPlanInfo.Click += new System.EventHandler(this.btnPlanInfo_Click);
            // 
            // btnFlyingInfo
            // 
            this.btnFlyingInfo.BGGradBot = System.Drawing.Color.White;
            this.btnFlyingInfo.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.btnFlyingInfo, "btnFlyingInfo");
            this.btnFlyingInfo.Name = "btnFlyingInfo";
            this.btnFlyingInfo.Tag = "";
            this.btnFlyingInfo.UseVisualStyleBackColor = true;
            this.btnFlyingInfo.Click += new System.EventHandler(this.btnFlyingInfo_Click);
            // 
            // btnAutoPan
            // 
            resources.ApplyResources(this.btnAutoPan, "btnAutoPan");
            this.btnAutoPan.BGGradBot = System.Drawing.Color.White;
            this.btnAutoPan.BGGradTop = System.Drawing.Color.White;
            this.btnAutoPan.Name = "btnAutoPan";
            this.btnAutoPan.Tag = "";
            this.btnAutoPan.UseVisualStyleBackColor = true;
            this.btnAutoPan.Click += new System.EventHandler(this.btnAutoPan_Click);
            // 
            // ebsPanelMeter
            // 
            this.ebsPanelMeter.AssociatedSplitter = null;
            this.ebsPanelMeter.BackColor = System.Drawing.Color.Transparent;
            this.ebsPanelMeter.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.ebsPanelMeter.CaptionHeight = 27;
            this.ebsPanelMeter.Controls.Add(this.hud1);
            this.ebsPanelMeter.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ebsPanelMeter.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.ebsPanelMeter.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.ebsPanelMeter.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ebsPanelMeter.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.ebsPanelMeter.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ebsPanelMeter.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.ebsPanelMeter.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.ebsPanelMeter.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.ebsPanelMeter.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.ebsPanelMeter.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.ebsPanelMeter.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ebsPanelMeter.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.ebsPanelMeter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ebsPanelMeter.Image = null;
            resources.ApplyResources(this.ebsPanelMeter, "ebsPanelMeter");
            this.ebsPanelMeter.Name = "ebsPanelMeter";
            this.ebsPanelMeter.ToolTipTextCloseIcon = null;
            this.ebsPanelMeter.ToolTipTextExpandIconPanelCollapsed = null;
            this.ebsPanelMeter.ToolTipTextExpandIconPanelExpanded = null;
            this.ebsPanelMeter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelShowMeter_MouseDown);
            this.ebsPanelMeter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelShowMeter_MouseMove);
            this.ebsPanelMeter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelShowMeter_MouseUp);
            // 
            // hud1
            // 
            this.hud1.airspeed = 0F;
            this.hud1.alt = 0F;
            this.hud1.BackColor = System.Drawing.Color.Transparent;
            this.hud1.batterylevel = 0F;
            this.hud1.batteryremaining = 0F;
            this.hud1.connected = false;
            this.hud1.current = 0F;
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("airspeed", this.bindingSource1, "airspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("alt", this.bindingSource1, "alt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batterylevel", this.bindingSource1, "battery_voltage", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("batteryremaining", this.bindingSource1, "battery_remaining", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("connected", this.bindingSource1, "connected", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("current", this.bindingSource1, "current", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("datetime", this.bindingSource1, "datetime", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("disttowp", this.bindingSource1, "wp_dist", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("ekfstatus", this.bindingSource1, "ekfstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("failsafe", this.bindingSource1, "failsafe", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix", this.bindingSource1, "gpsstatus", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop", this.bindingSource1, "gpshdop", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundalt", this.bindingSource1, "HomeAlt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundcourse", this.bindingSource1, "groundcourse", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("groundspeed", this.bindingSource1, "groundspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("heading", this.bindingSource1, "yaw", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("linkqualitygcs", this.bindingSource1, "linkqualitygcs", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("messagetime", this.bindingSource1, "messageHighTime", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navpitch", this.bindingSource1, "nav_pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("navroll", this.bindingSource1, "nav_roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("pitch", this.bindingSource1, "pitch", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("roll", this.bindingSource1, "roll", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetalt", this.bindingSource1, "targetalt", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetheading", this.bindingSource1, "nav_bearing", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("targetspeed", this.bindingSource1, "targetairspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("turnrate", this.bindingSource1, "turnrate", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("verticalspeed", this.bindingSource1, "verticalspeed", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibex", this.bindingSource1, "vibex", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibey", this.bindingSource1, "vibey", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("vibez", this.bindingSource1, "vibez", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("wpno", this.bindingSource1, "wpno", true));
            this.hud1.DataBindings.Add(new System.Windows.Forms.Binding("xtrack_error", this.bindingSource1, "xtrack_error", true));
            this.hud1.datetime = new System.DateTime(((long)(0)));
            this.hud1.disttowp = 0F;
            resources.ApplyResources(this.hud1, "hud1");
            this.hud1.ekfstatus = 0F;
            this.hud1.failsafe = false;
            this.hud1.gpsfix = 0F;
            this.hud1.gpshdop = 0F;
            this.hud1.groundalt = 0F;
            this.hud1.groundcourse = 0F;
            this.hud1.groundspeed = 0F;
            this.hud1.heading = 0F;
            this.hud1.hudcolor = System.Drawing.Color.Transparent;
            this.hud1.linkqualitygcs = 0F;
            this.hud1.lowairspeed = false;
            this.hud1.lowgroundspeed = false;
            this.hud1.lowvoltagealert = false;
            this.hud1.message = "";
            this.hud1.messagetime = new System.DateTime(((long)(0)));
            this.hud1.mode = "";
            this.hud1.Name = "hud1";
            this.hud1.navpitch = 0F;
            this.hud1.navroll = 0F;
            this.hud1.opengl = true;
            this.hud1.pitch = 0F;
            this.hud1.roll = 0F;
            this.hud1.Russian = false;
            this.hud1.status = false;
            this.hud1.streamjpg = null;
            this.hud1.targetalt = 0F;
            this.hud1.targetheading = 0F;
            this.hud1.targetspeed = 0F;
            this.hud1.turnrate = 0F;
            this.hud1.UseOpenGL = true;
            this.hud1.verticalspeed = 0F;
            this.hud1.vibex = 0F;
            this.hud1.vibey = 0F;
            this.hud1.vibez = 0F;
            this.hud1.VSync = false;
            this.hud1.wpno = 0;
            this.hud1.xtrack_error = 0F;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(ByAeroBeHero.CurrentState);
            // 
            // ebsPanelFlyingInfo
            // 
            resources.ApplyResources(this.ebsPanelFlyingInfo, "ebsPanelFlyingInfo");
            this.ebsPanelFlyingInfo.AssociatedSplitter = null;
            this.ebsPanelFlyingInfo.BackColor = System.Drawing.Color.Transparent;
            this.ebsPanelFlyingInfo.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.ebsPanelFlyingInfo.CaptionHeight = 27;
            this.ebsPanelFlyingInfo.Controls.Add(this.tableLayoutPanel1);
            this.ebsPanelFlyingInfo.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ebsPanelFlyingInfo.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.ebsPanelFlyingInfo.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.ebsPanelFlyingInfo.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ebsPanelFlyingInfo.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.ebsPanelFlyingInfo.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ebsPanelFlyingInfo.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.ebsPanelFlyingInfo.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.ebsPanelFlyingInfo.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.ebsPanelFlyingInfo.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.ebsPanelFlyingInfo.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.ebsPanelFlyingInfo.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ebsPanelFlyingInfo.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.ebsPanelFlyingInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ebsPanelFlyingInfo.Image = null;
            this.ebsPanelFlyingInfo.Name = "ebsPanelFlyingInfo";
            this.ebsPanelFlyingInfo.ToolTipTextCloseIcon = null;
            this.ebsPanelFlyingInfo.ToolTipTextExpandIconPanelCollapsed = null;
            this.ebsPanelFlyingInfo.ToolTipTextExpandIconPanelExpanded = null;
            this.ebsPanelFlyingInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelShowFlyigInfo_MouseDown);
            this.ebsPanelFlyingInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelShowFlyigInfo_MouseMove);
            this.ebsPanelFlyingInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelShowFlyigInfo_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.Qvalt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Qvverspeed, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Qvgroundspeed, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.QVSonarRange, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.Qvtohome, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Qvdist, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.qvpitch, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.qvyaw, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.qvroll, 0, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Qvalt
            // 
            this.Qvalt.BackColor = System.Drawing.Color.Transparent;
            this.Qvalt.backColor1 = System.Drawing.Color.Transparent;
            this.Qvalt.backColor2 = System.Drawing.Color.Black;
            this.Qvalt.backColor3 = System.Drawing.Color.Transparent;
            this.Qvalt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Qvalt.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource1, "alt", true));
            this.Qvalt.desc = "高度(M):";
            resources.ApplyResources(this.Qvalt, "Qvalt");
            this.Qvalt.Name = "Qvalt";
            this.Qvalt.number = 0D;
            this.Qvalt.numberColor = System.Drawing.Color.Lime;
            this.Qvalt.numberformat = "0.00";
            // 
            // Qvverspeed
            // 
            this.Qvverspeed.BackColor = System.Drawing.Color.Transparent;
            this.Qvverspeed.backColor1 = System.Drawing.Color.Transparent;
            this.Qvverspeed.backColor2 = System.Drawing.Color.Black;
            this.Qvverspeed.backColor3 = System.Drawing.Color.Transparent;
            this.Qvverspeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Qvverspeed.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource1, "verticalspeed", true));
            this.Qvverspeed.desc = "垂直速度(M/S):";
            resources.ApplyResources(this.Qvverspeed, "Qvverspeed");
            this.Qvverspeed.Name = "Qvverspeed";
            this.Qvverspeed.number = 0D;
            this.Qvverspeed.numberColor = System.Drawing.Color.Lime;
            this.Qvverspeed.numberformat = "0.00";
            // 
            // Qvgroundspeed
            // 
            this.Qvgroundspeed.BackColor = System.Drawing.Color.Transparent;
            this.Qvgroundspeed.backColor1 = System.Drawing.Color.Transparent;
            this.Qvgroundspeed.backColor2 = System.Drawing.Color.Black;
            this.Qvgroundspeed.backColor3 = System.Drawing.Color.Transparent;
            this.Qvgroundspeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Qvgroundspeed.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource1, "groundspeed", true));
            this.Qvgroundspeed.desc = "速度(M/S):";
            resources.ApplyResources(this.Qvgroundspeed, "Qvgroundspeed");
            this.Qvgroundspeed.Name = "Qvgroundspeed";
            this.Qvgroundspeed.number = 0D;
            this.Qvgroundspeed.numberColor = System.Drawing.Color.Lime;
            this.Qvgroundspeed.numberformat = "0.00";
            // 
            // QVSonarRange
            // 
            this.QVSonarRange.BackColor = System.Drawing.Color.Transparent;
            this.QVSonarRange.backColor1 = System.Drawing.Color.Transparent;
            this.QVSonarRange.backColor2 = System.Drawing.Color.Black;
            this.QVSonarRange.backColor3 = System.Drawing.Color.Transparent;
            this.QVSonarRange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QVSonarRange.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource1, "sonarrange", true));
            this.QVSonarRange.desc = "雷达范围(M):";
            resources.ApplyResources(this.QVSonarRange, "QVSonarRange");
            this.QVSonarRange.Name = "QVSonarRange";
            this.QVSonarRange.number = 0D;
            this.QVSonarRange.numberColor = System.Drawing.Color.Lime;
            this.QVSonarRange.numberformat = "0.00";
            // 
            // Qvtohome
            // 
            this.Qvtohome.BackColor = System.Drawing.Color.Transparent;
            this.Qvtohome.backColor1 = System.Drawing.Color.Transparent;
            this.Qvtohome.backColor2 = System.Drawing.Color.Black;
            this.Qvtohome.backColor3 = System.Drawing.Color.Transparent;
            this.Qvtohome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Qvtohome.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource1, "DistToHome", true));
            this.Qvtohome.desc = "距离返航点(M):";
            resources.ApplyResources(this.Qvtohome, "Qvtohome");
            this.Qvtohome.Name = "Qvtohome";
            this.Qvtohome.number = 0D;
            this.Qvtohome.numberColor = System.Drawing.Color.Lime;
            this.Qvtohome.numberformat = "0.00";
            // 
            // Qvdist
            // 
            this.Qvdist.BackColor = System.Drawing.Color.Transparent;
            this.Qvdist.backColor1 = System.Drawing.Color.Transparent;
            this.Qvdist.backColor2 = System.Drawing.Color.Black;
            this.Qvdist.backColor3 = System.Drawing.Color.Transparent;
            this.Qvdist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Qvdist.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource1, "wp_dist", true));
            this.Qvdist.desc = "距离目标点(M):";
            resources.ApplyResources(this.Qvdist, "Qvdist");
            this.Qvdist.Name = "Qvdist";
            this.Qvdist.number = 0D;
            this.Qvdist.numberColor = System.Drawing.Color.Lime;
            this.Qvdist.numberformat = "0.00";
            // 
            // qvpitch
            // 
            this.qvpitch.BackColor = System.Drawing.Color.Transparent;
            this.qvpitch.backColor1 = System.Drawing.Color.Transparent;
            this.qvpitch.backColor2 = System.Drawing.Color.Black;
            this.qvpitch.backColor3 = System.Drawing.Color.Transparent;
            this.qvpitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qvpitch.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource1, "pitch", true));
            this.qvpitch.desc = "俯仰角度(D):";
            resources.ApplyResources(this.qvpitch, "qvpitch");
            this.qvpitch.Name = "qvpitch";
            this.qvpitch.number = 0D;
            this.qvpitch.numberColor = System.Drawing.Color.Lime;
            this.qvpitch.numberformat = "0.00";
            // 
            // qvyaw
            // 
            this.qvyaw.BackColor = System.Drawing.Color.Transparent;
            this.qvyaw.backColor1 = System.Drawing.Color.Transparent;
            this.qvyaw.backColor2 = System.Drawing.Color.Black;
            this.qvyaw.backColor3 = System.Drawing.Color.Transparent;
            this.qvyaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qvyaw.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource1, "yaw", true));
            this.qvyaw.desc = "航向角度(D):";
            resources.ApplyResources(this.qvyaw, "qvyaw");
            this.qvyaw.Name = "qvyaw";
            this.qvyaw.number = 0D;
            this.qvyaw.numberColor = System.Drawing.Color.Lime;
            this.qvyaw.numberformat = "0.00";
            // 
            // qvroll
            // 
            this.qvroll.BackColor = System.Drawing.Color.Transparent;
            this.qvroll.backColor1 = System.Drawing.Color.Transparent;
            this.qvroll.backColor2 = System.Drawing.Color.Black;
            this.qvroll.backColor3 = System.Drawing.Color.Transparent;
            this.qvroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qvroll.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSource1, "roll", true));
            this.qvroll.desc = "滚转角度(D):";
            resources.ApplyResources(this.qvroll, "qvroll");
            this.qvroll.Name = "qvroll";
            this.qvroll.number = 0D;
            this.qvroll.numberColor = System.Drawing.Color.Lime;
            this.qvroll.numberformat = "0.00";
            // 
            // ebsPanelPlanInfo
            // 
            resources.ApplyResources(this.ebsPanelPlanInfo, "ebsPanelPlanInfo");
            this.ebsPanelPlanInfo.AssociatedSplitter = null;
            this.ebsPanelPlanInfo.BackColor = System.Drawing.Color.Transparent;
            this.ebsPanelPlanInfo.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.ebsPanelPlanInfo.CaptionHeight = 27;
            this.ebsPanelPlanInfo.Controls.Add(this.panel13);
            this.ebsPanelPlanInfo.Controls.Add(this.lblDoneArea);
            this.ebsPanelPlanInfo.Controls.Add(this.lblFlyTime);
            this.ebsPanelPlanInfo.Controls.Add(this.lblDistance1);
            this.ebsPanelPlanInfo.Controls.Add(this.lblStrip);
            this.ebsPanelPlanInfo.Controls.Add(this.lblAero);
            this.ebsPanelPlanInfo.Controls.Add(this.label1);
            this.ebsPanelPlanInfo.Controls.Add(this.label15);
            this.ebsPanelPlanInfo.Controls.Add(this.panel9);
            this.ebsPanelPlanInfo.Controls.Add(this.panel11);
            this.ebsPanelPlanInfo.Controls.Add(this.lblBearToHome);
            this.ebsPanelPlanInfo.Controls.Add(this.panel10);
            this.ebsPanelPlanInfo.Controls.Add(this.panel5);
            this.ebsPanelPlanInfo.Controls.Add(this.panel8);
            this.ebsPanelPlanInfo.Controls.Add(this.panel7);
            this.ebsPanelPlanInfo.Controls.Add(this.panel12);
            this.ebsPanelPlanInfo.Controls.Add(this.panel4);
            this.ebsPanelPlanInfo.Controls.Add(this.myButtonLand);
            this.ebsPanelPlanInfo.Controls.Add(this.myBtnFunction);
            this.ebsPanelPlanInfo.Controls.Add(this.BUT_quickauto1);
            this.ebsPanelPlanInfo.Controls.Add(this.BUT_clear_track1);
            this.ebsPanelPlanInfo.Controls.Add(this.btnLoiterUnlim);
            this.ebsPanelPlanInfo.Controls.Add(this.lblDisToHome);
            this.ebsPanelPlanInfo.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ebsPanelPlanInfo.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.ebsPanelPlanInfo.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.ebsPanelPlanInfo.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ebsPanelPlanInfo.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.ebsPanelPlanInfo.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ebsPanelPlanInfo.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.ebsPanelPlanInfo.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.ebsPanelPlanInfo.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.ebsPanelPlanInfo.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.ebsPanelPlanInfo.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.ebsPanelPlanInfo.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ebsPanelPlanInfo.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.ebsPanelPlanInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ebsPanelPlanInfo.Image = null;
            this.ebsPanelPlanInfo.Name = "ebsPanelPlanInfo";
            this.ebsPanelPlanInfo.ToolTipTextCloseIcon = null;
            this.ebsPanelPlanInfo.ToolTipTextExpandIconPanelCollapsed = null;
            this.ebsPanelPlanInfo.ToolTipTextExpandIconPanelExpanded = null;
            this.ebsPanelPlanInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelShowPlan_MouseDown);
            this.ebsPanelPlanInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelShowPlan_MouseMove);
            this.ebsPanelPlanInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelShowPlan_MouseUp);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Black;
            this.panel13.Controls.Add(this.lblFlighttime);
            resources.ApplyResources(this.panel13, "panel13");
            this.panel13.Name = "panel13";
            // 
            // lblFlighttime
            // 
            resources.ApplyResources(this.lblFlighttime, "lblFlighttime");
            this.lblFlighttime.ForeColor = System.Drawing.Color.White;
            this.lblFlighttime.Name = "lblFlighttime";
            // 
            // lblDoneArea
            // 
            resources.ApplyResources(this.lblDoneArea, "lblDoneArea");
            this.lblDoneArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDoneArea.Name = "lblDoneArea";
            // 
            // lblFlyTime
            // 
            resources.ApplyResources(this.lblFlyTime, "lblFlyTime");
            this.lblFlyTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlyTime.ForeColor = System.Drawing.Color.Black;
            this.lblFlyTime.Name = "lblFlyTime";
            // 
            // lblDistance1
            // 
            resources.ApplyResources(this.lblDistance1, "lblDistance1");
            this.lblDistance1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistance1.ForeColor = System.Drawing.Color.Black;
            this.lblDistance1.Name = "lblDistance1";
            // 
            // lblStrip
            // 
            resources.ApplyResources(this.lblStrip, "lblStrip");
            this.lblStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStrip.ForeColor = System.Drawing.Color.Black;
            this.lblStrip.Name = "lblStrip";
            // 
            // lblAero
            // 
            resources.ApplyResources(this.lblAero, "lblAero");
            this.lblAero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAero.ForeColor = System.Drawing.Color.Black;
            this.lblAero.Name = "lblAero";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Name = "label1";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Name = "label15";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Controls.Add(this.lblStrips);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // lblStrips
            // 
            resources.ApplyResources(this.lblStrips, "lblStrips");
            this.lblStrips.ForeColor = System.Drawing.Color.White;
            this.lblStrips.Name = "lblStrips";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Controls.Add(this.lblHeadinghold);
            this.panel11.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // lblHeadinghold
            // 
            resources.ApplyResources(this.lblHeadinghold, "lblHeadinghold");
            this.lblHeadinghold.Name = "lblHeadinghold";
            // 
            // lblBearToHome
            // 
            resources.ApplyResources(this.lblBearToHome, "lblBearToHome");
            this.lblBearToHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBearToHome.Name = "lblBearToHome";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Black;
            this.panel10.Controls.Add(this.lblDistance);
            this.panel10.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // lblDistance
            // 
            resources.ApplyResources(this.lblDistance, "lblDistance");
            this.lblDistance.Name = "lblDistance";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.lblDoneArea1);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Name = "panel5";
            // 
            // lblDoneArea1
            // 
            resources.ApplyResources(this.lblDoneArea1, "lblDoneArea1");
            this.lblDoneArea1.BackColor = System.Drawing.Color.Transparent;
            this.lblDoneArea1.Name = "lblDoneArea1";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.lblArea);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // lblArea
            // 
            resources.ApplyResources(this.lblArea, "lblArea");
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Name = "lblArea";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.lblBearToHome1);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Name = "panel7";
            // 
            // lblBearToHome1
            // 
            resources.ApplyResources(this.lblBearToHome1, "lblBearToHome1");
            this.lblBearToHome1.Name = "lblBearToHome1";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Controls.Add(this.lblDisToHome1);
            this.panel12.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // lblDisToHome1
            // 
            resources.ApplyResources(this.lblDisToHome1, "lblDisToHome1");
            this.lblDisToHome1.Name = "lblDisToHome1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.lblDistbetweenlines);
            this.panel4.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // lblDistbetweenlines
            // 
            resources.ApplyResources(this.lblDistbetweenlines, "lblDistbetweenlines");
            this.lblDistbetweenlines.Name = "lblDistbetweenlines";
            // 
            // myButtonLand
            // 
            this.myButtonLand.BGGradBot = System.Drawing.Color.White;
            this.myButtonLand.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.myButtonLand, "myButtonLand");
            this.myButtonLand.Name = "myButtonLand";
            this.myButtonLand.UseVisualStyleBackColor = true;
            this.myButtonLand.Click += new System.EventHandler(this.myButtonLand_Click);
            // 
            // myBtnFunction
            // 
            this.myBtnFunction.BGGradBot = System.Drawing.Color.White;
            this.myBtnFunction.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.myBtnFunction, "myBtnFunction");
            this.myBtnFunction.Name = "myBtnFunction";
            this.myBtnFunction.UseVisualStyleBackColor = true;
            this.myBtnFunction.Click += new System.EventHandler(this.myBtnFunction_Click);
            // 
            // BUT_quickauto1
            // 
            this.BUT_quickauto1.BGGradBot = System.Drawing.Color.White;
            this.BUT_quickauto1.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.BUT_quickauto1, "BUT_quickauto1");
            this.BUT_quickauto1.Name = "BUT_quickauto1";
            this.BUT_quickauto1.UseVisualStyleBackColor = true;
            this.BUT_quickauto1.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // BUT_clear_track1
            // 
            this.BUT_clear_track1.BGGradBot = System.Drawing.Color.White;
            this.BUT_clear_track1.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.BUT_clear_track1, "BUT_clear_track1");
            this.BUT_clear_track1.Name = "BUT_clear_track1";
            this.BUT_clear_track1.UseVisualStyleBackColor = true;
            this.BUT_clear_track1.Click += new System.EventHandler(this.BUT_clear_track_Click);
            // 
            // btnLoiterUnlim
            // 
            this.btnLoiterUnlim.BGGradBot = System.Drawing.Color.White;
            this.btnLoiterUnlim.BGGradTop = System.Drawing.Color.White;
            resources.ApplyResources(this.btnLoiterUnlim, "btnLoiterUnlim");
            this.btnLoiterUnlim.Name = "btnLoiterUnlim";
            this.btnLoiterUnlim.UseVisualStyleBackColor = true;
            this.btnLoiterUnlim.Click += new System.EventHandler(this.btnLoiterUnlim_Click);
            // 
            // lblDisToHome
            // 
            resources.ApplyResources(this.lblDisToHome, "lblDisToHome");
            this.lblDisToHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisToHome.Name = "lblDisToHome";
            // 
            // ebsPanelWarning
            // 
            resources.ApplyResources(this.ebsPanelWarning, "ebsPanelWarning");
            this.ebsPanelWarning.AssociatedSplitter = null;
            this.ebsPanelWarning.BackColor = System.Drawing.Color.Transparent;
            this.ebsPanelWarning.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.ebsPanelWarning.CaptionHeight = 27;
            this.ebsPanelWarning.Controls.Add(this.panel14);
            this.ebsPanelWarning.Controls.Add(this.panel15);
            this.ebsPanelWarning.Controls.Add(this.panel2);
            this.ebsPanelWarning.Controls.Add(this.BtnClear);
            this.ebsPanelWarning.Controls.Add(this.lblStaCount);
            this.ebsPanelWarning.Controls.Add(this.tableLayoutPanel6);
            this.ebsPanelWarning.Controls.Add(this.lblHorizontal);
            this.ebsPanelWarning.Controls.Add(this.lblTime);
            this.ebsPanelWarning.Controls.Add(this.txt_messagebox);
            this.ebsPanelWarning.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.ebsPanelWarning.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.ebsPanelWarning.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.ebsPanelWarning.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ebsPanelWarning.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.ebsPanelWarning.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.ebsPanelWarning.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.ebsPanelWarning.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.ebsPanelWarning.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.ebsPanelWarning.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.ebsPanelWarning.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.ebsPanelWarning.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ebsPanelWarning.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.ebsPanelWarning.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ebsPanelWarning.Image = null;
            this.ebsPanelWarning.Name = "ebsPanelWarning";
            this.ebsPanelWarning.ToolTipTextCloseIcon = null;
            this.ebsPanelWarning.ToolTipTextExpandIconPanelCollapsed = null;
            this.ebsPanelWarning.ToolTipTextExpandIconPanelExpanded = null;
            this.ebsPanelWarning.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelShowWarningInfo_MouseDown);
            this.ebsPanelWarning.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelShowWarningInfo_MouseMove);
            this.ebsPanelWarning.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelShowWarningInfo_MouseUp);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Black;
            this.panel14.Controls.Add(this.lblHorizontalError);
            resources.ApplyResources(this.panel14, "panel14");
            this.panel14.Name = "panel14";
            // 
            // lblHorizontalError
            // 
            resources.ApplyResources(this.lblHorizontalError, "lblHorizontalError");
            this.lblHorizontalError.BackColor = System.Drawing.Color.Black;
            this.lblHorizontalError.ForeColor = System.Drawing.Color.White;
            this.lblHorizontalError.Name = "lblHorizontalError";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.Black;
            this.panel15.Controls.Add(this.lblShowTime);
            resources.ApplyResources(this.panel15, "panel15");
            this.panel15.Name = "panel15";
            // 
            // lblShowTime
            // 
            resources.ApplyResources(this.lblShowTime, "lblShowTime");
            this.lblShowTime.BackColor = System.Drawing.Color.Black;
            this.lblShowTime.ForeColor = System.Drawing.Color.White;
            this.lblShowTime.Name = "lblShowTime";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblSataCount);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lblSataCount
            // 
            resources.ApplyResources(this.lblSataCount, "lblSataCount");
            this.lblSataCount.BackColor = System.Drawing.Color.Black;
            this.lblSataCount.ForeColor = System.Drawing.Color.White;
            this.lblSataCount.Name = "lblSataCount";
            // 
            // BtnClear
            // 
            resources.ApplyResources(this.BtnClear, "BtnClear");
            this.BtnClear.BGGradBot = System.Drawing.Color.White;
            this.BtnClear.BGGradTop = System.Drawing.Color.White;
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClearClick);
            // 
            // lblStaCount
            // 
            resources.ApplyResources(this.lblStaCount, "lblStaCount");
            this.lblStaCount.Name = "lblStaCount";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this.lblLD, 7, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblvibez, 6, 1);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxLD, 7, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblReceiver, 5, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblGyro, 4, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblCompass, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxGPS, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblAccel, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblGPS, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxLevel, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblLevel, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxAccel, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxReceiver, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxvibez, 6, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxGyro, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxCompass, 3, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // lblLD
            // 
            resources.ApplyResources(this.lblLD, "lblLD");
            this.lblLD.BackColor = System.Drawing.Color.Transparent;
            this.lblLD.ForeColor = System.Drawing.Color.Black;
            this.lblLD.Name = "lblLD";
            // 
            // lblvibez
            // 
            resources.ApplyResources(this.lblvibez, "lblvibez");
            this.lblvibez.BackColor = System.Drawing.Color.Transparent;
            this.lblvibez.ForeColor = System.Drawing.Color.Black;
            this.lblvibez.Name = "lblvibez";
            // 
            // pictureBoxLD
            // 
            resources.ApplyResources(this.pictureBoxLD, "pictureBoxLD");
            this.pictureBoxLD.Name = "pictureBoxLD";
            this.pictureBoxLD.TabStop = false;
            // 
            // lblReceiver
            // 
            resources.ApplyResources(this.lblReceiver, "lblReceiver");
            this.lblReceiver.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiver.ForeColor = System.Drawing.Color.Black;
            this.lblReceiver.Name = "lblReceiver";
            // 
            // lblGyro
            // 
            resources.ApplyResources(this.lblGyro, "lblGyro");
            this.lblGyro.BackColor = System.Drawing.Color.Transparent;
            this.lblGyro.ForeColor = System.Drawing.Color.Black;
            this.lblGyro.Name = "lblGyro";
            // 
            // lblCompass
            // 
            resources.ApplyResources(this.lblCompass, "lblCompass");
            this.lblCompass.BackColor = System.Drawing.Color.Transparent;
            this.lblCompass.ForeColor = System.Drawing.Color.Black;
            this.lblCompass.Name = "lblCompass";
            // 
            // pictureBoxGPS
            // 
            resources.ApplyResources(this.pictureBoxGPS, "pictureBoxGPS");
            this.pictureBoxGPS.Name = "pictureBoxGPS";
            this.pictureBoxGPS.TabStop = false;
            // 
            // lblAccel
            // 
            resources.ApplyResources(this.lblAccel, "lblAccel");
            this.lblAccel.BackColor = System.Drawing.Color.Transparent;
            this.lblAccel.ForeColor = System.Drawing.Color.Black;
            this.lblAccel.Name = "lblAccel";
            // 
            // lblGPS
            // 
            resources.ApplyResources(this.lblGPS, "lblGPS");
            this.lblGPS.BackColor = System.Drawing.Color.Transparent;
            this.lblGPS.ForeColor = System.Drawing.Color.Black;
            this.lblGPS.Name = "lblGPS";
            // 
            // pictureBoxLevel
            // 
            resources.ApplyResources(this.pictureBoxLevel, "pictureBoxLevel");
            this.pictureBoxLevel.Name = "pictureBoxLevel";
            this.pictureBoxLevel.TabStop = false;
            // 
            // lblLevel
            // 
            resources.ApplyResources(this.lblLevel, "lblLevel");
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.ForeColor = System.Drawing.Color.Black;
            this.lblLevel.Name = "lblLevel";
            // 
            // pictureBoxAccel
            // 
            resources.ApplyResources(this.pictureBoxAccel, "pictureBoxAccel");
            this.pictureBoxAccel.Name = "pictureBoxAccel";
            this.pictureBoxAccel.TabStop = false;
            // 
            // pictureBoxReceiver
            // 
            resources.ApplyResources(this.pictureBoxReceiver, "pictureBoxReceiver");
            this.pictureBoxReceiver.Name = "pictureBoxReceiver";
            this.pictureBoxReceiver.TabStop = false;
            // 
            // pictureBoxvibez
            // 
            resources.ApplyResources(this.pictureBoxvibez, "pictureBoxvibez");
            this.pictureBoxvibez.Name = "pictureBoxvibez";
            this.pictureBoxvibez.TabStop = false;
            // 
            // pictureBoxGyro
            // 
            resources.ApplyResources(this.pictureBoxGyro, "pictureBoxGyro");
            this.pictureBoxGyro.Name = "pictureBoxGyro";
            this.pictureBoxGyro.TabStop = false;
            // 
            // pictureBoxCompass
            // 
            resources.ApplyResources(this.pictureBoxCompass, "pictureBoxCompass");
            this.pictureBoxCompass.Name = "pictureBoxCompass";
            this.pictureBoxCompass.TabStop = false;
            // 
            // lblHorizontal
            // 
            resources.ApplyResources(this.lblHorizontal, "lblHorizontal");
            this.lblHorizontal.Name = "lblHorizontal";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.Name = "lblTime";
            // 
            // txt_messagebox
            // 
            this.txt_messagebox.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.txt_messagebox, "txt_messagebox");
            this.txt_messagebox.ForeColor = System.Drawing.Color.White;
            this.txt_messagebox.Name = "txt_messagebox";
            this.txt_messagebox.ReadOnly = true;
            // 
            // MainMap
            // 
            resources.ApplyResources(this.MainMap, "MainMap");
            this.MainMap.BackColor = System.Drawing.Color.Transparent;
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.ContextMenuStrip = this.contextMenuStrip1;
            this.MainMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Transparent;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 24;
            this.MainMap.MinZoom = 5;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Zoom = 20D;
            this.MainMap.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMap_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteWPToolStripMenuItem,
            this.insertWpToolStripMenuItem,
            this.insertSplineWPToolStripMenuItem,
            this.loiterToolStripMenuItem,
            this.jumpToolStripMenuItem,
            this.rTLToolStripMenuItem,
            this.landToolStripMenuItem,
            this.takeoffToolStripMenuItem,
            this.setROIToolStripMenuItem,
            this.clearMissionToolStripMenuItem,
            this.movePointsToolStripMenuItem,
            this.toolStripSeparator1,
            this.polygonToolStripMenuItem,
            this.rallyPointsToolStripMenuItem,
            this.limitPointToolStripMenuItem,
            this.breakpointtoolStripMenuItem,
            this.geoFenceToolStripMenuItem,
            this.autoWPToolStripMenuItem,
            this.mapToolToolStripMenuItem,
            this.fileLoadSaveToolStripMenuItem,
            this.pOIToolStripMenuItem,
            this.flyToHereToolStripMenuItem,
            this.modifyAltToolStripMenuItem,
            this.enterUTMCoordToolStripMenuItem,
            this.switchDockingToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteWPToolStripMenuItem
            // 
            this.deleteWPToolStripMenuItem.Name = "deleteWPToolStripMenuItem";
            resources.ApplyResources(this.deleteWPToolStripMenuItem, "deleteWPToolStripMenuItem");
            this.deleteWPToolStripMenuItem.Click += new System.EventHandler(this.deleteWPToolStripMenuItem_Click);
            // 
            // insertWpToolStripMenuItem
            // 
            this.insertWpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.insertWpToolStripMenuItem.Name = "insertWpToolStripMenuItem";
            resources.ApplyResources(this.insertWpToolStripMenuItem, "insertWpToolStripMenuItem");
            this.insertWpToolStripMenuItem.Click += new System.EventHandler(this.insertWpToolStripMenuItem_Click);
            // 
            // insertSplineWPToolStripMenuItem
            // 
            this.insertSplineWPToolStripMenuItem.Name = "insertSplineWPToolStripMenuItem";
            resources.ApplyResources(this.insertSplineWPToolStripMenuItem, "insertSplineWPToolStripMenuItem");
            this.insertSplineWPToolStripMenuItem.Click += new System.EventHandler(this.insertSplineWPToolStripMenuItem_Click);
            // 
            // loiterToolStripMenuItem
            // 
            this.loiterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loiterForeverToolStripMenuItem,
            this.loitertimeToolStripMenuItem,
            this.loitercirclesToolStripMenuItem});
            this.loiterToolStripMenuItem.Name = "loiterToolStripMenuItem";
            resources.ApplyResources(this.loiterToolStripMenuItem, "loiterToolStripMenuItem");
            // 
            // loiterForeverToolStripMenuItem
            // 
            this.loiterForeverToolStripMenuItem.Name = "loiterForeverToolStripMenuItem";
            resources.ApplyResources(this.loiterForeverToolStripMenuItem, "loiterForeverToolStripMenuItem");
            this.loiterForeverToolStripMenuItem.Click += new System.EventHandler(this.loiterForeverToolStripMenuItem_Click);
            // 
            // loitertimeToolStripMenuItem
            // 
            this.loitertimeToolStripMenuItem.Name = "loitertimeToolStripMenuItem";
            resources.ApplyResources(this.loitertimeToolStripMenuItem, "loitertimeToolStripMenuItem");
            this.loitertimeToolStripMenuItem.Click += new System.EventHandler(this.loitertimeToolStripMenuItem_Click);
            // 
            // loitercirclesToolStripMenuItem
            // 
            this.loitercirclesToolStripMenuItem.Name = "loitercirclesToolStripMenuItem";
            resources.ApplyResources(this.loitercirclesToolStripMenuItem, "loitercirclesToolStripMenuItem");
            this.loitercirclesToolStripMenuItem.Click += new System.EventHandler(this.loitercirclesToolStripMenuItem_Click);
            // 
            // jumpToolStripMenuItem
            // 
            this.jumpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jumpstartToolStripMenuItem,
            this.jumpwPToolStripMenuItem});
            this.jumpToolStripMenuItem.Name = "jumpToolStripMenuItem";
            resources.ApplyResources(this.jumpToolStripMenuItem, "jumpToolStripMenuItem");
            // 
            // jumpstartToolStripMenuItem
            // 
            this.jumpstartToolStripMenuItem.Name = "jumpstartToolStripMenuItem";
            resources.ApplyResources(this.jumpstartToolStripMenuItem, "jumpstartToolStripMenuItem");
            this.jumpstartToolStripMenuItem.Click += new System.EventHandler(this.jumpstartToolStripMenuItem_Click);
            // 
            // jumpwPToolStripMenuItem
            // 
            this.jumpwPToolStripMenuItem.Name = "jumpwPToolStripMenuItem";
            resources.ApplyResources(this.jumpwPToolStripMenuItem, "jumpwPToolStripMenuItem");
            this.jumpwPToolStripMenuItem.Click += new System.EventHandler(this.jumpwPToolStripMenuItem_Click);
            // 
            // rTLToolStripMenuItem
            // 
            this.rTLToolStripMenuItem.Name = "rTLToolStripMenuItem";
            resources.ApplyResources(this.rTLToolStripMenuItem, "rTLToolStripMenuItem");
            this.rTLToolStripMenuItem.Click += new System.EventHandler(this.rTLToolStripMenuItem_Click);
            // 
            // landToolStripMenuItem
            // 
            this.landToolStripMenuItem.Name = "landToolStripMenuItem";
            resources.ApplyResources(this.landToolStripMenuItem, "landToolStripMenuItem");
            this.landToolStripMenuItem.Click += new System.EventHandler(this.landToolStripMenuItem_Click);
            // 
            // takeoffToolStripMenuItem
            // 
            this.takeoffToolStripMenuItem.Name = "takeoffToolStripMenuItem";
            resources.ApplyResources(this.takeoffToolStripMenuItem, "takeoffToolStripMenuItem");
            this.takeoffToolStripMenuItem.Click += new System.EventHandler(this.takeoffToolStripMenuItem_Click);
            // 
            // setROIToolStripMenuItem
            // 
            this.setROIToolStripMenuItem.Name = "setROIToolStripMenuItem";
            resources.ApplyResources(this.setROIToolStripMenuItem, "setROIToolStripMenuItem");
            this.setROIToolStripMenuItem.Click += new System.EventHandler(this.setROIToolStripMenuItem_Click);
            // 
            // clearMissionToolStripMenuItem
            // 
            this.clearMissionToolStripMenuItem.Name = "clearMissionToolStripMenuItem";
            resources.ApplyResources(this.clearMissionToolStripMenuItem, "clearMissionToolStripMenuItem");
            this.clearMissionToolStripMenuItem.Click += new System.EventHandler(this.clearMissionToolStripMenuItem_Click);
            // 
            // movePointsToolStripMenuItem
            // 
            this.movePointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToUpToolStripMenuItem,
            this.moveToDownToolStripMenuItem,
            this.moveToLeftToolStripMenuItem,
            this.moveToRightToolStripMenuItem});
            this.movePointsToolStripMenuItem.Name = "movePointsToolStripMenuItem";
            resources.ApplyResources(this.movePointsToolStripMenuItem, "movePointsToolStripMenuItem");
            // 
            // moveToUpToolStripMenuItem
            // 
            this.moveToUpToolStripMenuItem.Name = "moveToUpToolStripMenuItem";
            resources.ApplyResources(this.moveToUpToolStripMenuItem, "moveToUpToolStripMenuItem");
            this.moveToUpToolStripMenuItem.Tag = "1";
            this.moveToUpToolStripMenuItem.Click += new System.EventHandler(this.movePointsToolStripMenuItem_Click);
            // 
            // moveToDownToolStripMenuItem
            // 
            this.moveToDownToolStripMenuItem.Name = "moveToDownToolStripMenuItem";
            resources.ApplyResources(this.moveToDownToolStripMenuItem, "moveToDownToolStripMenuItem");
            this.moveToDownToolStripMenuItem.Tag = "2";
            this.moveToDownToolStripMenuItem.Click += new System.EventHandler(this.movePointsToolStripMenuItem_Click);
            // 
            // moveToLeftToolStripMenuItem
            // 
            this.moveToLeftToolStripMenuItem.Name = "moveToLeftToolStripMenuItem";
            resources.ApplyResources(this.moveToLeftToolStripMenuItem, "moveToLeftToolStripMenuItem");
            this.moveToLeftToolStripMenuItem.Tag = "3";
            this.moveToLeftToolStripMenuItem.Click += new System.EventHandler(this.movePointsToolStripMenuItem_Click);
            // 
            // moveToRightToolStripMenuItem
            // 
            this.moveToRightToolStripMenuItem.Name = "moveToRightToolStripMenuItem";
            resources.ApplyResources(this.moveToRightToolStripMenuItem, "moveToRightToolStripMenuItem");
            this.moveToRightToolStripMenuItem.Tag = "4";
            this.moveToRightToolStripMenuItem.Click += new System.EventHandler(this.movePointsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPolygonPointToolStripMenuItem,
            this.clearPolygonToolStripMenuItem,
            this.savePolygonToolStripMenuItem,
            this.loadPolygonToolStripMenuItem,
            this.fromSHPToolStripMenuItem,
            this.exchangeToolStripMenuItem});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            resources.ApplyResources(this.polygonToolStripMenuItem, "polygonToolStripMenuItem");
            // 
            // addPolygonPointToolStripMenuItem
            // 
            this.addPolygonPointToolStripMenuItem.Name = "addPolygonPointToolStripMenuItem";
            resources.ApplyResources(this.addPolygonPointToolStripMenuItem, "addPolygonPointToolStripMenuItem");
            this.addPolygonPointToolStripMenuItem.Click += new System.EventHandler(this.addPolygonPointToolStripMenuItem_Click);
            // 
            // clearPolygonToolStripMenuItem
            // 
            this.clearPolygonToolStripMenuItem.Name = "clearPolygonToolStripMenuItem";
            resources.ApplyResources(this.clearPolygonToolStripMenuItem, "clearPolygonToolStripMenuItem");
            this.clearPolygonToolStripMenuItem.Click += new System.EventHandler(this.clearPolygonToolStripMenuItem_Click);
            // 
            // savePolygonToolStripMenuItem
            // 
            this.savePolygonToolStripMenuItem.Name = "savePolygonToolStripMenuItem";
            resources.ApplyResources(this.savePolygonToolStripMenuItem, "savePolygonToolStripMenuItem");
            this.savePolygonToolStripMenuItem.Click += new System.EventHandler(this.savePolygonToolStripMenuItem_Click);
            // 
            // loadPolygonToolStripMenuItem
            // 
            this.loadPolygonToolStripMenuItem.Name = "loadPolygonToolStripMenuItem";
            resources.ApplyResources(this.loadPolygonToolStripMenuItem, "loadPolygonToolStripMenuItem");
            this.loadPolygonToolStripMenuItem.Click += new System.EventHandler(this.loadPolygonToolStripMenuItem_Click);
            // 
            // fromSHPToolStripMenuItem
            // 
            this.fromSHPToolStripMenuItem.Name = "fromSHPToolStripMenuItem";
            resources.ApplyResources(this.fromSHPToolStripMenuItem, "fromSHPToolStripMenuItem");
            this.fromSHPToolStripMenuItem.Click += new System.EventHandler(this.fromSHPToolStripMenuItem_Click);
            // 
            // exchangeToolStripMenuItem
            // 
            this.exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            resources.ApplyResources(this.exchangeToolStripMenuItem, "exchangeToolStripMenuItem");
            this.exchangeToolStripMenuItem.Click += new System.EventHandler(this.exchangeToolStripMenuItem_Click);
            // 
            // rallyPointsToolStripMenuItem
            // 
            this.rallyPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setRallyPointToolStripMenuItem,
            this.getRallyPointsToolStripMenuItem,
            this.saveRallyPointsToolStripMenuItem,
            this.clearRallyPointsToolStripMenuItem,
            this.saveToFileToolStripMenuItem1,
            this.loadFromFileToolStripMenuItem1});
            this.rallyPointsToolStripMenuItem.Name = "rallyPointsToolStripMenuItem";
            resources.ApplyResources(this.rallyPointsToolStripMenuItem, "rallyPointsToolStripMenuItem");
            // 
            // setRallyPointToolStripMenuItem
            // 
            this.setRallyPointToolStripMenuItem.Name = "setRallyPointToolStripMenuItem";
            resources.ApplyResources(this.setRallyPointToolStripMenuItem, "setRallyPointToolStripMenuItem");
            this.setRallyPointToolStripMenuItem.Click += new System.EventHandler(this.setRallyPointToolStripMenuItem_Click);
            // 
            // getRallyPointsToolStripMenuItem
            // 
            this.getRallyPointsToolStripMenuItem.Name = "getRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.getRallyPointsToolStripMenuItem, "getRallyPointsToolStripMenuItem");
            this.getRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.getRallyPointsToolStripMenuItem_Click);
            // 
            // saveRallyPointsToolStripMenuItem
            // 
            this.saveRallyPointsToolStripMenuItem.Name = "saveRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.saveRallyPointsToolStripMenuItem, "saveRallyPointsToolStripMenuItem");
            this.saveRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.saveRallyPointsToolStripMenuItem_Click);
            // 
            // clearRallyPointsToolStripMenuItem
            // 
            this.clearRallyPointsToolStripMenuItem.Name = "clearRallyPointsToolStripMenuItem";
            resources.ApplyResources(this.clearRallyPointsToolStripMenuItem, "clearRallyPointsToolStripMenuItem");
            this.clearRallyPointsToolStripMenuItem.Click += new System.EventHandler(this.clearRallyPointsToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem1
            // 
            this.saveToFileToolStripMenuItem1.Name = "saveToFileToolStripMenuItem1";
            resources.ApplyResources(this.saveToFileToolStripMenuItem1, "saveToFileToolStripMenuItem1");
            this.saveToFileToolStripMenuItem1.Click += new System.EventHandler(this.saveToFileToolStripMenuItem1_Click);
            // 
            // loadFromFileToolStripMenuItem1
            // 
            this.loadFromFileToolStripMenuItem1.Name = "loadFromFileToolStripMenuItem1";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem1, "loadFromFileToolStripMenuItem1");
            this.loadFromFileToolStripMenuItem1.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem1_Click);
            // 
            // limitPointToolStripMenuItem
            // 
            this.limitPointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readLimitPointToolStripMenuItem,
            this.writeLimitPointToolStripMenuItem,
            this.clearLimitPointToolStripMenuItem,
            this.saveLimitPointToolStripMenuItem,
            this.loadLimitPointToolStripMenuItem});
            this.limitPointToolStripMenuItem.Name = "limitPointToolStripMenuItem";
            resources.ApplyResources(this.limitPointToolStripMenuItem, "limitPointToolStripMenuItem");
            // 
            // readLimitPointToolStripMenuItem
            // 
            this.readLimitPointToolStripMenuItem.Name = "readLimitPointToolStripMenuItem";
            resources.ApplyResources(this.readLimitPointToolStripMenuItem, "readLimitPointToolStripMenuItem");
            this.readLimitPointToolStripMenuItem.Click += new System.EventHandler(this.getObstaclePointsToolStripMenuItem_Click);
            // 
            // writeLimitPointToolStripMenuItem
            // 
            this.writeLimitPointToolStripMenuItem.Name = "writeLimitPointToolStripMenuItem";
            resources.ApplyResources(this.writeLimitPointToolStripMenuItem, "writeLimitPointToolStripMenuItem");
            this.writeLimitPointToolStripMenuItem.Click += new System.EventHandler(this.myBtnSendLimitPoint_Click);
            // 
            // clearLimitPointToolStripMenuItem
            // 
            this.clearLimitPointToolStripMenuItem.Name = "clearLimitPointToolStripMenuItem";
            resources.ApplyResources(this.clearLimitPointToolStripMenuItem, "clearLimitPointToolStripMenuItem");
            this.clearLimitPointToolStripMenuItem.Click += new System.EventHandler(this.clearObstaclePointsToolStripMenuItem_Click);
            // 
            // saveLimitPointToolStripMenuItem
            // 
            this.saveLimitPointToolStripMenuItem.Name = "saveLimitPointToolStripMenuItem";
            resources.ApplyResources(this.saveLimitPointToolStripMenuItem, "saveLimitPointToolStripMenuItem");
            this.saveLimitPointToolStripMenuItem.Click += new System.EventHandler(this.myButton_savelimitpoint_Click);
            // 
            // loadLimitPointToolStripMenuItem
            // 
            this.loadLimitPointToolStripMenuItem.Name = "loadLimitPointToolStripMenuItem";
            resources.ApplyResources(this.loadLimitPointToolStripMenuItem, "loadLimitPointToolStripMenuItem");
            this.loadLimitPointToolStripMenuItem.Click += new System.EventHandler(this.myButton_loadlimitpoint_Click);
            // 
            // breakpointtoolStripMenuItem
            // 
            this.breakpointtoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getbreakpointtoolStripMenuItem,
            this.SendbreakpointtoolStripMenuItem,
            this.SavebreakpointtoolStripMenuItem,
            this.loadbreakpointtoolStripMenuItem});
            this.breakpointtoolStripMenuItem.Name = "breakpointtoolStripMenuItem";
            resources.ApplyResources(this.breakpointtoolStripMenuItem, "breakpointtoolStripMenuItem");
            // 
            // getbreakpointtoolStripMenuItem
            // 
            this.getbreakpointtoolStripMenuItem.Name = "getbreakpointtoolStripMenuItem";
            resources.ApplyResources(this.getbreakpointtoolStripMenuItem, "getbreakpointtoolStripMenuItem");
            this.getbreakpointtoolStripMenuItem.Click += new System.EventHandler(this.myBtn_read_break_point_Click);
            // 
            // SendbreakpointtoolStripMenuItem
            // 
            this.SendbreakpointtoolStripMenuItem.Name = "SendbreakpointtoolStripMenuItem";
            resources.ApplyResources(this.SendbreakpointtoolStripMenuItem, "SendbreakpointtoolStripMenuItem");
            this.SendbreakpointtoolStripMenuItem.Click += new System.EventHandler(this.myBtn_write_break_point_Click);
            // 
            // SavebreakpointtoolStripMenuItem
            // 
            this.SavebreakpointtoolStripMenuItem.Name = "SavebreakpointtoolStripMenuItem";
            resources.ApplyResources(this.SavebreakpointtoolStripMenuItem, "SavebreakpointtoolStripMenuItem");
            this.SavebreakpointtoolStripMenuItem.Click += new System.EventHandler(this.SaveBreak_File_Click);
            // 
            // loadbreakpointtoolStripMenuItem
            // 
            this.loadbreakpointtoolStripMenuItem.Name = "loadbreakpointtoolStripMenuItem";
            resources.ApplyResources(this.loadbreakpointtoolStripMenuItem, "loadbreakpointtoolStripMenuItem");
            this.loadbreakpointtoolStripMenuItem.Click += new System.EventHandler(this.LoadBreak_File_Click);
            // 
            // geoFenceToolStripMenuItem
            // 
            this.geoFenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator4,
            this.GeoFenceuploadToolStripMenuItem,
            this.GeoFencedownloadToolStripMenuItem,
            this.setReturnLocationToolStripMenuItem,
            this.loadFromFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.geoFenceToolStripMenuItem.Name = "geoFenceToolStripMenuItem";
            resources.ApplyResources(this.geoFenceToolStripMenuItem, "geoFenceToolStripMenuItem");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // GeoFenceuploadToolStripMenuItem
            // 
            this.GeoFenceuploadToolStripMenuItem.Name = "GeoFenceuploadToolStripMenuItem";
            resources.ApplyResources(this.GeoFenceuploadToolStripMenuItem, "GeoFenceuploadToolStripMenuItem");
            this.GeoFenceuploadToolStripMenuItem.Click += new System.EventHandler(this.GeoFenceuploadToolStripMenuItem_Click);
            // 
            // GeoFencedownloadToolStripMenuItem
            // 
            this.GeoFencedownloadToolStripMenuItem.Name = "GeoFencedownloadToolStripMenuItem";
            resources.ApplyResources(this.GeoFencedownloadToolStripMenuItem, "GeoFencedownloadToolStripMenuItem");
            this.GeoFencedownloadToolStripMenuItem.Click += new System.EventHandler(this.GeoFencedownloadToolStripMenuItem_Click);
            // 
            // setReturnLocationToolStripMenuItem
            // 
            this.setReturnLocationToolStripMenuItem.Name = "setReturnLocationToolStripMenuItem";
            resources.ApplyResources(this.setReturnLocationToolStripMenuItem, "setReturnLocationToolStripMenuItem");
            this.setReturnLocationToolStripMenuItem.Click += new System.EventHandler(this.setReturnLocationToolStripMenuItem_Click);
            // 
            // loadFromFileToolStripMenuItem
            // 
            this.loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            resources.ApplyResources(this.loadFromFileToolStripMenuItem, "loadFromFileToolStripMenuItem");
            this.loadFromFileToolStripMenuItem.Click += new System.EventHandler(this.loadFromFileToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            resources.ApplyResources(this.saveToFileToolStripMenuItem, "saveToFileToolStripMenuItem");
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // autoWPToolStripMenuItem
            // 
            this.autoWPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createWpCircleToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.createSplineCircleToolStripMenuItem});
            this.autoWPToolStripMenuItem.Name = "autoWPToolStripMenuItem";
            resources.ApplyResources(this.autoWPToolStripMenuItem, "autoWPToolStripMenuItem");
            // 
            // createWpCircleToolStripMenuItem
            // 
            this.createWpCircleToolStripMenuItem.Name = "createWpCircleToolStripMenuItem";
            resources.ApplyResources(this.createWpCircleToolStripMenuItem, "createWpCircleToolStripMenuItem");
            this.createWpCircleToolStripMenuItem.Click += new System.EventHandler(this.createWpCircleToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            resources.ApplyResources(this.areaToolStripMenuItem, "areaToolStripMenuItem");
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // createSplineCircleToolStripMenuItem
            // 
            this.createSplineCircleToolStripMenuItem.Name = "createSplineCircleToolStripMenuItem";
            resources.ApplyResources(this.createSplineCircleToolStripMenuItem, "createSplineCircleToolStripMenuItem");
            this.createSplineCircleToolStripMenuItem.Click += new System.EventHandler(this.createSplineCircleToolStripMenuItem_Click);
            // 
            // mapToolToolStripMenuItem
            // 
            this.mapToolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMeasure,
            this.rotateMapToolStripMenuItem,
            this.zoomToToolStripMenuItem,
            this.prefetchToolStripMenuItem,
            this.prefetchWPPathToolStripMenuItem,
            this.kMLOverlayToolStripMenuItem,
            this.elevationGraphToolStripMenuItem,
            this.reverseWPsToolStripMenuItem});
            this.mapToolToolStripMenuItem.Name = "mapToolToolStripMenuItem";
            resources.ApplyResources(this.mapToolToolStripMenuItem, "mapToolToolStripMenuItem");
            // 
            // ContextMeasure
            // 
            this.ContextMeasure.Name = "ContextMeasure";
            resources.ApplyResources(this.ContextMeasure, "ContextMeasure");
            this.ContextMeasure.Click += new System.EventHandler(this.ContextMeasure_Click);
            // 
            // rotateMapToolStripMenuItem
            // 
            this.rotateMapToolStripMenuItem.Name = "rotateMapToolStripMenuItem";
            resources.ApplyResources(this.rotateMapToolStripMenuItem, "rotateMapToolStripMenuItem");
            this.rotateMapToolStripMenuItem.Click += new System.EventHandler(this.rotateMapToolStripMenuItem_Click);
            // 
            // zoomToToolStripMenuItem
            // 
            this.zoomToToolStripMenuItem.Name = "zoomToToolStripMenuItem";
            resources.ApplyResources(this.zoomToToolStripMenuItem, "zoomToToolStripMenuItem");
            this.zoomToToolStripMenuItem.Click += new System.EventHandler(this.zoomToToolStripMenuItem_Click);
            // 
            // prefetchToolStripMenuItem
            // 
            this.prefetchToolStripMenuItem.Name = "prefetchToolStripMenuItem";
            resources.ApplyResources(this.prefetchToolStripMenuItem, "prefetchToolStripMenuItem");
            this.prefetchToolStripMenuItem.Click += new System.EventHandler(this.prefetchToolStripMenuItem_Click);
            // 
            // prefetchWPPathToolStripMenuItem
            // 
            this.prefetchWPPathToolStripMenuItem.Name = "prefetchWPPathToolStripMenuItem";
            resources.ApplyResources(this.prefetchWPPathToolStripMenuItem, "prefetchWPPathToolStripMenuItem");
            this.prefetchWPPathToolStripMenuItem.Click += new System.EventHandler(this.prefetchWPPathToolStripMenuItem_Click);
            // 
            // kMLOverlayToolStripMenuItem
            // 
            this.kMLOverlayToolStripMenuItem.Name = "kMLOverlayToolStripMenuItem";
            resources.ApplyResources(this.kMLOverlayToolStripMenuItem, "kMLOverlayToolStripMenuItem");
            this.kMLOverlayToolStripMenuItem.Click += new System.EventHandler(this.kMLOverlayToolStripMenuItem_Click);
            // 
            // elevationGraphToolStripMenuItem
            // 
            this.elevationGraphToolStripMenuItem.Name = "elevationGraphToolStripMenuItem";
            resources.ApplyResources(this.elevationGraphToolStripMenuItem, "elevationGraphToolStripMenuItem");
            this.elevationGraphToolStripMenuItem.Click += new System.EventHandler(this.elevationGraphToolStripMenuItem_Click);
            // 
            // reverseWPsToolStripMenuItem
            // 
            this.reverseWPsToolStripMenuItem.Name = "reverseWPsToolStripMenuItem";
            resources.ApplyResources(this.reverseWPsToolStripMenuItem, "reverseWPsToolStripMenuItem");
            this.reverseWPsToolStripMenuItem.Click += new System.EventHandler(this.reverseWPsToolStripMenuItem_Click);
            // 
            // fileLoadSaveToolStripMenuItem
            // 
            this.fileLoadSaveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadWPFileToolStripMenuItem,
            this.loadAndAppendToolStripMenuItem,
            this.saveWPFileToolStripMenuItem,
            this.loadKMLFileToolStripMenuItem,
            this.loadSHPFileToolStripMenuItem});
            this.fileLoadSaveToolStripMenuItem.Name = "fileLoadSaveToolStripMenuItem";
            resources.ApplyResources(this.fileLoadSaveToolStripMenuItem, "fileLoadSaveToolStripMenuItem");
            // 
            // loadWPFileToolStripMenuItem
            // 
            this.loadWPFileToolStripMenuItem.Name = "loadWPFileToolStripMenuItem";
            resources.ApplyResources(this.loadWPFileToolStripMenuItem, "loadWPFileToolStripMenuItem");
            this.loadWPFileToolStripMenuItem.Click += new System.EventHandler(this.loadWPFileToolStripMenuItem_Click);
            // 
            // loadAndAppendToolStripMenuItem
            // 
            this.loadAndAppendToolStripMenuItem.Name = "loadAndAppendToolStripMenuItem";
            resources.ApplyResources(this.loadAndAppendToolStripMenuItem, "loadAndAppendToolStripMenuItem");
            this.loadAndAppendToolStripMenuItem.Click += new System.EventHandler(this.loadAndAppendToolStripMenuItem_Click);
            // 
            // saveWPFileToolStripMenuItem
            // 
            this.saveWPFileToolStripMenuItem.Name = "saveWPFileToolStripMenuItem";
            resources.ApplyResources(this.saveWPFileToolStripMenuItem, "saveWPFileToolStripMenuItem");
            this.saveWPFileToolStripMenuItem.Click += new System.EventHandler(this.saveWPFileToolStripMenuItem_Click);
            // 
            // loadKMLFileToolStripMenuItem
            // 
            this.loadKMLFileToolStripMenuItem.Name = "loadKMLFileToolStripMenuItem";
            resources.ApplyResources(this.loadKMLFileToolStripMenuItem, "loadKMLFileToolStripMenuItem");
            this.loadKMLFileToolStripMenuItem.Click += new System.EventHandler(this.loadKMLFileToolStripMenuItem_Click);
            // 
            // loadSHPFileToolStripMenuItem
            // 
            this.loadSHPFileToolStripMenuItem.Name = "loadSHPFileToolStripMenuItem";
            resources.ApplyResources(this.loadSHPFileToolStripMenuItem, "loadSHPFileToolStripMenuItem");
            this.loadSHPFileToolStripMenuItem.Click += new System.EventHandler(this.loadSHPFileToolStripMenuItem_Click);
            // 
            // pOIToolStripMenuItem
            // 
            this.pOIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poiaddToolStripMenuItem,
            this.poideleteToolStripMenuItem,
            this.poieditToolStripMenuItem});
            this.pOIToolStripMenuItem.Name = "pOIToolStripMenuItem";
            resources.ApplyResources(this.pOIToolStripMenuItem, "pOIToolStripMenuItem");
            // 
            // poiaddToolStripMenuItem
            // 
            this.poiaddToolStripMenuItem.Name = "poiaddToolStripMenuItem";
            resources.ApplyResources(this.poiaddToolStripMenuItem, "poiaddToolStripMenuItem");
            this.poiaddToolStripMenuItem.Click += new System.EventHandler(this.poiaddToolStripMenuItem_Click);
            // 
            // poideleteToolStripMenuItem
            // 
            this.poideleteToolStripMenuItem.Name = "poideleteToolStripMenuItem";
            resources.ApplyResources(this.poideleteToolStripMenuItem, "poideleteToolStripMenuItem");
            this.poideleteToolStripMenuItem.Click += new System.EventHandler(this.poideleteToolStripMenuItem_Click);
            // 
            // poieditToolStripMenuItem
            // 
            this.poieditToolStripMenuItem.Name = "poieditToolStripMenuItem";
            resources.ApplyResources(this.poieditToolStripMenuItem, "poieditToolStripMenuItem");
            this.poieditToolStripMenuItem.Click += new System.EventHandler(this.poieditToolStripMenuItem_Click);
            // 
            // flyToHereToolStripMenuItem
            // 
            this.flyToHereToolStripMenuItem.Name = "flyToHereToolStripMenuItem";
            resources.ApplyResources(this.flyToHereToolStripMenuItem, "flyToHereToolStripMenuItem");
            // 
            // modifyAltToolStripMenuItem
            // 
            this.modifyAltToolStripMenuItem.Name = "modifyAltToolStripMenuItem";
            resources.ApplyResources(this.modifyAltToolStripMenuItem, "modifyAltToolStripMenuItem");
            this.modifyAltToolStripMenuItem.Click += new System.EventHandler(this.modifyAltToolStripMenuItem_Click);
            // 
            // enterUTMCoordToolStripMenuItem
            // 
            this.enterUTMCoordToolStripMenuItem.Name = "enterUTMCoordToolStripMenuItem";
            resources.ApplyResources(this.enterUTMCoordToolStripMenuItem, "enterUTMCoordToolStripMenuItem");
            this.enterUTMCoordToolStripMenuItem.Click += new System.EventHandler(this.enterUTMCoordToolStripMenuItem_Click);
            // 
            // switchDockingToolStripMenuItem
            // 
            this.switchDockingToolStripMenuItem.Name = "switchDockingToolStripMenuItem";
            resources.ApplyResources(this.switchDockingToolStripMenuItem, "switchDockingToolStripMenuItem");
            this.switchDockingToolStripMenuItem.Click += new System.EventHandler(this.switchDockingToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer_time
            // 
            this.timer_time.Interval = 1000;
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // timer_getbreakpoint
            // 
            this.timer_getbreakpoint.Interval = 10;
            this.timer_getbreakpoint.Tick += new System.EventHandler(this.timer_getbreakpoint_Tick);
            // 
            // Messagetabtimer
            // 
            this.Messagetabtimer.Interval = 1000;
            this.Messagetabtimer.Tick += new System.EventHandler(this.Messagetabtimer_Tick);
            // 
            // FlightPlanner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelWaypoints);
            this.Controls.Add(this.panelMap);
            resources.ApplyResources(this, "$this");
            this.Name = "FlightPlanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightPlanner_FormClosing);
            this.Load += new System.EventHandler(this.FlightPlanner_Load);
            this.Resize += new System.EventHandler(this.Planner_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).EndInit();
            this.panelWaypoints.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelShowPoint.ResumeLayout(false);
            this.groupboxOPoint.ResumeLayout(false);
            this.breakpointgroupBox.ResumeLayout(false);
            this.groupBoxBasePoint.ResumeLayout(false);
            this.groupBoxRellyPoint.ResumeLayout(false);
            this.groupBoxAeroPoint.ResumeLayout(false);
            this.ebsPanelMeter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ebsPanelFlyingInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ebsPanelPlanInfo.ResumeLayout(false);
            this.ebsPanelPlanInfo.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ebsPanelWarning.ResumeLayout(false);
            this.ebsPanelWarning.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvibez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGyro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompass)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Controls.MyButton BUT_read;
        private Controls.MyButton BUT_write;
        private System.Windows.Forms.Label lblHAlt;
        private System.Windows.Forms.Label lbljd;
        private System.Windows.Forms.Label lblwd;
        private System.Windows.Forms.TextBox TXT_homealt;
        private System.Windows.Forms.TextBox TXT_homelng;
        private System.Windows.Forms.TextBox TXT_homelat;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView Commands;
        private System.Windows.Forms.CheckBox CHK_verifyheight;
        private Controls.MyButton BUT_Add;
        private System.Windows.Forms.TextBox TXT_WPRad;
        private System.Windows.Forms.TextBox TXT_DefaultAlt;
        private System.Windows.Forms.Label LBL_WPRad;
        private System.Windows.Forms.Label LBL_defalutalt;
        private System.Windows.Forms.TextBox TXT_loiterrad;
        private System.Windows.Forms.Label label5;
        private BSE.Windows.Forms.Panel panelWaypoints;
        private System.Windows.Forms.Panel panelMap;
        private Controls.myGMAP MainMap;
        private Controls.MyTrackBar trackBar1;
        private System.Windows.Forms.Label lbl_distance;
        private System.Windows.Forms.Label lbl_prevdist;
        private System.Windows.Forms.Label lbl_homedist;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem clearMissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPolygonPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loiterForeverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loitertimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loitercirclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpstartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpwPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteWPToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem geoFenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GeoFencedownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setReturnLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem GeoFenceuploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem setROIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoWPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createWpCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextMeasure;
        private System.Windows.Forms.ToolStripMenuItem rotateMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prefetchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kMLOverlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elevationGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeoffToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxMapType;
        private System.Windows.Forms.ToolStripMenuItem fileLoadSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWPFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWPFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flyToHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseWPsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAndAppendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPolygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem insertWpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rallyPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getRallyPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveRallyPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRallyPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearRallyPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadKMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyAltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadFromFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prefetchWPPathToolStripMenuItem;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TXT_altwarn;
        private System.Windows.Forms.ToolStripMenuItem pOIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poiaddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poideleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poieditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterUTMCoordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSHPFileToolStripMenuItem;
        private Controls.Coords coords1;
        private Controls.MyButton BUT_loadwpfile;
        private Controls.MyButton BUT_saveWPFile;
        private System.Windows.Forms.ToolStripMenuItem switchDockingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertSplineWPToolStripMenuItem;
        private System.Windows.Forms.CheckBox CHK_splinedefault;
        private System.Windows.Forms.ToolStripMenuItem createSplineCircleToolStripMenuItem;
        private System.Windows.Forms.ComboBox CMB_altmode;
        private System.Windows.Forms.ToolStripMenuItem fromSHPToolStripMenuItem;
        private System.Windows.Forms.Panel panel6;
        private BSE.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblKeepLiter;
        private System.Windows.Forms.Label label10;
        private Controls.MavlinkNumericUpDown WPNAV_SPEED;
        private Controls.MavlinkNumericUpDown WPNAV_RADIUS;
        private Controls.MavlinkNumericUpDown WPNAV_SPEED_UP;
        private Controls.MavlinkNumericUpDown WPNAV_SPEED_DN;
        private Controls.MavlinkNumericUpDown WPNAV_LOIT_SPEED;
        private Controls.MyButton BUT_writePIDS;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Controls.MyButton myButton1;
        private System.Windows.Forms.Label lblhxj;
        private Controls.MyButton myBtnAddPoint;
        private Controls.MyButton myBtnLimit;
        private System.Windows.Forms.Label lblFlighttime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblDistbetweenlines;
        private System.Windows.Forms.Label lblFlyTime;
        private System.Windows.Forms.Label lblStrips;
        private System.Windows.Forms.Label lblStrip;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblDistance1;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblAero;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanelRoute;
        private Controls.MyButton myBtnSendPoint;
        private Controls.MyButton myBtnLoadAeroPoint;
        private Controls.MyButton myBtnSetRallyPoint;
        private System.Windows.Forms.GroupBox groupBoxRellyPoint;
        private Controls.MyButton myButton2;
        private System.Windows.Forms.GroupBox groupboxOPoint;
        private System.Windows.Forms.GroupBox groupBoxAeroPoint;
        private System.Windows.Forms.GroupBox groupBoxBasePoint;
        private Controls.MyButton myBtnFunction;
        private Controls.MyButton myButtonReadLimitPoint;
        private Controls.MyButton myButtonClearLimitPoint;
        private Controls.MyButton myButton_loadRallypoint;
        private Controls.MyButton myButton_loadlimitpoint;
        private Controls.MyButton myButton_savelimitpoint;
        private Controls.MyButton myButtonDonwloadRallyPoint;
        private System.Windows.Forms.ToolStripMenuItem limitPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeLimitPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readLimitPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLimitPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLimitPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadLimitPointToolStripMenuItem;
        private System.Windows.Forms.Label lblHorizontalError;
        private System.Windows.Forms.Label lblSataCount;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Controls.MyButton BtnClear;
        private System.Windows.Forms.Timer timer_time;
        private Controls.MyButton BUT_quickauto1;
        private Controls.MyButton btnLoiterUnlim;
        private Controls.MyButton BUT_clear_track1;
        private Controls.MyButton BUT_ARM1;
        private Controls.MyButton BUT_quickrtl1;
        private System.Windows.Forms.GroupBox breakpointgroupBox;
        private Controls.MyButton myBtn_write_break_point;
        private Controls.MyButton myBtn_read_break_point;
        private System.Windows.Forms.ToolStripMenuItem breakpointtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getbreakpointtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SendbreakpointtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavebreakpointtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadbreakpointtoolStripMenuItem;
        private System.Windows.Forms.Timer timer_getbreakpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeadinghold;
        private System.Windows.Forms.Label lblDoneArea;
        private System.Windows.Forms.Label lblBearToHome;
        private System.Windows.Forms.Label lblDisToHome;
        private System.Windows.Forms.Label lblDoneArea1;
        private System.Windows.Forms.Label lblBearToHome1;
        private System.Windows.Forms.Label lblDisToHome1;
        private System.Windows.Forms.ToolStripMenuItem movePointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToRightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exchangeToolStripMenuItem;
        private System.Windows.Forms.Timer timer_GetMapPoint;
        private Controls.MyButton myButtonLand;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblLD;
        private System.Windows.Forms.Label lblvibez;
        private System.Windows.Forms.PictureBox pictureBoxLD;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.Label lblGyro;
        private System.Windows.Forms.Label lblCompass;
        private System.Windows.Forms.PictureBox pictureBoxGPS;
        private System.Windows.Forms.Label lblAccel;
        private System.Windows.Forms.Label lblGPS;
        private System.Windows.Forms.PictureBox pictureBoxLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.PictureBox pictureBoxAccel;
        private System.Windows.Forms.PictureBox pictureBoxReceiver;
        private System.Windows.Forms.PictureBox pictureBoxvibez;
        private System.Windows.Forms.PictureBox pictureBoxGyro;
        private System.Windows.Forms.PictureBox pictureBoxCompass;
        private System.Windows.Forms.Label lblStaCount;
        private System.Windows.Forms.Label lblHorizontal;
        private System.Windows.Forms.Label lblTime;
        private BSE.Windows.Forms.Panel ebsPanelWarning;
        private BSE.Windows.Forms.Panel ebsPanelPlanInfo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel2;
        private Controls.QuickView Qvgroundspeed;
        private Controls.QuickView QVSonarRange;
        private Controls.QuickView Qvverspeed;
        private Controls.QuickView Qvalt;
        private Controls.QuickView Qvdist;
        private Controls.QuickView qvpitch;
        private Controls.QuickView Qvtohome;
        private Controls.QuickView qvyaw;
        private Controls.QuickView qvroll;
        private System.Windows.Forms.TextBox txt_messagebox;
        private BSE.Windows.Forms.Panel ebsPanelFlyingInfo;
        private System.Windows.Forms.Timer Messagetabtimer;
        private Controls.HUD hud1;
        private BSE.Windows.Forms.Panel ebsPanelMeter;
        private Controls.MyButton btnAutoPan;
        private Controls.MyButton btnMeterInfo;
        private Controls.MyButton btnWarnning;
        private Controls.MyButton btnPlanInfo;
        private Controls.MyButton btnFlyingInfo;
        private BSE.Windows.Forms.Panel panelShowPoint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waypno;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Up;
        private System.Windows.Forms.DataGridViewImageColumn Down;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AZ;
    }
}