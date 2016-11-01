using ByAeroBeHero.Controls;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    partial class ConfigAccelerometerCalibration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigAccelerometerCalibration));
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Accel_user = new System.Windows.Forms.Label();
            this.BUT_calib_accell = new ByAeroBeHero.Controls.MyButton();
            this.BUT_level = new ByAeroBeHero.Controls.MyButton();
            this.lblCalibate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWarnInfo = new System.Windows.Forms.Label();
            this.panCalibrate = new System.Windows.Forms.Panel();
            this.lblCalibrate = new System.Windows.Forms.Label();
            this.panel2 = new BSE.Windows.Forms.Panel();
            this.panel3 = new BSE.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panCalibrate.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lbl_Accel_user
            // 
            resources.ApplyResources(this.lbl_Accel_user, "lbl_Accel_user");
            this.lbl_Accel_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Accel_user.ForeColor = System.Drawing.Color.Red;
            this.lbl_Accel_user.Name = "lbl_Accel_user";
            // 
            // BUT_calib_accell
            // 
            resources.ApplyResources(this.BUT_calib_accell, "BUT_calib_accell");
            this.BUT_calib_accell.BackColor = System.Drawing.SystemColors.Control;
            this.BUT_calib_accell.BGGradBot = System.Drawing.Color.Transparent;
            this.BUT_calib_accell.BGGradTop = System.Drawing.Color.Transparent;
            this.BUT_calib_accell.Name = "BUT_calib_accell";
            this.BUT_calib_accell.UseVisualStyleBackColor = false;
            this.BUT_calib_accell.Click += new System.EventHandler(this.BUT_calib_accell_Click);
            // 
            // BUT_level
            // 
            resources.ApplyResources(this.BUT_level, "BUT_level");
            this.BUT_level.BackColor = System.Drawing.SystemColors.Control;
            this.BUT_level.BGGradBot = System.Drawing.Color.Transparent;
            this.BUT_level.BGGradTop = System.Drawing.Color.Transparent;
            this.BUT_level.Name = "BUT_level";
            this.BUT_level.UseVisualStyleBackColor = false;
            this.BUT_level.Click += new System.EventHandler(this.BUT_level_Click);
            // 
            // lblCalibate
            // 
            resources.ApplyResources(this.lblCalibate, "lblCalibate");
            this.lblCalibate.BackColor = System.Drawing.Color.Transparent;
            this.lblCalibate.Name = "lblCalibate";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.lblWarnInfo);
            this.panel1.Controls.Add(this.lbl_Accel_user);
            this.panel1.Controls.Add(this.lblCalibate);
            this.panel1.Name = "panel1";
            // 
            // lblWarnInfo
            // 
            resources.ApplyResources(this.lblWarnInfo, "lblWarnInfo");
            this.lblWarnInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblWarnInfo.ForeColor = System.Drawing.Color.Red;
            this.lblWarnInfo.Name = "lblWarnInfo";
            // 
            // panCalibrate
            // 
            resources.ApplyResources(this.panCalibrate, "panCalibrate");
            this.panCalibrate.Controls.Add(this.lblCalibrate);
            this.panCalibrate.Name = "panCalibrate";
            // 
            // lblCalibrate
            // 
            resources.ApplyResources(this.lblCalibrate, "lblCalibrate");
            this.lblCalibrate.Name = "lblCalibrate";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.AssociatedSplitter = null;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panel2.CaptionHeight = 27;
            this.panel2.Controls.Add(this.BUT_calib_accell);
            this.panel2.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel2.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel2.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel2.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel2.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel2.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel2.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel2.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
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
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.AssociatedSplitter = null;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 11.75F, System.Drawing.FontStyle.Bold);
            this.panel3.CaptionHeight = 27;
            this.panel3.Controls.Add(this.panCalibrate);
            this.panel3.Controls.Add(this.BUT_level);
            this.panel3.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel3.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel3.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel3.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel3.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel3.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.panel3.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
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
            // ConfigAccelerometerCalibration
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigAccelerometerCalibration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panCalibrate.ResumeLayout(false);
            this.panCalibrate.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private MyButton BUT_calib_accell;
        private System.Windows.Forms.Label lbl_Accel_user;
        private MyButton BUT_level;
        private System.Windows.Forms.Label lblCalibate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWarnInfo;
        private System.Windows.Forms.Panel panCalibrate;
        private System.Windows.Forms.Label lblCalibrate;
        private BSE.Windows.Forms.Panel panel2;
        private BSE.Windows.Forms.Panel panel3;
    }
}
