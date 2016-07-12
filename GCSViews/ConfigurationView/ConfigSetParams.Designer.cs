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
            this.WP_YAW_BEHAVIOR = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.RTL_ALT_P = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.RTL_ALT_FINAL = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NUM_movelength = new System.Windows.Forms.NumericUpDown();
            this.lblMoveDistance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_FINAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_movelength)).BeginInit();
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
            // ConfigSetParams
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMoveDistance);
            this.Controls.Add(this.NUM_movelength);
            this.Controls.Add(this.WP_YAW_BEHAVIOR);
            this.Controls.Add(this.lblYawBehavior);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.RTL_ALT_P);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.Btn_);
            this.Controls.Add(this.RTL_ALT_FINAL);
            this.Controls.Add(this.lbl_RTL_ALT_F);
            this.Controls.Add(this.lbl_RTL_ALT);
            this.Name = "ConfigSetParams";
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTL_ALT_FINAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_movelength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
