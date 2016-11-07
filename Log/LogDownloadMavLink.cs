using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;
using KMLib;
using KMLib.Feature;
using KMLib.Geometry;
using Core.Geometry;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Core;
using log4net;
using ByAeroBeHero.Comms;
using ByAeroBeHero.Utilities;
using ByAeroBeHero.Controls;
using System.Threading;


namespace ByAeroBeHero.Log
{
    public partial class LogDownloadMavLink : MyUserControl
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        serialstatus status = serialstatus.连接中;
        int currentlog = 0;
        string logfile = "";
        int receivedbytes = 0;
        int receibedbytestotal = 0;

        //List<Model> orientation = new List<Model>();

        Object thisLock = new Object();
        DateTime start = DateTime.Now;

        enum serialstatus
        {
            连接中,
            创建文件,
            关闭文件,
            读取,
            等待,
            完成
        }

        public LogDownloadMavLink()
        {
            InitializeComponent();

            //ThemeManager.ApplyThemeTo(this);
            ByAeroBeHero.Utilities.Tracking.AddPage(this.GetType().ToString(), this.Text);
        }

        public void Log_Load(object sender, EventArgs e)
        {

        }

        public void ShowLog(bool ienable) 
        {
            CHK_logs.ForeColor = TXT_seriallog.ForeColor = Color.White;
            CHK_logs.BackColor = TXT_seriallog.BackColor = Color.Black;
            BUT_DLall.BackgroundImage = BUT_DLthese.BackgroundImage = BUT_clearlogs.BackgroundImage = ByAeroBeHero.Properties.Resources.white;

            if (ienable)
            {
                BUT_DLall.Enabled = true;
                BUT_DLthese.Enabled = true;
                BUT_clearlogs.Enabled = true;
            }
            else 
            {
                BUT_DLall.Enabled = false;
                BUT_DLthese.Enabled = false;
                BUT_clearlogs.Enabled = false;
            }

            if (!MainV2.comPort.BaseStream.IsOpen)
            {

                CHK_logs.Text = string.Empty;
                TXT_seriallog.Text = string.Empty;
                this.Close();

                return;
            }

            try
            {
                var list = MainV2.comPort.GetLogList();

                foreach (var item in list)
                {
                    genchkcombo(item.id);

                    //receibedbytestotal = (int)item.size;
                    TXT_seriallog.AppendText(item.id + "\t" + new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(item.time_utc).ToLocalTime() + "\t  大小:\t" + item.size + "\r\n");
                }

                if (list.Count == 0)
                {
                    TXT_seriallog.AppendText("没有日志下载！");
                }
            }
            catch { CustomMessageBox.Show(Strings.ErrorLogList, Strings.ERROR); this.Close(); }

            status = serialstatus.完成;
        }

        void genchkcombo(int logcount)
        {
            MethodInvoker m = delegate()
            {
                //CHK_logs.Items.Clear();
                //for (int a = 1; a <= logcount; a++)
                if (!CHK_logs.Items.Contains(logcount))
                {
                    CHK_logs.Items.Add(logcount);
                }
            };
            try
            {
                BeginInvoke(m);
            }
            catch
            {
            }
        }

        void updateDisplay()
        {
            if (this.IsDisposed)
                return;

            if (start.Second != DateTime.Now.Second)
            {
                this.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate()
                {
                    try
                    {

                        TXT_status.Text = status.ToString() + " " + receivedbytes + "----" + receibedbytestotal;
                        progressBar1.Value = (int)Math.Floor((double)(receivedbytes / receibedbytestotal) * 100);
                    }
                    catch { }
                });
                start = DateTime.Now;
            }
        }
      
        private void BUT_DLall_Click(object sender, EventArgs e)
        {
            if (status == serialstatus.完成)
            {
                if (CHK_logs.Items.Count == 0)
                {
                    CustomMessageBox.Show("没有日志下载");
                    return;
                }

                System.Threading.Thread t11 = new System.Threading.Thread(delegate() { downloadthread(int.Parse(CHK_logs.Items[0].ToString()), int.Parse(CHK_logs.Items[CHK_logs.Items.Count - 1].ToString())); });
                t11.Name = "Log Download All thread";
                t11.Start();
            }
        }

        string GetLog(ushort no)
        {
            receibedbytestotal = (int)MainV2.comPort.GetLogList()[no - 1].size;

            MainV2.comPort.Progress += comPort_Progress;

            status = serialstatus.读取;

            // get df log from mav
            var ms = MainV2.comPort.GetLog(no);

            status = serialstatus.完成;
            updateDisplay();

            MainV2.comPort.Progress -= comPort_Progress;

            // set log fn
            byte[] hbpacket = MainV2.comPort.getHeartBeat();

            MAVLink.mavlink_heartbeat_t hb = (MAVLink.mavlink_heartbeat_t)MainV2.comPort.DebugPacket(hbpacket);
            //QUADROTOR四轴         HEXAROTOR六轴        OCTOROTOR八轴
            string aptype;
            if (MainV2.comPort.MAV.aptype.ToString() == "QUADROTOR") 
            {
                aptype = "四轴";
            }
            else if (MainV2.comPort.MAV.aptype.ToString() == "HEXAROTOR")
            {
                aptype = "六轴";
            }
            else 
            {
                aptype = "八轴";
            }
                
            logfile = MainV2.LogDir + Path.DirectorySeparatorChar
             + aptype + Path.DirectorySeparatorChar
             + hbpacket[3] + Path.DirectorySeparatorChar + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + " " + no + ".bin";

            // make log dir
            Directory.CreateDirectory(Path.GetDirectoryName(logfile));

            // save memorystream to file
            using (BinaryWriter bw = new BinaryWriter(File.OpenWrite(logfile)))
            {
                bw.Write(ms.ToArray());
            }

            //// create ascii log
            //BinaryLog.ConvertBin(logfile, logfile + ".log");

            ////update the new filename
            //logfile = logfile + ".log";

            //// get gps time of assci log
            //DateTime logtime = DFLog.GetFirstGpsTime(logfile);

            //// rename log is we have a valid gps time
            //if (logtime != DateTime.MinValue)
            //{
            //    string newlogfilename = MainV2.LogDir + Path.DirectorySeparatorChar
            // + MainV2.comPort.MAV.aptype.ToString() + Path.DirectorySeparatorChar
            // + hbpacket[3] + Path.DirectorySeparatorChar + logtime.ToString("yyyy-MM-dd HH-mm-ss") + ".log";
            //    try
            //    {
            //        File.Move(logfile, newlogfilename);
            //        // rename bin as well
            //        File.Move(logfile.Replace(".log", ""), newlogfilename.Replace(".log", ".bin"));
            //        logfile = newlogfilename;
            //    }
            //    catch  { CustomMessageBox.Show(Strings.ErrorRenameFile+ " " + logfile + "\nto " + newlogfilename, Strings.ERROR); }
            //}

            return logfile;
        }

        void comPort_Progress(int progress, string status)
        {
            receivedbytes = progress;
            updateDisplay();
        }

        void CreateLog(string logfile)
        {
            TextReader tr = new StreamReader(logfile);
            //

            this.Invoke((System.Windows.Forms.MethodInvoker)delegate()
            {
                TXT_seriallog.AppendText("日志文件保存位置：" + logfile + "\n");
            });

            LogOutput lo = new LogOutput();

            while (tr.Peek() != -1)
            {
                lo.processLine(tr.ReadLine());
            }

            tr.Close();

            //try
            //{
            //    lo.writeKML(logfile + ".kml");
            //}
            //catch { } // usualy invalid lat long error
            status = serialstatus.完成;
            updateDisplay();
        }

        private void downloadthread(int startlognum, int endlognum)
        {
            try
            {
                for (int a = startlognum; a <= endlognum; a++)
                {
                    currentlog = a;

                    var logname = GetLog((ushort)a);

                    CreateLog(logname);

                    if (chk_droneshare.Checked)
                    {
                        try
                        {
                            Utilities.DroneApi.droneshare.doUpload(logname);
                        }
                        catch (Exception ex) { CustomMessageBox.Show("Droneshare upload failed " + ex.ToString()); }
                    }
                }

                status = serialstatus.完成;
                updateDisplay();

                Console.Beep();
            }
            catch (Exception ex) { CustomMessageBox.Show(ex.Message, "Error in log " + currentlog); }
        }

        private void downloadsinglethread()
        {
            try
            {
                for (int i = 0; i < CHK_logs.CheckedItems.Count; ++i)
                {
                    int a = (int)CHK_logs.CheckedItems[i];

                    currentlog = a;

                    var logname = GetLog((ushort)a);

                    CreateLog(logname);

                    if (chk_droneshare.Checked)
                    {
                        try
                        {
                            Utilities.DroneApi.droneshare.doUpload(logname);
                        }
                        catch (Exception ex) { CustomMessageBox.Show("Droneshare upload failed " + ex.ToString()); }
                    }
                }

                status = serialstatus.完成;
                updateDisplay();

                Console.Beep();
            }
            catch (Exception ex) { CustomMessageBox.Show(ex.Message, "Error in log " + currentlog); }
        }

        private void BUT_DLthese_Click(object sender, EventArgs e)
        {
            if (status == serialstatus.完成)
            {
                System.Threading.Thread t11 = new System.Threading.Thread(delegate() { downloadsinglethread(); });
                t11.Name = "Log download single thread";
                t11.Start();
            }
        }

        private void BUT_clearlogs_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Show("确定是否清除日志文件?", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    MainV2.comPort.EraseLog();
                    TXT_seriallog.AppendText("!!允许30-90秒删除！\n");
                    status = serialstatus.完成;
                    updateDisplay();
                    CHK_logs.Items.Clear();
                }
                catch (Exception ex) { CustomMessageBox.Show(ex.Message, Strings.ERROR); }
            }
        }

        private void BUT_redokml_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "*.log|*.log";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Multiselect = true;
                try
                {
                    openFileDialog1.InitialDirectory = MainV2.LogDir + Path.DirectorySeparatorChar;
                }
                catch { } // incase dir doesnt exist

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (string logfile in openFileDialog1.FileNames)
                    {
                        TXT_seriallog.AppendText("\n\n处理..." + logfile + "\n");
                        this.Refresh();
                        LogOutput lo = new LogOutput();
                        try
                        {
                            TextReader tr = new StreamReader(logfile);

                            while (tr.Peek() != -1)
                            {
                                lo.processLine(tr.ReadLine());
                            }

                            tr.Close();
                        }
                        catch (Exception ex) { CustomMessageBox.Show("处理文件错误. 确保文件没有在使用中.\n" + ex.ToString()); }

                        //lo.writeKML(logfile + ".kml");

                        TXT_seriallog.AppendText("完成\n");
                    }
                }
            }
        }


        private void BUT_firstperson_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "*.log|*.log";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Multiselect = true;
                try
                {
                    openFileDialog1.InitialDirectory = MainV2.LogDir + Path.DirectorySeparatorChar;
                }
                catch { } // incase dir doesnt exist

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (string logfile in openFileDialog1.FileNames)
                    {
                        TXT_seriallog.AppendText("\n\n处理... " + logfile + "\n");
                        this.Refresh();

                        LogOutput lo = new LogOutput();

                        try
                        {
                            TextReader tr = new StreamReader(logfile);

                            while (tr.Peek() != -1)
                            {
                                lo.processLine(tr.ReadLine());
                            }

                            tr.Close();
                        }
                        catch (Exception ex) { CustomMessageBox.Show("处理日志错误. 是否要继续下载? "); continue; }

                        lo.writeKMLFirstPerson(logfile + "-fp.kml");

                        TXT_seriallog.AppendText("完成\n");
                    }
                }
            }
        }

        private void BUT_bintolog_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Binary Log|*.bin";

                ofd.ShowDialog();

                if (File.Exists(ofd.FileName))
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.Filter = "log|*.log";

                        DialogResult res = sfd.ShowDialog();

                        if (res == System.Windows.Forms.DialogResult.OK)
                        {
                            BinaryLog.ConvertBin(ofd.FileName, sfd.FileName);
                        }
                    }
                }
            }
        }

        private void chk_droneshare_CheckedChanged(object sender, EventArgs e)
        {

        } 
    }
}