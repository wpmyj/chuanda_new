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
            this.lbl_Accel_user = new System.Windows.Forms.Label();
            this.lblCalibate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWarnInfo = new System.Windows.Forms.Label();
            this.panCalibrate = new System.Windows.Forms.Panel();
            this.lblCalibrate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnShowCalibrate = new ByAeroBeHero.Controls.MyButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCorrectA = new System.Windows.Forms.Label();
            this.BUT_level = new ByAeroBeHero.Controls.MyButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblCalibrateAccel = new System.Windows.Forms.Label();
            this.BUT_calib_accell = new ByAeroBeHero.Controls.MyButton();
            this.panel1.SuspendLayout();
            this.panCalibrate.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Accel_user
            // 
            resources.ApplyResources(this.lbl_Accel_user, "lbl_Accel_user");
            this.lbl_Accel_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Accel_user.ForeColor = System.Drawing.Color.Red;
            this.lbl_Accel_user.Name = "lbl_Accel_user";
            // 
            // lblCalibate
            // 
            resources.ApplyResources(this.lblCalibate, "lblCalibate");
            this.lblCalibate.BackColor = System.Drawing.Color.Transparent;
            this.lblCalibate.Name = "lblCalibate";
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
            this.panCalibrate.BackColor = System.Drawing.Color.Transparent;
            this.panCalibrate.Controls.Add(this.lblCalibrate);
            this.panCalibrate.Name = "panCalibrate";
            // 
            // lblCalibrate
            // 
            resources.ApplyResources(this.lblCalibrate, "lblCalibrate");
            this.lblCalibrate.Name = "lblCalibrate";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.panCalibrate);
            this.panel4.Controls.Add(this.btnShowCalibrate);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.BUT_level);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // btnShowCalibrate
            // 
            this.btnShowCalibrate.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowCalibrate.BGGradBot = System.Drawing.Color.Transparent;
            this.btnShowCalibrate.BGGradTop = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnShowCalibrate, "btnShowCalibrate");
            this.btnShowCalibrate.Name = "btnShowCalibrate";
            this.btnShowCalibrate.UseVisualStyleBackColor = false;
            this.btnShowCalibrate.Click += new System.EventHandler(this.btnShowCalibrate_Click);
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblCorrectA);
            this.panel5.Name = "panel5";
            // 
            // lblCorrectA
            // 
            resources.ApplyResources(this.lblCorrectA, "lblCorrectA");
            this.lblCorrectA.BackColor = System.Drawing.Color.Transparent;
            this.lblCorrectA.Name = "lblCorrectA";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.BUT_calib_accell);
            this.panel3.Controls.Add(this.panel1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblCalibrateAccel);
            this.panel6.Name = "panel6";
            // 
            // lblCalibrateAccel
            // 
            resources.ApplyResources(this.lblCalibrateAccel, "lblCalibrateAccel");
            this.lblCalibrateAccel.BackColor = System.Drawing.Color.Transparent;
            this.lblCalibrateAccel.Name = "lblCalibrateAccel";
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
            // ConfigAccelerometerCalibration
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "ConfigAccelerometerCalibration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panCalibrate.ResumeLayout(false);
            this.panCalibrate.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MyButton BUT_calib_accell;
        private System.Windows.Forms.Label lbl_Accel_user;
        private MyButton BUT_level;
        private System.Windows.Forms.Label lblCalibate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWarnInfo;
        private System.Windows.Forms.Panel panCalibrate;
        private System.Windows.Forms.Label lblCalibrate;
        private MyButton btnShowCalibrate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCorrectA;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblCalibrateAccel;
    }
}
