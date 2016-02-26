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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigAC_Fence));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mavlinkComboBox2 = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.mavlinkCheckBox1 = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.label3enable = new System.Windows.Forms.Label();
            this.mavlinkComboBox1 = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.label4type = new System.Windows.Forms.Label();
            this.label5action = new System.Windows.Forms.Label();
            this.label6maxalt = new System.Windows.Forms.Label();
            this.label7maxrad = new System.Windows.Forms.Label();
            this.label2rtlalt = new System.Windows.Forms.Label();
            this.mavlinkNumericUpDown1 = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.mavlinkNumericUpDown2 = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.mavlinkNumericUpDown3 = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSendParam = new ByAeroBeHero.Controls.MyButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.mavlinkComboBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mavlinkCheckBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3enable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mavlinkComboBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4type, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5action, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6maxalt, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7maxrad, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2rtlalt, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.mavlinkNumericUpDown1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.mavlinkNumericUpDown2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.mavlinkNumericUpDown3, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // mavlinkComboBox2
            // 
            resources.ApplyResources(this.mavlinkComboBox2, "mavlinkComboBox2");
            this.mavlinkComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mavlinkComboBox2.FormattingEnabled = true;
            this.mavlinkComboBox2.Name = "mavlinkComboBox2";
            this.mavlinkComboBox2.ParamName = null;
            this.mavlinkComboBox2.SubControl = null;
            this.mavlinkComboBox2.TextChanged += new System.EventHandler(this.mavlinkComboBox2_TextChanged);
            // 
            // mavlinkCheckBox1
            // 
            resources.ApplyResources(this.mavlinkCheckBox1, "mavlinkCheckBox1");
            this.mavlinkCheckBox1.Name = "mavlinkCheckBox1";
            this.mavlinkCheckBox1.OffValue = 0D;
            this.mavlinkCheckBox1.OnValue = 1D;
            this.mavlinkCheckBox1.ParamName = null;
            this.mavlinkCheckBox1.UseVisualStyleBackColor = true;
            // 
            // label3enable
            // 
            resources.ApplyResources(this.label3enable, "label3enable");
            this.label3enable.Name = "label3enable";
            // 
            // mavlinkComboBox1
            // 
            resources.ApplyResources(this.mavlinkComboBox1, "mavlinkComboBox1");
            this.mavlinkComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mavlinkComboBox1.FormattingEnabled = true;
            this.mavlinkComboBox1.Name = "mavlinkComboBox1";
            this.mavlinkComboBox1.ParamName = null;
            this.mavlinkComboBox1.SubControl = null;
            this.mavlinkComboBox1.TextChanged += new System.EventHandler(this.mavlinkComboBox1_TextChanged);
            // 
            // label4type
            // 
            resources.ApplyResources(this.label4type, "label4type");
            this.label4type.Name = "label4type";
            // 
            // label5action
            // 
            resources.ApplyResources(this.label5action, "label5action");
            this.label5action.Name = "label5action";
            // 
            // label6maxalt
            // 
            resources.ApplyResources(this.label6maxalt, "label6maxalt");
            this.label6maxalt.Name = "label6maxalt";
            // 
            // label7maxrad
            // 
            resources.ApplyResources(this.label7maxrad, "label7maxrad");
            this.label7maxrad.Name = "label7maxrad";
            // 
            // label2rtlalt
            // 
            resources.ApplyResources(this.label2rtlalt, "label2rtlalt");
            this.label2rtlalt.Name = "label2rtlalt";
            // 
            // mavlinkNumericUpDown1
            // 
            resources.ApplyResources(this.mavlinkNumericUpDown1, "mavlinkNumericUpDown1");
            this.mavlinkNumericUpDown1.Max = 1F;
            this.mavlinkNumericUpDown1.Min = 0F;
            this.mavlinkNumericUpDown1.Name = "mavlinkNumericUpDown1";
            this.mavlinkNumericUpDown1.ParamName = null;
            this.mavlinkNumericUpDown1.ValueChanged += new System.EventHandler(this.mavlinkNumericUpDown1_ValueChanged);
            // 
            // mavlinkNumericUpDown2
            // 
            resources.ApplyResources(this.mavlinkNumericUpDown2, "mavlinkNumericUpDown2");
            this.mavlinkNumericUpDown2.Max = 1F;
            this.mavlinkNumericUpDown2.Min = 0F;
            this.mavlinkNumericUpDown2.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.mavlinkNumericUpDown2.Name = "mavlinkNumericUpDown2";
            this.mavlinkNumericUpDown2.ParamName = null;
            this.mavlinkNumericUpDown2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.mavlinkNumericUpDown2.ValueChanged += new System.EventHandler(this.mavlinkNumericUpDown2_ValueChanged);
            // 
            // mavlinkNumericUpDown3
            // 
            resources.ApplyResources(this.mavlinkNumericUpDown3, "mavlinkNumericUpDown3");
            this.mavlinkNumericUpDown3.Max = 1F;
            this.mavlinkNumericUpDown3.Min = 0F;
            this.mavlinkNumericUpDown3.Name = "mavlinkNumericUpDown3";
            this.mavlinkNumericUpDown3.ParamName = null;
            this.mavlinkNumericUpDown3.ValueChanged += new System.EventHandler(this.mavlinkNumericUpDown3_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnSendParam
            // 
            resources.ApplyResources(this.btnSendParam, "btnSendParam");
            this.btnSendParam.Name = "btnSendParam";
            this.btnSendParam.UseVisualStyleBackColor = true;
            this.btnSendParam.Click += new System.EventHandler(this.btnSendParam_Click);
            // 
            // ConfigAC_Fence
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSendParam);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigAC_Fence";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDown3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MavlinkCheckBox mavlinkCheckBox1;
        private Controls.MavlinkComboBox mavlinkComboBox1;
        private Controls.MavlinkComboBox mavlinkComboBox2;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDown1;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDown2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3enable;
        private System.Windows.Forms.Label label4type;
        private System.Windows.Forms.Label label5action;
        private System.Windows.Forms.Label label6maxalt;
        private System.Windows.Forms.Label label7maxrad;
        private System.Windows.Forms.Label label2rtlalt;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDown3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Controls.MyButton btnSendParam;
    }
}
