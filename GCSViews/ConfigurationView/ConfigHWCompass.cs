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
            this.BackColor = Color.Black;
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
                //CustomMessageBox.Show("校准成功！", "提示");
            }

            if (CurrentState.icompletionpercent == 202)
            {
                progressBar1.Value = 0;
                lblPressCount.Text = "0%";
                this.lblReason.Text = "失败";
                //CustomMessageBox.Show("校准失败！", "提示");
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
            this.BackColor = Color.Black;
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                Enabled = false;
                return;
            }
            Enabled = true;

            startup = true;

            CMB_compass_orient.setup(typeof (Common.Rotation), "COMPASS_ORIENT", MainV2.comPort.MAV.param);


            CHK_enablecompass.setup(1, 0, "MAG_ENABLE", MainV2.comPort.MAV.param, TXT_declination_deg);

            this.CHK_enablecompass.Visible = false;

            if (MainV2.comPort.MAV.param["COMPASS_DEC"] != null)
            {
                var dec = MainV2.comPort.MAV.param["COMPASS_DEC"].Value*rad2deg;

                var min = (dec - (int) dec)*60;

                TXT_declination_deg.Text = ((int) dec).ToString("0");
                TXT_declination_min.Text = min.ToString("0");
            }

            if (MainV2.comPort.MAV.param["COMPASS_AUTODEC"] != null)
            {
                CHK_autodec.Checked = MainV2.comPort.MAV.param["COMPASS_AUTODEC"].ToString() == "1" ? true : false;
            }

            rb_px4pixhawk.Checked = true;

            startup = false;

            timer.Enabled = true;
            timer.Interval = 100;
            timer.Start();
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


            //if (MainV2.comPort.MAV.param["COMPASS_CALIBRATE"] != null)
            //{
            //    MainV2.comPort.setParam("COMPASS_CALIBRATE", 1);
            //}

            //MagCalib.DoGUIMagCalib();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //System.Diagnostics.Process.Start("http://www.ngdc.noaa.gov/geomagmodels/Declination.jsp");
                Process.Start("http://www.magnetic-declination.com/");
            }
            catch
            {
                CustomMessageBox.Show(
                    "Webpage open failed... do you have a virus?\nhttp://www.magnetic-declination.com/", "Mag");
            }
        }

        private void TXT_declination_Validating(object sender, CancelEventArgs e)
        {
            float ans = 0;
            e.Cancel = !float.TryParse(TXT_declination_deg.Text, out ans);
        }

        private void TXT_declination_Validated(object sender, EventArgs e)
        {
            if (startup)
                return;
            try
            {
                if (MainV2.comPort.MAV.param["COMPASS_DEC"] == null)
                {
                    CustomMessageBox.Show(Strings.ErrorFeatureNotEnabled, Strings.ERROR);
                }
                else
                {
                    var dec = 0.0f;
                    try
                    {
                        var deg = TXT_declination_deg.Text;

                        var min = TXT_declination_min.Text;

                        dec = float.Parse(deg);

                        if (dec < 0)
                            dec -= (float.Parse(min)/60);
                        else
                            dec += (float.Parse(min)/60);
                    }
                    catch
                    {
                        CustomMessageBox.Show(Strings.InvalidNumberEntered, Strings.ERROR);
                        return;
                    }

                    MainV2.comPort.setParam("COMPASS_DEC", dec*deg2rad);
                }
            }
            catch
            {
                CustomMessageBox.Show(string.Format(Strings.ErrorSetValueFailed, "COMPASS_DEC"), Strings.ERROR);
            }
        }

        private void CHK_enablecompass_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox) sender).Checked)
            {
                CHK_autodec.Enabled = true;
                TXT_declination_deg.Enabled = true;
                TXT_declination_min.Enabled = true;
            }
            else
            {
                CHK_autodec.Enabled = false;
                TXT_declination_deg.Enabled = false;
                TXT_declination_min.Enabled = false;
            }

            if (startup)
                return;
            try
            {
                if (MainV2.comPort.MAV.param["MAG_ENABLE"] == null)
                {
                    CustomMessageBox.Show(Strings.ErrorFeatureNotEnabled, Strings.ERROR);
                }
                else
                {
                    MainV2.comPort.setParam("MAG_ENABLE", ((CheckBox) sender).Checked ? 1 : 0);
                }
            }
            catch
            {
                CustomMessageBox.Show(string.Format(Strings.ErrorSetValueFailed, "MAG_ENABLE"), Strings.ERROR);
            }
        }

        private void BUT_MagCalibrationLog_Click(object sender, EventArgs e)
        {
            var minthro = "30";
            if (DialogResult.Cancel ==
                InputBox.Show("Min Throttle", "Use only data above this throttle percent.", ref minthro))
                return;

            var ans = 0;
            int.TryParse(minthro, out ans);

            MagCalib.ProcessLog(ans);
        }

        private void CHK_autodec_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox) sender).Checked)
            {
                TXT_declination_deg.Enabled = false;

                TXT_declination_min.Enabled = false;
            }
            else
            {
                TXT_declination_deg.Enabled = true;
                TXT_declination_min.Enabled = true;
            }

            if (startup)
                return;
            try
            {
                if (MainV2.comPort.MAV.param["COMPASS_AUTODEC"] == null)
                {
                    CustomMessageBox.Show("Not Available on " + MainV2.comPort.MAV.cs.firmware);
                }
                else
                {
                    MainV2.comPort.setParam("COMPASS_AUTODEC", ((CheckBox) sender).Checked ? 1 : 0);
                }
            }
            catch
            {
                CustomMessageBox.Show("Set COMPASS_AUTODEC Failed");
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://www.youtube.com/watch?v=DmsueBS0J3E");
            }
            catch
            {
                CustomMessageBox.Show(Strings.ERROR + " https://www.youtube.com/watch?v=DmsueBS0J3E");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.ErrorNotConnected);
                MainV2.View.Reload();
                return;
            }

            try
            {
                if (radioButton_onboard.Checked && sender == radioButton_onboard)
                {
                    CMB_compass_orient.SelectedIndex = (int) Common.Rotation.ROTATION_NONE;
                    MainV2.comPort.setParam("COMPASS_EXTERNAL", 0);
                }

                if (radioButton_external.Checked && sender == radioButton_external)
                {
                    CMB_compass_orient.SelectedIndex = (int) Common.Rotation.ROTATION_ROLL_180;
                    MainV2.comPort.setParam("COMPASS_EXTERNAL", 1);
                }

                if (rb_px4pixhawk.Checked && sender == rb_px4pixhawk)
                {
                    if (
                        CustomMessageBox.Show("is the FW version greater than APM:copter 3.01 or APM:Plane 2.74?", "",
                            MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        CMB_compass_orient.SelectedIndex = (int) Common.Rotation.ROTATION_NONE;
                    }
                    else
                    {
                        CMB_compass_orient.SelectedIndex = (int) Common.Rotation.ROTATION_ROLL_180;
                        MainV2.comPort.setParam("COMPASS_EXTERNAL", 0);
                    }
                }
            }
            catch (Exception)
            {
                CustomMessageBox.Show(Strings.ErrorSettingParameter, Strings.ERROR);
            }
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