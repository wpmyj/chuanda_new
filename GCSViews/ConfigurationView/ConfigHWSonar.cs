using System;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Utilities;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigHWSonar : UserControl, IActivate, IDeactivate
    {
        private const float rad2deg = (float)(180 / Math.PI);
        private const float deg2rad = (float)(1.0 / rad2deg);

        public ConfigHWSonar()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                Enabled = false;
                return;
            }
            Enabled = true;

            //CMB_sonartype.setup(
            //    ParameterMetaDataRepository.GetParameterOptionsInt("RNGFND_TYPE",
            //        MainV2.comPort.MAV.cs.firmware.ToString()), "RNGFND_TYPE", MainV2.comPort.MAV.param);

            chbSonar.setup(1, 0, "RNGFND_TYPE", MainV2.comPort.MAV.param);
            cb_LevelSensor.setup(1, 0, "FS_LEVEL_ENABLE", MainV2.comPort.MAV.param);
            SPRAY_RATE_MAX.setup(1, 100, 1, (float)1, "SPRAY_RATE_MAX",
            MainV2.comPort.MAV.param);

            SPRAY_RATE_MIN.setup(1, 100, 1, (float)1, "SPRAY_RATE_MIN",
             MainV2.comPort.MAV.param);

            SPRAY_SPEED_MIN.setup(1, 200, (float)CurrentState.fromDistDisplayUnit(100), (float)0.1, "SPRAY_SPEED_MIN",
            MainV2.comPort.MAV.param);

            SPRAY_SPEED_MAX.setup(1, 1000, (float)CurrentState.fromDistDisplayUnit(100), (float)0.1, "SPRAY_SPEED_MAX",
            MainV2.comPort.MAV.param);

            SPRAY_SPEEN_EN.setup(1, 0, "SPRAY_SPEED_EN", MainV2.comPort.MAV.param);
            timer1.Start();
        }

        public void Deactivate()
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (MainV2.comPort.MAV.param.ContainsKey("SPRAY_SPEED_EN") && MainV2.comPort.MAV.param["SPRAY_SPEED_EN"].ToString() == "1")
            {
                SPRAY_RATE_MIN.Enabled = SPRAY_RATE_MAX.Enabled = SPRAY_SPEED_MIN.Enabled = SPRAY_SPEED_MAX.Enabled = true;
            }
            else
            {
                SPRAY_RATE_MIN.Enabled = SPRAY_RATE_MAX.Enabled = SPRAY_SPEED_MIN.Enabled = SPRAY_SPEED_MAX.Enabled = false;
            }

        }

        private void SPRAY_ValueChanged(object sender, EventArgs e)
        {
            if (SPRAY_RATE_MIN.Value > SPRAY_RATE_MAX.Value)
            {
                CustomMessageBox.Show("水泵调速最大值必须大于最小值", "水泵开度设置");
                return;
            }

            if (SPRAY_RATE_MIN.Value > SPRAY_RATE_MAX.Value)
            {
                CustomMessageBox.Show("水泵调速最大值必须大于最小值", "水泵开度设置");
                return;
            }
        }

        private void MBtnSendSaray_Click(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.setParam(SPRAY_RATE_MIN.ParamName, (float)SPRAY_RATE_MIN.Value);
                MainV2.comPort.setParam(SPRAY_RATE_MAX.ParamName, (float)SPRAY_RATE_MAX.Value);
                MainV2.comPort.setParam(SPRAY_SPEED_MIN.ParamName, (float)SPRAY_SPEED_MIN.Value * 100);
                MainV2.comPort.setParam(SPRAY_SPEED_MAX.ParamName, (float)SPRAY_SPEED_MAX.Value * 100);

                CustomMessageBox.Show("设置成功", "水泵开度设置");
            }
            catch
            {

                CustomMessageBox.Show("设置参数失败", "水泵开度设置");
                return;
            }
        }


    }
}