using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using Timer = System.Windows.Forms.Timer;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigRadioInput : UserControl, IActivate, IDeactivate
    {
        private readonly float[] rcmax = new float[14];
        private readonly float[] rcmin = new float[14];
        private readonly float[] rctrim = new float[14];
        private readonly Timer timer = new Timer();
        private int chpitch = -1;
        private int chroll = -1;
        private int chthro = -1;
        private int chyaw = -1;
        private bool run;
        private bool startup;

        public ConfigRadioInput()
        {
            InitializeComponent();

            // setup rc calib extents
            for (var a = 0; a < rcmin.Length; a++)
            {
                rcmin[a] = 3000;
                rcmax[a] = 0;
                rctrim[a] = 1500;
            }


            // setup rc update
            timer.Tick += timer_Tick;
        }

        public void Activate()
        {
            timer.Enabled = true;
            timer.Interval = 100;
            timer.Start();

            if (!MainV2.comPort.MAV.param.ContainsKey("RCMAP_ROLL"))
            {
                chroll = 1;
                chpitch = 2;
                chthro = 3;
                chyaw = 4;
            }
            else
            {
                //setup bindings
                chroll = (int) (float) MainV2.comPort.MAV.param["RCMAP_ROLL"];
                chpitch = (int) (float) MainV2.comPort.MAV.param["RCMAP_PITCH"];
                chthro = (int)(float)MainV2.comPort.MAV.param["RCMAP_THROTTLE"];
                chyaw = (int) (float) MainV2.comPort.MAV.param["RCMAP_YAW"];
            }

            BARroll.DataBindings.Clear();
            BARpitch.DataBindings.Clear();
            BARthrottle.DataBindings.Clear();
            BARyaw.DataBindings.Clear();
            BAR5.DataBindings.Clear();
            BAR6.DataBindings.Clear();
            BAR7.DataBindings.Clear();
            BAR8.DataBindings.Clear();
            BAR9.DataBindings.Clear();
            BAR10.DataBindings.Clear();
            BAR11.DataBindings.Clear();
            BAR12.DataBindings.Clear();
            BAR13.DataBindings.Clear();
            BAR14.DataBindings.Clear();

            BARroll.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch" + chroll + "in", true));
            BARpitch.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch" + chpitch + "in", true));
            BARthrottle.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch" + chthro + "in", true));
            BARyaw.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch" + chyaw + "in", true));


            BAR5.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch5in", true));
            BAR6.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch6in", true));
            BAR7.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch7in", true));
            BAR8.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch8in", true));

            BAR9.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch9in", true));
            BAR10.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch10in", true));
            BAR11.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch11in", true));
            BAR12.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch12in", true));
            BAR13.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch13in", true));
            BAR14.DataBindings.Add(new Binding("Value", currentStateBindingSource, "ch14in", true));

            try
            {
                // force this screen to work
                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.RC_CHANNELS, 2);
            }
            catch
            {
            }

            startup = true;

            if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduPlane ||
                MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.Ateryx)
            {
                try
                {
                    CHK_mixmode.Checked = MainV2.comPort.MAV.param["ELEVON_MIXING"].ToString() == "1";
                    CHK_elevonrev.Checked = MainV2.comPort.MAV.param["ELEVON_REVERSE"].ToString() == "1";
                    CHK_elevonch1rev.Checked = MainV2.comPort.MAV.param["ELEVON_CH1_REV"].ToString() == "1";
                    CHK_elevonch2rev.Checked = MainV2.comPort.MAV.param["ELEVON_CH2_REV"].ToString() == "1";
                }
                catch
                {
                } // this will fail on arducopter
            }
            else
            {
                groupBoxElevons.Visible = false;

                if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2)
                {
                    //CHK_revch1.Visible = false;
                    //CHK_revch2.Visible = false;
                    //CHK_revch3.Visible = false;
                    //CHK_revch4.Visible = false;
                }
            }
            try
            {
                //CHK_revch1.Checked = MainV2.comPort.MAV.param["RC1_REV"].ToString() == "-1";
                //CHK_revch2.Checked = MainV2.comPort.MAV.param["RC2_REV"].ToString() == "-1";
                //if (MainV2.comPort.MAV.param.ContainsKey("RC3_REV"))
                //{
                //    CHK_revch3.Checked = MainV2.comPort.MAV.param["RC3_REV"].ToString() == "-1";
                //    CHK_revch4.Checked = MainV2.comPort.MAV.param["RC4_REV"].ToString() == "-1";
                //}
            }
            catch
            {
            } //(Exception ex) { CustomMessageBox.Show("Missing RC rev Param " + ex.ToString()); }
            startup = false;
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

                this.lbl1.Text = MainV2.comPort.MAV.cs.ch1in.ToString();
                this.lbl2.Text = MainV2.comPort.MAV.cs.ch2in.ToString();
                this.lbl3.Text = MainV2.comPort.MAV.cs.ch3in.ToString();
                this.lbl4.Text = MainV2.comPort.MAV.cs.ch4in.ToString();
                this.lbl5.Text = MainV2.comPort.MAV.cs.ch5in.ToString();
                this.lbl6.Text = MainV2.comPort.MAV.cs.ch6in.ToString();
                this.lbl7.Text = MainV2.comPort.MAV.cs.ch7in.ToString();
                this.lbl8.Text = MainV2.comPort.MAV.cs.ch8in.ToString();
                this.lbl9.Text = MainV2.comPort.MAV.cs.ch9in.ToString();
                this.lbl10.Text = MainV2.comPort.MAV.cs.ch10in.ToString();
                this.lbl11.Text = MainV2.comPort.MAV.cs.ch11in.ToString();
                this.lbl12.Text = MainV2.comPort.MAV.cs.ch12in.ToString();
                this.lbl13.Text = MainV2.comPort.MAV.cs.ch13in.ToString();
                this.lbl14.Text = MainV2.comPort.MAV.cs.ch14in.ToString();

                this.panel2.ForeColor = Color.Black; 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        

        private void BUT_Calibrateradio_Click(object sender, EventArgs e)
        {
            if (run)
            {
                BUT_Calibrateradio.Text = "校准遥控";
                run = false;
                return;
            }

            CustomMessageBox.Show(
                "确保你的遥控器和接收机连接电源，并且电机没有连接电源。");

            var oldrc = MainV2.comPort.MAV.cs.raterc;
            var oldatt = MainV2.comPort.MAV.cs.rateattitude;
            var oldpos = MainV2.comPort.MAV.cs.rateposition;
            var oldstatus = MainV2.comPort.MAV.cs.ratestatus;

            MainV2.comPort.MAV.cs.raterc = 10;
            MainV2.comPort.MAV.cs.rateattitude = 0;
            MainV2.comPort.MAV.cs.rateposition = 0;
            MainV2.comPort.MAV.cs.ratestatus = 0;

            try
            {
                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.RC_CHANNELS, 10);
            }
            catch
            {
            }

            BUT_Calibrateradio.Text = Strings.Click_when_Done;

            CustomMessageBox.Show(
                "确保你遥控器所有摇杆的位置达到红线位置");

            run = true;


            while (run)
            {
                Application.DoEvents();

                Thread.Sleep(5);

                MainV2.comPort.MAV.cs.UpdateCurrentSettings(currentStateBindingSource, true, MainV2.comPort);

                // check for non 0 values
                if (MainV2.comPort.MAV.cs.ch1in > 800 && MainV2.comPort.MAV.cs.ch1in < 2200)
                {
                    rcmin[0] = Math.Min(rcmin[0], MainV2.comPort.MAV.cs.ch1in);
                    rcmax[0] = Math.Max(rcmax[0], MainV2.comPort.MAV.cs.ch1in);

                    rcmin[1] = Math.Min(rcmin[1], MainV2.comPort.MAV.cs.ch2in);
                    rcmax[1] = Math.Max(rcmax[1], MainV2.comPort.MAV.cs.ch2in);

                    rcmin[2] = Math.Min(rcmin[2], MainV2.comPort.MAV.cs.ch3in);
                    rcmax[2] = Math.Max(rcmax[2], MainV2.comPort.MAV.cs.ch3in);

                    rcmin[3] = Math.Min(rcmin[3], MainV2.comPort.MAV.cs.ch4in);
                    rcmax[3] = Math.Max(rcmax[3], MainV2.comPort.MAV.cs.ch4in);

                    rcmin[4] = Math.Min(rcmin[4], MainV2.comPort.MAV.cs.ch5in);
                    rcmax[4] = Math.Max(rcmax[4], MainV2.comPort.MAV.cs.ch5in);

                    rcmin[5] = Math.Min(rcmin[5], MainV2.comPort.MAV.cs.ch6in);
                    rcmax[5] = Math.Max(rcmax[5], MainV2.comPort.MAV.cs.ch6in);

                    rcmin[6] = Math.Min(rcmin[6], MainV2.comPort.MAV.cs.ch7in);
                    rcmax[6] = Math.Max(rcmax[6], MainV2.comPort.MAV.cs.ch7in);

                    rcmin[7] = Math.Min(rcmin[7], MainV2.comPort.MAV.cs.ch8in);
                    rcmax[7] = Math.Max(rcmax[7], MainV2.comPort.MAV.cs.ch8in);

                    rcmin[8] = Math.Min(rcmin[8], MainV2.comPort.MAV.cs.ch9in);
                    rcmax[8] = Math.Max(rcmax[8], MainV2.comPort.MAV.cs.ch9in);

                    rcmin[9] = Math.Min(rcmin[9], MainV2.comPort.MAV.cs.ch10in);
                    rcmax[9] = Math.Max(rcmax[9], MainV2.comPort.MAV.cs.ch10in);

                    rcmin[10] = Math.Min(rcmin[10], MainV2.comPort.MAV.cs.ch11in);
                    rcmax[10] = Math.Max(rcmax[10], MainV2.comPort.MAV.cs.ch11in);

                    rcmin[11] = Math.Min(rcmin[11], MainV2.comPort.MAV.cs.ch12in);
                    rcmax[11] = Math.Max(rcmax[11], MainV2.comPort.MAV.cs.ch12in);

                    rcmin[12] = Math.Min(rcmin[12], MainV2.comPort.MAV.cs.ch13in);
                    rcmax[12] = Math.Max(rcmax[12], MainV2.comPort.MAV.cs.ch13in);

                    rcmin[13] = Math.Min(rcmin[13], MainV2.comPort.MAV.cs.ch14in);
                    rcmax[13] = Math.Max(rcmax[13], MainV2.comPort.MAV.cs.ch14in);

                    BARroll.minline = (int) rcmin[chroll - 1];
                    BARroll.maxline = (int) rcmax[chroll - 1];

                    BARpitch.minline = (int) rcmin[chpitch - 1];
                    BARpitch.maxline = (int) rcmax[chpitch - 1];

                    BARthrottle.minline = (int) rcmin[chthro - 1];
                    BARthrottle.maxline = (int) rcmax[chthro - 1];

                    BARyaw.minline = (int) rcmin[chyaw - 1];
                    BARyaw.maxline = (int) rcmax[chyaw - 1];

                    BAR5.minline = (int) rcmin[4];
                    BAR5.maxline = (int) rcmax[4];

                    BAR6.minline = (int) rcmin[5];
                    BAR6.maxline = (int) rcmax[5];

                    BAR7.minline = (int) rcmin[6];
                    BAR7.maxline = (int) rcmax[6];

                    BAR8.minline = (int) rcmin[7];
                    BAR8.maxline = (int) rcmax[7];

                    BAR9.minline = (int)rcmin[8];
                    BAR9.maxline = (int)rcmax[8];

                    BAR10.minline = (int)rcmin[9];
                    BAR10.maxline = (int)rcmax[9];

                    BAR11.minline = (int)rcmin[10];
                    BAR11.maxline = (int)rcmax[10];

                    BAR12.minline = (int)rcmin[11];
                    BAR12.maxline = (int)rcmax[11];

                    BAR13.minline = (int)rcmin[12];
                    BAR13.maxline = (int)rcmax[12];

                    BAR14.minline = (int)rcmin[13];
                    BAR14.maxline = (int)rcmax[13];
                }
            }

            if (rcmin[0] > 800 && rcmin[0] < 2200)
            {
            }
            else
            {
                CustomMessageBox.Show("错误的通道1");
                return;
            }

            CustomMessageBox.Show("确保遥控器的摇杆和油门都是居中的，然后点击确定继续");

            MainV2.comPort.MAV.cs.UpdateCurrentSettings(currentStateBindingSource, true, MainV2.comPort);

            rctrim[0] = MainV2.comPort.MAV.cs.ch1in;
            rctrim[1] = MainV2.comPort.MAV.cs.ch2in;
            rctrim[2] = MainV2.comPort.MAV.cs.ch3in;
            rctrim[3] = MainV2.comPort.MAV.cs.ch4in;
            rctrim[4] = MainV2.comPort.MAV.cs.ch5in;
            rctrim[5] = MainV2.comPort.MAV.cs.ch6in;
            rctrim[6] = MainV2.comPort.MAV.cs.ch7in;
            rctrim[7] = MainV2.comPort.MAV.cs.ch8in;
            rctrim[8] = MainV2.comPort.MAV.cs.ch9in;
            rctrim[9] = MainV2.comPort.MAV.cs.ch10in;
            rctrim[10] = MainV2.comPort.MAV.cs.ch11in;
            rctrim[11] = MainV2.comPort.MAV.cs.ch12in;
            rctrim[12] = MainV2.comPort.MAV.cs.ch13in;
            rctrim[13] = MainV2.comPort.MAV.cs.ch14in;

            var data = "---------------\n";

            for (var a = 0; a < 8; a++)
            {
                // we want these to save no matter what
                BUT_Calibrateradio.Text = Strings.Saving;
                try
                {
                    if (rcmin[a] != rcmax[a])
                    {
                        MainV2.comPort.setParam("RC" + (a + 1).ToString("0") + "_MIN", rcmin[a]);
                        MainV2.comPort.setParam("RC" + (a + 1).ToString("0") + "_MAX", rcmax[a]);
                    }
                    if (rctrim[a] < 1195 || rctrim[a] > 1205)
                        MainV2.comPort.setParam("RC" + (a + 1).ToString("0") + "_TRIM", rctrim[a]);
                }
                catch
                {
                    CustomMessageBox.Show("设置通道失败 " + (a + 1));
                }

                data = data + "CH" + (a + 1) + " " + rcmin[a] + " | " + rcmax[a] + "\n";
            }

            MainV2.comPort.MAV.cs.raterc = oldrc;
            MainV2.comPort.MAV.cs.rateattitude = oldatt;
            MainV2.comPort.MAV.cs.rateposition = oldpos;
            MainV2.comPort.MAV.cs.ratestatus = oldstatus;

            try
            {
                MainV2.comPort.requestDatastream(MAVLink.MAV_DATA_STREAM.RC_CHANNELS, oldrc);
            }
            catch
            {
            }

            CustomMessageBox.Show(
                "检测参数设置\n通道参数没有显示在 1500 +-2\n正常值范围 1100 | 1900\n通道:Min | Max \n" +
                data, "Radio");

            BUT_Calibrateradio.Text = "校准遥控";
        }

        private void CHK_mixmode_CheckedChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            try
            {
                if (MainV2.comPort.MAV.param["ELEVON_MIXING"] == null)
                {
                    CustomMessageBox.Show("不可用 " + MainV2.comPort.MAV.cs.firmware);
                }
                else
                {
                    MainV2.comPort.setParam("ELEVON_MIXING", ((CheckBox) sender).Checked ? 1 : 0);
                }
            }
            catch
            {
                CustomMessageBox.Show("设置 ELEVON_MIXING 失败");
            }
        }

        private void CHK_elevonrev_CheckedChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            try
            {
                if (MainV2.comPort.MAV.param["ELEVON_REVERSE"] == null)
                {
                    CustomMessageBox.Show("Not Available on " + MainV2.comPort.MAV.cs.firmware);
                }
                else
                {
                    MainV2.comPort.setParam("ELEVON_REVERSE", ((CheckBox) sender).Checked ? 1 : 0);
                }
            }
            catch
            {
                CustomMessageBox.Show("Set ELEVON_REVERSE Failed");
            }
        }

        private void CHK_elevonch1rev_CheckedChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            try
            {
                if (MainV2.comPort.MAV.param["ELEVON_CH1_REV"] == null)
                {
                    CustomMessageBox.Show("Not Available on " + MainV2.comPort.MAV.cs.firmware);
                }
                else
                {
                    MainV2.comPort.setParam("ELEVON_CH1_REV", ((CheckBox) sender).Checked ? 1 : 0);
                }
            }
            catch
            {
                CustomMessageBox.Show("Set ELEVON_CH1_REV Failed");
            }
        }

        private void CHK_elevonch2rev_CheckedChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            try
            {
                if (MainV2.comPort.MAV.param["ELEVON_CH2_REV"] == null)
                {
                    CustomMessageBox.Show("Not Available on " + MainV2.comPort.MAV.cs.firmware);
                }
                else
                {
                    MainV2.comPort.setParam("ELEVON_CH2_REV", ((CheckBox) sender).Checked ? 1 : 0);
                }
            }
            catch
            {
                CustomMessageBox.Show("Set ELEVON_CH2_REV Failed");
            }
        }

        private void CHK_revch1_CheckedChanged(object sender, EventArgs e)
        {
            reverseChannel("RC1_REV", ((CheckBox) sender).Checked, BARroll);
        }

        private void CHK_revch2_CheckedChanged(object sender, EventArgs e)
        {
            reverseChannel("RC2_REV", ((CheckBox) sender).Checked, BARpitch);
        }

        private void CHK_revch3_CheckedChanged(object sender, EventArgs e)
        {
            reverseChannel("RC3_REV", ((CheckBox) sender).Checked, BARthrottle);
        }

        private void CHK_revch4_CheckedChanged(object sender, EventArgs e)
        {
            reverseChannel("RC4_REV", ((CheckBox) sender).Checked, BARyaw);
        }

        private void reverseChannel(string name, bool normalreverse, Control progressbar)
        {
            if (normalreverse)
            {
                ((HorizontalProgressBar2) progressbar).reverse = true;
                ((HorizontalProgressBar2) progressbar).BackgroundColor = Color.FromArgb(148, 193, 31);
                ((HorizontalProgressBar2) progressbar).ValueColor = Color.FromArgb(0x43, 0x44, 0x45);
            }
            else
            {
                ((HorizontalProgressBar2) progressbar).reverse = false;
                ((HorizontalProgressBar2) progressbar).BackgroundColor = Color.FromArgb(0x43, 0x44, 0x45);
                ((HorizontalProgressBar2) progressbar).ValueColor = Color.FromArgb(148, 193, 31);
            }

            if (startup)
                return;
            if (MainV2.comPort.MAV.param["SWITCH_ENABLE"] != null &&
                (float) MainV2.comPort.MAV.param["SWITCH_ENABLE"] == 1)
            {
                try
                {
                    MainV2.comPort.setParam("SWITCH_ENABLE", 0);
                    CustomMessageBox.Show("Disabled Dip Switchs");
                }
                catch
                {
                    CustomMessageBox.Show("Error Disableing Dip Switch");
                }
            }
            try
            {
                var i = normalreverse == false ? 1 : -1;
                MainV2.comPort.setParam(name, i);
            }
            catch
            {
                CustomMessageBox.Show("Error Reversing");
            }
        }

        private void BUT_Bindradiodsm2_Click(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.START_RX_PAIR, 0, 0, 0, 0, 0, 0, 0);
                CustomMessageBox.Show(Strings.Put_the_transmitter_in_bind_mode__Receiver_is_waiting);
            }
            catch { CustomMessageBox.Show(Strings.Error_binding); }
        }

        private void BUT_BindradiodsmX_Click(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.START_RX_PAIR, 0, 1, 0, 0, 0, 0, 0);
                CustomMessageBox.Show(Strings.Put_the_transmitter_in_bind_mode__Receiver_is_waiting);
            }
            catch { CustomMessageBox.Show(Strings.Error_binding); }
        }

        private void BUT_Bindradiodsm8_Click(object sender, EventArgs e)
        {
            try
            {
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.START_RX_PAIR, 0, 2, 0, 0, 0, 0, 0);
                CustomMessageBox.Show(Strings.Put_the_transmitter_in_bind_mode__Receiver_is_waiting);
            }
            catch { CustomMessageBox.Show(Strings.Error_binding); }
        }

        private void panel1_CloseClick(object sender, EventArgs e)
        {

        }

        private void BAR8_Click(object sender, EventArgs e)
        {

        }

        private bool isShowOther = false;
        private void btnOtherCalibrate_Click(object sender, EventArgs e)
        {
            if (isShowOther)
            {
                isShowOther = false;
                this.panel2.Visible = false;
            }
            else
            {
                isShowOther = true;
                this.panel2.Visible = true;
            }
        }
    }
}
