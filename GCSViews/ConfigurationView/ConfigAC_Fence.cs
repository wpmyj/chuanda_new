using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Utilities;
using System;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigAC_Fence : UserControl, IActivate
    {
        public ConfigAC_Fence()
        {
            InitializeComponent();

            label6maxalt.Text += "["+"米"+"]";
            label7maxrad.Text += "[" + "米" + "]";
            label2rtlalt.Text += "["+"米"+"]";
            sendParam(); 
        }

        public void Activate()
        {
        }

        public void sendParam() 
        {
            mavlinkCheckBox1.setup(1, 0, "FENCE_ENABLE", MainV2.comPort.MAV.param);

            mavlinkComboBox1.setup(
                ParameterMetaDataRepository.GetParameterOptionsInt("FENCE_TYPE",
                    MainV2.comPort.MAV.cs.firmware.ToString()), "FENCE_TYPE", MainV2.comPort.MAV.param);


            mavlinkComboBox2.setup(
                ParameterMetaDataRepository.GetParameterOptionsInt("FENCE_ACTION",
                    MainV2.comPort.MAV.cs.firmware.ToString()), "FENCE_ACTION", MainV2.comPort.MAV.param);


            // 3
            mavlinkNumericUpDown1.setup(10, 1000, (float)CurrentState.fromDistDisplayUnit(1), 1, "FENCE_ALT_MAX",
                MainV2.comPort.MAV.param);

            mavlinkNumericUpDown2.setup(30, 65536, (float)CurrentState.fromDistDisplayUnit(1), 1, "FENCE_RADIUS",
                MainV2.comPort.MAV.param);

            mavlinkNumericUpDown3.setup(1, 500, (float)CurrentState.fromDistDisplayUnit(100), 1, "RTL_ALT",
                MainV2.comPort.MAV.param);
        }
        private void btnSendParam_Click(object sender, System.EventArgs e)
        {
            try
            {
                sendParam(); 

                CustomMessageBox.Show("成功写入参数", Strings.Success);
            }
            catch
            {
                CustomMessageBox.Show("写入参数失败", Strings.ERROR);
            }
            

        }
    }
}