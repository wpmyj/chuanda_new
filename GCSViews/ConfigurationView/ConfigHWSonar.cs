﻿using System;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Utilities;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigHWSonar : UserControl, IActivate, IDeactivate
    {
        private const float rad2deg = (float) (180/Math.PI);
        private const float deg2rad = (float) (1.0/rad2deg);

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
            timer1.Start();
        }

        public void Deactivate()
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LBL_dist.Text = MainV2.comPort.MAV.cs.sonarrange.ToString();
            LBL_volt.Text = MainV2.comPort.MAV.cs.sonarvoltage.ToString();
        }
    }
}