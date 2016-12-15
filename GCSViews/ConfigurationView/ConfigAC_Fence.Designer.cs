namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    partial class ConfigAC_Fence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigAC_Fence));
            this.label3enable = new System.Windows.Forms.Label();
            this.label4type = new System.Windows.Forms.Label();
            this.label5action = new System.Windows.Forms.Label();
            this.label6maxalt = new System.Windows.Forms.Label();
            this.label7maxrad = new System.Windows.Forms.Label();
            this.label2rtlalt = new System.Windows.Forms.Label();
            this.btnSendParam = new ByAeroBeHero.Controls.MyButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mavlinkComboBox2 = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.mavlinkCheckBox1 = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.mavlinkNumericUpDown3 = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.mavlinkComboBox1 = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.mavlinkNumericUpDown2 = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.mavlinkNumericUpDown1 = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3enable
            // 
            resources.ApplyResources(this.label3enable, "label3enable");
            this.label3enable.BackColor = System.Drawing.Color.Transparent;
            this.label3enable.Name = "label3enable";
            // 
            // label4type
            // 
            resources.ApplyResources(this.label4type, "label4type");
            this.label4type.BackColor = System.Drawing.Color.Transparent;
            this.label4type.Name = "label4type";
            // 
            // label5action
            // 
            resources.ApplyResources(this.label5action, "label5action");
            this.label5action.BackColor = System.Drawing.Color.Transparent;
            this.label5action.Name = "label5action";
            // 
            // label6maxalt
            // 
            resources.ApplyResources(this.label6maxalt, "label6maxalt");
            this.label6maxalt.BackColor = System.Drawing.Color.Transparent;
            this.label6maxalt.Name = "label6maxalt";
            // 
            // label7maxrad
            // 
            resources.ApplyResources(this.label7maxrad, "label7maxrad");
            this.label7maxrad.BackColor = System.Drawing.Color.Transparent;
            this.label7maxrad.Name = "label7maxrad";
            // 
            // label2rtlalt
            // 
            resources.ApplyResources(this.label2rtlalt, "label2rtlalt");
            this.label2rtlalt.BackColor = System.Drawing.Color.Transparent;
            this.label2rtlalt.Name = "label2rtlalt";
            // 
            // btnSendParam
            // 
            this.btnSendParam.BackColor = System.Drawing.SystemColors.Control;
            this.btnSendParam.BGGradBot = System.Drawing.Color.Transparent;
            this.btnSendParam.BGGradTop = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSendParam, "btnSendParam");
            this.btnSendParam.Name = "btnSendParam";
            this.btnSendParam.UseVisualStyleBackColor = false;
            this.btnSendParam.Click += new System.EventHandler(this.btnSendParam_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label6maxalt);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.mavlinkComboBox2);
            this.panel1.Controls.Add(this.label3enable);
            this.panel1.Controls.Add(this.btnSendParam);
            this.panel1.Controls.Add(this.label4type);
            this.panel1.Controls.Add(this.label7maxrad);
            this.panel1.Controls.Add(this.mavlinkCheckBox1);
            this.panel1.Controls.Add(this.mavlinkNumericUpDown3);
            this.panel1.Controls.Add(this.label2rtlalt);
            this.panel1.Controls.Add(this.mavlinkComboBox1);
            this.panel1.Controls.Add(this.label5action);
            this.panel1.Controls.Add(this.mavlinkNumericUpDown2);
            this.panel1.Controls.Add(this.mavlinkNumericUpDown1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Name = "panel3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // mavlinkComboBox2
            // 
            resources.ApplyResources(this.mavlinkComboBox2, "mavlinkComboBox2");
            this.mavlinkComboBox2.BackColor = System.Drawing.Color.Black;
            this.mavlinkComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mavlinkComboBox2.ForeColor = System.Drawing.Color.White;
            this.mavlinkComboBox2.FormattingEnabled = true;
            this.mavlinkComboBox2.Name = "mavlinkComboBox2";
            this.mavlinkComboBox2.ParamName = null;
            this.mavlinkComboBox2.SubControl = null;
            this.toolTip1.SetToolTip(this.mavlinkComboBox2, resources.GetString("mavlinkComboBox2.ToolTip"));
            this.mavlinkComboBox2.TextChanged += new System.EventHandler(this.mavlinkComboBox2_TextChanged);
            // 
            // mavlinkCheckBox1
            // 
            resources.ApplyResources(this.mavlinkCheckBox1, "mavlinkCheckBox1");
            this.mavlinkCheckBox1.BackColor = System.Drawing.Color.Black;
            this.mavlinkCheckBox1.ForeColor = System.Drawing.Color.White;
            this.mavlinkCheckBox1.Name = "mavlinkCheckBox1";
            this.mavlinkCheckBox1.OffValue = 0D;
            this.mavlinkCheckBox1.OnValue = 1D;
            this.mavlinkCheckBox1.ParamName = null;
            this.mavlinkCheckBox1.UseVisualStyleBackColor = false;
            // 
            // mavlinkNumericUpDown3
            // 
            resources.ApplyResources(this.mavlinkNumericUpDown3, "mavlinkNumericUpDown3");
            this.mavlinkNumericUpDown3.BackColor = System.Drawing.Color.Black;
            this.mavlinkNumericUpDown3.DecimalPlaces = 1;
            this.mavlinkNumericUpDown3.ForeColor = System.Drawing.Color.White;
            this.mavlinkNumericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mavlinkNumericUpDown3.Max = 1F;
            this.mavlinkNumericUpDown3.Min = 0F;
            this.mavlinkNumericUpDown3.Name = "mavlinkNumericUpDown3";
            this.mavlinkNumericUpDown3.ParamName = null;
            this.toolTip1.SetToolTip(this.mavlinkNumericUpDown3, resources.GetString("mavlinkNumericUpDown3.ToolTip"));
            this.mavlinkNumericUpDown3.ValueChanged += new System.EventHandler(this.mavlinkNumericUpDown3_ValueChanged);
            // 
            // mavlinkComboBox1
            // 
            resources.ApplyResources(this.mavlinkComboBox1, "mavlinkComboBox1");
            this.mavlinkComboBox1.BackColor = System.Drawing.Color.Black;
            this.mavlinkComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mavlinkComboBox1.ForeColor = System.Drawing.Color.White;
            this.mavlinkComboBox1.FormattingEnabled = true;
            this.mavlinkComboBox1.Name = "mavlinkComboBox1";
            this.mavlinkComboBox1.ParamName = null;
            this.mavlinkComboBox1.SubControl = null;
            this.toolTip1.SetToolTip(this.mavlinkComboBox1, resources.GetString("mavlinkComboBox1.ToolTip"));
            this.mavlinkComboBox1.TextChanged += new System.EventHandler(this.mavlinkComboBox1_TextChanged);
            // 
            // mavlinkNumericUpDown2
            // 
            resources.ApplyResources(this.mavlinkNumericUpDown2, "mavlinkNumericUpDown2");
            this.mavlinkNumericUpDown2.BackColor = System.Drawing.Color.Black;
            this.mavlinkNumericUpDown2.ForeColor = System.Drawing.Color.White;
            this.mavlinkNumericUpDown2.Max = 1F;
            this.mavlinkNumericUpDown2.Min = 0F;
            this.mavlinkNumericUpDown2.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.mavlinkNumericUpDown2.Name = "mavlinkNumericUpDown2";
            this.mavlinkNumericUpDown2.ParamName = null;
            this.toolTip1.SetToolTip(this.mavlinkNumericUpDown2, resources.GetString("mavlinkNumericUpDown2.ToolTip"));
            this.mavlinkNumericUpDown2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.mavlinkNumericUpDown2.ValueChanged += new System.EventHandler(this.mavlinkNumericUpDown2_ValueChanged);
            // 
            // mavlinkNumericUpDown1
            // 
            resources.ApplyResources(this.mavlinkNumericUpDown1, "mavlinkNumericUpDown1");
            this.mavlinkNumericUpDown1.BackColor = System.Drawing.Color.Black;
            this.mavlinkNumericUpDown1.ForeColor = System.Drawing.Color.White;
            this.mavlinkNumericUpDown1.Max = 1F;
            this.mavlinkNumericUpDown1.Min = 0F;
            this.mavlinkNumericUpDown1.Name = "mavlinkNumericUpDown1";
            this.mavlinkNumericUpDown1.ParamName = null;
            this.toolTip1.SetToolTip(this.mavlinkNumericUpDown1, resources.GetString("mavlinkNumericUpDown1.ToolTip"));
            this.mavlinkNumericUpDown1.ValueChanged += new System.EventHandler(this.mavlinkNumericUpDown1_ValueChanged);
            // 
            // ConfigAC_Fence
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel1);
            this.Name = "ConfigAC_Fence";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MavlinkCheckBox mavlinkCheckBox1;
        private Controls.MavlinkComboBox mavlinkComboBox1;
        private Controls.MavlinkComboBox mavlinkComboBox2;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDown1;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDown2;
        private System.Windows.Forms.Label label3enable;
        private System.Windows.Forms.Label label4type;
        private System.Windows.Forms.Label label5action;
        private System.Windows.Forms.Label label6maxalt;
        private System.Windows.Forms.Label label7maxrad;
        private System.Windows.Forms.Label label2rtlalt;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDown3;
        private Controls.MyButton btnSendParam;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}
