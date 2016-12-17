using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Utilities;
using System;
using System.Text;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigAC_Fence : UserControl, IActivate
    {
        float iFenceType;
        float iFenceAction;
        float iFenceAltMax;
        float iFenceRadius;
        float iRTLAlt;
        public ConfigAC_Fence()
        {
            InitializeComponent();

            label6maxalt.Text += "("+"米"+"）";
            label7maxrad.Text += "(" + "米" + "）";
            label2rtlalt.Text += "(" + "米" + "）";
        }

        public void Activate()
        {
            initControl();
            mavlinkCheckBox1.setup(1, 0, "FENCE_ENABLE", MainV2.comPort.MAV.param);

            mavlinkComboBox1.setup(
                ParameterMetaDataRepository.GetParameterOptionsInt("FENCE_TYPE",
                    MainV2.comPort.MAV.cs.firmware.ToString()), "FENCE_TYPE", MainV2.comPort.MAV.param);


            mavlinkComboBox2.setup(
                ParameterMetaDataRepository.GetParameterOptionsInt("FENCE_ACTION",
                    MainV2.comPort.MAV.cs.firmware.ToString()), "FENCE_ACTION", MainV2.comPort.MAV.param);


            // 3
            mavlinkNumericUpDown1.setup(10, 1000, (float)CurrentState.fromDistDisplayUnit(1), 1, "FENCE_ALT_MAX",
                MainV2.comPort.MAV.param);

            mavlinkNumericUpDown2.setup(30, 65536, (float)CurrentState.fromDistDisplayUnit(1), 1, "FENCE_RADIUS",
                MainV2.comPort.MAV.param);

            mavlinkNumericUpDown3.setup(1, 500, (float)CurrentState.fromDistDisplayUnit(100), (float)0.1, "RTL_ALT",
                MainV2.comPort.MAV.param);


        }

        private void initControl() 
        {
            this.label3enable.ForeColor = this.label1.ForeColor = this.label4type.ForeColor = this.label5action.ForeColor = this.label6maxalt.ForeColor =
                this.label7maxrad.ForeColor = this.label2rtlalt.ForeColor = System.Drawing.Color.Black;
        
        }


        public string sendParam() 
        {
            StringBuilder errorMessage = new StringBuilder();

            if(!MainV2.comPort.BaseStream.IsOpen)
            {
                return errorMessage.Append("请连接地面站，再进行操作设置！").ToString();
            }


            if (!MainV2.comPort.setParam(mavlinkComboBox1.ParamName, iFenceType))
            {
                errorMessage.Append(label4type.Text + " ,");
            }

            if (!MainV2.comPort.setParam(mavlinkComboBox2.ParamName, iFenceAction))
            {
                errorMessage.Append(label5action.Text + " ,");
            }

            if (this.mavlinkCheckBox1.Checked)
            {
                    bool ans = MainV2.comPort.setParam(this.mavlinkCheckBox1.ParamName, 1);
                    if (ans == false)
                        errorMessage.Append(label3enable.Text + " ,");
            }
            else
            {
                    bool ans = MainV2.comPort.setParam(this.mavlinkCheckBox1.ParamName, 0);
                    if (ans == false)
                        errorMessage.Append(label3enable.Text + " ,");
            }

            if (!MainV2.comPort.setParam(mavlinkNumericUpDown1.ParamName, iFenceAltMax))
            {
                errorMessage.Append(label6maxalt.Text + " ,");
            }

            if (!MainV2.comPort.setParam(mavlinkNumericUpDown2.ParamName, iFenceRadius))
            {
                errorMessage.Append(this.label7maxrad.Text + " ,");
            }

            if (!MainV2.comPort.setParam(mavlinkNumericUpDown3.ParamName, iRTLAlt*100))
            {
                errorMessage.Append(this.label2rtlalt.Text + " ,");
            }

            return errorMessage.ToString();
        }
        private void btnSendParam_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (sendParam().Length > 0)
                {
                    CustomMessageBox.Show(sendParam(), "提示");
                }
                else 
                {
                    CustomMessageBox.Show("成功写入参数", "提示");
                } 
            }
            catch
            {
                CustomMessageBox.Show(sendParam(), "提示");
            }
            

        }

        private void mavlinkNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            iFenceAltMax = (float)mavlinkNumericUpDown1.Value;
        }

        private void mavlinkNumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            iFenceRadius = (float)mavlinkNumericUpDown2.Value;
        }

        private void mavlinkNumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            iRTLAlt = (float)mavlinkNumericUpDown3.Value;
        }

        private void mavlinkComboBox1_TextChanged(object sender, EventArgs e)
        {
            if(mavlinkComboBox1.Text == "无"){iFenceType=0;}
            else if(mavlinkComboBox1.Text == "高度限制"){iFenceType=1;}
            else if (mavlinkComboBox1.Text == "半径限制") { iFenceType = 2; }
            else{iFenceType=3;}
        }

        private void mavlinkComboBox2_TextChanged(object sender, EventArgs e)
        {
            if (mavlinkComboBox2.Text == "仅通知") { iFenceAction = 0; }
            else{ iFenceAction = 1; }
        }


    }
}