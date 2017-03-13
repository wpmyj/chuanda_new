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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MBtnSendSaray = new ByAeroBeHero.Controls.MyButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblSpray = new System.Windows.Forms.Label();
            this.SPRAY_SPEEN_EN = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.SPRAY_RATE_MIN = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.SPRAY_SPEED_MAX = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.SPRAY_RATE_MAX = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.SPRAY_SPEED_MIN = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.chbSonar = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.mavlinkComboBox1 = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.cb_LevelSensor = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_RATE_MIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_SPEED_MAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_RATE_MAX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_SPEED_MIN)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mavlinkComboBox1);
            this.groupBox3.Controls.Add(this.cb_LevelSensor);
            this.groupBox3.Controls.Add(this.SPRAY_RATE_MAX);
            this.groupBox3.Controls.Add(this.SPRAY_RATE_MIN);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
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
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Name = "label10";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.chbSonar);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label1);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.MBtnSendSaray);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.SPRAY_SPEEN_EN);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.SPRAY_SPEED_MAX);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.SPRAY_SPEED_MIN);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblSpray);
            this.panel6.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // lblSpray
            // 
            resources.ApplyResources(this.lblSpray, "lblSpray");
            this.lblSpray.BackColor = System.Drawing.Color.Transparent;
            this.lblSpray.ForeColor = System.Drawing.Color.Black;
            this.lblSpray.Name = "lblSpray";
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
            // chbSonar
            // 
            resources.ApplyResources(this.chbSonar, "chbSonar");
            this.chbSonar.Name = "chbSonar";
            this.chbSonar.OffValue = 0D;
            this.chbSonar.OnValue = 1D;
            this.chbSonar.ParamName = null;
            this.chbSonar.UseVisualStyleBackColor = true;
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
            // cb_LevelSensor
            // 
            resources.ApplyResources(this.cb_LevelSensor, "cb_LevelSensor");
            this.cb_LevelSensor.Name = "cb_LevelSensor";
            this.cb_LevelSensor.OffValue = 0D;
            this.cb_LevelSensor.OnValue = 1D;
            this.cb_LevelSensor.ParamName = null;
            this.cb_LevelSensor.UseVisualStyleBackColor = true;
            // 
            // ConfigHWSonar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Name = "ConfigHWSonar";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_RATE_MIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_SPEED_MAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_RATE_MAX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPRAY_SPEED_MIN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Controls.MavlinkCheckBox chbSonar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSpray;
    }
}
