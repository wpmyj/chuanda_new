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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWarnInfo = new System.Windows.Forms.Label();
            this.panCalibrate = new System.Windows.Forms.Panel();
            this.lblCalibrate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panCalibrate.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.lbl_Accel_user.ForeColor = System.Drawing.Color.Red;
            this.lbl_Accel_user.Name = "lbl_Accel_user";
            // 
            // BUT_calib_accell
            // 
            resources.ApplyResources(this.BUT_calib_accell, "BUT_calib_accell");
            this.BUT_calib_accell.Name = "BUT_calib_accell";
            this.BUT_calib_accell.UseVisualStyleBackColor = true;
            this.BUT_calib_accell.Click += new System.EventHandler(this.BUT_calib_accell_Click);
            // 
            // BUT_level
            // 
            resources.ApplyResources(this.BUT_level, "BUT_level");
            this.BUT_level.Name = "BUT_level";
            this.BUT_level.UseVisualStyleBackColor = true;
            this.BUT_level.Click += new System.EventHandler(this.BUT_level_Click);
            // 
            // lblCalibate
            // 
            resources.ApplyResources(this.lblCalibate, "lblCalibate");
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
            this.tableLayoutPanel2.Controls.Add(this.BUT_calib_accell, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblWarnInfo);
            this.panel1.Controls.Add(this.lbl_Accel_user);
            this.panel1.Controls.Add(this.lblCalibate);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblWarnInfo
            // 
            resources.ApplyResources(this.lblWarnInfo, "lblWarnInfo");
            this.lblWarnInfo.ForeColor = System.Drawing.Color.Red;
            this.lblWarnInfo.Name = "lblWarnInfo";
            // 
            // panCalibrate
            // 
            this.panCalibrate.Controls.Add(this.lblCalibrate);
            resources.ApplyResources(this.panCalibrate, "panCalibrate");
            this.panCalibrate.Name = "panCalibrate";
            // 
            // lblCalibrate
            // 
            resources.ApplyResources(this.lblCalibrate, "lblCalibrate");
            this.lblCalibrate.Name = "lblCalibrate";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.BUT_level, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panCalibrate, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // ConfigAccelerometerCalibration
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigAccelerometerCalibration";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panCalibrate.ResumeLayout(false);
            this.panCalibrate.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWarnInfo;
        private System.Windows.Forms.Panel panCalibrate;
        private System.Windows.Forms.Label lblCalibrate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
