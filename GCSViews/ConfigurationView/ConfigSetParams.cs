using System;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Utilities;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigSetParams : UserControl, IActivate, IDeactivate
    {

        public ConfigSetParams()
        {
            InitializeComponent();

            InitControl(); 
        }

        private void InitControl() 
        {
            CHK_enablespeech.BackColor = CHK_speechwaypoint.BackColor = CHK_speechflightParams.BackColor
            = chbShow_AllParams.BackColor = CHK_speechotherParams.BackColor = Color.LightGray;

            CHK_enablespeech.ForeColor = CHK_speechwaypoint.ForeColor = CHK_speechflightParams.ForeColor
            = chbShow_AllParams.ForeColor = CHK_speechotherParams.ForeColor = Color.Black;
        }

        public void Activate()
        {
            InitControl(); 
            NUM_movelength.Value = decimal.Parse(MainV2.config["NUM_movelength"].ToString());
            chb_AllMove.Checked = bool.Parse(MainV2.config["CHB_AllMove"].ToString());
            setWPParams();
            this.lblVNo .Text= MainV2.comPort.MAV.param["BATT_VOLT_MULT"].ToString().Substring(0,5);
            this.chbShow_AllParams.Checked = bool.Parse(MainV2.config["Show_AllParams"].ToString());
            CHK_enablespeech_CheckedChanged(null, null);
            timer1.Start();
        }

        private readonly Hashtable changes = new Hashtable();
        internal bool startup = true;
        void setWPParams()
        {
            try
            {
                if (!MainV2.comPort.BaseStream.IsOpen)
                {
                    RTL_ALT_P.Enabled = false;
                }
                else
                {
                    startup = true;
                    changes.Clear();

                    RTL_ALT_P.setup(1, 500, (float)CurrentState.fromDistDisplayUnit(100), (float)0.1, "RTL_CLIMB_MIN",
                    MainV2.comPort.MAV.param);

                    SPRAY_WRAP_EN.setup(1, 0, "SPRAY_WRAP_EN", MainV2.comPort.MAV.param);

                    //语音播报 
                    SetCheckboxFromConfig("speechenable", CHK_enablespeech);
                    SetCheckboxFromConfig("speechwaypointenabled", CHK_speechwaypoint);
                    SetCheckboxFromConfig("speechflightparamsabled", CHK_speechflightParams);
                    SetCheckboxFromConfig("speechmodeenabled", CHK_speechotherParams);
                    startup = false;
                }
            }
            catch (Exception ex) { }
        }

        private static void SetCheckboxFromConfig(string configKey, CheckBox chk)
        {
            if (MainV2.config[configKey] != null)
                chk.Checked = bool.Parse(MainV2.config[configKey].ToString());
        }

        #region
        private void numeric_ValueUpdated(object sender, EventArgs e)
        {
            EEPROM_View_float_TextChanged(sender, e);
        }

        private void BUT_writePIDS_Click(object sender, EventArgs e)
        {
            var temp = (Hashtable)changes.Clone();

            MainV2.comPort.setParam(new string[] { "VOLT_DIVIDER", "BATT_VOLT_MULT" }, float.Parse(lblVNo.Text));

            bool IsSetParam = false;

            foreach (string value in temp.Keys)
            {
                try
                {
                    IsSetParam = MainV2.comPort.setParam(value, (float)changes[value]);
                    changes.Remove(value);
                    try
                    {
                        // set control as well
                        var textControls = Controls.Find(value, true);
                        if (textControls.Length > 0)
                        {
                            textControls[0].BackColor = Color.FromArgb(0x43, 0x44, 0x45);
                        }
                    }
                    catch { }
                }
                catch { CustomMessageBox.Show("设置参数失败!", "提示"); }
            }

            if (IsSetParam)
            {
                CustomMessageBox.Show(Strings.SetValueSuccess,"提示");
            }
        }

        internal void EEPROM_View_float_TextChanged(object sender, EventArgs e)
        {
            if (startup)
                return;

            float value = 0;
            var name = ((Control)sender).Name;

            // do domainupdown state check
            try
            {
                if (sender.GetType() == typeof(MavlinkNumericUpDown))
                {
                    value = ((MAVLinkParamChanged)e).value;
                    changes[name] = value;
                }
                else if (sender.GetType() == typeof(MavlinkComboBox))
                {
                    value = ((MAVLinkParamChanged)e).value;
                    changes[name] = value;
                }
                ((Control)sender).BackColor = Color.Green;
            }
            catch (Exception)
            {
                ((Control)sender).BackColor = Color.Red;
            }

            try
            {
                // keep nav_lat and nav_lon paired
                if (name.Contains("NAV_LAT_"))
                {
                    var newname = name.Replace("NAV_LAT_", "NAV_LON_");
                    var arr = Controls.Find(newname, true);
                    changes[newname] = value;

                    if (arr.Length > 0)
                    {
                        arr[0].Text = ((Control)sender).Text;
                        arr[0].BackColor = Color.Green;
                    }
                }
                // keep loiter_lat and loiter_lon paired
                if (name.Contains("LOITER_LAT_"))
                {
                    var newname = name.Replace("LOITER_LAT_", "LOITER_LON_");
                    var arr = Controls.Find(newname, true);
                    changes[newname] = value;

                    if (arr.Length > 0)
                    {
                        arr[0].Text = ((Control)sender).Text;
                        arr[0].BackColor = Color.Green;
                    }
                }
            }
            catch
            {
            }
        }

        private void BUT_refreshpart_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
                return;

            ((Control)sender).Enabled = false;


            updateparam(this);

            ((Control)sender).Enabled = true;


            Activate();
            this.Refresh();
        }

        private void updateparam(Control parentctl)
        {
            foreach (Control ctl in parentctl.Controls)
            {
                if (typeof(MavlinkNumericUpDown) == ctl.GetType())
                {
                    try
                    {
                        MainV2.comPort.GetParam(ctl.Name);
                    }
                    catch
                    {
                    }
                }

                if (ctl.Controls.Count > 0)
                {
                    updateparam(ctl);
                }
            }
        }

        #endregion

        public void Deactivate()
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InitControl(); 
        }

        private void NUM_movelength_ValueChanged(object sender, EventArgs e)
        {
            MainV2.config["NUM_movelength"] = NUM_movelength.Value;
        }

        private void CHK_enablespeech_CheckedChanged(object sender, EventArgs e)
        {
            MainV2.speechEnable = CHK_enablespeech.Checked;
            MainV2.config["speechenable"] = CHK_enablespeech.Checked;

            if (MainV2.speechEngine != null)
                MainV2.speechEngine.SpeakAsyncCancelAll();

            if (CHK_enablespeech.Checked)
            {
                CHK_speechwaypoint.Visible = true;
                CHK_speechflightParams.Visible = true;
                CHK_speechotherParams.Visible = true;
            }
            else
            {
                CHK_speechwaypoint.Visible = false;
                CHK_speechflightParams.Visible = false;
                CHK_speechotherParams.Visible = false;
            }
        }

        private void CHK_speechwaypoint_CheckedChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            MainV2.config["speechwaypointenabled"] = ((CheckBox)sender).Checked.ToString();

            if (((CheckBox)sender).Checked)
            {
                var speechstring = "正在飞往航点 {wpn}";
                if (MainV2.config["speechwaypoint"] != null)
                    speechstring = MainV2.config["speechwaypoint"].ToString();
                if (DialogResult.Cancel ==
                    CustomMessageBox.Show("是否进行语音播报?", "提示"))
                    return;
                MainV2.config["speechwaypoint"] = speechstring;
            }
        }

        private void CHK_speechflightParams_CheckedChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            MainV2.config["speechflightparamsabled"] = ((CheckBox)sender).Checked.ToString();

            //MainV2.config["speechflightparams"] = string.Empty;
            if (((CheckBox)sender).Checked)
            {
                var speechstring = "当前高度{alt}米,速度 {gsp}米每秒,电压{batv}伏";
                if (MainV2.config["speechflightparams"] != null)
                    speechstring = MainV2.config["speechflightparams"].ToString();
                if (DialogResult.Cancel ==
                    CustomMessageBox.Show("是否进行语音播报?", "提示"))
                    return;
                MainV2.config["speechflightparams"] = speechstring;
            }
        }

        private void CHK_speechotherParams_CheckedChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            MainV2.config["speecharmenabled"] = ((CheckBox)sender).Checked.ToString();
            MainV2.config["speechmodeenabled"] = ((CheckBox)sender).Checked.ToString();

            if (((CheckBox)sender).Checked)
            {
                var speechstring = "飞行模式{mode}";
                if (MainV2.config["speechmode"] != null)
                    speechstring = MainV2.config["speechmode"].ToString();
                if (DialogResult.Cancel ==
                    CustomMessageBox.Show("是否进行语音播报", "提示?"))
                    return;
                MainV2.config["speechmode"] = speechstring;
            }
        }

        private void chb_AllMove_CheckedChanged(object sender, EventArgs e)
        {
            MainV2.config["CHB_AllMove"] = chb_AllMove.Checked;
        }

        private void tboxWriteV_Resize(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tboxWriteV.Text))
                return;

            //算法
            float voltage = MainV2.comPort.MAV.cs.battery_voltage;
            float actualvoltage = float.Parse(this.tboxWriteV.Text);
            float control = float.Parse(MainV2.comPort.MAV.param["BATT_VOLT_MULT"].ToString());
            float newcontrol = actualvoltage / (voltage / control);
            this.lblVNo.Text = newcontrol.ToString();
        }

        private void tboxWriteV_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tboxWriteV.Text) || MainV2.comPort.MAV.cs.battery_voltage == 0)
                return;
            //算法
            float voltage = MainV2.comPort.MAV.cs.battery_voltage;
            float actualvoltage = float.Parse(this.tboxWriteV.Text);
            float control = float.Parse(MainV2.comPort.MAV.param["BATT_VOLT_MULT"].ToString());
            float newcontrol = actualvoltage / (voltage / control);
            this.lblVNo.Text = newcontrol.ToString();
        }


        private bool isShowPanel = false;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.P))
            {
                if (isShowPanel)
                {
                    this.pSetParams.Visible = false;
                    isShowPanel = false;
                }
                else
                {
                    this.pSetParams.Visible = true;
                    isShowPanel = true;
                }

                return true;
            }

            return false;
        }

        private void chbShow_AllParams_CheckedChanged(object sender, EventArgs e)
        {
            MainV2.config["Show_AllParams"] = this.chbShow_AllParams.Checked;
        }

    }
}