using System;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using ByAeroBeHero.Controls;
using Transitions;
using ByAeroBeHero.HIL;
using System.Drawing;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigFrameType : MyUserControl, IActivate, IDeactivate
    {

        public enum Frame
        {
            Plus = 0,
            X = 1,
            V = 2,
            H = 3,
            VTail = 4,
            Y = 10
        }

        public enum CopterType 
        {
            Four = 1,
            Six = 2,
            Eight = 3
        }

        public enum MotorTest
        {
            One = 11,
            Two = 12,
            Three = 13,
            Four = 14,
            Five = 15,
            Six = 16,
            Seven = 17,
            Eight = 18
        }

        private const float DisabledOpacity = 0.2F;
        private const float EnabledOpacity = 1.0F;
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private bool indochange;
        private int iCopterType;
        private int iMotorTest;

        public ConfigFrameType()
        {
            InitializeComponent();
            //configDefaultSettings1.OnChange += configDefaultSettings1_OnChange;
        }

        public void Activate()
        {
            //if (!MainV2.comPort.MAV.param.ContainsKey("FRAME"))
            //{
            //    Enabled = false;
            //    return;
            //}

            #region

            var motormax = 8;

            if (!MainV2.comPort.MAV.param.ContainsKey("FRAME"))
            {
                Enabled = false;
                return;
            }

            var motors = new Motor[0];

            if (MainV2.comPort.MAV.aptype == MAVLink.MAV_TYPE.TRICOPTER)
            {
                motormax = 4;

                motors = Motor.build_motors(MAVLink.MAV_TYPE.TRICOPTER, (int)(float)MainV2.comPort.MAV.param["FRAME"]);
            }
            else if (MainV2.comPort.MAV.aptype == MAVLink.MAV_TYPE.QUADROTOR)
            {
                motormax = 4;

                motors = Motor.build_motors(MAVLink.MAV_TYPE.QUADROTOR, (int)(float)MainV2.comPort.MAV.param["FRAME"]);
            }
            else if (MainV2.comPort.MAV.aptype == MAVLink.MAV_TYPE.HEXAROTOR)
            {
                motormax = 6;

                motors = Motor.build_motors(MAVLink.MAV_TYPE.HEXAROTOR, (int)(float)MainV2.comPort.MAV.param["FRAME"]);
            }
            else if (MainV2.comPort.MAV.aptype == MAVLink.MAV_TYPE.OCTOROTOR)
            {
                motormax = 8;

                motors = Motor.build_motors(MAVLink.MAV_TYPE.OCTOROTOR, (int)(float)MainV2.comPort.MAV.param["FRAME"]);
            }
            else if (MainV2.comPort.MAV.aptype == MAVLink.MAV_TYPE.HELICOPTER)
            {
                motormax = 0;
            }

            ControlRabtn(motormax);

            #endregion

            this.BackColor = System.Drawing.Color.Teal;
            DoChange((Frame) Enum.Parse(typeof (Frame), MainV2.comPort.MAV.param["FRAME"].ToString()));
        }

        

        public void Deactivate()
        {
            MainV2.comPort.giveComport = false;
        }

        private void configDefaultSettings1_OnChange(object sender, EventArgs e)
        {
            Activate();
        }

        #region

        private void DoChange(Frame frame)
        {
            //if (indochange)
            //    return;

            //indochange = true;

            //switch (frame)
            //{
            //    case Frame.Plus:
            //        FadePicBoxes(pictureBoxPlus, EnabledOpacity);
            //        FadePicBoxes(pictureBoxX, EnabledOpacity);
            //        FadePicBoxes(pictureBoxV, EnabledOpacity);
            //        FadePicBoxes(pictureBoxH, EnabledOpacity);
            //        FadePicBoxes(pictureBoxY, EnabledOpacity);
            //        FadePicBoxes(pictureBoxVTail, EnabledOpacity);
            //        radioButton_VTail.Checked = false;
            //        radioButton_Plus.Checked = true;
            //        radioButton_V.Checked = false;
            //        radioButton_X.Checked = false;
            //        radioButton_H.Checked = false;
            //        radioButton_Y.Checked = false;
            //        SetFrameParam(frame);
            //        break;
            //    case Frame.X:
            //        FadePicBoxes(pictureBoxPlus, EnabledOpacity);
            //        FadePicBoxes(pictureBoxX, EnabledOpacity);
            //        FadePicBoxes(pictureBoxV, EnabledOpacity);
            //        FadePicBoxes(pictureBoxH, EnabledOpacity);
            //        FadePicBoxes(pictureBoxY, EnabledOpacity);
            //        FadePicBoxes(pictureBoxVTail, EnabledOpacity);
            //        radioButton_VTail.Checked = false;
            //        radioButton_Plus.Checked = false;
            //        radioButton_V.Checked = false;
            //        radioButton_X.Checked = true;
            //        radioButton_H.Checked = false;
            //        radioButton_Y.Checked = false;
            //        SetFrameParam(frame);
            //        break;
            //    case Frame.V:
            //        FadePicBoxes(pictureBoxPlus, EnabledOpacity);
            //        FadePicBoxes(pictureBoxX, EnabledOpacity);
            //        FadePicBoxes(pictureBoxV, EnabledOpacity);
            //        FadePicBoxes(pictureBoxH, EnabledOpacity);
            //        FadePicBoxes(pictureBoxY, EnabledOpacity);
            //        FadePicBoxes(pictureBoxVTail, EnabledOpacity);
            //        radioButton_VTail.Checked = false;
            //        radioButton_Plus.Checked = false;
            //        radioButton_V.Checked = true;
            //        radioButton_X.Checked = false;
            //        radioButton_H.Checked = false;
            //        radioButton_Y.Checked = false;
            //        SetFrameParam(frame);
            //        break;
            //    case Frame.H:
            //        FadePicBoxes(pictureBoxPlus, EnabledOpacity);
            //        FadePicBoxes(pictureBoxX, EnabledOpacity);
            //        FadePicBoxes(pictureBoxV, EnabledOpacity);
            //        FadePicBoxes(pictureBoxH, EnabledOpacity);
            //        FadePicBoxes(pictureBoxY, EnabledOpacity);
            //        FadePicBoxes(pictureBoxVTail, EnabledOpacity);
            //        radioButton_VTail.Checked = false;
            //        radioButton_Plus.Checked = false;
            //        radioButton_V.Checked = false;
            //        radioButton_X.Checked = false;
            //        radioButton_H.Checked = true;
            //        radioButton_Y.Checked = false;
            //        SetFrameParam(frame);
            //        break;
            //    case Frame.Y:
            //        FadePicBoxes(pictureBoxPlus, EnabledOpacity);
            //        FadePicBoxes(pictureBoxX, EnabledOpacity);
            //        FadePicBoxes(pictureBoxV, EnabledOpacity);
            //        FadePicBoxes(pictureBoxH, EnabledOpacity);
            //        FadePicBoxes(pictureBoxY, EnabledOpacity);
            //        FadePicBoxes(pictureBoxVTail, EnabledOpacity);
            //        radioButton_VTail.Checked = false;
            //        radioButton_Plus.Checked = false;
            //        radioButton_V.Checked = false;
            //        radioButton_X.Checked = false;
            //        radioButton_H.Checked = false;
            //        radioButton_Y.Checked = true;
            //        SetFrameParam(frame);
            //        break;
            //    case Frame.VTail:
            //        FadePicBoxes(pictureBoxPlus, EnabledOpacity);
            //        FadePicBoxes(pictureBoxX, EnabledOpacity);
            //        FadePicBoxes(pictureBoxV, EnabledOpacity);
            //        FadePicBoxes(pictureBoxH, EnabledOpacity);
            //        FadePicBoxes(pictureBoxY, EnabledOpacity);
            //        FadePicBoxes(pictureBoxVTail, EnabledOpacity);
            //        radioButton_VTail.Checked = true;
            //        radioButton_Plus.Checked = false;
            //        radioButton_V.Checked = false;
            //        radioButton_X.Checked = false;
            //        radioButton_H.Checked = false;
            //        radioButton_Y.Checked = false;
            //        SetFrameParam(frame);
            //        break;
            //    default:
            //        radioButton_Plus.Checked = false;
            //        radioButton_V.Checked = false;
            //        radioButton_X.Checked = false;
            //        radioButton_H.Checked = false;
            //        radioButton_Y.Checked = false;
            //        break;
            //}
            //indochange = false;
        }

        private void SetFrameParam(Frame frame)
        {
            try
            {
                MainV2.comPort.setParam("FRAME", (int) frame);
            }
            catch
            {
                CustomMessageBox.Show(string.Format(Strings.ErrorSetValueFailed, "FRAME"), Strings.ERROR,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FadePicBoxes(Control picbox, float Opacity)
        {
            var fade = new Transition(new TransitionType_Linear(400));
            fade.add(picbox, "Opacity", Opacity);
            fade.run();
        }

        private void radioButton_Plus_CheckedChanged(object sender, EventArgs e)
        {
            DoChange(Frame.Plus);
        }

        private void radioButton_X_CheckedChanged(object sender, EventArgs e)
        {
            DoChange(Frame.X);
        }

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            DoChange(Frame.Plus);
        }

        private void pictureBoxX_Click(object sender, EventArgs e)
        {
            DoChange(Frame.X);
        }

        private void pictureBoxV_Click(object sender, EventArgs e)
        {
            DoChange(Frame.V);
        }

        private void radioButton_V_CheckedChanged(object sender, EventArgs e)
        {
            DoChange(Frame.V);
        }

        private void pictureBoxH_Click(object sender, EventArgs e)
        {
            DoChange(Frame.H);
        }

        private void radioButton_H_CheckedChanged(object sender, EventArgs e)
        {
            DoChange(Frame.H);
        }

        private void pictureBoxY_Click(object sender, EventArgs e)
        {
            DoChange(Frame.Y);
        }

        private void radioButton_Y_CheckedChanged(object sender, EventArgs e)
        {
            DoChange(Frame.Y);
        }

        private void radioButton_VTail_CheckedChanged(object sender, EventArgs e)
        {
            DoChange(Frame.VTail);
        }

        private void pictureBoxVTail_Click(object sender, EventArgs e)
        {
            DoChange(Frame.VTail);
        }

#endregion

        #region 选择机架类型
        private void btnSelectRackType_Click(object sender, EventArgs e)
        {
            string paramName = "COPTER_TYPE";
            if (iCopterType != 0 && MainV2.comPort.setParams(paramName, iCopterType))
                CustomMessageBox.Show(string.Format(Strings.CopterTypeSetSuccessed, "CopterType"), Strings.CopterTypeSelected,
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else  
                CustomMessageBox.Show(string.Format(Strings.CopterTypeSetFailed, "CopterType"), Strings.CopterTypeSelected,
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RadbtnFourRotor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadbtnFourRotor.Checked) 
            {
                this.iCopterType = (int)CopterType.Four;
                this.lblText1.Text = Strings.CopterTypeInstruction1;
                this.lblText3.Text = Strings.CopterTypeInstruction2;
                this.lblText4.Text = Strings.CopterTypeInstruction3;
            }
        }

        private void RadbtnFiveRotor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadbtnFiveRotor.Checked) 
            {
                this.iCopterType = (int)CopterType.Six;
                this.lblText1.Text = Strings.CopterTypeInstruction4;
                this.lblText3.Text = Strings.CopterTypeInstruction2;
                this.lblText4.Text = Strings.CopterTypeInstruction3;
            } 
        }

        private void RadbtnSevenRotor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadbtnSevenRotor.Checked) 
            {
                this.iCopterType = (int)CopterType.Eight;
                this.lblText1.Text = Strings.CopterTypeInstruction5;
                this.lblText3.Text = Strings.CopterTypeInstruction2;
                this.lblText4.Text = Strings.CopterTypeInstruction3;
            }
        }
        #endregion

        #region 电机测试

        private void ControlRabtn(int motormax)
        {
            this.rbtn1.Enabled = true;
            this.rbtn2.Enabled = true;
            this.rbtn3.Enabled = true;
            this.rbtn4.Enabled = true;
            this.rbtn5.Enabled = true;
            this.rbtn6.Enabled = true;
            this.rbtn7.Enabled = true;
            this.rbtn8.Enabled = true;


            if (motormax == 4)
            {
                this.rbtn5.Enabled = false;
                this.rbtn6.Enabled = false;
                this.rbtn7.Enabled = false;
                this.rbtn8.Enabled = false;
            }
            else if (motormax == 6)
            {
                this.rbtn7.Enabled = false;
                this.rbtn8.Enabled = false;
            }
            else if (motormax == 8)
            {

            }
            else
            {
                this.rbtn1.Enabled = false;
                this.rbtn2.Enabled = false;
                this.rbtn3.Enabled = false;
                this.rbtn4.Enabled = false;
                this.rbtn5.Enabled = false;
                this.rbtn6.Enabled = false;
                this.rbtn7.Enabled = false;
                this.rbtn8.Enabled = false;
            }
        }
        private void but_Click(object sender, EventArgs e)
        {
            try
            {
                object motor = ((RadioButton)sender).Tag;

                int imotor = Convert.ToInt32(motor);
                if (MainV2.comPort.doMotorTest(imotor, MAVLink.MOTOR_TEST_THROTTLE_TYPE.MOTOR_TEST_THROTTLE_PERCENT,
                    (int)NUM_thr_percent.Value, (int)NUM_duration.Value))
                {
                }
                else
                {
                    CustomMessageBox.Show("测试电机失败!");
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("测试电机失败!");
            }
        }
        #endregion


    }
}