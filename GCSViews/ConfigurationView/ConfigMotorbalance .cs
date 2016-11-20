using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.HIL;
using System.Threading;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigMotorbalance  : UserControl, IActivate
    {
        public ConfigMotorbalance()
        {
            InitializeComponent();
        }

        public void Activate()
        {
           
        }

        DateTime dt;    //记时  
        private void BtnChenckbalance_Click(object sender, EventArgs e)
        {
            initControl();
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                CustomMessageBox.Show("请连接地面站!", "提示");
                return;
            }

            if (MainV2.comPort.MAV.cs.mode != "定高" && MainV2.comPort.MAV.cs.mode != "定点") 
            {
                CustomMessageBox.Show("请选则定高或定点模式!", "提示");
                return;
            }

            if (MainV2.comPort.MAV.cs.roll > 15) 
            {
                CustomMessageBox.Show("滚转角度大于15°!", "提示");
                return;
            }

            if (MainV2.comPort.MAV.cs.pitch > 15)
            {
                CustomMessageBox.Show("俯仰角度大于15°!", "提示");
                return;
            }
            
            progressBar.Value = 0;

            this.BtnChenckbalance.Text = "检测中...";
            Thread myThread = new Thread(DoData);
            myThread.IsBackground = true;
            myThread.Start(60); //线程开始  
            dt = DateTime.Now;  //开始记录当前时间 
        }

        private void initControl()
        {
            this.lblPositive.Text = "";
            this.lblNegative.Text = "";
            this.lblDiff.Text = "";
            this.lblCheckReson1.Text = "";
        }

        private delegate void DoDataDelegate(object number);  
        /// <summary>  
        /// 进行循环  
        /// </summary>  
        /// <param name="number"></param>  
       private void DoData(object number)  
       {  
           if (progressBar.InvokeRequired)  
           {  
               DoDataDelegate d = DoData;  
               progressBar.Invoke(d, number);  
            }  
           else  
           {

               float ch1out = 0;
               float ch2out = 0;
               float ch3out = 0;
               float ch4out = 0;
               float ch5out = 0;
               float ch6out = 0;
               float ch7out = 0;
               float ch8out = 0;

               int a = 0;
               for (int i = 1; i <= 60; i++)
               {
                   ch1out += MainV2.comPort.MAV.cs.ch1out;
                   ch2out += MainV2.comPort.MAV.cs.ch2out;
                   ch3out += MainV2.comPort.MAV.cs.ch3out;
                   ch4out += MainV2.comPort.MAV.cs.ch4out;
                   ch5out += MainV2.comPort.MAV.cs.ch5out;
                   ch6out += MainV2.comPort.MAV.cs.ch6out;
                   ch7out += MainV2.comPort.MAV.cs.ch7out;
                   ch8out += MainV2.comPort.MAV.cs.ch8out;
                   a+= 2;
                   if(a>=100)
                       progressBar.Value =100;
                   else
                       progressBar.Value = a;
                   lblprogress1.Text = ((double)a / 120 * 100).ToString("f2")+"%";
                   Application.DoEvents();  
                   Thread.Sleep(500);
               }

               int iCopterType = (int)(float)MainV2.comPort.MAV.param["COPTER_TYPE"];

               float Positivedirection = 0;
               float Negativedirection = 0;
               int iFType = 0;

               if (iCopterType == 1)
               {
                   Negativedirection = ch1out + ch3out;
                   Positivedirection = ch2out + ch4out;
                   iFType = 4;
               }
               else if (iCopterType == 2)
               {
                    Negativedirection= ch1out + ch3out + ch5out;
                    Positivedirection = ch2out + ch4out + ch6out;
                   iFType = 6;
               }
               else
               {
                   Negativedirection = ch1out + ch3out + ch5out + ch7out;
                   Positivedirection = ch2out + ch4out + ch6out + ch8out;
                   iFType = 8;
               };

               float fNegativedirection = (Negativedirection / (iFType / 2)) / 60;
               float fPositivedirection= (Positivedirection / (iFType / 2))/60;

               float iDifference = fNegativedirection - fPositivedirection;

               this.lblPositive.Text = fPositivedirection.ToString("f2");
               this.lblNegative.Text = fNegativedirection.ToString("f2");
               this.lblDiff.Text = (-iDifference).ToString("f2");

               string strs = "";
               if (iDifference > 50)
               {
                   strs += "飞机航向存在偏差，需要将电机逆时针旋转（从飞机侧面正对电机），提供顺时针的补偿力矩";
               }
               else if (iDifference < -50)
               {
                   strs += "飞机航向存在偏差，需要将电机顺时针旋转（从飞机侧面正对电机），提供逆时针的补偿力矩";
               }
               else
               {
                   strs += "飞机航向正常，不需要补偿";
               }

               this.lblCheckReson.Text = strs;
               this.BtnChenckbalance.Text = "检测完成";
            }  
        }  
    }
}