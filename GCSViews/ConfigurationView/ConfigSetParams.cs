using System;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Utilities;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigSetParams : UserControl, IActivate, IDeactivate
    {

        public ConfigSetParams()
        {
            InitializeComponent();
            
        }

        public void Activate()
        {
            NUM_movelength.Value = decimal.Parse(MainV2.config["NUM_movelength"].ToString());
            setWPParams();

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
                    RTL_ALT_FINAL.Enabled = false;
                }
                else
                {
                    startup = true;
                    changes.Clear();

                 WP_YAW_BEHAVIOR.setup(
                    ParameterMetaDataRepository.GetParameterOptionsInt("WP_YAW_BEHAVIOR", MainV2.comPort.MAV.cs.firmware.ToString())
                    .ToList(), "WP_YAW_BEHAVIOR", MainV2.comPort.MAV.param);

                    RTL_ALT_P.setup(1, 500, (float)CurrentState.fromDistDisplayUnit(100), (float)0.1, "RTL_ALT",
                MainV2.comPort.MAV.param);
                    RTL_ALT_FINAL.setup(1, 500, (float)CurrentState.fromDistDisplayUnit(100), (float)0.1, "RTL_ALT_FINAL",
                MainV2.comPort.MAV.param);
                    startup = false;
                }
            }
            catch (Exception ex) { }
        }

        #region
        private void numeric_ValueUpdated(object sender, EventArgs e)
        {
            EEPROM_View_float_TextChanged(sender, e);
        }

        private void BUT_writePIDS_Click(object sender, EventArgs e)
        {
            var temp = (Hashtable)changes.Clone();

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
                catch { CustomMessageBox.Show(string.Format(Strings.ErrorSetValueFailed, value), Strings.ERROR); }
            }

            if (IsSetParam)
            {
                CustomMessageBox.Show(Strings.SetValueSuccess, Strings.Success);
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
                ((Control)sender).BackColor = Color.Green;
            }
            catch (Exception)
            {
                ((Control)sender).BackColor = Color.Red;
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

        }

        private void RTL_ALT_ValueChanged(object sender, EventArgs e)
        {
            EEPROM_View_float_TextChanged(sender, e);
        }

        private void NUM_movelength_ValueChanged(object sender, EventArgs e)
        {
            MainV2.config["NUM_movelength"] = NUM_movelength.Value;
        }
    }
}