using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using log4net;
using ByAeroBeHero.Controls;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigAccelerometerCalibration : UserControl, IActivate, IDeactivate
    {
        private const float DisabledOpacity = 0.2F;
        private const float EnabledOpacity = 1.0F;
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private byte count;

        public ConfigAccelerometerCalibration()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            BUT_calib_accell.Enabled = true;
        }

        public void Deactivate()
        {
            MainV2.comPort.giveComport = false;
        }

        private void BUT_calib_accell_Click(object sender, EventArgs e)
        {
            this.lblWarnInfo.Visible = false;
            if (MainV2.comPort.giveComport)
            {
                count++;
                try
                {
                    MainV2.comPort.sendPacket(new MAVLink.mavlink_command_ack_t {command = 1, result = count});
                }
                catch
                {
                    CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    return;
                }

                return;
            }

            try
            {
                count = 0;

                Log.Info("Sending accel command (mavlink 1.0)");
                MainV2.comPort.giveComport = true;

                MainV2.comPort.Write("\n\n\n\n\n\n\n\n\n\n\n");
                Thread.Sleep(200);

                MainV2.comPort.doCommand(MAVLink.MAV_CMD.PREFLIGHT_CALIBRATION, 0, 0, 0, 0, 1, 0, 0);
                MainV2.comPort.giveComport = true;

                ThreadPool.QueueUserWorkItem(readmessage, this);

                BUT_calib_accell.Text = Strings.Click_when_Done;
            }
            catch (Exception ex)
            {
                MainV2.comPort.giveComport = false;
                Log.Error("Exception on level", ex);
                CustomMessageBox.Show("水平校准失败", Strings.ERROR);
            }
        }

        private static void readmessage(object item)
        {
            var local = (ConfigAccelerometerCalibration) item;

            // clean up history
            MainV2.comPort.MAV.cs.messages.Clear();

            while (
                !(MainV2.comPort.MAV.cs.message.ToLower().Contains("calibration successful") ||
                  MainV2.comPort.MAV.cs.message.ToLower().Contains("calibration failed")))
            {
                try
                {
                    Thread.Sleep(10);
                    // read the message
                    MainV2.comPort.readPacket();
                    // update cs with the message
                    MainV2.comPort.MAV.cs.UpdateCurrentSettings(null);
                    // update user display
                    local.UpdateUserMessage();
                }
                catch
                {
                    break;
                }
            }

            MainV2.comPort.giveComport = false;

            try
            {
                local.Invoke((MethodInvoker) delegate
                {
                    local.BUT_calib_accell.Text = "加速度计修正";//Strings.Done;
                    //local.BUT_calib_accell.Enabled = false;
                    
                });
            }
            catch
            {
            }
        }

        public void UpdateUserMessage()
        {
            Invoke((MethodInvoker) delegate
            {
                if (!MainV2.comPort.MAV.cs.message.ToLower().Contains("initi")) 
                {
                    if (MainV2.comPort.MAV.cs.message != "")
                    {
                        if (MainV2.comPort.MAV.cs.message.Contains("左"))
                        {
                            lbl_Accel_user.Text = "要求:将飞行器放在左侧，按任意键";
                        }
                        else if (MainV2.comPort.MAV.cs.message.Contains("右"))
                        {
                            lbl_Accel_user.Text = "要求:将飞行器放在右侧，按任意键";
                        }
                        else if (MainV2.comPort.MAV.cs.message.Contains("下"))
                        {
                            lbl_Accel_user.Text = "要求:将飞行器头向下，按任意键";
                        }
                        else if (MainV2.comPort.MAV.cs.message.Contains("上"))
                        {
                            lbl_Accel_user.Text = "要求:将飞行器头向上，按任意键";
                        }
                        else if (MainV2.comPort.MAV.cs.message.Contains("翻转"))
                        {
                            lbl_Accel_user.Text = "要求:将飞行器反方向放置，按任意键";
                        }
                        else if (MainV2.comPort.MAV.cs.message.Contains("水平"))
                        {
                            lbl_Accel_user.Text = "要求:将飞行器水平方向放置，按任意键";
                        }
                        else if (MainV2.comPort.MAV.cs.message.Contains("失败"))
                        {
                            lbl_Accel_user.Text = "校准失败";
                        }
                        else if (MainV2.comPort.MAV.cs.message.Contains("成功")) 
                        {
                            lbl_Accel_user.Text = "校准完成";
                        }
                    }
                    else 
                    {
                        lbl_Accel_user.Text = MainV2.comPort.MAV.cs.message;
                    }
                    
                
                }
                    //lbl_Accel_user.Text = MainV2.comPort.MAV.cs.message;
            });
        }

        private void BUT_level_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info("Sending level command (mavlink 1.0)");
                MainV2.comPort.doCommand(MAVLink.MAV_CMD.PREFLIGHT_CALIBRATION, 0, 0, 0, 0, 2, 0, 0);

                //BUT_level.Text = Strings.Completed;
                CustomMessageBox.Show("水平校准完成",Strings.Success);
                BUT_level.Text = "水平修正";
            }
            catch (Exception ex)
            {
                Log.Error("Exception on level", ex);
                CustomMessageBox.Show("水平校准失败", Strings.ERROR);
            }
        }
    }
}