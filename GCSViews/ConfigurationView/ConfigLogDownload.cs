using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.HIL;
using System.Threading;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigLogDownload  : UserControl, IActivate
    {
        public ConfigLogDownload()
        {
            InitializeComponent();
        }

        public void Activate()
        {
           
        }

        DateTime dt;    //记时  
        private void BtnChenckbalance_Click(object sender, EventArgs e)
        {
            if (!MainV2.comPort.BaseStream.IsOpen)
            {
                CustomMessageBox.Show("请连接地面站!", "提示");
                return;
            }

            Thread myThread = new Thread(DoData);
            myThread.IsBackground = true;
            myThread.Start(60); //线程开始  
            dt = DateTime.Now;  //开始记录当前时间 
        }

        private delegate void DoDataDelegate(object number);  
        /// <summary>  
        /// 进行循环  
        /// </summary>  
        /// <param name="number"></param>  
       private void DoData(object number)  
       {  
           
        }  
    }
}