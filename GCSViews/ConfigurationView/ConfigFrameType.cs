using System;
using System.Reflection;
using System.Windows.Forms;
using log4net;
using ByAeroBeHero.Controls;
using Transitions;

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
            Four = 4,
            Six = 6,
            Eight = 8
        }

        private const float DisabledOpacity = 0.2F;
        private const float EnabledOpacity = 1.0F;
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private bool indochange;
        private int iCopterType;

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

        #region 加载参数
        private void btnSelectRackType_Click(object sender, EventArgs e)
        {
            if(MainV2.comPort.SendCopterType(iCopterType))
                CustomMessageBox.Show(string.Format(Strings.CopterTypeSetSuccessed, "CopterType"), Strings.CopterTypeSelected,
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                CustomMessageBox.Show(string.Format(Strings.CopterTypeSetFailed, "CopterType"), Strings.CopterTypeSelected,
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RadbtnFourRotor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadbtnFourRotor.Checked)
                this.iCopterType = (int)CopterType.Four;
        }

        private void RadbtnFiveRotor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadbtnFiveRotor.Checked)
                this.iCopterType = (int)CopterType.Six;
        }

        private void RadbtnSevenRotor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RadbtnSevenRotor.Checked)
                this.iCopterType = (int)CopterType.Eight;
        }
        #endregion
    }
}