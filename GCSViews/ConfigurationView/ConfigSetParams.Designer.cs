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
            this.myButton2 = new ByAeroBeHero.Controls.MyButton();
            this.Btn_ = new ByAeroBeHero.Controls.MyButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.WP_YAW_BEHAVIOR = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.NUM_movelength = new System.Windows.Forms.NumericUpDown();
            this.lblMoveDistance = new System.Windows.Forms.Label();
            this.lblDSM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RTL_ALT_FINAL = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.RTL_ALT_P = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCheckSpeech = new System.Windows.Forms.Label();
            this.CHK_enablespeech = new System.Windows.Forms.CheckBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.CHK_speechwaypoint = new System.Windows.Forms.CheckBox();
            this.groupBoxSetP = new System.Windows.Forms.GroupBox();
            this.CHK_speechflightParams = new System.Windows.Forms.CheckBox();
            this.CHK_speechotherParams = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_movelength)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_FINAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_P)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxSetP.SuspendLayout();
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
            // myButton2
            // 
            resources.ApplyResources(this.myButton2, "myButton2");
            this.myButton2.Name = "myButton2";
            this.myButton2.UseVisualStyleBackColor = true;
            this.myButton2.Click += new System.EventHandler(this.BUT_refreshpart_Click);
            // 
            // Btn_
            // 
            resources.ApplyResources(this.Btn_, "Btn_");
            this.Btn_.Name = "Btn_";
            this.Btn_.UseVisualStyleBackColor = true;
            this.Btn_.Click += new System.EventHandler(this.BUT_writePIDS_Click);
            // 
            // WP_YAW_BEHAVIOR
            // 
            this.WP_YAW_BEHAVIOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.WP_YAW_BEHAVIOR, "WP_YAW_BEHAVIOR");
            this.WP_YAW_BEHAVIOR.FormattingEnabled = true;
            this.WP_YAW_BEHAVIOR.Name = "WP_YAW_BEHAVIOR";
            this.WP_YAW_BEHAVIOR.ParamName = null;
            this.WP_YAW_BEHAVIOR.SubControl = null;
            this.WP_YAW_BEHAVIOR.Tag = "";
            this.toolTip1.SetToolTip(this.WP_YAW_BEHAVIOR, resources.GetString("WP_YAW_BEHAVIOR.ToolTip"));
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
            // lblMoveDistance
            // 
            resources.ApplyResources(this.lblMoveDistance, "lblMoveDistance");
            this.lblMoveDistance.Name = "lblMoveDistance";
            // 
            // lblDSM
            // 
            resources.ApplyResources(this.lblDSM, "lblDSM");
            this.lblDSM.Name = "lblDSM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_RTL_ALT_F);
            this.groupBox1.Controls.Add(this.lbl_RTL_ALT);
            this.groupBox1.Controls.Add(this.RTL_ALT_FINAL);
            this.groupBox1.Controls.Add(this.RTL_ALT_P);
            this.groupBox1.Controls.Add(this.myButton2);
            this.groupBox1.Controls.Add(this.WP_YAW_BEHAVIOR);
            this.groupBox1.Controls.Add(this.Btn_);
            this.groupBox1.Controls.Add(this.lblUnit);
            this.groupBox1.Controls.Add(this.lblYawBehavior);
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
            // RTL_ALT_P
            // 
            this.RTL_ALT_P.DecimalPlaces = 1;
            resources.ApplyResources(this.RTL_ALT_P, "RTL_ALT_P");
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
            this.RTL_ALT_P.ValueUpdated += new System.EventHandler(this.numeric_ValueUpdated);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDSM);
            this.groupBox2.Controls.Add(this.NUM_movelength);
            this.groupBox2.Controls.Add(this.lblMoveDistance);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lblCheckSpeech
            // 
            resources.ApplyResources(this.lblCheckSpeech, "lblCheckSpeech");
            this.lblCheckSpeech.Name = "lblCheckSpeech";
            // 
            // CHK_enablespeech
            // 
            resources.ApplyResources(this.CHK_enablespeech, "CHK_enablespeech");
            this.CHK_enablespeech.Name = "CHK_enablespeech";
            this.CHK_enablespeech.UseVisualStyleBackColor = true;
            this.CHK_enablespeech.CheckedChanged += new System.EventHandler(this.CHK_enablespeech_CheckedChanged);
            // 
            // CHK_speechwaypoint
            // 
            resources.ApplyResources(this.CHK_speechwaypoint, "CHK_speechwaypoint");
            this.CHK_speechwaypoint.Name = "CHK_speechwaypoint";
            this.CHK_speechwaypoint.UseVisualStyleBackColor = true;
            this.CHK_speechwaypoint.CheckedChanged += new System.EventHandler(this.CHK_speechwaypoint_CheckedChanged);
            // 
            // groupBoxSetP
            // 
            this.groupBoxSetP.Controls.Add(this.CHK_speechotherParams);
            this.groupBoxSetP.Controls.Add(this.CHK_speechflightParams);
            this.groupBoxSetP.Controls.Add(this.CHK_speechwaypoint);
            this.groupBoxSetP.Controls.Add(this.CHK_enablespeech);
            this.groupBoxSetP.Controls.Add(this.lblCheckSpeech);
            resources.ApplyResources(this.groupBoxSetP, "groupBoxSetP");
            this.groupBoxSetP.Name = "groupBoxSetP";
            this.groupBoxSetP.TabStop = false;
            // 
            // CHK_speechflightParams
            // 
            resources.ApplyResources(this.CHK_speechflightParams, "CHK_speechflightParams");
            this.CHK_speechflightParams.Name = "CHK_speechflightParams";
            this.CHK_speechflightParams.UseVisualStyleBackColor = true;
            this.CHK_speechflightParams.CheckedChanged += new System.EventHandler(this.CHK_speechflightParams_CheckedChanged);
            // 
            // CHK_speechotherParams
            // 
            resources.ApplyResources(this.CHK_speechotherParams, "CHK_speechotherParams");
            this.CHK_speechotherParams.Name = "CHK_speechotherParams";
            this.CHK_speechotherParams.UseVisualStyleBackColor = true;
            this.CHK_speechotherParams.CheckedChanged += new System.EventHandler(this.CHK_speechotherParams_CheckedChanged);
            // 
            // ConfigSetParams
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxSetP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigSetParams";
            ((System.ComponentModel.ISupportInitialize)(this.NUM_movelength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_FINAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_P)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSetP.ResumeLayout(false);
            this.groupBoxSetP.PerformLayout();
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
        private System.Windows.Forms.Label lblDSM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label lblCheckSpeech;
        private System.Windows.Forms.CheckBox CHK_enablespeech;
        private System.Windows.Forms.CheckBox CHK_speechwaypoint;
        private System.Windows.Forms.GroupBox groupBoxSetP;
        private System.Windows.Forms.CheckBox CHK_speechflightParams;
        private System.Windows.Forms.CheckBox CHK_speechotherParams;
    }
}
