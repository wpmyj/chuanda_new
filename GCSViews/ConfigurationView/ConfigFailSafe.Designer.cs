using ByAeroBeHero.Controls;
namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    partial class ConfigFailSafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigFailSafe));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblFailSafeBegin = new System.Windows.Forms.Label();
            this.mavlinkNumericUpDownthr_fs_value = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.mavlinkComboFS_GCS_ENABLE = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.mavlinkComboBox_fs_thr_enable = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.mavlinkComboBoxfs_batt_enable = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.mavlinkNumericUpDownlow_voltage = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mavlinkNumericUpDownfs_thr_value = new ByAeroBeHero.Controls.MavlinkNumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSafe = new System.Windows.Forms.Label();
            this.cb_FS_Level_Enable = new ByAeroBeHero.Controls.MavlinkComboBox();
            this.currentStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDownthr_fs_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDownlow_voltage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDownfs_thr_value)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // lblFailSafeBegin
            // 
            resources.ApplyResources(this.lblFailSafeBegin, "lblFailSafeBegin");
            this.lblFailSafeBegin.BackColor = System.Drawing.Color.Transparent;
            this.lblFailSafeBegin.ForeColor = System.Drawing.Color.Black;
            this.lblFailSafeBegin.Name = "lblFailSafeBegin";
            this.toolTip1.SetToolTip(this.lblFailSafeBegin, resources.GetString("lblFailSafeBegin.ToolTip"));
            // 
            // mavlinkNumericUpDownthr_fs_value
            // 
            this.mavlinkNumericUpDownthr_fs_value.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.mavlinkNumericUpDownthr_fs_value, "mavlinkNumericUpDownthr_fs_value");
            this.mavlinkNumericUpDownthr_fs_value.ForeColor = System.Drawing.Color.White;
            this.mavlinkNumericUpDownthr_fs_value.Max = 1F;
            this.mavlinkNumericUpDownthr_fs_value.Min = 0F;
            this.mavlinkNumericUpDownthr_fs_value.Name = "mavlinkNumericUpDownthr_fs_value";
            this.mavlinkNumericUpDownthr_fs_value.ParamName = null;
            this.toolTip1.SetToolTip(this.mavlinkNumericUpDownthr_fs_value, resources.GetString("mavlinkNumericUpDownthr_fs_value.ToolTip"));
            // 
            // mavlinkComboFS_GCS_ENABLE
            // 
            this.mavlinkComboFS_GCS_ENABLE.BackColor = System.Drawing.Color.Black;
            this.mavlinkComboFS_GCS_ENABLE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.mavlinkComboFS_GCS_ENABLE, "mavlinkComboFS_GCS_ENABLE");
            this.mavlinkComboFS_GCS_ENABLE.ForeColor = System.Drawing.Color.White;
            this.mavlinkComboFS_GCS_ENABLE.FormattingEnabled = true;
            this.mavlinkComboFS_GCS_ENABLE.Name = "mavlinkComboFS_GCS_ENABLE";
            this.mavlinkComboFS_GCS_ENABLE.ParamName = null;
            this.mavlinkComboFS_GCS_ENABLE.SubControl = null;
            this.toolTip1.SetToolTip(this.mavlinkComboFS_GCS_ENABLE, resources.GetString("mavlinkComboFS_GCS_ENABLE.ToolTip"));
            // 
            // mavlinkComboBox_fs_thr_enable
            // 
            this.mavlinkComboBox_fs_thr_enable.BackColor = System.Drawing.Color.Black;
            this.mavlinkComboBox_fs_thr_enable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.mavlinkComboBox_fs_thr_enable, "mavlinkComboBox_fs_thr_enable");
            this.mavlinkComboBox_fs_thr_enable.ForeColor = System.Drawing.Color.White;
            this.mavlinkComboBox_fs_thr_enable.FormattingEnabled = true;
            this.mavlinkComboBox_fs_thr_enable.Name = "mavlinkComboBox_fs_thr_enable";
            this.mavlinkComboBox_fs_thr_enable.ParamName = null;
            this.mavlinkComboBox_fs_thr_enable.SubControl = null;
            this.toolTip1.SetToolTip(this.mavlinkComboBox_fs_thr_enable, resources.GetString("mavlinkComboBox_fs_thr_enable.ToolTip"));
            // 
            // mavlinkComboBoxfs_batt_enable
            // 
            this.mavlinkComboBoxfs_batt_enable.BackColor = System.Drawing.Color.Black;
            this.mavlinkComboBoxfs_batt_enable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.mavlinkComboBoxfs_batt_enable, "mavlinkComboBoxfs_batt_enable");
            this.mavlinkComboBoxfs_batt_enable.ForeColor = System.Drawing.Color.White;
            this.mavlinkComboBoxfs_batt_enable.FormattingEnabled = true;
            this.mavlinkComboBoxfs_batt_enable.Name = "mavlinkComboBoxfs_batt_enable";
            this.mavlinkComboBoxfs_batt_enable.ParamName = null;
            this.mavlinkComboBoxfs_batt_enable.SubControl = null;
            this.toolTip1.SetToolTip(this.mavlinkComboBoxfs_batt_enable, resources.GetString("mavlinkComboBoxfs_batt_enable.ToolTip"));
            // 
            // mavlinkNumericUpDownlow_voltage
            // 
            this.mavlinkNumericUpDownlow_voltage.BackColor = System.Drawing.Color.Black;
            this.mavlinkNumericUpDownlow_voltage.DecimalPlaces = 1;
            resources.ApplyResources(this.mavlinkNumericUpDownlow_voltage, "mavlinkNumericUpDownlow_voltage");
            this.mavlinkNumericUpDownlow_voltage.ForeColor = System.Drawing.Color.White;
            this.mavlinkNumericUpDownlow_voltage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mavlinkNumericUpDownlow_voltage.Max = 99F;
            this.mavlinkNumericUpDownlow_voltage.Min = 3F;
            this.mavlinkNumericUpDownlow_voltage.Name = "mavlinkNumericUpDownlow_voltage";
            this.mavlinkNumericUpDownlow_voltage.ParamName = null;
            this.toolTip1.SetToolTip(this.mavlinkNumericUpDownlow_voltage, resources.GetString("mavlinkNumericUpDownlow_voltage.ToolTip"));
            this.mavlinkNumericUpDownlow_voltage.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // lblLevel
            // 
            resources.ApplyResources(this.lblLevel, "lblLevel");
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.ForeColor = System.Drawing.Color.Black;
            this.lblLevel.Name = "lblLevel";
            // 
            // lblPC
            // 
            resources.ApplyResources(this.lblPC, "lblPC");
            this.lblPC.BackColor = System.Drawing.Color.Transparent;
            this.lblPC.ForeColor = System.Drawing.Color.Black;
            this.lblPC.Name = "lblPC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.mavlinkNumericUpDownthr_fs_value);
            this.panel1.Controls.Add(this.mavlinkNumericUpDownfs_thr_value);
            this.panel1.Controls.Add(this.mavlinkComboFS_GCS_ENABLE);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblFailSafeBegin);
            this.panel1.Controls.Add(this.mavlinkComboBox_fs_thr_enable);
            this.panel1.Controls.Add(this.cb_FS_Level_Enable);
            this.panel1.Controls.Add(this.mavlinkComboBoxfs_batt_enable);
            this.panel1.Controls.Add(this.lblPC);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Controls.Add(this.mavlinkNumericUpDownlow_voltage);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // mavlinkNumericUpDownfs_thr_value
            // 
            resources.ApplyResources(this.mavlinkNumericUpDownfs_thr_value, "mavlinkNumericUpDownfs_thr_value");
            this.mavlinkNumericUpDownfs_thr_value.Max = 1F;
            this.mavlinkNumericUpDownfs_thr_value.Min = 0F;
            this.mavlinkNumericUpDownfs_thr_value.Name = "mavlinkNumericUpDownfs_thr_value";
            this.mavlinkNumericUpDownfs_thr_value.ParamName = null;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblSafe);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // lblSafe
            // 
            resources.ApplyResources(this.lblSafe, "lblSafe");
            this.lblSafe.BackColor = System.Drawing.Color.Transparent;
            this.lblSafe.ForeColor = System.Drawing.Color.Black;
            this.lblSafe.Name = "lblSafe";
            // 
            // cb_FS_Level_Enable
            // 
            this.cb_FS_Level_Enable.BackColor = System.Drawing.Color.Black;
            this.cb_FS_Level_Enable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cb_FS_Level_Enable, "cb_FS_Level_Enable");
            this.cb_FS_Level_Enable.ForeColor = System.Drawing.Color.White;
            this.cb_FS_Level_Enable.FormattingEnabled = true;
            this.cb_FS_Level_Enable.Name = "cb_FS_Level_Enable";
            this.cb_FS_Level_Enable.ParamName = null;
            this.cb_FS_Level_Enable.SubControl = null;
            // 
            // currentStateBindingSource
            // 
            this.currentStateBindingSource.DataSource = typeof(ByAeroBeHero.CurrentState);
            // 
            // ConfigFailSafe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel1);
            this.Name = "ConfigFailSafe";
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDownthr_fs_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDownlow_voltage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mavlinkNumericUpDownfs_thr_value)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource currentStateBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
        private Controls.MavlinkComboBox mavlinkComboBox_fs_thr_enable;
        private Controls.MavlinkNumericUpDown mavlinkNumericUpDownfs_thr_value;
        private System.Windows.Forms.Label label4;
        private MavlinkComboBox mavlinkComboBoxfs_batt_enable;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label lblFailSafeBegin;
        private MavlinkComboBox cb_FS_Level_Enable;
        private System.Windows.Forms.Label lblLevel;
        private MavlinkNumericUpDown mavlinkNumericUpDownlow_voltage;
        private MavlinkComboBox mavlinkComboFS_GCS_ENABLE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSafe;
        private MavlinkNumericUpDown mavlinkNumericUpDownthr_fs_value;
    }
}
