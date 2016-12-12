namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    partial class ConfigSetParams
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
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigSetParams));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_RTL_ALT = new System.Windows.Forms.Label();
            this.lbl_RTL_ALT_F = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblYawBehavior = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NUM_movelength = new System.Windows.Forms.NumericUpDown();
            this.tboxWriteV = new System.Windows.Forms.TextBox();
            this.WP_YAW_BEHAVIOR = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.RTL_ALT_P = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.lblMoveDistance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RTL_ALT_FINAL = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.panelArmCheck = new System.Windows.Forms.Panel();
            this.ARMING_CHECK = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.lblArmCheck = new System.Windows.Forms.Label();
            this.myButton2 = new ByAeroBeHero.Controls.MyButton();
            this.Btn_ = new ByAeroBeHero.Controls.MyButton();
            this.lblAllMove = new System.Windows.Forms.Label();
            this.chb_AllMove = new System.Windows.Forms.CheckBox();
            this.lblCheckSpeech = new System.Windows.Forms.Label();
            this.CHK_enablespeech = new System.Windows.Forms.CheckBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.CHK_speechwaypoint = new System.Windows.Forms.CheckBox();
            this.CHK_speechotherParams = new System.Windows.Forms.CheckBox();
            this.CHK_speechflightParams = new System.Windows.Forms.CheckBox();
            this.panel1 = new BSE.Windows.Forms.Panel();
            this.SPRAY_WRAP_EN = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.lblChangeRow = new System.Windows.Forms.Label();
            this.lblVNo = new System.Windows.Forms.Label();
            this.lblVVNo = new System.Windows.Forms.Label();
            this.panel2 = new BSE.Windows.Forms.Panel();
            this.panel3 = new BSE.Windows.Forms.Panel();
            this.pSetParams = new BSE.Windows.Forms.Panel();
            this.chbShow_AllParams = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_movelength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_P)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_FINAL)).BeginInit();
            this.panelArmCheck.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pSetParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_RTL_ALT
            // 
            resources.ApplyResources(this.lbl_RTL_ALT, "lbl_RTL_ALT");
            this.lbl_RTL_ALT.Name = "lbl_RTL_ALT";
            // 
            // lbl_RTL_ALT_F
            // 
            resources.ApplyResources(this.lbl_RTL_ALT_F, "lbl_RTL_ALT_F");
            this.lbl_RTL_ALT_F.Name = "lbl_RTL_ALT_F";
            // 
            // lblUnit
            // 
            resources.ApplyResources(this.lblUnit, "lblUnit");
            this.lblUnit.Name = "lblUnit";
            // 
            // lblYawBehavior
            // 
            resources.ApplyResources(this.lblYawBehavior, "lblYawBehavior");
            this.lblYawBehavior.Name = "lblYawBehavior";
            // 
            // NUM_movelength
            // 
            this.NUM_movelength.BackColor = System.Drawing.SystemColors.Window;
            this.NUM_movelength.DecimalPlaces = 1;
            resources.ApplyResources(this.NUM_movelength, "NUM_movelength");
            this.NUM_movelength.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NUM_movelength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NUM_movelength.Name = "NUM_movelength";
            this.toolTip1.SetToolTip(this.NUM_movelength, resources.GetString("NUM_movelength.ToolTip"));
            this.toolTip2.SetToolTip(this.NUM_movelength, resources.GetString("NUM_movelength.ToolTip1"));
            this.NUM_movelength.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.NUM_movelength.ValueChanged += new System.EventHandler(this.NUM_movelength_ValueChanged);
            // 
            // tboxWriteV
            // 
            resources.ApplyResources(this.tboxWriteV, "tboxWriteV");
            this.tboxWriteV.Name = "tboxWriteV";
            this.toolTip1.SetToolTip(this.tboxWriteV, resources.GetString("tboxWriteV.ToolTip"));
            this.tboxWriteV.TextChanged += new System.EventHandler(this.tboxWriteV_TextChanged);
            this.tboxWriteV.Resize += new System.EventHandler(this.tboxWriteV_Resize);
            // 
            // WP_YAW_BEHAVIOR
            // 
            this.WP_YAW_BEHAVIOR.BackColor = System.Drawing.Color.Black;
            this.WP_YAW_BEHAVIOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.WP_YAW_BEHAVIOR, "WP_YAW_BEHAVIOR");
            this.WP_YAW_BEHAVIOR.ForeColor = System.Drawing.Color.White;
            this.WP_YAW_BEHAVIOR.FormattingEnabled = true;
            this.WP_YAW_BEHAVIOR.Name = "WP_YAW_BEHAVIOR";
            this.WP_YAW_BEHAVIOR.ParamName = null;
            this.WP_YAW_BEHAVIOR.SubControl = null;
            this.WP_YAW_BEHAVIOR.Tag = "";
            this.toolTip1.SetToolTip(this.WP_YAW_BEHAVIOR, resources.GetString("WP_YAW_BEHAVIOR.ToolTip"));
            // 
            // RTL_ALT_P
            // 
            this.RTL_ALT_P.BackColor = System.Drawing.Color.Black;
            this.RTL_ALT_P.DecimalPlaces = 1;
            resources.ApplyResources(this.RTL_ALT_P, "RTL_ALT_P");
            this.RTL_ALT_P.ForeColor = System.Drawing.Color.White;
            this.RTL_ALT_P.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RTL_ALT_P.Max = 1F;
            this.RTL_ALT_P.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.RTL_ALT_P.Min = 0F;
            this.RTL_ALT_P.Name = "RTL_ALT_P";
            this.RTL_ALT_P.ParamName = null;
            this.toolTip1.SetToolTip(this.RTL_ALT_P, resources.GetString("RTL_ALT_P.ToolTip"));
            this.toolTip2.SetToolTip(this.RTL_ALT_P, resources.GetString("RTL_ALT_P.ToolTip1"));
            this.RTL_ALT_P.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RTL_ALT_P.ValueUpdated += new System.EventHandler(this.numeric_ValueUpdated);
            // 
            // lblMoveDistance
            // 
            resources.ApplyResources(this.lblMoveDistance, "lblMoveDistance");
            this.lblMoveDistance.Name = "lblMoveDistance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_RTL_ALT_F);
            this.groupBox1.Controls.Add(this.RTL_ALT_FINAL);
            this.groupBox1.Controls.Add(this.lblUnit);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // RTL_ALT_FINAL
            // 
            this.RTL_ALT_FINAL.DecimalPlaces = 1;
            resources.ApplyResources(this.RTL_ALT_FINAL, "RTL_ALT_FINAL");
            this.RTL_ALT_FINAL.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.RTL_ALT_FINAL.Max = 1F;
            this.RTL_ALT_FINAL.Min = 0F;
            this.RTL_ALT_FINAL.Name = "RTL_ALT_FINAL";
            this.RTL_ALT_FINAL.ParamName = null;
            this.RTL_ALT_FINAL.ValueUpdated += new System.EventHandler(this.numeric_ValueUpdated);
            // 
            // panelArmCheck
            // 
            this.panelArmCheck.BackColor = System.Drawing.Color.Transparent;
            this.panelArmCheck.Controls.Add(this.WP_YAW_BEHAVIOR);
            this.panelArmCheck.Controls.Add(this.lblYawBehavior);
            this.panelArmCheck.Controls.Add(this.ARMING_CHECK);
            this.panelArmCheck.Controls.Add(this.lblArmCheck);
            resources.ApplyResources(this.panelArmCheck, "panelArmCheck");
            this.panelArmCheck.Name = "panelArmCheck";
            // 
            // ARMING_CHECK
            // 
            this.ARMING_CHECK.BackColor = System.Drawing.Color.Black;
            this.ARMING_CHECK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ARMING_CHECK, "ARMING_CHECK");
            this.ARMING_CHECK.ForeColor = System.Drawing.Color.White;
            this.ARMING_CHECK.FormattingEnabled = true;
            this.ARMING_CHECK.Name = "ARMING_CHECK";
            this.ARMING_CHECK.ParamName = null;
            this.ARMING_CHECK.SubControl = null;
            this.ARMING_CHECK.Tag = "";
            // 
            // lblArmCheck
            // 
            resources.ApplyResources(this.lblArmCheck, "lblArmCheck");
            this.lblArmCheck.Name = "lblArmCheck";
            // 
            // myButton2
            // 
            this.myButton2.BackColor = System.Drawing.SystemColors.Control;
            this.myButton2.BGGradBot = System.Drawing.Color.Transparent;
            this.myButton2.BGGradTop = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.Name = "myButton2";
            this.myButton2.UseVisualStyleBackColor = false;
            this.myButton2.Click += new System.EventHandler(this.BUT_refreshpart_Click);
            // 
            // Btn_
            // 
            this.Btn_.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_.BGGradBot = System.Drawing.Color.Transparent;
            this.Btn_.BGGradTop = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Btn_, "Btn_");
            this.Btn_.Name = "Btn_";
            this.Btn_.UseVisualStyleBackColor = false;
            this.Btn_.Click += new System.EventHandler(this.BUT_writePIDS_Click);
            // 
            // lblAllMove
            // 
            resources.ApplyResources(this.lblAllMove, "lblAllMove");
            this.lblAllMove.Name = "lblAllMove";
            // 
            // chb_AllMove
            // 
            resources.ApplyResources(this.chb_AllMove, "chb_AllMove");
            this.chb_AllMove.Name = "chb_AllMove";
            this.chb_AllMove.UseVisualStyleBackColor = true;
            this.chb_AllMove.CheckedChanged += new System.EventHandler(this.chb_AllMove_CheckedChanged);
            // 
            // lblCheckSpeech
            // 
            resources.ApplyResources(this.lblCheckSpeech, "lblCheckSpeech");
            this.lblCheckSpeech.Name = "lblCheckSpeech";
            // 
            // CHK_enablespeech
            // 
            resources.ApplyResources(this.CHK_enablespeech, "CHK_enablespeech");
            this.CHK_enablespeech.BackColor = System.Drawing.Color.Gainsboro;
            this.CHK_enablespeech.Name = "CHK_enablespeech";
            this.CHK_enablespeech.UseVisualStyleBackColor = false;
            this.CHK_enablespeech.CheckedChanged += new System.EventHandler(this.CHK_enablespeech_CheckedChanged);
            // 
            // CHK_speechwaypoint
            // 
            resources.ApplyResources(this.CHK_speechwaypoint, "CHK_speechwaypoint");
            this.CHK_speechwaypoint.BackColor = System.Drawing.Color.Gainsboro;
            this.CHK_speechwaypoint.Name = "CHK_speechwaypoint";
            this.CHK_speechwaypoint.UseVisualStyleBackColor = false;
            this.CHK_speechwaypoint.CheckedChanged += new System.EventHandler(this.CHK_speechwaypoint_CheckedChanged);
            // 
            // CHK_speechotherParams
            // 
            resources.ApplyResources(this.CHK_speechotherParams, "CHK_speechotherParams");
            this.CHK_speechotherParams.BackColor = System.Drawing.Color.Gainsboro;
            this.CHK_speechotherParams.Name = "CHK_speechotherParams";
            this.CHK_speechotherParams.UseVisualStyleBackColor = false;
            this.CHK_speechotherParams.CheckedChanged += new System.EventHandler(this.CHK_speechotherParams_CheckedChanged);
            // 
            // CHK_speechflightParams
            // 
            resources.ApplyResources(this.CHK_speechflightParams, "CHK_speechflightParams");
            this.CHK_speechflightParams.BackColor = System.Drawing.Color.Gainsboro;
            this.CHK_speechflightParams.Name = "CHK_speechflightParams";
            this.CHK_speechflightParams.UseVisualStyleBackColor = false;
            this.CHK_speechflightParams.CheckedChanged += new System.EventHandler(this.CHK_speechflightParams_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AssociatedSplitter = null;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.CaptionFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.CaptionHeight = 27;
            this.panel1.Controls.Add(this.SPRAY_WRAP_EN);
            this.panel1.Controls.Add(this.lblChangeRow);
            this.panel1.Controls.Add(this.lblVNo);
            this.panel1.Controls.Add(this.tboxWriteV);
            this.panel1.Controls.Add(this.lblVVNo);
            this.panel1.Controls.Add(this.lbl_RTL_ALT);
            this.panel1.Controls.Add(this.myButton2);
            this.panel1.Controls.Add(this.RTL_ALT_P);
            this.panel1.Controls.Add(this.Btn_);
            this.panel1.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel1.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel1.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel1.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panel1.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panel1.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panel1.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel1.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Image = null;
            this.panel1.Name = "panel1";
            this.panel1.ToolTipTextCloseIcon = null;
            this.panel1.ToolTipTextExpandIconPanelCollapsed = null;
            this.panel1.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // SPRAY_WRAP_EN
            // 
            resources.ApplyResources(this.SPRAY_WRAP_EN, "SPRAY_WRAP_EN");
            this.SPRAY_WRAP_EN.Name = "SPRAY_WRAP_EN";
            this.SPRAY_WRAP_EN.OffValue = 0D;
            this.SPRAY_WRAP_EN.OnValue = 1D;
            this.SPRAY_WRAP_EN.ParamName = null;
            this.SPRAY_WRAP_EN.UseVisualStyleBackColor = true;
            // 
            // lblChangeRow
            // 
            resources.ApplyResources(this.lblChangeRow, "lblChangeRow");
            this.lblChangeRow.Name = "lblChangeRow";
            // 
            // lblVNo
            // 
            resources.ApplyResources(this.lblVNo, "lblVNo");
            this.lblVNo.Name = "lblVNo";
            // 
            // lblVVNo
            // 
            resources.ApplyResources(this.lblVVNo, "lblVVNo");
            this.lblVVNo.Name = "lblVVNo";
            // 
            // panel2
            // 
            this.panel2.AssociatedSplitter = null;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.CaptionFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.CaptionHeight = 27;
            this.panel2.Controls.Add(this.lblAllMove);
            this.panel2.Controls.Add(this.chb_AllMove);
            this.panel2.Controls.Add(this.lblMoveDistance);
            this.panel2.Controls.Add(this.NUM_movelength);
            this.panel2.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel2.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel2.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel2.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel2.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel2.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel2.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panel2.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panel2.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panel2.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panel2.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panel2.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel2.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Image = null;
            this.panel2.Name = "panel2";
            this.panel2.ToolTipTextCloseIcon = null;
            this.panel2.ToolTipTextExpandIconPanelCollapsed = null;
            this.panel2.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // panel3
            // 
            this.panel3.AssociatedSplitter = null;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.CaptionFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.panel3.CaptionHeight = 27;
            this.panel3.Controls.Add(this.CHK_speechotherParams);
            this.panel3.Controls.Add(this.CHK_speechflightParams);
            this.panel3.Controls.Add(this.lblCheckSpeech);
            this.panel3.Controls.Add(this.CHK_speechwaypoint);
            this.panel3.Controls.Add(this.CHK_enablespeech);
            this.panel3.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel3.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel3.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel3.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel3.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panel3.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panel3.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panel3.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panel3.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panel3.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Image = null;
            this.panel3.Name = "panel3";
            this.panel3.ToolTipTextCloseIcon = null;
            this.panel3.ToolTipTextExpandIconPanelCollapsed = null;
            this.panel3.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // pSetParams
            // 
            this.pSetParams.AssociatedSplitter = null;
            this.pSetParams.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pSetParams, "pSetParams");
            this.pSetParams.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.pSetParams.CaptionHeight = 27;
            this.pSetParams.Controls.Add(this.chbShow_AllParams);
            this.pSetParams.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.pSetParams.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.pSetParams.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.pSetParams.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pSetParams.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.pSetParams.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pSetParams.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pSetParams.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.pSetParams.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.pSetParams.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.pSetParams.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.pSetParams.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pSetParams.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.pSetParams.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pSetParams.Image = null;
            this.pSetParams.Name = "pSetParams";
            this.pSetParams.ToolTipTextCloseIcon = null;
            this.pSetParams.ToolTipTextExpandIconPanelCollapsed = null;
            this.pSetParams.ToolTipTextExpandIconPanelExpanded = null;
            // 
            // chbShow_AllParams
            // 
            resources.ApplyResources(this.chbShow_AllParams, "chbShow_AllParams");
            this.chbShow_AllParams.Name = "chbShow_AllParams";
            this.chbShow_AllParams.UseVisualStyleBackColor = true;
            this.chbShow_AllParams.CheckedChanged += new System.EventHandler(this.chbShow_AllParams_CheckedChanged);
            // 
            // ConfigSetParams
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pSetParams);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelArmCheck);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigSetParams";
            ((System.ComponentModel.ISupportInitialize)(this.NUM_movelength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_P)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_FINAL)).EndInit();
            this.panelArmCheck.ResumeLayout(false);
            this.panelArmCheck.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pSetParams.ResumeLayout(false);
            this.pSetParams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_RTL_ALT;
        private System.Windows.Forms.Label lbl_RTL_ALT_F;
        private Controls.MavlinkNumericUpDown RTL_ALT_FINAL;
        private Controls.MyButton Btn_;
        private Controls.MyButton myButton2;
        private Controls.MavlinkNumericUpDown RTL_ALT_P;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblYawBehavior;
        private Controls.MavlinkComboBox WP_YAW_BEHAVIOR;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown NUM_movelength;
        private System.Windows.Forms.Label lblMoveDistance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label lblCheckSpeech;
        private System.Windows.Forms.CheckBox CHK_enablespeech;
        private System.Windows.Forms.CheckBox CHK_speechwaypoint;
        private System.Windows.Forms.CheckBox CHK_speechflightParams;
        private System.Windows.Forms.CheckBox CHK_speechotherParams;
        private System.Windows.Forms.Label lblAllMove;
        private System.Windows.Forms.CheckBox chb_AllMove;
        private System.Windows.Forms.Panel panelArmCheck;
        private Controls.MavlinkComboBox ARMING_CHECK;
        private System.Windows.Forms.Label lblArmCheck;
        private BSE.Windows.Forms.Panel panel1;
        private BSE.Windows.Forms.Panel panel2;
        private BSE.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblVVNo;
        private System.Windows.Forms.TextBox tboxWriteV;
        private System.Windows.Forms.Label lblVNo;
        private System.Windows.Forms.Label lblChangeRow;
        private Controls.MavlinkCheckBox SPRAY_WRAP_EN;
        private BSE.Windows.Forms.Panel pSetParams;
        private System.Windows.Forms.CheckBox chbShow_AllParams;
    }
}
