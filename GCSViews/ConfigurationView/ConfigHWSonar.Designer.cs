namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    partial class ConfigHWSonar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigHWSonar));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LBL_volt = new System.Windows.Forms.Label();
            this.LBL_dist = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chbSonar = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mavlinkComboBox1 = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_LevelSensor = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.CMB_sonartype = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.MBtnSendSaray = new ByAeroBeHero.Controls.MyButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SPRAY_SPEED_MIN = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.SPRAY_RATE_MAX = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.SPRAY_SPEED_MAX = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.SPRAY_RATE_MIN = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.SPRAY_SPEEN_EN = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new BSE.Windows.Forms.Panel();
            this.panel3 = new BSE.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_SPEED_MIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_RATE_MAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_SPEED_MAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_RATE_MIN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::ByAeroBeHero.Properties.Resources.sonar;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // LBL_volt
            // 
            resources.ApplyResources(this.LBL_volt, "LBL_volt");
            this.LBL_volt.Name = "LBL_volt";
            // 
            // LBL_dist
            // 
            resources.ApplyResources(this.LBL_dist, "LBL_dist");
            this.LBL_dist.Name = "LBL_dist";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chbSonar
            // 
            resources.ApplyResources(this.chbSonar, "chbSonar");
            this.chbSonar.Name = "chbSonar";
            this.chbSonar.OffValue = 0D;
            this.chbSonar.OnValue = 1D;
            this.chbSonar.ParamName = null;
            this.chbSonar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mavlinkComboBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_LevelSensor);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // mavlinkComboBox1
            // 
            this.mavlinkComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.mavlinkComboBox1, "mavlinkComboBox1");
            this.mavlinkComboBox1.FormattingEnabled = true;
            this.mavlinkComboBox1.Name = "mavlinkComboBox1";
            this.mavlinkComboBox1.ParamName = null;
            this.mavlinkComboBox1.SubControl = null;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cb_LevelSensor
            // 
            resources.ApplyResources(this.cb_LevelSensor, "cb_LevelSensor");
            this.cb_LevelSensor.Name = "cb_LevelSensor";
            this.cb_LevelSensor.OffValue = 0D;
            this.cb_LevelSensor.OnValue = 1D;
            this.cb_LevelSensor.ParamName = null;
            this.cb_LevelSensor.UseVisualStyleBackColor = true;
            // 
            // CMB_sonartype
            // 
            this.CMB_sonartype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CMB_sonartype, "CMB_sonartype");
            this.CMB_sonartype.FormattingEnabled = true;
            this.CMB_sonartype.Items.AddRange(new object[] {
            resources.GetString("CMB_sonartype.Items"),
            resources.GetString("CMB_sonartype.Items1"),
            resources.GetString("CMB_sonartype.Items2"),
            resources.GetString("CMB_sonartype.Items3")});
            this.CMB_sonartype.Name = "CMB_sonartype";
            this.CMB_sonartype.ParamName = null;
            this.CMB_sonartype.SubControl = null;
            // 
            // MBtnSendSaray
            // 
            this.MBtnSendSaray.BackColor = System.Drawing.SystemColors.Control;
            this.MBtnSendSaray.BGGradBot = System.Drawing.Color.Transparent;
            this.MBtnSendSaray.BGGradTop = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MBtnSendSaray, "MBtnSendSaray");
            this.MBtnSendSaray.Name = "MBtnSendSaray";
            this.MBtnSendSaray.UseVisualStyleBackColor = false;
            this.MBtnSendSaray.Click += new System.EventHandler(this.MBtnSendSaray_Click);
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
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // SPRAY_SPEED_MIN
            // 
            this.SPRAY_SPEED_MIN.BackColor = System.Drawing.Color.Black;
            this.SPRAY_SPEED_MIN.DecimalPlaces = 1;
            resources.ApplyResources(this.SPRAY_SPEED_MIN, "SPRAY_SPEED_MIN");
            this.SPRAY_SPEED_MIN.ForeColor = System.Drawing.Color.White;
            this.SPRAY_SPEED_MIN.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SPRAY_SPEED_MIN.Max = 1F;
            this.SPRAY_SPEED_MIN.Min = 0F;
            this.SPRAY_SPEED_MIN.Name = "SPRAY_SPEED_MIN";
            this.SPRAY_SPEED_MIN.ParamName = null;
            this.SPRAY_SPEED_MIN.Value = new decimal(new int[] {
            8,
            0,
            0,
            65536});
            this.SPRAY_SPEED_MIN.ValueChanged += new System.EventHandler(this.SPRAY_ValueChanged);
            // 
            // SPRAY_RATE_MAX
            // 
            this.SPRAY_RATE_MAX.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.SPRAY_RATE_MAX, "SPRAY_RATE_MAX");
            this.SPRAY_RATE_MAX.ForeColor = System.Drawing.Color.White;
            this.SPRAY_RATE_MAX.Max = 100F;
            this.SPRAY_RATE_MAX.Min = 0F;
            this.SPRAY_RATE_MAX.Name = "SPRAY_RATE_MAX";
            this.SPRAY_RATE_MAX.ParamName = null;
            this.SPRAY_RATE_MAX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.SPRAY_RATE_MAX.ValueChanged += new System.EventHandler(this.SPRAY_ValueChanged);
            // 
            // SPRAY_SPEED_MAX
            // 
            this.SPRAY_SPEED_MAX.BackColor = System.Drawing.Color.Black;
            this.SPRAY_SPEED_MAX.DecimalPlaces = 1;
            resources.ApplyResources(this.SPRAY_SPEED_MAX, "SPRAY_SPEED_MAX");
            this.SPRAY_SPEED_MAX.ForeColor = System.Drawing.Color.White;
            this.SPRAY_SPEED_MAX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SPRAY_SPEED_MAX.Max = 1F;
            this.SPRAY_SPEED_MAX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SPRAY_SPEED_MAX.Min = 0F;
            this.SPRAY_SPEED_MAX.Name = "SPRAY_SPEED_MAX";
            this.SPRAY_SPEED_MAX.ParamName = null;
            this.SPRAY_SPEED_MAX.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.SPRAY_SPEED_MAX.ValueChanged += new System.EventHandler(this.SPRAY_ValueChanged);
            // 
            // SPRAY_RATE_MIN
            // 
            this.SPRAY_RATE_MIN.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.SPRAY_RATE_MIN, "SPRAY_RATE_MIN");
            this.SPRAY_RATE_MIN.ForeColor = System.Drawing.Color.White;
            this.SPRAY_RATE_MIN.Max = 100F;
            this.SPRAY_RATE_MIN.Min = 0F;
            this.SPRAY_RATE_MIN.Name = "SPRAY_RATE_MIN";
            this.SPRAY_RATE_MIN.ParamName = null;
            this.SPRAY_RATE_MIN.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.SPRAY_RATE_MIN.ValueChanged += new System.EventHandler(this.SPRAY_ValueChanged);
            // 
            // SPRAY_SPEEN_EN
            // 
            resources.ApplyResources(this.SPRAY_SPEEN_EN, "SPRAY_SPEEN_EN");
            this.SPRAY_SPEEN_EN.Name = "SPRAY_SPEEN_EN";
            this.SPRAY_SPEEN_EN.OffValue = 0D;
            this.SPRAY_SPEEN_EN.OnValue = 1D;
            this.SPRAY_SPEEN_EN.ParamName = null;
            this.SPRAY_SPEEN_EN.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.CMB_sonartype);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LBL_volt);
            this.panel1.Controls.Add(this.LBL_dist);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.AssociatedSplitter = null;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.CaptionFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.CaptionHeight = 27;
            this.panel2.Controls.Add(this.chbSonar);
            this.panel2.Controls.Add(this.label3);
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
            this.panel3.CaptionFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel3.CaptionHeight = 27;
            this.panel3.Controls.Add(this.MBtnSendSaray);
            this.panel3.Controls.Add(this.SPRAY_SPEEN_EN);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.SPRAY_SPEED_MIN);
            this.panel3.Controls.Add(this.SPRAY_RATE_MAX);
            this.panel3.Controls.Add(this.SPRAY_SPEED_MAX);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.SPRAY_RATE_MIN);
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
            // ConfigHWSonar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Name = "ConfigHWSonar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_SPEED_MIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_RATE_MAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_SPEED_MAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_RATE_MIN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MavlinkComboBox CMB_sonartype;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label LBL_volt;
        private System.Windows.Forms.Label LBL_dist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private Controls.MavlinkCheckBox chbSonar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private Controls.MavlinkCheckBox cb_LevelSensor;
        private Controls.MavlinkComboBox mavlinkComboBox1;
        private Controls.MyButton MBtnSendSaray;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Controls.MavlinkNumericUpDown SPRAY_SPEED_MIN;
        private Controls.MavlinkNumericUpDown SPRAY_RATE_MAX;
        private Controls.MavlinkNumericUpDown SPRAY_SPEED_MAX;
        private Controls.MavlinkNumericUpDown SPRAY_RATE_MIN;
        private Controls.MavlinkCheckBox SPRAY_SPEEN_EN;
        private System.Windows.Forms.Panel panel1;
        private BSE.Windows.Forms.Panel panel2;
        private BSE.Windows.Forms.Panel panel3;
    }
}
