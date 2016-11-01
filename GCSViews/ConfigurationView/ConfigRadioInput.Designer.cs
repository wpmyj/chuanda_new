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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new BSE.Windows.Forms.Panel();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.currentStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBoxElevons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.BUT_Calibrateradio.BackColor = System.Drawing.SystemColors.Control;
            this.BUT_Calibrateradio.BGGradBot = System.Drawing.Color.Transparent;
            this.BUT_Calibrateradio.BGGradTop = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BUT_Calibrateradio, "BUT_Calibrateradio");
            this.BUT_Calibrateradio.Name = "BUT_Calibrateradio";
            this.BUT_Calibrateradio.UseVisualStyleBackColor = false;
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
            this.BAR8.Click += new System.EventHandler(this.BAR8_Click);
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.AssociatedSplitter = null;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.CaptionFont = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.CaptionHeight = 27;
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lbl8);
            this.panel1.Controls.Add(this.lbl7);
            this.panel1.Controls.Add(this.lbl6);
            this.panel1.Controls.Add(this.lbl5);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BAR8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BAR7);
            this.panel1.Controls.Add(this.BUT_Calibrateradio);
            this.panel1.Controls.Add(this.BAR6);
            this.panel1.Controls.Add(this.BAR5);
            this.panel1.Controls.Add(this.BARyaw);
            this.panel1.Controls.Add(this.BARthrottle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.BARroll);
            this.panel1.Controls.Add(this.BARpitch);
            this.panel1.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel1.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel1.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
            this.panel1.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panel1.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(215)))), ((int)(((byte)(243)))));
            this.panel1.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
            this.panel1.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
            this.panel1.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel1.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Image = null;
            this.panel1.Name = "panel1";
            this.panel1.ToolTipTextCloseIcon = null;
            this.panel1.ToolTipTextExpandIconPanelCollapsed = null;
            this.panel1.ToolTipTextExpandIconPanelExpanded = null;
            this.panel1.CloseClick += new System.EventHandler<System.EventArgs>(this.panel1_CloseClick);
            // 
            // lbl8
            // 
            resources.ApplyResources(this.lbl8, "lbl8");
            this.lbl8.Name = "lbl8";
            // 
            // lbl7
            // 
            resources.ApplyResources(this.lbl7, "lbl7");
            this.lbl7.Name = "lbl7";
            // 
            // lbl6
            // 
            resources.ApplyResources(this.lbl6, "lbl6");
            this.lbl6.Name = "lbl6";
            // 
            // lbl5
            // 
            resources.ApplyResources(this.lbl5, "lbl5");
            this.lbl5.Name = "lbl5";
            // 
            // lbl4
            // 
            resources.ApplyResources(this.lbl4, "lbl4");
            this.lbl4.Name = "lbl4";
            // 
            // lbl3
            // 
            resources.ApplyResources(this.lbl3, "lbl3");
            this.lbl3.Name = "lbl3";
            // 
            // lbl2
            // 
            resources.ApplyResources(this.lbl2, "lbl2");
            this.lbl2.Name = "lbl2";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.Name = "lbl1";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // currentStateBindingSource
            // 
            this.currentStateBindingSource.DataSource = typeof(ByAeroBeHero.CurrentState);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // ConfigRadioInput
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConfigRadioInput";
            this.groupBoxElevons.ResumeLayout(false);
            this.groupBoxElevons.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxElevons;
        private System.Windows.Forms.CheckBox CHK_mixmode;
        private System.Windows.Forms.CheckBox CHK_elevonch2rev;
        private System.Windows.Forms.CheckBox CHK_elevonrev;
        private System.Windows.Forms.CheckBox CHK_elevonch1rev;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BSE.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
    }
}
