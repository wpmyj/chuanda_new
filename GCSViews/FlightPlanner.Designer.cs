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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Commands = new System.Windows.Forms.DataGridView();
            this.Command = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Param1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Param4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alt = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.myButton1 = new ByAeroBeHero.Controls.MyButton();
            this.BUT_writePIDS = new ByAeroBeHero.Controls.MyButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblKeepLiter = new System.Windows.Forms.Label();
            this.WPNAV_SPEED = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.WPNAV_RADIUS = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.WPNAV_SPEED_UP = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.WPNAV_SPEED_DN = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.WPNAV_LOIT_SPEED = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.TXT_altwarn = new System.Windows.Forms.TextBox();
            this.CMB_altmode = new System.Windows.Forms.ComboBox();
            this.CHK_splinedefault = new System.Windows.Forms.CheckBox();
            this.BUT_Add = new ByAeroBeHero.Controls.MyButton();
            this.comboBoxMapType = new System.Windows.Forms.ComboBox();
            this.BUT_loadwpfile = new ByAeroBeHero.Controls.MyButton();
            this.BUT_saveWPFile = new ByAeroBeHero.Controls.MyButton();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panelShowPoint = new System.Windows.Forms.Panel();
            this.breakpointgroupBox = new System.Windows.Forms.GroupBox();
            this.myBtn_write_break_point = new ByAeroBeHero.Controls.MyButton();
            this.myBtn_read_break_point = new ByAeroBeHero.Controls.MyButton();
            this.groupBoxRellyPoint = new System.Windows.Forms.GroupBox();
            this.myButtonDonwloadRallyPoint = new ByAeroBeHero.Controls.MyButton();
            this.myButton_loadRallypoint = new ByAeroBeHero.Controls.MyButton();
            this.myButton2 = new ByAeroBeHero.Controls.MyButton();
            this.myBtnSetRallyPoint = new ByAeroBeHero.Controls.MyButton();
            this.groupboxOPoint = new System.Windows.Forms.GroupBox();
            this.myButton_savelimitpoint = new ByAeroBeHero.Controls.MyButton();
            this.myButton_loadlimitpoint = new ByAeroBeHero.Controls.MyButton();
            this.myButtonReadLimitPoint = new ByAeroBeHero.Controls.MyButton();
            this.myButtonClearLimitPoint = new ByAeroBeHero.Controls.MyButton();
            this.myBtnLimit = new ByAeroBeHero.Controls.MyButton();
            this.myBtnSendPoint = new ByAeroBeHero.Controls.MyButton();
            this.groupBoxAeroPoint = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelRoute = new System.Windows.Forms.TableLayoutPanel();
            this.myBtnLoadAeroPoint = new ByAeroBeHero.Controls.MyButton();
            this.myBtnAddPoint = new ByAeroBeHero.Controls.MyButton();
            this.groupBoxBasePoint = new System.Windows.Forms.GroupBox();
            this.panelShowInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDoneArea1 = new System.Windows.Forms.Label();
            this.lblDoneArea = new System.Windows.Forms.Label();
            this.lblBearToHome1 = new System.Windows.Forms.Label();
            this.lblBearToHome = new System.Windows.Forms.Label();
            this.lblDisToHome1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblAero = new System.Windows.Forms.Label();
            this.lblStrips = new System.Windows.Forms.Label();
            this.lblStrip = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblDistance1 = new System.Windows.Forms.Label();
            this.lblDistbetweenlines = new System.Windows.Forms.Label();
            this.lblFlyTime = new System.Windows.Forms.Label();
            this.lblFlighttime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeadinghold = new System.Windows.Forms.Label();
            this.lblDisToHome = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.lbl_homedist = new System.Windows.Forms.Label();
            this.lbl_prevdist = new System.Windows.Forms.Label();
            this.lblhxj = new System.Windows.Forms.Label();
            this.lblHorizontalError = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblSataCount = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.BtnClear = new ByAeroBeHero.Controls.MyButton();
            this.CHK_autopan = new System.Windows.Forms.CheckBox();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPolygonPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPolygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromSHPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.trackBar1 = new ByAeroBeHero.Controls.MyTrackBar();
            this.panelBASE = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BUT_quickrtl1 = new ByAeroBeHero.Controls.MyButton();
            this.BUT_quickauto1 = new ByAeroBeHero.Controls.MyButton();
            this.btnLoiterUnlim = new ByAeroBeHero.Controls.MyButton();
            this.BUT_clear_track1 = new ByAeroBeHero.Controls.MyButton();
            this.BUT_ARM1 = new ByAeroBeHero.Controls.MyButton();
            this.myBtnFunction = new ByAeroBeHero.Controls.MyButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.timer_getbreakpoint = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).BeginInit();
            this.panelWaypoints.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WPNAV_SPEED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPNAV_RADIUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPNAV_SPEED_UP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPNAV_SPEED_DN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPNAV_LOIT_SPEED)).BeginInit();
            this.panelMap.SuspendLayout();
            this.panelShowPoint.SuspendLayout();
            this.breakpointgroupBox.SuspendLayout();
            this.groupBoxRellyPoint.SuspendLayout();
            this.groupboxOPoint.SuspendLayout();
            this.groupBoxAeroPoint.SuspendLayout();
            this.groupBoxBasePoint.SuspendLayout();
            this.panelShowInfo.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panelBASE.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Commands
            // 
            this.Commands.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            this.Commands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Commands.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
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
            this.Delete,
            this.Up,
            this.Down,
            this.Grad,
            this.Dist,
            this.AZ});
            this.Commands.EnableHeadersVisualStyles = false;
            this.Commands.GridColor = System.Drawing.Color.Cyan;
            this.Commands.Name = "Commands";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.Format = "N0";
            dataGridViewCellStyle16.NullValue = "0";
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.Commands.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Turquoise;
            this.Commands.RowsDefaultCellStyle = dataGridViewCellStyle17;
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
            this.BUT_write.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BUT_write.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.BUT_write, "BUT_write");
            this.BUT_write.Name = "BUT_write";
            this.BUT_write.UseVisualStyleBackColor = true;
            this.BUT_write.Click += new System.EventHandler(this.BUT_write_Click);
            // 
            // BUT_read
            // 
            this.BUT_read.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BUT_read.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle19;
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
            this.panelWaypoints.CaptionFont = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelWaypoints.CaptionHeight = 27;
            this.panelWaypoints.Controls.Add(this.myButton1);
            this.panelWaypoints.Controls.Add(this.BUT_writePIDS);
            this.panelWaypoints.Controls.Add(this.tableLayoutPanel2);
            this.panelWaypoints.Controls.Add(this.CMB_altmode);
            this.panelWaypoints.Controls.Add(this.CHK_splinedefault);
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
            resources.ApplyResources(this.panelWaypoints, "panelWaypoints");
            this.panelWaypoints.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelWaypoints.Image = null;
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
            // myButton1
            // 
            this.myButton1.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myButton1.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.Name = "myButton1";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.BUT_refreshpart_Click);
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
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
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
            this.tableLayoutPanel3.Controls.Add(this.WPNAV_SPEED, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.WPNAV_RADIUS, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.WPNAV_SPEED_UP, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.WPNAV_SPEED_DN, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.WPNAV_LOIT_SPEED, 5, 1);
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
            // WPNAV_SPEED
            // 
            resources.ApplyResources(this.WPNAV_SPEED, "WPNAV_SPEED");
            this.WPNAV_SPEED.Max = 1F;
            this.WPNAV_SPEED.Min = 0F;
            this.WPNAV_SPEED.Name = "WPNAV_SPEED";
            this.WPNAV_SPEED.ParamName = null;
            this.WPNAV_SPEED.ValueUpdated += new System.EventHandler(this.numeric_ValueUpdated);
            // 
            // WPNAV_RADIUS
            // 
            resources.ApplyResources(this.WPNAV_RADIUS, "WPNAV_RADIUS");
            this.WPNAV_RADIUS.Max = 1F;
            this.WPNAV_RADIUS.Min = 0F;
            this.WPNAV_RADIUS.Name = "WPNAV_RADIUS";
            this.WPNAV_RADIUS.ParamName = null;
            this.WPNAV_RADIUS.ValueUpdated += new System.EventHandler(this.numeric_ValueUpdated);
            // 
            // WPNAV_SPEED_UP
            // 
            resources.ApplyResources(this.WPNAV_SPEED_UP, "WPNAV_SPEED_UP");
            this.WPNAV_SPEED_UP.Max = 1F;
            this.WPNAV_SPEED_UP.Min = 0F;
            this.WPNAV_SPEED_UP.Name = "WPNAV_SPEED_UP";
            this.WPNAV_SPEED_UP.ParamName = null;
            this.WPNAV_SPEED_UP.ValueUpdated += new System.EventHandler(this.numeric_ValueUpdated);
            // 
            // WPNAV_SPEED_DN
            // 
            resources.ApplyResources(this.WPNAV_SPEED_DN, "WPNAV_SPEED_DN");
            this.WPNAV_SPEED_DN.Max = 1F;
            this.WPNAV_SPEED_DN.Min = 0F;
            this.WPNAV_SPEED_DN.Name = "WPNAV_SPEED_DN";
            this.WPNAV_SPEED_DN.ParamName = null;
            this.WPNAV_SPEED_DN.ValueUpdated += new System.EventHandler(this.numeric_ValueUpdated);
            // 
            // WPNAV_LOIT_SPEED
            // 
            resources.ApplyResources(this.WPNAV_LOIT_SPEED, "WPNAV_LOIT_SPEED");
            this.WPNAV_LOIT_SPEED.Max = 1F;
            this.WPNAV_LOIT_SPEED.Min = 0F;
            this.WPNAV_LOIT_SPEED.Name = "WPNAV_LOIT_SPEED";
            this.WPNAV_LOIT_SPEED.ParamName = null;
            this.WPNAV_LOIT_SPEED.ValueUpdated += new System.EventHandler(this.numeric_ValueUpdated);
            // 
            // TXT_altwarn
            // 
            resources.ApplyResources(this.TXT_altwarn, "TXT_altwarn");
            this.TXT_altwarn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TXT_altwarn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_altwarn.Name = "TXT_altwarn";
            // 
            // CMB_altmode
            // 
            this.CMB_altmode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.CMB_altmode, "CMB_altmode");
            this.CMB_altmode.FormattingEnabled = true;
            this.CMB_altmode.Name = "CMB_altmode";
            this.CMB_altmode.SelectedIndexChanged += new System.EventHandler(this.CMB_altmode_SelectedIndexChanged);
            // 
            // CHK_splinedefault
            // 
            resources.ApplyResources(this.CHK_splinedefault, "CHK_splinedefault");
            this.CHK_splinedefault.BackColor = System.Drawing.Color.Black;
            this.CHK_splinedefault.Name = "CHK_splinedefault";
            this.CHK_splinedefault.UseVisualStyleBackColor = false;
            this.CHK_splinedefault.CheckedChanged += new System.EventHandler(this.CHK_splinedefault_CheckedChanged);
            // 
            // BUT_Add
            // 
            this.BUT_Add.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BUT_Add.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.BUT_Add, "BUT_Add");
            this.BUT_Add.Name = "BUT_Add";
            this.toolTip1.SetToolTip(this.BUT_Add, resources.GetString("BUT_Add.ToolTip"));
            this.BUT_Add.UseVisualStyleBackColor = true;
            this.BUT_Add.Click += new System.EventHandler(this.BUT_Add_Click);
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
            this.panelMap.BackColor = System.Drawing.Color.Black;
            this.panelMap.Controls.Add(this.panelShowPoint);
            this.panelMap.Controls.Add(this.panelShowInfo);
            this.panelMap.Controls.Add(this.tableLayoutPanel5);
            this.panelMap.Controls.Add(this.MainMap);
            this.panelMap.Controls.Add(this.trackBar1);
            resources.ApplyResources(this.panelMap, "panelMap");
            this.panelMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMap.Name = "panelMap";
            this.panelMap.Resize += new System.EventHandler(this.panelMap_Resize);
            // 
            // panelShowPoint
            // 
            this.panelShowPoint.BackColor = System.Drawing.Color.Black;
            this.panelShowPoint.Controls.Add(this.breakpointgroupBox);
            this.panelShowPoint.Controls.Add(this.groupBoxRellyPoint);
            this.panelShowPoint.Controls.Add(this.groupboxOPoint);
            this.panelShowPoint.Controls.Add(this.groupBoxAeroPoint);
            this.panelShowPoint.Controls.Add(this.groupBoxBasePoint);
            resources.ApplyResources(this.panelShowPoint, "panelShowPoint");
            this.panelShowPoint.Name = "panelShowPoint";
            // 
            // breakpointgroupBox
            // 
            this.breakpointgroupBox.Controls.Add(this.myBtn_write_break_point);
            this.breakpointgroupBox.Controls.Add(this.myBtn_read_break_point);
            this.breakpointgroupBox.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.breakpointgroupBox, "breakpointgroupBox");
            this.breakpointgroupBox.Name = "breakpointgroupBox";
            this.breakpointgroupBox.TabStop = false;
            // 
            // myBtn_write_break_point
            // 
            resources.ApplyResources(this.myBtn_write_break_point, "myBtn_write_break_point");
            this.myBtn_write_break_point.Name = "myBtn_write_break_point";
            this.myBtn_write_break_point.UseVisualStyleBackColor = true;
            this.myBtn_write_break_point.Click += new System.EventHandler(this.myBtn_write_break_point_Click);
            // 
            // myBtn_read_break_point
            // 
            resources.ApplyResources(this.myBtn_read_break_point, "myBtn_read_break_point");
            this.myBtn_read_break_point.Name = "myBtn_read_break_point";
            this.myBtn_read_break_point.UseVisualStyleBackColor = true;
            this.myBtn_read_break_point.Click += new System.EventHandler(this.myBtn_read_break_point_Click);
            // 
            // groupBoxRellyPoint
            // 
            this.groupBoxRellyPoint.BackColor = System.Drawing.Color.Black;
            this.groupBoxRellyPoint.Controls.Add(this.myButtonDonwloadRallyPoint);
            this.groupBoxRellyPoint.Controls.Add(this.myButton_loadRallypoint);
            this.groupBoxRellyPoint.Controls.Add(this.myButton2);
            this.groupBoxRellyPoint.Controls.Add(this.myBtnSetRallyPoint);
            this.groupBoxRellyPoint.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.groupBoxRellyPoint, "groupBoxRellyPoint");
            this.groupBoxRellyPoint.Name = "groupBoxRellyPoint";
            this.groupBoxRellyPoint.TabStop = false;
            // 
            // myButtonDonwloadRallyPoint
            // 
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
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.Name = "myButton2";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.saveRallyPointsToolStripMenuItem_Click);
            // 
            // myBtnSetRallyPoint
            // 
            resources.ApplyResources(this.myBtnSetRallyPoint, "myBtnSetRallyPoint");
            this.myBtnSetRallyPoint.Name = "myBtnSetRallyPoint";
            this.myBtnSetRallyPoint.UseVisualStyleBackColor = true;
            this.myBtnSetRallyPoint.Click += new System.EventHandler(this.setRallyPoint_Click);
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
            // groupBoxAeroPoint
            // 
            this.groupBoxAeroPoint.Controls.Add(this.tableLayoutPanelRoute);
            this.groupBoxAeroPoint.Controls.Add(this.myBtnLoadAeroPoint);
            this.groupBoxAeroPoint.Controls.Add(this.myBtnAddPoint);
            this.groupBoxAeroPoint.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.groupBoxAeroPoint, "groupBoxAeroPoint");
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
            resources.ApplyResources(this.myBtnAddPoint, "myBtnAddPoint");
            this.myBtnAddPoint.Name = "myBtnAddPoint";
            this.myBtnAddPoint.UseVisualStyleBackColor = true;
            this.myBtnAddPoint.Click += new System.EventHandler(this.myBtnAddPoint_Click);
            // 
            // groupBoxBasePoint
            // 
            this.groupBoxBasePoint.Controls.Add(this.BUT_loadwpfile);
            this.groupBoxBasePoint.Controls.Add(this.BUT_write);
            this.groupBoxBasePoint.Controls.Add(this.BUT_read);
            this.groupBoxBasePoint.Controls.Add(this.BUT_saveWPFile);
            this.groupBoxBasePoint.Controls.Add(this.BUT_Add);
            this.groupBoxBasePoint.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.groupBoxBasePoint, "groupBoxBasePoint");
            this.groupBoxBasePoint.Name = "groupBoxBasePoint";
            this.groupBoxBasePoint.TabStop = false;
            // 
            // panelShowInfo
            // 
            this.panelShowInfo.BackColor = System.Drawing.Color.Black;
            this.panelShowInfo.Controls.Add(this.tableLayoutPanel7);
            resources.ApplyResources(this.panelShowInfo, "panelShowInfo");
            this.panelShowInfo.Name = "panelShowInfo";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.Controls.Add(this.lblDoneArea1, 5, 2);
            this.tableLayoutPanel7.Controls.Add(this.lblDoneArea, 4, 2);
            this.tableLayoutPanel7.Controls.Add(this.lblBearToHome1, 5, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblBearToHome, 4, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblDisToHome1, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblArea, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblAero, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblStrips, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblStrip, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblDistance, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblDistance1, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblDistbetweenlines, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblFlyTime, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.lblFlighttime, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.label1, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.lblHeadinghold, 3, 2);
            this.tableLayoutPanel7.Controls.Add(this.lblDisToHome, 4, 0);
            this.tableLayoutPanel7.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // lblDoneArea1
            // 
            resources.ApplyResources(this.lblDoneArea1, "lblDoneArea1");
            this.lblDoneArea1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDoneArea1.Name = "lblDoneArea1";
            // 
            // lblDoneArea
            // 
            resources.ApplyResources(this.lblDoneArea, "lblDoneArea");
            this.lblDoneArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDoneArea.Name = "lblDoneArea";
            // 
            // lblBearToHome1
            // 
            resources.ApplyResources(this.lblBearToHome1, "lblBearToHome1");
            this.lblBearToHome1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBearToHome1.Name = "lblBearToHome1";
            // 
            // lblBearToHome
            // 
            resources.ApplyResources(this.lblBearToHome, "lblBearToHome");
            this.lblBearToHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBearToHome.Name = "lblBearToHome";
            // 
            // lblDisToHome1
            // 
            resources.ApplyResources(this.lblDisToHome1, "lblDisToHome1");
            this.lblDisToHome1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisToHome1.Name = "lblDisToHome1";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Name = "label15";
            // 
            // lblArea
            // 
            resources.ApplyResources(this.lblArea, "lblArea");
            this.lblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArea.Name = "lblArea";
            // 
            // lblAero
            // 
            resources.ApplyResources(this.lblAero, "lblAero");
            this.lblAero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAero.ForeColor = System.Drawing.Color.White;
            this.lblAero.Name = "lblAero";
            // 
            // lblStrips
            // 
            resources.ApplyResources(this.lblStrips, "lblStrips");
            this.lblStrips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStrips.Name = "lblStrips";
            // 
            // lblStrip
            // 
            resources.ApplyResources(this.lblStrip, "lblStrip");
            this.lblStrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStrip.ForeColor = System.Drawing.Color.White;
            this.lblStrip.Name = "lblStrip";
            // 
            // lblDistance
            // 
            resources.ApplyResources(this.lblDistance, "lblDistance");
            this.lblDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistance.Name = "lblDistance";
            // 
            // lblDistance1
            // 
            resources.ApplyResources(this.lblDistance1, "lblDistance1");
            this.lblDistance1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistance1.ForeColor = System.Drawing.Color.White;
            this.lblDistance1.Name = "lblDistance1";
            // 
            // lblDistbetweenlines
            // 
            resources.ApplyResources(this.lblDistbetweenlines, "lblDistbetweenlines");
            this.lblDistbetweenlines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistbetweenlines.Name = "lblDistbetweenlines";
            // 
            // lblFlyTime
            // 
            resources.ApplyResources(this.lblFlyTime, "lblFlyTime");
            this.lblFlyTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlyTime.ForeColor = System.Drawing.Color.White;
            this.lblFlyTime.Name = "lblFlyTime";
            // 
            // lblFlighttime
            // 
            resources.ApplyResources(this.lblFlighttime, "lblFlighttime");
            this.lblFlighttime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFlighttime.Name = "lblFlighttime";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Name = "label1";
            // 
            // lblHeadinghold
            // 
            resources.ApplyResources(this.lblHeadinghold, "lblHeadinghold");
            this.lblHeadinghold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeadinghold.Name = "lblHeadinghold";
            // 
            // lblDisToHome
            // 
            resources.ApplyResources(this.lblDisToHome, "lblDisToHome");
            this.lblDisToHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisToHome.Name = "lblDisToHome";
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
            this.tableLayoutPanel5.Controls.Add(this.lblHorizontalError, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblSataCount, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblShowTime, 7, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtnClear, 8, 0);
            this.tableLayoutPanel5.Controls.Add(this.CHK_autopan, 9, 0);
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
            // lblHorizontalError
            // 
            resources.ApplyResources(this.lblHorizontalError, "lblHorizontalError");
            this.lblHorizontalError.BackColor = System.Drawing.Color.Black;
            this.lblHorizontalError.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "gpshdop", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "GPS水平误差: 0.0"));
            this.lblHorizontalError.ForeColor = System.Drawing.Color.White;
            this.lblHorizontalError.Name = "lblHorizontalError";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(ByAeroBeHero.CurrentState);
            // 
            // lblSataCount
            // 
            resources.ApplyResources(this.lblSataCount, "lblSataCount");
            this.lblSataCount.BackColor = System.Drawing.Color.Black;
            this.lblSataCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "satcount", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "卫星数量: 0"));
            this.lblSataCount.ForeColor = System.Drawing.Color.White;
            this.lblSataCount.Name = "lblSataCount";
            // 
            // lblShowTime
            // 
            resources.ApplyResources(this.lblShowTime, "lblShowTime");
            this.lblShowTime.ForeColor = System.Drawing.Color.White;
            this.lblShowTime.Name = "lblShowTime";
            // 
            // BtnClear
            // 
            resources.ApplyResources(this.BtnClear, "BtnClear");
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClearClick);
            // 
            // CHK_autopan
            // 
            resources.ApplyResources(this.CHK_autopan, "CHK_autopan");
            this.CHK_autopan.ForeColor = System.Drawing.Color.White;
            this.CHK_autopan.Name = "CHK_autopan";
            this.CHK_autopan.UseVisualStyleBackColor = true;
            this.CHK_autopan.CheckedChanged += new System.EventHandler(this.CHK_autopan_CheckedChanged);
            // 
            // MainMap
            // 
            this.MainMap.BackColor = System.Drawing.Color.Black;
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.ContextMenuStrip = this.contextMenuStrip1;
            this.MainMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Gray;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            resources.ApplyResources(this.MainMap, "MainMap");
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 24;
            this.MainMap.MinZoom = 5;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Zoom = 5D;
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
            this.fromSHPToolStripMenuItem});
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
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 2F;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // panelBASE
            // 
            this.panelBASE.BackColor = System.Drawing.Color.Black;
            this.panelBASE.Controls.Add(this.splitter1);
            this.panelBASE.Controls.Add(this.tableLayoutPanel1);
            this.panelBASE.Controls.Add(this.panelWaypoints);
            resources.ApplyResources(this.panelBASE, "panelBASE");
            this.panelBASE.Name = "panelBASE";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panelMap, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.BUT_quickrtl1);
            this.panel6.Controls.Add(this.BUT_quickauto1);
            this.panel6.Controls.Add(this.btnLoiterUnlim);
            this.panel6.Controls.Add(this.BUT_clear_track1);
            this.panel6.Controls.Add(this.BUT_ARM1);
            this.panel6.Controls.Add(this.myBtnFunction);
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
            // BUT_quickauto1
            // 
            resources.ApplyResources(this.BUT_quickauto1, "BUT_quickauto1");
            this.BUT_quickauto1.Name = "BUT_quickauto1";
            this.BUT_quickauto1.UseVisualStyleBackColor = true;
            this.BUT_quickauto1.Click += new System.EventHandler(this.BUT_quickauto_Click);
            // 
            // btnLoiterUnlim
            // 
            resources.ApplyResources(this.btnLoiterUnlim, "btnLoiterUnlim");
            this.btnLoiterUnlim.Name = "btnLoiterUnlim";
            this.btnLoiterUnlim.UseVisualStyleBackColor = true;
            this.btnLoiterUnlim.Click += new System.EventHandler(this.btnLoiterUnlim_Click);
            // 
            // BUT_clear_track1
            // 
            resources.ApplyResources(this.BUT_clear_track1, "BUT_clear_track1");
            this.BUT_clear_track1.Name = "BUT_clear_track1";
            this.BUT_clear_track1.UseVisualStyleBackColor = true;
            this.BUT_clear_track1.Click += new System.EventHandler(this.BUT_clear_track_Click);
            // 
            // BUT_ARM1
            // 
            resources.ApplyResources(this.BUT_ARM1, "BUT_ARM1");
            this.BUT_ARM1.Name = "BUT_ARM1";
            this.BUT_ARM1.UseVisualStyleBackColor = true;
            this.BUT_ARM1.Click += new System.EventHandler(this.BUT_ARM_Click);
            // 
            // myBtnFunction
            // 
            resources.ApplyResources(this.myBtnFunction, "myBtnFunction");
            this.myBtnFunction.Name = "myBtnFunction";
            this.myBtnFunction.UseVisualStyleBackColor = true;
            this.myBtnFunction.Click += new System.EventHandler(this.myBtnFunction_Click);
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
            // FlightPlanner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panelBASE);
            resources.ApplyResources(this, "$this");
            this.Name = "FlightPlanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightPlanner_FormClosing);
            this.Load += new System.EventHandler(this.FlightPlanner_Load);
            this.Resize += new System.EventHandler(this.Planner_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Commands)).EndInit();
            this.panelWaypoints.ResumeLayout(false);
            this.panelWaypoints.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WPNAV_SPEED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPNAV_RADIUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPNAV_SPEED_UP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPNAV_SPEED_DN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WPNAV_LOIT_SPEED)).EndInit();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            this.panelShowPoint.ResumeLayout(false);
            this.breakpointgroupBox.ResumeLayout(false);
            this.groupBoxRellyPoint.ResumeLayout(false);
            this.groupboxOPoint.ResumeLayout(false);
            this.groupBoxAeroPoint.ResumeLayout(false);
            this.groupBoxBasePoint.ResumeLayout(false);
            this.panelShowInfo.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panelBASE.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
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
        private System.Windows.Forms.Panel panelBASE;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Panel panelShowInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
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
        private System.Windows.Forms.Panel panelShowPoint;
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
        private System.Windows.Forms.CheckBox CHK_autopan;
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
        private System.Windows.Forms.DataGridViewComboBoxColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Param4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alt;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Up;
        private System.Windows.Forms.DataGridViewImageColumn Down;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dist;
        private System.Windows.Forms.DataGridViewTextBoxColumn AZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeadinghold;
        private System.Windows.Forms.Label lblDoneArea;
        private System.Windows.Forms.Label lblBearToHome;
        private System.Windows.Forms.Label lblDisToHome;
        private System.Windows.Forms.Label lblDoneArea1;
        private System.Windows.Forms.Label lblBearToHome1;
        private System.Windows.Forms.Label lblDisToHome1;
    }
}