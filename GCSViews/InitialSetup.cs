using System;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Controls.BackstageView;
using ByAeroBeHero.Utilities;

namespace ByAeroBeHero.GCSViews
{
    public partial class InitialSetup : MyUserControl, IActivate
    {
        internal static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static string lastpagename = "";

        public InitialSetup()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl() 
        {
            this.BackColor = System.Drawing.Color.Teal;
        }

        public bool isConnected
        {
            get { return MainV2.comPort.BaseStream.IsOpen; }
        }

        public bool isDisConnected
        {
            get { return !MainV2.comPort.BaseStream.IsOpen; }
        }

        public bool isTracker
        {
            get { return isConnected && MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduTracker; }
        }

        public bool isCopter
        {
            get { return isConnected && MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2; }
        }

        public bool isHeli
        {
            get { return isConnected && MainV2.comPort.MAV.aptype == MAVLink.MAV_TYPE.HELICOPTER; }
        }

        public bool isPlane
        {
            get
            {
                return isConnected &&
                       (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduPlane ||
                        MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Ateryx);
            }
        }

        public bool isRover
        {
            get { return isConnected && MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduRover; }
        }

        public void Activate()
        {
            initialSetupBindingSource.DataSource = this;
            
        }

        private void HardwareConfig_Load(object sender, EventArgs e)
        {
            // remeber last page accessed
            foreach (BackstageViewPage page in backstageView.Pages)
            {
                
                if (page.LinkText == lastpagename && page.Show)
                {
                    backstageView.ActivatePage(page);
                    break;
                }

                if (page.LinkText == "机架类型")
                {
                    page.Show = true;
                }
            }
            
            MainV2.instance.controlMainMenuColor("MenuInitConfig");
            IsShowControl(isConnected);
            ThemeManager.ApplyThemeTo(this);
        }

        public void IsShowControl(bool isConnected)
        {
            if (!isConnected)
            {
                CustomMessageBox.Show("请使用地面站连接飞行控制器，然后在进行参数设置操作！","提示");

            }
        }

        private void HardwareConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backstageView.SelectedPage != null)
                lastpagename = backstageView.SelectedPage.LinkText;

            backstageView.Close();
        }
    }
}