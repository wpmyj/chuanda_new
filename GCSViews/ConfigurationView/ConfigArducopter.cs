using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Utilities;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigArducopter : UserControl, IActivate
    {
        // from http://stackoverflow.com/questions/2512781/winforms-big-paragraph-tooltip/2512895#2512895
        private const int maximumSingleLineTooltipLength = 50;
        private static Hashtable tooltips = new Hashtable();
        private readonly Hashtable changes = new Hashtable();
        internal bool startup = true;

        

        public ConfigArducopter()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            initControl();
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                Enabled = false;
                return;
            }
            if (MainV2.comPort.MAV.cs.firmware == MainV2.Firmwares.ArduCopter2)
            {
                Enabled = true;
            }
            else
            {
                Enabled = false;
                return;
            }

            startup = true;

            changes.Clear();

            RATE_PIT_D.setup(0, 0, 1, 0.001f, "RATE_PIT_D", MainV2.comPort.MAV.param);
            RATE_PIT_I.setup(0, 0, 1, 0.001f, "RATE_PIT_I", MainV2.comPort.MAV.param);
            RATE_PIT_IMAX.setup(0, 0, 10, 0.1f, "RATE_PIT_IMAX", MainV2.comPort.MAV.param);
            RATE_PIT_P.setup(0, 0, 1, 0.001f, "RATE_PIT_P", MainV2.comPort.MAV.param);
            RATE_RLL_D.setup(0, 0, 1, 0.001f, "RATE_RLL_D", MainV2.comPort.MAV.param);
            RATE_RLL_I.setup(0, 0, 1, 0.001f, "RATE_RLL_I", MainV2.comPort.MAV.param);
            RATE_RLL_IMAX.setup(0, 0, 10, 0.1f, "RATE_RLL_IMAX", MainV2.comPort.MAV.param);
            RATE_RLL_P.setup(0, 0, 1, 0.001f, "RATE_RLL_P", MainV2.comPort.MAV.param);
            RATE_YAW_D.setup(0, 0, 1, 0.001f, "RATE_YAW_D", MainV2.comPort.MAV.param);
            RATE_YAW_I.setup(0, 0, 1, 0.001f, "RATE_YAW_I", MainV2.comPort.MAV.param);
            RATE_YAW_IMAX.setup(0, 0, 10, 0.1f, "RATE_YAW_IMAX", MainV2.comPort.MAV.param);
            RATE_YAW_P.setup(0, 0, 1, 0.001f, "RATE_YAW_P", MainV2.comPort.MAV.param);
            STB_PIT_P.setup(0, 0, 1, 0.001f, "STB_PIT_P", MainV2.comPort.MAV.param);
            STB_RLL_P.setup(0, 0, 1, 0.001f, "STB_RLL_P", MainV2.comPort.MAV.param);
            STB_YAW_P.setup(0, 0, 1, 0.001f, "STB_YAW_P", MainV2.comPort.MAV.param);

            Btn_refParam(); 
            startup = false;
        }

        private void initControl() 
        {
            this.label19.ForeColor = this.label20.ForeColor = this.label21.ForeColor = this.label43.ForeColor = this.label44.ForeColor =
            this.label45.ForeColor = this.label40.ForeColor = this.label48.ForeColor = this.label49.ForeColor = this.label50.ForeColor =
            this.label23.ForeColor = System.Drawing.Color.Black;
        }


        private void disableNumericUpDownControls(Control inctl)
        {
            foreach (Control ctl in inctl.Controls)
            {
                if (ctl.Controls.Count > 0)
                {
                    disableNumericUpDownControls(ctl);
                }
                if (ctl.GetType() == typeof (NumericUpDown))
                {
                    ctl.Enabled = false;
                }
            }
        }

        internal void EEPROM_View_float_TextChanged(object sender, EventArgs e)
        {
            if (startup)
                return;

            float value = 0;
            var name = ((Control) sender).Name;

            // do domainupdown state check
            try
            {
                if (sender.GetType() == typeof (MavlinkNumericUpDown))
                {
                    value = ((MAVLinkParamChanged) e).value;
                    changes[name] = value;
                }
                else if (sender.GetType() == typeof (MavlinkComboBox))
                {
                    value = ((MAVLinkParamChanged) e).value;
                    changes[name] = value;
                }
                ((Control) sender).BackColor = Color.Green;
            }
            catch (Exception)
            {
                ((Control) sender).BackColor = Color.Red;
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
                        arr[0].Text = ((Control) sender).Text;
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
                        arr[0].Text = ((Control) sender).Text;
                        arr[0].BackColor = Color.Green;
                    }
                }
            }
            catch
            {
            }
        }

        private void BUT_writePIDS_Click(object sender, EventArgs e)
        {

            if (!MainV2.comPort.BaseStream.IsOpen)
                return;

            try {

                VerificationParams(); 

                MainV2.comPort.setParam("STB_YAW_P", STB_YAW_P1);
                MainV2.comPort.setParam("STB_RLL_P", STB_RLL_P1);
                MainV2.comPort.setParam("STB_PIT_P", STB_PIT_P1);
                MainV2.comPort.setParam("RATE_YAW_P", RATE_YAW_P1);
                MainV2.comPort.setParam("RATE_RLL_P", RATE_RLL_P1);
                MainV2.comPort.setParam("RATE_PIT_P", RATE_PIT_P1);
                MainV2.comPort.setParam("RATE_YAW_I", RATE_YAW_I1);
                MainV2.comPort.setParam("RATE_RLL_I", RATE_RLL_I1);
                MainV2.comPort.setParam("RATE_PIT_I", RATE_PIT_I1);
                //MainV2.comPort.setParam("RATE_YAW_D", RATE_YAW_D1);
                MainV2.comPort.setParam("RATE_RLL_D", RATE_RLL_D1);
                MainV2.comPort.setParam("RATE_PIT_D", RATE_PIT_D1);
                MainV2.comPort.setParam("RATE_YAW_IMAX", RATE_YAW_IMAX1);
                MainV2.comPort.setParam("RATE_RLL_IMAX", RATE_RLL_IMAX1);
                MainV2.comPort.setParam("RATE_PIT_IMAX", RATE_PIT_IMAX1);

                CustomMessageBox.Show("设置飞行模式成功!", "提示");
                
            }
            catch { CustomMessageBox.Show("设置飞行模式失败!", "提示"); }
        }

        /// <summary>
        ///     Handles the Click event of the BUT_rerequestparams control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        protected void BUT_rerequestparams_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
                return;

            ((Control) sender).Enabled = false;

            try
            {
                MainV2.comPort.getParamList();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(Strings.ErrorReceivingParams + ex, Strings.ERROR);
            }


            ((Control) sender).Enabled = true;


            Activate();
        }

        private void BUT_refreshpart_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
                return;

            Activate();
            ByAeroBeHero.MainV2.instance.refParams();
        }

        private void Btn_refParam() 
        {
            STB_YAW_P_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["STB_YAW_P"].ToString()) - 1.5) / 4 * 100;
            STB_RLL_P_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["STB_RLL_P"].ToString()) - 2.5) / 4 * 100;
            STB_PIT_P_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["STB_PIT_P"].ToString()) - 2.5) / 4 * 100;

            RATE_YAW_P_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["RATE_YAW_P"].ToString()) - 0.25) / 4 * 1000;
            RATE_RLL_P_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["RATE_RLL_P"].ToString()) - 0.1) / 19 * 10000;
            RATE_PIT_P_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["RATE_PIT_P"].ToString()) - 0.1) / 19 * 10000;

            RATE_YAW_I_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["RATE_YAW_I"].ToString()) - 0.01) / 4 * 10000;
            RATE_RLL_I_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["RATE_RLL_I"].ToString()) - 0.1) / 14 * 10000;
            RATE_PIT_I_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["RATE_PIT_I"].ToString()) - 0.1) / 14 * 10000;

            RATE_YAW_D_1.Value = 50;
            RATE_RLL_D_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["RATE_RLL_D"].ToString()) - 0.001) / 6 * 100000;
            RATE_PIT_D_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["RATE_PIT_D"].ToString()) - 0.001) / 6 * 100000;

            RATE_YAW_IMAX_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["RATE_YAW_IMAX"].ToString()))/20;
            RATE_RLL_IMAX_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["RATE_RLL_IMAX"].ToString()) - 500)/30;
            RATE_PIT_IMAX_1.Value = (decimal)(float.Parse(MainV2.comPort.MAV.param["RATE_PIT_IMAX"].ToString()) - 500)/30;
        
        }

        private void updateparam(Control parentctl)
        {
            foreach (Control ctl in parentctl.Controls)
            {
                if (typeof (MavlinkNumericUpDown) == ctl.GetType() || typeof (ComboBox) == ctl.GetType())
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

        private void numeric_ValueUpdated(object sender, EventArgs e)
        {
            EEPROM_View_float_TextChanged(sender, e);
        }

        private float STB_YAW_P1 =0;
        private float STB_RLL_P1 = 0;
        private float STB_PIT_P1= 0;
        private float RATE_YAW_P1 = 0;
        private float RATE_RLL_P1 = 0;
        private float RATE_PIT_P1 = 0;
        private float RATE_YAW_I1 = 0;
        private float RATE_RLL_I1 = 0;
        private float RATE_PIT_I1 = 0;
        private float RATE_YAW_D1 = 0;
        private float RATE_RLL_D1 = 0;
        private float RATE_PIT_D1 = 0;
        private float RATE_YAW_IMAX1 = 0;
        private float RATE_RLL_IMAX1 = 0;
        private float RATE_PIT_IMAX1 = 0;
        private void adjustmentParameters_ValueChanged(object sender, EventArgs e)
        {

            VerificationParams(); 
            STB_YAW_P1 = (float)STB_YAW_P_1.Value * 4 /100 + (float)1.5;
            STB_RLL_P1 = (float)STB_RLL_P_1.Value * 4 / 100 + (float)2.5;
            STB_PIT_P1 = (float)STB_PIT_P_1.Value * 4 / 100 + (float)2.5;

            RATE_YAW_P1 = (float)RATE_YAW_P_1.Value * 4 / 1000 + (float)0.25;
            RATE_RLL_P1 = (float)RATE_RLL_P_1.Value * 19 / 10000 + (float)0.1;
            RATE_PIT_P1 = (float)RATE_PIT_P_1.Value * 19 / 10000 + (float)0.1;

            RATE_YAW_I1 = (float)RATE_YAW_I_1.Value * 4 / 10000 + (float)0.01;
            RATE_RLL_I1 = (float)RATE_RLL_I_1.Value * 14 / 10000 + (float)0.1;
            RATE_PIT_I1 = (float)RATE_PIT_I_1.Value * 14 / 10000 + (float)0.1;

            RATE_YAW_D1 = 50;
            RATE_RLL_D1 = (float)RATE_RLL_D_1.Value * 6 / 100000 + (float)0.001;
            RATE_PIT_D1 = (float)RATE_PIT_D_1.Value * 6 / 100000 + (float)0.001;

            RATE_YAW_IMAX1 = (float)RATE_YAW_IMAX_1.Value * 20 ;
            RATE_RLL_IMAX1 = (float)RATE_RLL_IMAX_1.Value * 30 + 500;
            RATE_PIT_IMAX1 = (float)RATE_PIT_IMAX_1.Value * 30 + 500;
        }

        private void noticeInfo() 
        {
            CustomMessageBox.Show("参数值应该在20-100之间", "提示");
        }

        private void VerificationParams() 
        {
            if (STB_YAW_P_1.Value < 20 || STB_YAW_P_1.Value > 100)
            {
                noticeInfo();
                return;
            }

            if (STB_RLL_P_1.Value < 20 || STB_RLL_P_1.Value > 100)
            {
                noticeInfo();
                return;
            }

            if (STB_PIT_P_1.Value < 20 || STB_PIT_P_1.Value > 100)
            {
                noticeInfo();
                return;
            }

            if (RATE_YAW_P_1.Value < 20 || RATE_YAW_P_1.Value > 100)
            {
                noticeInfo();
                return;
            }

            if (RATE_RLL_P_1.Value < 0 || RATE_RLL_P_1.Value > 100)
            {
                noticeInfo();
                return;
            }

            if (RATE_PIT_P_1.Value < 0 || RATE_PIT_P_1.Value > 100)
            {
                noticeInfo();
                return;
            }

            if (RATE_YAW_I_1.Value < 0 || RATE_YAW_I_1.Value > 100)
            {
                noticeInfo();
                return;
            }

            if (RATE_RLL_I_1.Value < 0 || RATE_RLL_I_1.Value > 100)
            {
                noticeInfo();
                return;
            }

            if (RATE_PIT_I_1.Value < 0 || RATE_PIT_I_1.Value > 100)
            {
                noticeInfo();
                return;
            }


            if (RATE_RLL_D_1.Value < 0 || RATE_RLL_D_1.Value > 100)
            {
                noticeInfo();
                return;
            }

            if (RATE_YAW_IMAX_1.Value < 0 || RATE_YAW_IMAX_1.Value > 100)
            {
                noticeInfo();
                return;
            }

            if (RATE_RLL_IMAX_1.Value < 0 || RATE_RLL_IMAX_1.Value > 100)
            {
                noticeInfo();
                return;
            }

            if (RATE_PIT_IMAX_1.Value < 0 || RATE_PIT_IMAX_1.Value > 100)
            {
                noticeInfo();
                return;
            }
        }





        //private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        //{
        //    // 重绘
        //    //e.Graphics.DrawRectangle(new Pen(Color.Black), e.CellBounds.X, e.CellBounds.Y, e.CellBounds.X + e.CellBounds.Width - 1, e.CellBounds.Y + e.CellBounds.Height - 1); 
        //}
    }
}