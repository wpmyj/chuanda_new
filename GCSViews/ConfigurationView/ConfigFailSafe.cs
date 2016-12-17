using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Utilities;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigFailSafe : MyUserControl, IActivate, IDeactivate
    {
        private readonly Timer timer = new Timer();

        public ConfigFailSafe()
        {
            InitializeComponent();

            // setup rc update
            timer.Tick += timer_Tick;
        }

        public void Activate()
        {
            mavlinkComboBox_fs_thr_enable.setup(
                ParameterMetaDataRepository.GetParameterOptionsInt("FS_THR_ENABLE",
                    MainV2.comPort.MAV.cs.firmware.ToString()), "FS_THR_ENABLE", MainV2.comPort.MAV.param);

            // arducopter
            mavlinkComboBoxfs_batt_enable.setup(
                ParameterMetaDataRepository.GetParameterOptionsInt("FS_BATT_ENABLE",
                    MainV2.comPort.MAV.cs.firmware.ToString()), "FS_BATT_ENABLE", MainV2.comPort.MAV.param);
            mavlinkNumericUpDownfs_thr_value.setup(800, 1200, 1, 1, "FS_THR_VALUE", MainV2.comPort.MAV.param);

            mavlinkComboFS_GCS_ENABLE.setup(
               ParameterMetaDataRepository.GetParameterOptionsInt("FS_GCS_ENABLE",
                   MainV2.comPort.MAV.cs.firmware.ToString()), "FS_GCS_ENABLE", MainV2.comPort.MAV.param);

            mavlinkNumericUpDownlow_voltage.setup(3, 99, 1, 0.1f, "FS_BATT_VOLTAGE", MainV2.comPort.MAV.param);

            // arducopter
            cb_FS_Level_Enable.setup(
                ParameterMetaDataRepository.GetParameterOptionsInt("FS_LEVEL_ENABLE",
                    MainV2.comPort.MAV.cs.firmware.ToString()), "FS_LEVEL_ENABLE", MainV2.comPort.MAV.param);
            timer.Enabled = true;
            timer.Interval = 100;
            timer.Start();

        }

        public void Deactivate()
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // update all linked controls - 10hz
            try
            {
                MainV2.comPort.MAV.cs.UpdateCurrentSettings(currentStateBindingSource);
            }
            catch
            {
            }
        }
    }
}