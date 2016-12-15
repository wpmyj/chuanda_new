using System;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using ByAeroBeHero.Controls;
using Transitions;
using ByAeroBeHero.HIL;
using System.Drawing;
using System.Threading;

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

        private const float DisabledOpacity = 0.2F;
        private const float EnabledOpacity = 1.0F;
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private int iCopterType;
        private int iShapeType;

        public ConfigFrameType()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl()
        {
            label8.ForeColor = lblDuration.ForeColor = lblSelectCpterType.ForeColor = lblMotorTest.ForeColor = Color.Black;

        }

        public void Activate()
        {
            this.BackColor = Color.DimGray;
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

            int iCopterType = (int)(float)MainV2.comPort.MAV.param["COPTER_TYPE"];

            if (iCopterType == 1 && (int)(float)MainV2.comPort.MAV.param["FRAME"] == 1) 
            {
                RadbtnFourRotor_CheckedChanged(null,null);
            }
            else if (iCopterType == 2 && (int)(float)MainV2.comPort.MAV.param["FRAME"] == 1)
            {
                RadbtnFiveRotor_CheckedChanged(null, null);
            }
            else if (iCopterType == 3 && (int)(float)MainV2.comPort.MAV.param["FRAME"] == 1)
            {
                RadbtnSevenRotor_CheckedChanged(null, null);
            }
            else if (iCopterType == 1 && (int)(float)MainV2.comPort.MAV.param["FRAME"] == 0)
            {
                RadbtnFourRotorT_CheckedChanged(null, null);
            }
            else if (iCopterType == 2 && (int)(float)MainV2.comPort.MAV.param["FRAME"] == 0)
            {
                RadbtnFiveRotorT_CheckedChanged(null, null);
            }
            else if (iCopterType == 3 && (int)(float)MainV2.comPort.MAV.param["FRAME"] == 0)
            {
                RadbtnSevenRotorT_CheckedChanged(null, null);
            }
            else if (iCopterType == 2 && (int)(float)MainV2.comPort.MAV.param["FRAME"] == 6)
            {
                RadbtnSpSixRotorT_CheckedChanged(null,null);
            }
            ControlRabtn(iCopterType);

            #endregion
            DoChange((Frame) Enum.Parse(typeof (Frame), MainV2.comPort.MAV.param["FRAME"].ToString()));
        }      

        public void Deactivate()
        {
            MainV2.comPort.giveComport = false;
        }

        #region

        private void DoChange(Frame frame)
        {

        }

        private void SetFrameParam(int frame)
        {
            try
            {
                MainV2.comPort.setParam("FRAME", frame);
            }
            catch
            {
                CustomMessageBox.Show(string.Format(Strings.ErrorSetValueFailed, "FRAME"), Strings.ERROR,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region 选择机架类型
        private void btnSelectRackType_Click(object sender, EventArgs e)
        {
            string paramName = "COPTER_TYPE";
            if (iCopterType != 0 && MainV2.comPort.setParams(paramName, iCopterType))
            {
            
                CustomMessageBox.Show(string.Format(Strings.CopterTypeSetSuccessed, "CopterType"), Strings.CopterTypeSelected,
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetFrameParam(iShapeType);
            }
            else  
                CustomMessageBox.Show(string.Format(Strings.CopterTypeSetFailed, "CopterType"), Strings.CopterTypeSelected,
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        /// <summary>
        /// X四轴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadbtnFourRotor_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.RadbtnFourRotor.Checked) 
            //{
                this.iCopterType = (int)CopterType.Four;
                this.iShapeType = 1;
                this.pictureBoxWithPseudoOpacity2.BackColor = Color.White;
                this.pictureBoxWithPseudoOpacity1.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity3.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity4.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity5.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity6.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity7.BackColor = Color.Transparent;
                this.RadbtnFourRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.white;
                this.RadbtnFiveRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnSevenRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFourRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFiveRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnSevenRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnSpSixRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;

            //}
        }

        /// <summary>
        /// X六轴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadbtnFiveRotor_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.RadbtnFiveRotor.Checked) 
            //{
                this.iShapeType = 1;
                this.iCopterType = (int)CopterType.Six;
                this.pictureBoxWithPseudoOpacity2.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity1.BackColor = Color.White;
                this.pictureBoxWithPseudoOpacity3.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity4.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity5.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity6.BackColor = Color.Transparent;
                this.RadbtnFourRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFiveRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.white;
                this.RadbtnSevenRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFourRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFiveRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnSevenRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.pictureBoxWithPseudoOpacity7.BackColor = Color.Transparent;
                this.RadbtnSpSixRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            //} 
        }

        /// <summary>
        /// X8轴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadbtnSevenRotor_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.RadbtnSevenRotor.Checked) 
            //{
                this.iShapeType = 1;
                this.iCopterType = (int)CopterType.Eight;
                this.pictureBoxWithPseudoOpacity2.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity1.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity3.BackColor = Color.White;
                this.pictureBoxWithPseudoOpacity4.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity5.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity6.BackColor = Color.Transparent;
                this.RadbtnFourRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFiveRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnSevenRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.white;
                this.RadbtnFourRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFiveRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnSevenRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.pictureBoxWithPseudoOpacity7.BackColor = Color.Transparent;
                this.RadbtnSpSixRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;

            //}
        }

        /// <summary>
        /// 十4轴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadbtnFourRotorT_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.RadbtnFourRotorT.Checked)
            //{
                this.iShapeType = 0;
                this.iCopterType = (int)CopterType.Four;
                this.pictureBoxWithPseudoOpacity2.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity1.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity3.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity4.BackColor = Color.White;
                this.pictureBoxWithPseudoOpacity5.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity6.BackColor = Color.Transparent;
                this.RadbtnFourRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFiveRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnSevenRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFourRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.white;
                this.RadbtnFiveRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnSevenRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.pictureBoxWithPseudoOpacity7.BackColor = Color.Transparent;
                this.RadbtnSpSixRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            //}
        }

        /// <summary>
        /// 十6轴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadbtnFiveRotorT_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.RadbtnFiveRotorT.Checked)
            //{
                this.iShapeType = 0;
                this.iCopterType = (int)CopterType.Six;
                this.pictureBoxWithPseudoOpacity2.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity1.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity3.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity4.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity5.BackColor = Color.White;
                this.pictureBoxWithPseudoOpacity6.BackColor = Color.Transparent;
                this.RadbtnFourRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFiveRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnSevenRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFourRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFiveRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.white;
                this.RadbtnSevenRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.pictureBoxWithPseudoOpacity7.BackColor = Color.Transparent;
                this.RadbtnSpSixRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            //}
        }

        /// <summary>
        /// 十8轴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadbtnSevenRotorT_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.RadbtnSevenRotorT.Checked)
            //{
                this.iCopterType = (int)CopterType.Eight;
                this.iShapeType = 0;
                this.pictureBoxWithPseudoOpacity2.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity1.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity3.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity4.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity5.BackColor = Color.Transparent;
                this.pictureBoxWithPseudoOpacity6.BackColor = Color.White;
                this.RadbtnFourRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFiveRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnSevenRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFourRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnFiveRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
                this.RadbtnSevenRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.white;
                this.pictureBoxWithPseudoOpacity7.BackColor = Color.Transparent;
                this.RadbtnSpSixRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            //}
        }

        /// <summary>
        /// 十型六轴特殊
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadbtnSpSixRotorT_CheckedChanged(object sender, EventArgs e)
        {
            this.iShapeType = 6;
            this.iCopterType = (int)CopterType.Six;
            this.pictureBoxWithPseudoOpacity2.BackColor = Color.Transparent;
            this.pictureBoxWithPseudoOpacity1.BackColor = Color.Transparent;
            this.pictureBoxWithPseudoOpacity3.BackColor = Color.Transparent;
            this.pictureBoxWithPseudoOpacity4.BackColor = Color.Transparent;
            this.pictureBoxWithPseudoOpacity5.BackColor = Color.Transparent;
            this.pictureBoxWithPseudoOpacity6.BackColor = Color.Transparent;
            this.RadbtnFourRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.RadbtnFiveRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.RadbtnSevenRotor1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.RadbtnFourRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.RadbtnFiveRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.RadbtnSevenRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.pictureBoxWithPseudoOpacity7.BackColor = Color.White;
            this.RadbtnSpSixRotorT1.BackgroundImage = ByAeroBeHero.Properties.Resources.white;
        }
        #endregion

        #region 电机测试

        private void ControlRabtn(int motormax)
        {
            this.button1.Enabled = true;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.button5.Enabled = true;
            this.button6.Enabled = true;
            this.button7.Enabled = true;
            this.button8.Enabled = true;

            if (motormax == 1)
            {
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
            }
            else if (motormax == 2)
            {
                this.button7.Enabled = false;
                this.button8.Enabled = false;
            }
            else if (motormax == 3)
            {

            }
            else
            {
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;
                this.button6.Enabled = false;
                this.button7.Enabled = false;
                this.button8.Enabled = false;
            }
        }
        private void but_Click(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.button2.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.button3.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.button4.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.button5.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.button6.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.button7.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp;
            this.button8.BackgroundImage = ByAeroBeHero.Properties.Resources.backgroudp; 

            try
            {
                object motor = ((Button)sender).Tag;

                CustomMessageBox.Show("电机测试："+((Button)sender).Text, "测试电机");

                int imotor = Convert.ToInt32(motor);
                if (imotor == 1) { this.button1.BackgroundImage = ByAeroBeHero.Properties.Resources.white; }
                else if (imotor == 2) { this.button2.BackgroundImage = ByAeroBeHero.Properties.Resources.white; }
                else if (imotor == 3) { this.button3.BackgroundImage = ByAeroBeHero.Properties.Resources.white; }
                else if (imotor == 4) { this.button4.BackgroundImage = ByAeroBeHero.Properties.Resources.white; }
                else if (imotor == 5) { this.button5.BackgroundImage = ByAeroBeHero.Properties.Resources.white; }
                else if (imotor == 6) { this.button6.BackgroundImage = ByAeroBeHero.Properties.Resources.white; }
                else if (imotor == 7) { this.button7.BackgroundImage = ByAeroBeHero.Properties.Resources.white; }
                else if (imotor == 8) { this.button8.BackgroundImage = ByAeroBeHero.Properties.Resources.white; }

                if (MainV2.comPort.doMotorTest(imotor, MAVLink.MOTOR_TEST_THROTTLE_TYPE.MOTOR_TEST_THROTTLE_PERCENT,
                    (int)NUM_thr_percent.Value, (int)NUM_duration.Value))
                {

                }
                else
                {
                    CustomMessageBox.Show("测试电机失败!", "电机测试");
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("测试电机失败!", "电机测试");
            }
        }
        #endregion

        private int loop = 0;
        private void btnTestSAll_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int)(float)MainV2.comPort.MAV.param["COPTER_TYPE"] == 1) 
                {
                    loop = 4;
                }
                else if ((int)(float)MainV2.comPort.MAV.param["COPTER_TYPE"] == 2)
                {
                    loop = 6;
                }
                else 
                {
                    loop = 8;
                }
                for (int i = 1; i <= loop; i++)
                {
                    MainV2.comPort.doMotorTest(i, MAVLink.MOTOR_TEST_THROTTLE_TYPE.MOTOR_TEST_THROTTLE_PERCENT,
                        (int)NUM_thr_percent.Value, (int)NUM_duration.Value);
                    Thread.Sleep((int)((NUM_duration.Value) * 1000));
                }
            }
            catch
            {
            }
        }

    }
}            