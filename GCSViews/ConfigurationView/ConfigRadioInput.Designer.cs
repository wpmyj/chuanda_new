using ByAeroBeHero.Controls;
namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    partial class ConfigRadioInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigRadioInput));
            this.groupBoxElevons = new System.Windows.Forms.GroupBox();
            this.CHK_mixmode = new System.Windows.Forms.CheckBox();
            this.CHK_elevonch2rev = new System.Windows.Forms.CheckBox();
            this.CHK_elevonrev = new System.Windows.Forms.CheckBox();
            this.CHK_elevonch1rev = new System.Windows.Forms.CheckBox();
            this.CHK_revch3 = new System.Windows.Forms.CheckBox();
            this.CHK_revch4 = new System.Windows.Forms.CheckBox();
            this.CHK_revch2 = new System.Windows.Forms.CheckBox();
            this.CHK_revch1 = new System.Windows.Forms.CheckBox();
            this.BUT_BindDSM8 = new ByAeroBeHero.Controls.MyButton();
            this.BUT_BindDSMX = new ByAeroBeHero.Controls.MyButton();
            this.BUT_BindDSM2 = new ByAeroBeHero.Controls.MyButton();
            this.BUT_Calibrateradio = new ByAeroBeHero.Controls.MyButton();
            this.BAR8 = new ByAeroBeHero.Controls.HorizontalProgressBar2();
            this.BAR7 = new ByAeroBeHero.Controls.HorizontalProgressBar2();
            this.BAR6 = new ByAeroBeHero.Controls.HorizontalProgressBar2();
            this.BAR5 = new ByAeroBeHero.Controls.HorizontalProgressBar2();
            this.BARyaw = new ByAeroBeHero.Controls.HorizontalProgressBar2();
            this.BARroll = new ByAeroBeHero.Controls.HorizontalProgressBar2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BARpitch = new ByAeroBeHero.Controls.HorizontalProgressBar2();
            this.BARthrottle = new ByAeroBeHero.Controls.HorizontalProgressBar2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currentStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxElevons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxElevons
            // 
            this.groupBoxElevons.Controls.Add(this.CHK_mixmode);
            this.groupBoxElevons.Controls.Add(this.CHK_elevonch2rev);
            this.groupBoxElevons.Controls.Add(this.CHK_elevonrev);
            this.groupBoxElevons.Controls.Add(this.CHK_elevonch1rev);
            resources.ApplyResources(this.groupBoxElevons, "groupBoxElevons");
            this.groupBoxElevons.Name = "groupBoxElevons";
            this.groupBoxElevons.TabStop = false;
            // 
            // CHK_mixmode
            // 
            resources.ApplyResources(this.CHK_mixmode, "CHK_mixmode");
            this.CHK_mixmode.Name = "CHK_mixmode";
            this.CHK_mixmode.UseVisualStyleBackColor = true;
            this.CHK_mixmode.CheckedChanged += new System.EventHandler(this.CHK_mixmode_CheckedChanged);
            // 
            // CHK_elevonch2rev
            // 
            resources.ApplyResources(this.CHK_elevonch2rev, "CHK_elevonch2rev");
            this.CHK_elevonch2rev.Name = "CHK_elevonch2rev";
            this.CHK_elevonch2rev.UseVisualStyleBackColor = true;
            this.CHK_elevonch2rev.CheckedChanged += new System.EventHandler(this.CHK_elevonch2rev_CheckedChanged);
            // 
            // CHK_elevonrev
            // 
            resources.ApplyResources(this.CHK_elevonrev, "CHK_elevonrev");
            this.CHK_elevonrev.Name = "CHK_elevonrev";
            this.CHK_elevonrev.UseVisualStyleBackColor = true;
            this.CHK_elevonrev.CheckedChanged += new System.EventHandler(this.CHK_elevonrev_CheckedChanged);
            // 
            // CHK_elevonch1rev
            // 
            resources.ApplyResources(this.CHK_elevonch1rev, "CHK_elevonch1rev");
            this.CHK_elevonch1rev.Name = "CHK_elevonch1rev";
            this.CHK_elevonch1rev.UseVisualStyleBackColor = true;
            this.CHK_elevonch1rev.CheckedChanged += new System.EventHandler(this.CHK_elevonch1rev_CheckedChanged);
            // 
            // CHK_revch3
            // 
            resources.ApplyResources(this.CHK_revch3, "CHK_revch3");
            this.CHK_revch3.Name = "CHK_revch3";
            this.CHK_revch3.UseVisualStyleBackColor = true;
            this.CHK_revch3.CheckedChanged += new System.EventHandler(this.CHK_revch3_CheckedChanged);
            // 
            // CHK_revch4
            // 
            resources.ApplyResources(this.CHK_revch4, "CHK_revch4");
            this.CHK_revch4.Name = "CHK_revch4";
            this.CHK_revch4.UseVisualStyleBackColor = true;
            this.CHK_revch4.CheckedChanged += new System.EventHandler(this.CHK_revch4_CheckedChanged);
            // 
            // CHK_revch2
            // 
            resources.ApplyResources(this.CHK_revch2, "CHK_revch2");
            this.CHK_revch2.Name = "CHK_revch2";
            this.CHK_revch2.UseVisualStyleBackColor = true;
            this.CHK_revch2.CheckedChanged += new System.EventHandler(this.CHK_revch2_CheckedChanged);
            // 
            // CHK_revch1
            // 
            resources.ApplyResources(this.CHK_revch1, "CHK_revch1");
            this.CHK_revch1.Name = "CHK_revch1";
            this.CHK_revch1.UseVisualStyleBackColor = true;
            this.CHK_revch1.CheckedChanged += new System.EventHandler(this.CHK_revch1_CheckedChanged);
            // 
            // BUT_BindDSM8
            // 
            resources.ApplyResources(this.BUT_BindDSM8, "BUT_BindDSM8");
            this.BUT_BindDSM8.Name = "BUT_BindDSM8";
            this.BUT_BindDSM8.UseVisualStyleBackColor = true;
            this.BUT_BindDSM8.Click += new System.EventHandler(this.BUT_Bindradiodsm8_Click);
            // 
            // BUT_BindDSMX
            // 
            resources.ApplyResources(this.BUT_BindDSMX, "BUT_BindDSMX");
            this.BUT_BindDSMX.Name = "BUT_BindDSMX";
            this.BUT_BindDSMX.UseVisualStyleBackColor = true;
            this.BUT_BindDSMX.Click += new System.EventHandler(this.BUT_BindradiodsmX_Click);
            // 
            // BUT_BindDSM2
            // 
            resources.ApplyResources(this.BUT_BindDSM2, "BUT_BindDSM2");
            this.BUT_BindDSM2.Name = "BUT_BindDSM2";
            this.BUT_BindDSM2.UseVisualStyleBackColor = true;
            this.BUT_BindDSM2.Click += new System.EventHandler(this.BUT_Bindradiodsm2_Click);
            // 
            // BUT_Calibrateradio
            // 
            resources.ApplyResources(this.BUT_Calibrateradio, "BUT_Calibrateradio");
            this.BUT_Calibrateradio.Name = "BUT_Calibrateradio";
            this.BUT_Calibrateradio.UseVisualStyleBackColor = true;
            this.BUT_Calibrateradio.Click += new System.EventHandler(this.BUT_Calibrateradio_Click);
            // 
            // BAR8
            // 
            this.BAR8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR8.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR8.DrawLabel = true;
            resources.ApplyResources(this.BAR8, "BAR8");
            this.BAR8.Label = "通道 8";
            this.BAR8.Maximum = 2200;
            this.BAR8.maxline = 0;
            this.BAR8.Minimum = 800;
            this.BAR8.minline = 0;
            this.BAR8.Name = "BAR8";
            this.BAR8.Value = 1500;
            this.BAR8.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BAR7
            // 
            this.BAR7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR7.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR7.DrawLabel = true;
            resources.ApplyResources(this.BAR7, "BAR7");
            this.BAR7.Label = "通道 7";
            this.BAR7.Maximum = 2200;
            this.BAR7.maxline = 0;
            this.BAR7.Minimum = 800;
            this.BAR7.minline = 0;
            this.BAR7.Name = "BAR7";
            this.BAR7.Value = 1500;
            this.BAR7.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BAR6
            // 
            this.BAR6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR6.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR6.DrawLabel = true;
            resources.ApplyResources(this.BAR6, "BAR6");
            this.BAR6.Label = "通道 6";
            this.BAR6.Maximum = 2200;
            this.BAR6.maxline = 0;
            this.BAR6.Minimum = 800;
            this.BAR6.minline = 0;
            this.BAR6.Name = "BAR6";
            this.BAR6.Value = 1500;
            this.BAR6.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BAR5
            // 
            this.BAR5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR5.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR5.DrawLabel = true;
            resources.ApplyResources(this.BAR5, "BAR5");
            this.BAR5.Label = "通道 5";
            this.BAR5.Maximum = 2200;
            this.BAR5.maxline = 0;
            this.BAR5.Minimum = 800;
            this.BAR5.minline = 0;
            this.BAR5.Name = "BAR5";
            this.BAR5.Value = 1500;
            this.BAR5.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BARyaw
            // 
            this.BARyaw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BARyaw.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BARyaw.DrawLabel = true;
            resources.ApplyResources(this.BARyaw, "BARyaw");
            this.BARyaw.Label = "航向";
            this.BARyaw.Maximum = 2200;
            this.BARyaw.maxline = 0;
            this.BARyaw.Minimum = 800;
            this.BARyaw.minline = 0;
            this.BARyaw.Name = "BARyaw";
            this.BARyaw.Value = 1500;
            this.BARyaw.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BARroll
            // 
            this.BARroll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BARroll.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BARroll.DrawLabel = true;
            resources.ApplyResources(this.BARroll, "BARroll");
            this.BARroll.Label = "滚转";
            this.BARroll.Maximum = 2200;
            this.BARroll.maxline = 0;
            this.BARroll.Minimum = 800;
            this.BARroll.minline = 0;
            this.BARroll.Name = "BARroll";
            this.BARroll.Value = 1500;
            this.BARroll.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BUT_BindDSM2);
            this.groupBox1.Controls.Add(this.BUT_BindDSM8);
            this.groupBox1.Controls.Add(this.BUT_BindDSMX);
            this.groupBox1.Controls.Add(this.groupBoxElevons);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BARpitch
            // 
            this.BARpitch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BARpitch.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BARpitch.DrawLabel = true;
            resources.ApplyResources(this.BARpitch, "BARpitch");
            this.BARpitch.Label = "俯仰";
            this.BARpitch.Maximum = 2200;
            this.BARpitch.maxline = 0;
            this.BARpitch.Minimum = 800;
            this.BARpitch.minline = 0;
            this.BARpitch.Name = "BARpitch";
            this.BARpitch.Value = 1500;
            this.BARpitch.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BARthrottle
            // 
            this.BARthrottle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BARthrottle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BARthrottle.DrawLabel = true;
            resources.ApplyResources(this.BARthrottle, "BARthrottle");
            this.BARthrottle.Label = "油门";
            this.BARthrottle.Maximum = 2200;
            this.BARthrottle.maxline = 0;
            this.BARthrottle.Minimum = 800;
            this.BARthrottle.minline = 0;
            this.BARthrottle.Name = "BARthrottle";
            this.BARthrottle.Value = 1500;
            this.BARthrottle.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BAR5);
            this.groupBox2.Controls.Add(this.BAR6);
            this.groupBox2.Controls.Add(this.BAR7);
            this.groupBox2.Controls.Add(this.BAR8);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BARthrottle);
            this.groupBox3.Controls.Add(this.BARroll);
            this.groupBox3.Controls.Add(this.BARyaw);
            this.groupBox3.Controls.Add(this.BARpitch);
            this.groupBox3.Controls.Add(this.CHK_revch1);
            this.groupBox3.Controls.Add(this.CHK_revch2);
            this.groupBox3.Controls.Add(this.CHK_revch3);
            this.groupBox3.Controls.Add(this.CHK_revch4);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Name = "label3";
            // 
            // currentStateBindingSource
            // 
            this.currentStateBindingSource.DataSource = typeof(ByAeroBeHero.CurrentState);
            // 
            // ConfigRadioInput
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BUT_Calibrateradio);
            this.Name = "ConfigRadioInput";
            this.groupBoxElevons.ResumeLayout(false);
            this.groupBoxElevons.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxElevons;
        private System.Windows.Forms.CheckBox CHK_mixmode;
        private System.Windows.Forms.CheckBox CHK_elevonch2rev;
        private System.Windows.Forms.CheckBox CHK_elevonrev;
        private System.Windows.Forms.CheckBox CHK_elevonch1rev;
        private System.Windows.Forms.CheckBox CHK_revch3;
        private System.Windows.Forms.CheckBox CHK_revch4;
        private System.Windows.Forms.CheckBox CHK_revch2;
        private System.Windows.Forms.CheckBox CHK_revch1;
        private Controls.MyButton BUT_Calibrateradio;
        private HorizontalProgressBar2 BAR8;
        private HorizontalProgressBar2 BAR7;
        private HorizontalProgressBar2 BAR6;
        private HorizontalProgressBar2 BAR5;
        private HorizontalProgressBar2 BARyaw;
        private HorizontalProgressBar2 BARroll;
        private System.Windows.Forms.BindingSource currentStateBindingSource;
        private MyButton BUT_BindDSM2;
        private MyButton BUT_BindDSMX;
        private MyButton BUT_BindDSM8;
        private System.Windows.Forms.GroupBox groupBox1;
        private HorizontalProgressBar2 BARpitch;
        private HorizontalProgressBar2 BARthrottle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
