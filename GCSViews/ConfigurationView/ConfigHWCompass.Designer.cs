namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    partial class ConfigHWCompass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigHWCompass));
            this.linkLabelmagdec = new System.Windows.Forms.LinkLabel();
            this.label100 = new System.Windows.Forms.Label();
            this.TXT_declination_deg = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CHK_autodec = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_px4pixhawk = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TXT_declination_min = new System.Windows.Forms.TextBox();
            this.radioButtonmanual = new System.Windows.Forms.RadioButton();
            this.radioButton_external = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radioButton_onboard = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIMU2z = new System.Windows.Forms.Label();
            this.lblIMU2y = new System.Windows.Forms.Label();
            this.lblIMU2x = new System.Windows.Forms.Label();
            this.lblIMUz = new System.Windows.Forms.Label();
            this.lblIMUy = new System.Windows.Forms.Label();
            this.lblIMUx = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblIMU2State = new System.Windows.Forms.Label();
            this.lblIMUState = new System.Windows.Forms.Label();
            this.imageLabel1 = new ByAeroBeHero.Controls.ImageLabel();
            this.BUT_MagCalibrationLive = new ByAeroBeHero.Controls.MyButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CHK_enablecompass = new ByAeroBeHero.Controls.MavlinkCheckBox();
            this.CMB_compass_orient = new ByAeroBeHero.Controls.MavlinkComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelmagdec
            // 
            resources.ApplyResources(this.linkLabelmagdec, "linkLabelmagdec");
            this.linkLabelmagdec.Name = "linkLabelmagdec";
            this.linkLabelmagdec.TabStop = true;
            this.linkLabelmagdec.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label100
            // 
            resources.ApplyResources(this.label100, "label100");
            this.label100.Name = "label100";
            // 
            // TXT_declination_deg
            // 
            resources.ApplyResources(this.TXT_declination_deg, "TXT_declination_deg");
            this.TXT_declination_deg.Name = "TXT_declination_deg";
            this.TXT_declination_deg.Validated += new System.EventHandler(this.TXT_declination_Validated);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ByAeroBeHero.Properties.Resources.compass;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // CHK_autodec
            // 
            this.CHK_autodec.Checked = true;
            this.CHK_autodec.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.CHK_autodec, "CHK_autodec");
            this.CHK_autodec.Name = "CHK_autodec";
            this.CHK_autodec.UseVisualStyleBackColor = true;
            this.CHK_autodec.CheckedChanged += new System.EventHandler(this.CHK_autodec_CheckedChanged);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ByAeroBeHero.Properties.Resources.apmp2;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rb_px4pixhawk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.imageLabel1);
            this.groupBox1.Controls.Add(this.TXT_declination_min);
            this.groupBox1.Controls.Add(this.radioButtonmanual);
            this.groupBox1.Controls.Add(this.radioButton_external);
            this.groupBox1.Controls.Add(this.label100);
            this.groupBox1.Controls.Add(this.CHK_enablecompass);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.linkLabelmagdec);
            this.groupBox1.Controls.Add(this.CMB_compass_orient);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.TXT_declination_deg);
            this.groupBox1.Controls.Add(this.CHK_autodec);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.radioButton_onboard);
            this.groupBox1.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // rb_px4pixhawk
            // 
            resources.ApplyResources(this.rb_px4pixhawk, "rb_px4pixhawk");
            this.rb_px4pixhawk.Checked = true;
            this.rb_px4pixhawk.ForeColor = System.Drawing.Color.White;
            this.rb_px4pixhawk.Name = "rb_px4pixhawk";
            this.rb_px4pixhawk.TabStop = true;
            this.rb_px4pixhawk.UseVisualStyleBackColor = true;
            this.rb_px4pixhawk.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ByAeroBeHero.Properties.Resources.pixhawk;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // TXT_declination_min
            // 
            resources.ApplyResources(this.TXT_declination_min, "TXT_declination_min");
            this.TXT_declination_min.Name = "TXT_declination_min";
            this.TXT_declination_min.Validated += new System.EventHandler(this.TXT_declination_Validated);
            // 
            // radioButtonmanual
            // 
            resources.ApplyResources(this.radioButtonmanual, "radioButtonmanual");
            this.radioButtonmanual.ForeColor = System.Drawing.Color.White;
            this.radioButtonmanual.Name = "radioButtonmanual";
            this.radioButtonmanual.UseVisualStyleBackColor = true;
            this.radioButtonmanual.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_external
            // 
            resources.ApplyResources(this.radioButton_external, "radioButton_external");
            this.radioButton_external.ForeColor = System.Drawing.Color.White;
            this.radioButton_external.Name = "radioButton_external";
            this.radioButton_external.UseVisualStyleBackColor = true;
            this.radioButton_external.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ByAeroBeHero.Properties.Resources.maggps;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // radioButton_onboard
            // 
            resources.ApplyResources(this.radioButton_onboard, "radioButton_onboard");
            this.radioButton_onboard.ForeColor = System.Drawing.Color.White;
            this.radioButton_onboard.Name = "radioButton_onboard";
            this.radioButton_onboard.UseVisualStyleBackColor = true;
            this.radioButton_onboard.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.lblIMU2z, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIMU2y, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIMU2x, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIMUz, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIMUy, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIMUx, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblState, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblIMU2State, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblIMUState, 4, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lblIMU2z
            // 
            resources.ApplyResources(this.lblIMU2z, "lblIMU2z");
            this.lblIMU2z.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "mz2", true));
            this.lblIMU2z.ForeColor = System.Drawing.Color.White;
            this.lblIMU2z.Name = "lblIMU2z";
            // 
            // lblIMU2y
            // 
            resources.ApplyResources(this.lblIMU2y, "lblIMU2y");
            this.lblIMU2y.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "my2", true));
            this.lblIMU2y.ForeColor = System.Drawing.Color.White;
            this.lblIMU2y.Name = "lblIMU2y";
            // 
            // lblIMU2x
            // 
            resources.ApplyResources(this.lblIMU2x, "lblIMU2x");
            this.lblIMU2x.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "mx2", true));
            this.lblIMU2x.ForeColor = System.Drawing.Color.White;
            this.lblIMU2x.Name = "lblIMU2x";
            // 
            // lblIMUz
            // 
            resources.ApplyResources(this.lblIMUz, "lblIMUz");
            this.lblIMUz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "mz", true));
            this.lblIMUz.ForeColor = System.Drawing.Color.White;
            this.lblIMUz.Name = "lblIMUz";
            // 
            // lblIMUy
            // 
            resources.ApplyResources(this.lblIMUy, "lblIMUy");
            this.lblIMUy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "my", true));
            this.lblIMUy.ForeColor = System.Drawing.Color.White;
            this.lblIMUy.Name = "lblIMUy";
            // 
            // lblIMUx
            // 
            resources.ApplyResources(this.lblIMUx, "lblIMUx");
            this.lblIMUx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "mx", true));
            this.lblIMUx.ForeColor = System.Drawing.Color.White;
            this.lblIMUx.Name = "lblIMUx";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Name = "label10";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // lblState
            // 
            resources.ApplyResources(this.lblState, "lblState");
            this.lblState.ForeColor = System.Drawing.Color.White;
            this.lblState.Name = "lblState";
            // 
            // lblIMU2State
            // 
            resources.ApplyResources(this.lblIMU2State, "lblIMU2State");
            this.lblIMU2State.ForeColor = System.Drawing.Color.White;
            this.lblIMU2State.Name = "lblIMU2State";
            // 
            // lblIMUState
            // 
            resources.ApplyResources(this.lblIMUState, "lblIMUState");
            this.lblIMUState.ForeColor = System.Drawing.Color.White;
            this.lblIMUState.Name = "lblIMUState";
            // 
            // imageLabel1
            // 
            this.imageLabel1.Image = ((System.Drawing.Image)(resources.GetObject("imageLabel1.Image")));
            resources.ApplyResources(this.imageLabel1, "imageLabel1");
            this.imageLabel1.Name = "imageLabel1";
            // 
            // BUT_MagCalibrationLive
            // 
            this.BUT_MagCalibrationLive.BackColor = System.Drawing.Color.Black;
            this.BUT_MagCalibrationLive.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BUT_MagCalibrationLive.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BUT_MagCalibrationLive.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.BUT_MagCalibrationLive, "BUT_MagCalibrationLive");
            this.BUT_MagCalibrationLive.Name = "BUT_MagCalibrationLive";
            this.BUT_MagCalibrationLive.UseVisualStyleBackColor = false;
            this.BUT_MagCalibrationLive.Click += new System.EventHandler(this.BUT_MagCalibration_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(ByAeroBeHero.CurrentState);
            // 
            // CHK_enablecompass
            // 
            this.CHK_enablecompass.Checked = true;
            this.CHK_enablecompass.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.CHK_enablecompass, "CHK_enablecompass");
            this.CHK_enablecompass.Name = "CHK_enablecompass";
            this.CHK_enablecompass.OffValue = 0D;
            this.CHK_enablecompass.OnValue = 1D;
            this.CHK_enablecompass.ParamName = null;
            this.CHK_enablecompass.UseVisualStyleBackColor = true;
            this.CHK_enablecompass.CheckedChanged += new System.EventHandler(this.CHK_enablecompass_CheckedChanged);
            // 
            // CMB_compass_orient
            // 
            this.CMB_compass_orient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.CMB_compass_orient, "CMB_compass_orient");
            this.CMB_compass_orient.FormattingEnabled = true;
            this.CMB_compass_orient.Name = "CMB_compass_orient";
            this.CMB_compass_orient.ParamName = null;
            this.CMB_compass_orient.SubControl = null;
            // 
            // ConfigHWCompass
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BUT_MagCalibrationLive);
            this.Name = "ConfigHWCompass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyButton BUT_MagCalibrationLive;
        private System.Windows.Forms.LinkLabel linkLabelmagdec;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox TXT_declination_deg;
        private Controls.MavlinkCheckBox CHK_enablecompass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CHK_autodec;
        private Controls.MavlinkComboBox CMB_compass_orient;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private Controls.ImageLabel imageLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonmanual;
        private System.Windows.Forms.RadioButton radioButton_external;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton radioButton_onboard;
        private System.Windows.Forms.TextBox TXT_declination_min;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_px4pixhawk;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIMU2z;
        private System.Windows.Forms.Label lblIMU2y;
        private System.Windows.Forms.Label lblIMU2x;
        private System.Windows.Forms.Label lblIMUz;
        private System.Windows.Forms.Label lblIMUy;
        private System.Windows.Forms.Label lblIMUx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblIMU2State;
        private System.Windows.Forms.Label lblIMUState;
    }
}
