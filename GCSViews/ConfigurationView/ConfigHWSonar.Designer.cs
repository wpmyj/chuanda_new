﻿namespace ByAeroBeHero.GCSViews.ConfigurationView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBL_volt = new System.Windows.Forms.Label();
            this.LBL_dist = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chbSonar = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.CMB_sonartype = new ByAeroBeHero.Controls.MavlinkComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbSonar);
            this.groupBox2.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
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
            // ConfigHWSonar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_volt);
            this.Controls.Add(this.LBL_dist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CMB_sonartype);
            this.Controls.Add(this.pictureBox3);
            this.Name = "ConfigHWSonar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MavlinkComboBox CMB_sonartype;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBL_volt;
        private System.Windows.Forms.Label LBL_dist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controls.MavlinkCheckBox chbSonar;
        private System.Windows.Forms.Label label3;
    }
}
