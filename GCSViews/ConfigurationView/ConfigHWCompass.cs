using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using System.Drawing;
                
namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigHWCompass : UserControl, IActivate
    {
        private const float rad2deg = (float) (180/Math.PI);
        private const float deg2rad = (float) (1.0/rad2deg);
        private bool startup;
        private readonly Timer timer = new Timer();

        public ConfigHWCompass()
        {
            InitializeComponent();
            timer.Tick += timer_Tick;
        }

        public void Deactivate()
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ShowIMUState();

            compassCalibrate();

            ControlCompassPress();
            // update all linked controls - 10hz
            try
            {
                MainV2.comPort.MAV.cs.UpdateCurrentSettings(bindingSource1);
            }
            catch
            {
            }
        }

        private void ControlCompassPress()
        {
            if (!MainV2.comPort.BaseStream.IsOpen) 
            {
                progressBar1.Value = 0;
                lblPressCount.Text = "0%";
            }

            if (CurrentState.icompletionpercent <= 102)
            {
                if (CurrentState.icompletionpercent < 100)
                {
                    progressBar1.Value = CurrentState.icompletionpercent;
                    lblPressCount.Text = CurrentState.icompletionpercent + "%";
                    this.lblReason.Text = string.Empty;
                }
                else 
                {
                    progressBar1.Value = 100;
                    lblPressCount.Text = "100%";
                }
            }

            if (CurrentState.icompletionpercent == 201 || (100<= CurrentState.icompletionpercent&&  CurrentState.icompletionpercent<=102) )
            {
                progressBar1.Value = 100;
                lblPressCount.Text = "100%";
                this.lblReason.Text = "成功";
            }

            if (CurrentState.icompletionpercent == 202)
            {
                progressBar1.Value = 0;
                lblPressCount.Text = "0%";
                this.lblReason.Text = "失败";
            }
        }

        private int compassprocess = 0;
        private void compassCalibrate() 
        {
            if (MainV2.comPort.MAV.param["COMPASS_PROCESS "] != null)
            {
                compassprocess = (int)MainV2.comPort.MAV.param["COMPASS_DEC"].Value;

            }

            if (compassprocess == 100) 
            {
                if (MainV2.comPort.MAV.param["COMPASS_CALIBRATE"] != null)
                {
                    MainV2.comPort.setParam("COMPASS_CALIBRATE", 0);
                }

                BUT_MagCalibrationLive.Text = "校准完成";
            }

        }

        private int iIMU2 = 0;
        private void ShowIMUState() 
        {
            if (CurrentState.compasshealth)
            {
                if ((MainV2.comPort.MAV.cs.mx == 0 && MainV2.comPort.MAV.cs.my == 0 && MainV2.comPort.MAV.cs.mz == 0) || IsChangeIMU())
                {
                    this.lblIMUState.Text = "断开";
                }
                else
                {
                    this.lblIMUState.Text = "连接";
                }
            }
            else 
            {
                this.lblIMUState.Text = "不健康";
            }


            if ((MainV2.comPort.MAV.cs.mx2 == 0 && MainV2.comPort.MAV.cs.my2 == 0 && MainV2.comPort.MAV.cs.mz2 == 0)|| IsChangeIMU2())
            {
                iIMU2++;
                if (iIMU2 > 10)
                    this.lblIMU2State.Text = "断开";
            }
            else 
            {
                iIMU2 = 0;
                this.lblIMU2State.Text = "连接";
            }
        }

        private int iIMU1 = 0;
        public static float difimux = 0;
        public static float difimuy = 0;
        public static float difimuz = 0;
        public bool IsChangeIMU()
        {
            if (difimux != MainV2.comPort.MAV.cs.mx || difimuy != MainV2.comPort.MAV.cs.my || difimuz != MainV2.comPort.MAV.cs.mz)
            {
                difimux = MainV2.comPort.MAV.cs.mx;
                difimuy = MainV2.comPort.MAV.cs.my;
                difimuz = MainV2.comPort.MAV.cs.mz;
                iIMU1 = 0;
                return false;
            }
            else
            {
                iIMU1++;
                if (iIMU > 10)
                    return true;
                else
                    return false;
            }
        }

        private int iIMU = 0;
        public static float difimux2 = 0;
        public static float difimuy2 = 0;
        public static float difimuz2 = 0;
        public bool IsChangeIMU2()
        {
            if (difimux2 != MainV2.comPort.MAV.cs.mx2 || difimuy2 != MainV2.comPort.MAV.cs.my2 || difimuz2 != MainV2.comPort.MAV.cs.mz2)
            {
                difimux = MainV2.comPort.MAV.cs.mx2;
                difimuy = MainV2.comPort.MAV.cs.my2;
                difimuz = MainV2.comPort.MAV.cs.mz2;
                iIMU = 0;
                return false;
            }
            else
            {
                iIMU++;
                if (iIMU > 10)
                    return true;
                else
                    return false;
            }
        }

        public void Activate()
        {
            InitControl();
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                Enabled = false;
                return;
            }
            Enabled = true;

            startup = true;

            if (MainV2.comPort.MAV.param["COMPASS_DEC"] != null)
            {
                var dec = MainV2.comPort.MAV.param["COMPASS_DEC"].Value*rad2deg;

                var min = (dec - (int) dec)*60;
            }

            startup = false;

            timer.Enabled = true;
            timer.Interval = 100;
            timer.Start();
        }

        private void InitControl() 
        {
            lblCheckCompass.ForeColor = lblx.ForeColor = label4.ForeColor = label6.ForeColor = label7.ForeColor = label8.ForeColor
                = label9.ForeColor = this.lblPressCount.ForeColor = this.lblReason.ForeColor = this.lblConpassPress.ForeColor =Color.Black;

            this.BackColor = Color.DimGray;
        }

        private void BUT_MagCalibration_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                return;
            }

            this.lblReason.Text = string.Empty;

            try {
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_START_MAG_CAL, 0, 0, 1, 1 * 1.0e-4f, 0, 0, 0);
            }
            catch { }

        }

        private void btnCanelPress_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                return;
            }

            try
            {
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.DO_CANCEL_MAG_CAL, 0, 0, 0, 0, 0, 0, 0);
            }
            catch { }
        }
    }
}