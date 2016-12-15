namespace ByAeroBeHero.GCSViews
{
    partial class InitialSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialSetup));
            this.backstageView = new ByAeroBeHero.Controls.BackstageView.BackstageView();
            this.configWizard1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigWizard();
            this.configMandatory1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigMandatory();
            this.initialSetupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.configTradHeli1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigTradHeli();
            this.backstageViewPageframetype = new ByAeroBeHero.Controls.BackstageView.BackstageViewPage();
            this.configFrameType1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigFrameType();
            this.backstageViewPageaccel = new ByAeroBeHero.Controls.BackstageView.BackstageViewPage();
            this.configAccelerometerCalibration = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigAccelerometerCalibration();
            this.backstageViewPagecompass = new ByAeroBeHero.Controls.BackstageView.BackstageViewPage();
            this.configHWCompass1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigHWCompass();
            this.backstageViewPageradio = new ByAeroBeHero.Controls.BackstageView.BackstageViewPage();
            this.configRadioInput1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigRadioInput();
            this.configFlightModes1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigFlightModes();
            this.backstageViewPagefs = new ByAeroBeHero.Controls.BackstageView.BackstageViewPage();
            this.configFailSafe1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigFailSafe();
            this.configOptional1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigOptional();
            this._3DRradio1 = new ByAeroBeHero._3DRradio();
            this.configBatteryMonitoring1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigBatteryMonitoring();
            this.configCompassMot1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigCompassMot();
            this.backstageViewPagesonar = new ByAeroBeHero.Controls.BackstageView.BackstageViewPage();
            this.configHWSonar1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigHWSonar();
            this.configHWAirspeed1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigHWAirspeed();
            this.configHWOptFlow1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigHWOptFlow();
            this.configHWOSD1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigHWOSD();
            this.configMount1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigMount();
            this.tracker1 = new ByAeroBeHero.Antenna.Tracker();
            this.configMotor1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigMotorTest();
            this.configHWBT1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigHWBT();
            this.configHWPa1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigHWParachute();
            this.backstageViewPageinstfw = new ByAeroBeHero.Controls.BackstageView.BackstageViewPage();
            this.configFirmware1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigFirmware();
            this.backstageViewPageSetParams = new ByAeroBeHero.Controls.BackstageView.BackstageViewPage();
            this.configSetParams1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigSetParams();
            this.backstageViewPageMotorblance = new ByAeroBeHero.Controls.BackstageView.BackstageViewPage();
            this.ConfigMotorbalance1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigMotorbalance();
            this.backstageViewPagefw = new ByAeroBeHero.Controls.BackstageView.BackstageViewPage();
            this.backstageViewPagefwdisabled = new ByAeroBeHero.Controls.BackstageView.BackstageViewPage();
            this.configFirmwareDisabled1 = new ByAeroBeHero.GCSViews.ConfigurationView.ConfigFirmwareDisabled();
            ((System.ComponentModel.ISupportInitialize)(this.initialSetupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backstageView
            // 
            this.backstageView.BackColor = System.Drawing.Color.Black;
            this.backstageView.ButtonsAreaBgColor = System.Drawing.Color.Black;
            this.backstageView.ButtonsAreaPencilColor = System.Drawing.Color.White;
            resources.ApplyResources(this.backstageView, "backstageView");
            this.backstageView.ForeColor = System.Drawing.Color.Black;
            this.backstageView.HighlightColor1 = System.Drawing.SystemColors.Highlight;
            this.backstageView.HighlightColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.backstageView.Name = "backstageView";
            this.backstageView.Pages.Add(this.backstageViewPageframetype);
            this.backstageView.Pages.Add(this.backstageViewPageaccel);
            this.backstageView.Pages.Add(this.backstageViewPagecompass);
            this.backstageView.Pages.Add(this.backstageViewPageradio);
            this.backstageView.Pages.Add(this.backstageViewPagefs);
            this.backstageView.Pages.Add(this.backstageViewPagesonar);
            this.backstageView.Pages.Add(this.backstageViewPageinstfw);
            this.backstageView.Pages.Add(this.backstageViewPageSetParams);
            this.backstageView.Pages.Add(this.backstageViewPageMotorblance);
            this.backstageView.UnSelectedTextColor = System.Drawing.Color.White;
            this.backstageView.WidthMenu = 1000;
            // 
            // configWizard1
            // 
            resources.ApplyResources(this.configWizard1, "configWizard1");
            this.configWizard1.Name = "configWizard1";
            // 
            // configMandatory1
            // 
            resources.ApplyResources(this.configMandatory1, "configMandatory1");
            this.configMandatory1.Name = "configMandatory1";
            // 
            // initialSetupBindingSource
            // 
            this.initialSetupBindingSource.DataSource = typeof(ByAeroBeHero.GCSViews.InitialSetup);
            // 
            // configTradHeli1
            // 
            resources.ApplyResources(this.configTradHeli1, "configTradHeli1");
            this.configTradHeli1.Name = "configTradHeli1";
            // 
            // backstageViewPageframetype
            // 
            this.backstageViewPageframetype.Advanced = false;
            this.backstageViewPageframetype.DataBindings.Add(new System.Windows.Forms.Binding("Show", this.initialSetupBindingSource, "isCopter", true));
            this.backstageViewPageframetype.LinkText = "Frame Type";
            this.backstageViewPageframetype.Page = this.configFrameType1;
            this.backstageViewPageframetype.Parent = null;
            this.backstageViewPageframetype.Show = true;
            this.backstageViewPageframetype.Spacing = 30;
            resources.ApplyResources(this.backstageViewPageframetype, "backstageViewPageframetype");
            // 
            // configFrameType1
            // 
            resources.ApplyResources(this.configFrameType1, "configFrameType1");
            this.configFrameType1.BackColor = System.Drawing.Color.White;
            this.configFrameType1.ForeColor = System.Drawing.Color.White;
            this.configFrameType1.Name = "configFrameType1";
            // 
            // backstageViewPageaccel
            // 
            this.backstageViewPageaccel.Advanced = false;
            this.backstageViewPageaccel.DataBindings.Add(new System.Windows.Forms.Binding("Show", this.initialSetupBindingSource, "isConnected", true));
            this.backstageViewPageaccel.LinkText = "Accel Calibration";
            this.backstageViewPageaccel.Page = this.configAccelerometerCalibration;
            this.backstageViewPageaccel.Parent = null;
            this.backstageViewPageaccel.Show = true;
            this.backstageViewPageaccel.Spacing = 30;
            resources.ApplyResources(this.backstageViewPageaccel, "backstageViewPageaccel");
            // 
            // configAccelerometerCalibration
            // 
            this.configAccelerometerCalibration.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.configAccelerometerCalibration, "configAccelerometerCalibration");
            this.configAccelerometerCalibration.Name = "configAccelerometerCalibration";
            // 
            // backstageViewPagecompass
            // 
            this.backstageViewPagecompass.Advanced = false;
            this.backstageViewPagecompass.DataBindings.Add(new System.Windows.Forms.Binding("Show", this.initialSetupBindingSource, "isConnected", true));
            this.backstageViewPagecompass.LinkText = "Compass";
            this.backstageViewPagecompass.Page = this.configHWCompass1;
            this.backstageViewPagecompass.Parent = null;
            this.backstageViewPagecompass.Show = true;
            this.backstageViewPagecompass.Spacing = 30;
            resources.ApplyResources(this.backstageViewPagecompass, "backstageViewPagecompass");
            // 
            // configHWCompass1
            // 
            this.configHWCompass1.BackColor = System.Drawing.Color.Teal;
            resources.ApplyResources(this.configHWCompass1, "configHWCompass1");
            this.configHWCompass1.Name = "configHWCompass1";
            // 
            // backstageViewPageradio
            // 
            this.backstageViewPageradio.Advanced = false;
            this.backstageViewPageradio.DataBindings.Add(new System.Windows.Forms.Binding("Show", this.initialSetupBindingSource, "isConnected", true));
            this.backstageViewPageradio.LinkText = "Radio Calibration";
            this.backstageViewPageradio.Page = this.configRadioInput1;
            this.backstageViewPageradio.Parent = null;
            this.backstageViewPageradio.Show = true;
            this.backstageViewPageradio.Spacing = 30;
            resources.ApplyResources(this.backstageViewPageradio, "backstageViewPageradio");
            // 
            // configRadioInput1
            // 
            resources.ApplyResources(this.configRadioInput1, "configRadioInput1");
            this.configRadioInput1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.configRadioInput1.Name = "configRadioInput1";
            // 
            // configFlightModes1
            // 
            this.configFlightModes1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.configFlightModes1, "configFlightModes1");
            this.configFlightModes1.Name = "configFlightModes1";
            // 
            // backstageViewPagefs
            // 
            this.backstageViewPagefs.Advanced = false;
            this.backstageViewPagefs.DataBindings.Add(new System.Windows.Forms.Binding("Show", this.initialSetupBindingSource, "isConnected", true));
            this.backstageViewPagefs.LinkText = "FailSafe";
            this.backstageViewPagefs.Page = this.configFailSafe1;
            this.backstageViewPagefs.Parent = null;
            this.backstageViewPagefs.Show = true;
            this.backstageViewPagefs.Spacing = 30;
            resources.ApplyResources(this.backstageViewPagefs, "backstageViewPagefs");
            // 
            // configFailSafe1
            // 
            resources.ApplyResources(this.configFailSafe1, "configFailSafe1");
            this.configFailSafe1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.configFailSafe1.Name = "configFailSafe1";
            // 
            // configOptional1
            // 
            resources.ApplyResources(this.configOptional1, "configOptional1");
            this.configOptional1.Name = "configOptional1";
            // 
            // _3DRradio1
            // 
            resources.ApplyResources(this._3DRradio1, "_3DRradio1");
            this._3DRradio1.Name = "_3DRradio1";
            // 
            // configBatteryMonitoring1
            // 
            resources.ApplyResources(this.configBatteryMonitoring1, "configBatteryMonitoring1");
            this.configBatteryMonitoring1.Name = "configBatteryMonitoring1";
            // 
            // configCompassMot1
            // 
            resources.ApplyResources(this.configCompassMot1, "configCompassMot1");
            this.configCompassMot1.Name = "configCompassMot1";
            // 
            // backstageViewPagesonar
            // 
            this.backstageViewPagesonar.Advanced = false;
            this.backstageViewPagesonar.DataBindings.Add(new System.Windows.Forms.Binding("Show", this.initialSetupBindingSource, "isConnected", true));
            this.backstageViewPagesonar.LinkText = "Sonar";
            this.backstageViewPagesonar.Page = this.configHWSonar1;
            this.backstageViewPagesonar.Parent = null;
            this.backstageViewPagesonar.Show = true;
            this.backstageViewPagesonar.Spacing = 30;
            resources.ApplyResources(this.backstageViewPagesonar, "backstageViewPagesonar");
            // 
            // configHWSonar1
            // 
            this.configHWSonar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.configHWSonar1, "configHWSonar1");
            this.configHWSonar1.Name = "configHWSonar1";
            // 
            // configHWAirspeed1
            // 
            resources.ApplyResources(this.configHWAirspeed1, "configHWAirspeed1");
            this.configHWAirspeed1.Name = "configHWAirspeed1";
            // 
            // configHWOptFlow1
            // 
            resources.ApplyResources(this.configHWOptFlow1, "configHWOptFlow1");
            this.configHWOptFlow1.Name = "configHWOptFlow1";
            // 
            // configHWOSD1
            // 
            resources.ApplyResources(this.configHWOSD1, "configHWOSD1");
            this.configHWOSD1.Name = "configHWOSD1";
            // 
            // configMount1
            // 
            resources.ApplyResources(this.configMount1, "configMount1");
            this.configMount1.Name = "configMount1";
            // 
            // tracker1
            // 
            this.tracker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            resources.ApplyResources(this.tracker1, "tracker1");
            this.tracker1.ForeColor = System.Drawing.Color.White;
            this.tracker1.Name = "tracker1";
            // 
            // configMotor1
            // 
            resources.ApplyResources(this.configMotor1, "configMotor1");
            this.configMotor1.Name = "configMotor1";
            // 
            // configHWBT1
            // 
            resources.ApplyResources(this.configHWBT1, "configHWBT1");
            this.configHWBT1.Name = "configHWBT1";
            // 
            // configHWPa1
            // 
            resources.ApplyResources(this.configHWPa1, "configHWPa1");
            this.configHWPa1.Name = "configHWPa1";
            // 
            // backstageViewPageinstfw
            // 
            this.backstageViewPageinstfw.Advanced = false;
            this.backstageViewPageinstfw.LinkText = "安装固件";
            this.backstageViewPageinstfw.Page = this.configFirmware1;
            this.backstageViewPageinstfw.Parent = null;
            this.backstageViewPageinstfw.Show = false;
            this.backstageViewPageinstfw.Spacing = 30;
            resources.ApplyResources(this.backstageViewPageinstfw, "backstageViewPageinstfw");
            // 
            // configFirmware1
            // 
            resources.ApplyResources(this.configFirmware1, "configFirmware1");
            this.configFirmware1.Name = "configFirmware1";
            // 
            // backstageViewPageSetParams
            // 
            this.backstageViewPageSetParams.Advanced = false;
            this.backstageViewPageSetParams.DataBindings.Add(new System.Windows.Forms.Binding("Show", this.initialSetupBindingSource, "isConnected", true));
            this.backstageViewPageSetParams.LinkText = "参数设置";
            this.backstageViewPageSetParams.Page = this.configSetParams1;
            this.backstageViewPageSetParams.Parent = null;
            this.backstageViewPageSetParams.Show = true;
            this.backstageViewPageSetParams.Spacing = 40;
            resources.ApplyResources(this.backstageViewPageSetParams, "backstageViewPageSetParams");
            // 
            // configSetParams1
            // 
            this.configSetParams1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.configSetParams1, "configSetParams1");
            this.configSetParams1.Name = "configSetParams1";
            // 
            // backstageViewPageMotorblance
            // 
            this.backstageViewPageMotorblance.Advanced = false;
            this.backstageViewPageMotorblance.DataBindings.Add(new System.Windows.Forms.Binding("Show", this.initialSetupBindingSource, "isConnected", true));
            this.backstageViewPageMotorblance.LinkText = "动平衡校准";
            this.backstageViewPageMotorblance.Page = this.ConfigMotorbalance1;
            this.backstageViewPageMotorblance.Parent = null;
            this.backstageViewPageMotorblance.Show = true;
            this.backstageViewPageMotorblance.Spacing = 30;
            resources.ApplyResources(this.backstageViewPageMotorblance, "backstageViewPageMotorblance");
            // 
            // ConfigMotorbalance1
            // 
            this.ConfigMotorbalance1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.ConfigMotorbalance1, "ConfigMotorbalance1");
            this.ConfigMotorbalance1.Name = "ConfigMotorbalance1";
            // 
            // backstageViewPagefw
            // 
            this.backstageViewPagefw.Advanced = false;
            this.backstageViewPagefw.DataBindings.Add(new System.Windows.Forms.Binding("Show", this.initialSetupBindingSource, "isDisConnected", true));
            this.backstageViewPagefw.LinkText = "Install Firmware";
            this.backstageViewPagefw.Page = this.configFirmware1;
            this.backstageViewPagefw.Parent = null;
            this.backstageViewPagefw.Show = false;
            this.backstageViewPagefw.Spacing = 30;
            resources.ApplyResources(this.backstageViewPagefw, "backstageViewPagefw");
            // 
            // backstageViewPagefwdisabled
            // 
            this.backstageViewPagefwdisabled.Advanced = false;
            this.backstageViewPagefwdisabled.DataBindings.Add(new System.Windows.Forms.Binding("Show", this.initialSetupBindingSource, "isConnected", true));
            this.backstageViewPagefwdisabled.LinkText = "Install Firmware";
            this.backstageViewPagefwdisabled.Page = this.configFirmwareDisabled1;
            this.backstageViewPagefwdisabled.Parent = null;
            this.backstageViewPagefwdisabled.Show = false;
            this.backstageViewPagefwdisabled.Spacing = 30;
            resources.ApplyResources(this.backstageViewPagefwdisabled, "backstageViewPagefwdisabled");
            // 
            // configFirmwareDisabled1
            // 
            resources.ApplyResources(this.configFirmwareDisabled1, "configFirmwareDisabled1");
            this.configFirmwareDisabled1.Name = "configFirmwareDisabled1";
            // 
            // InitialSetup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.backstageView);
            this.Controls.Add(this.configAccelerometerCalibration);
            this.Controls.Add(this.configHWBT1);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(1000, 450);
            this.Name = "InitialSetup";
            resources.ApplyResources(this, "$this");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HardwareConfig_FormClosing);
            this.Load += new System.EventHandler(this.HardwareConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.initialSetupBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BackstageView.BackstageView backstageView;
        private ConfigurationView.ConfigFirmware configFirmware1;
        private ConfigurationView.ConfigFirmwareDisabled configFirmwareDisabled1;
        private ConfigurationView.ConfigWizard configWizard1;
        private ConfigurationView.ConfigMandatory configMandatory1;
        private ConfigurationView.ConfigOptional configOptional1;
        private ConfigurationView.ConfigTradHeli configTradHeli1;
        private ConfigurationView.ConfigFrameType configFrameType1;
        private ConfigurationView.ConfigHWCompass configHWCompass1;
        private ConfigurationView.ConfigRadioInput configRadioInput1;
        private ConfigurationView.ConfigFlightModes configFlightModes1;
        private ConfigurationView.ConfigFailSafe configFailSafe1;
        private _3DRradio _3DRradio1;
        private ConfigurationView.ConfigBatteryMonitoring configBatteryMonitoring1;
        private ConfigurationView.ConfigHWSonar configHWSonar1;
        private ConfigurationView.ConfigHWAirspeed configHWAirspeed1;
        private ConfigurationView.ConfigHWOptFlow configHWOptFlow1;
        private ConfigurationView.ConfigHWOSD configHWOSD1;
        private ConfigurationView.ConfigMount configMount1;
        private ConfigurationView.ConfigMotorTest configMotor1;
        private Antenna.Tracker tracker1;
        private ConfigurationView.ConfigSetParams configSetParams1;
        private Controls.BackstageView.BackstageViewPage backstageViewPageinstfw;
        private Controls.BackstageView.BackstageViewPage backstageViewPageframetype;
        private Controls.BackstageView.BackstageViewPage backstageViewPagecompass;
        private Controls.BackstageView.BackstageViewPage backstageViewPageradio;
        private Controls.BackstageView.BackstageViewPage backstageViewPagefs;
        private Controls.BackstageView.BackstageViewPage backstageViewPagesonar;
        private Controls.BackstageView.BackstageViewPage backstageViewPagefwdisabled;
        private Controls.BackstageView.BackstageViewPage backstageViewPagefw;
        private System.Windows.Forms.BindingSource initialSetupBindingSource;
        private ConfigurationView.ConfigCompassMot configCompassMot1;
        private Controls.BackstageView.BackstageViewPage backstageViewPageaccel;
        private ConfigurationView.ConfigAccelerometerCalibration configAccelerometerCalibration;
        private ConfigurationView.ConfigHWBT configHWBT1;
        private ConfigurationView.ConfigHWParachute configHWPa1;
        private Controls.BackstageView.BackstageViewPage backstageViewPageSetParams;
        private ConfigurationView.ConfigMotorbalance ConfigMotorbalance1;
        private Controls.BackstageView.BackstageViewPage backstageViewPageMotorblance;
    }
}
