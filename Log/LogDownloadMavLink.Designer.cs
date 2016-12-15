namespace ByAeroBeHero.Log
{
    partial class LogDownloadMavLink
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogDownloadMavLink));
            this.TXT_seriallog = new System.Windows.Forms.TextBox();
            this.BUT_DLall = new ByAeroBeHero.Controls.MyButton();
            this.BUT_DLthese = new ByAeroBeHero.Controls.MyButton();
            this.BUT_clearlogs = new ByAeroBeHero.Controls.MyButton();
            this.CHK_logs = new System.Windows.Forms.CheckedListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNInfo = new System.Windows.Forms.Label();
            this.BtnLoadLog = new ByAeroBeHero.Controls.MyButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_seriallog
            // 
            resources.ApplyResources(this.TXT_seriallog, "TXT_seriallog");
            this.TXT_seriallog.BackColor = System.Drawing.Color.Black;
            this.TXT_seriallog.ForeColor = System.Drawing.Color.White;
            this.TXT_seriallog.Name = "TXT_seriallog";
            this.TXT_seriallog.ReadOnly = true;
            // 
            // BUT_DLall
            // 
            resources.ApplyResources(this.BUT_DLall, "BUT_DLall");
            this.BUT_DLall.BackColor = System.Drawing.SystemColors.Control;
            this.BUT_DLall.BGGradBot = System.Drawing.Color.Transparent;
            this.BUT_DLall.BGGradTop = System.Drawing.Color.Transparent;
            this.BUT_DLall.Name = "BUT_DLall";
            this.BUT_DLall.UseVisualStyleBackColor = false;
            this.BUT_DLall.Click += new System.EventHandler(this.BUT_DLall_Click);
            // 
            // BUT_DLthese
            // 
            resources.ApplyResources(this.BUT_DLthese, "BUT_DLthese");
            this.BUT_DLthese.BackColor = System.Drawing.SystemColors.Control;
            this.BUT_DLthese.BGGradBot = System.Drawing.Color.Transparent;
            this.BUT_DLthese.BGGradTop = System.Drawing.Color.Transparent;
            this.BUT_DLthese.Name = "BUT_DLthese";
            this.BUT_DLthese.UseVisualStyleBackColor = false;
            this.BUT_DLthese.Click += new System.EventHandler(this.BUT_DLthese_Click);
            // 
            // BUT_clearlogs
            // 
            this.BUT_clearlogs.BackColor = System.Drawing.SystemColors.Control;
            this.BUT_clearlogs.BGGradBot = System.Drawing.Color.Transparent;
            this.BUT_clearlogs.BGGradTop = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BUT_clearlogs, "BUT_clearlogs");
            this.BUT_clearlogs.Name = "BUT_clearlogs";
            this.BUT_clearlogs.UseVisualStyleBackColor = false;
            this.BUT_clearlogs.Click += new System.EventHandler(this.BUT_clearlogs_Click);
            // 
            // CHK_logs
            // 
            resources.ApplyResources(this.CHK_logs, "CHK_logs");
            this.CHK_logs.BackColor = System.Drawing.Color.Black;
            this.CHK_logs.CheckOnClick = true;
            this.CHK_logs.ForeColor = System.Drawing.Color.White;
            this.CHK_logs.FormattingEnabled = true;
            this.CHK_logs.Name = "CHK_logs";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblNInfo);
            this.panel1.Controls.Add(this.BtnLoadLog);
            this.panel1.Controls.Add(this.BUT_DLall);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BUT_DLthese);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.CHK_logs);
            this.panel1.Controls.Add(this.TXT_seriallog);
            this.panel1.Controls.Add(this.BUT_clearlogs);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lblNInfo
            // 
            resources.ApplyResources(this.lblNInfo, "lblNInfo");
            this.lblNInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblNInfo.Name = "lblNInfo";
            // 
            // BtnLoadLog
            // 
            this.BtnLoadLog.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLoadLog.BGGradBot = System.Drawing.Color.Transparent;
            this.BtnLoadLog.BGGradTop = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.BtnLoadLog, "BtnLoadLog");
            this.BtnLoadLog.Name = "BtnLoadLog";
            this.BtnLoadLog.UseVisualStyleBackColor = false;
            this.BtnLoadLog.Click += new System.EventHandler(this.BtnLoadLog_Click);
            // 
            // LogDownloadMavLink
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "LogDownloadMavLink";
            this.Load += new System.EventHandler(this.Log_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyButton BUT_DLall;
        private Controls.MyButton BUT_DLthese;
        private Controls.MyButton BUT_clearlogs;
        private System.Windows.Forms.CheckedListBox CHK_logs;
        private System.Windows.Forms.TextBox TXT_seriallog;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Controls.MyButton BtnLoadLog;
        private System.Windows.Forms.Label lblNInfo;
    }
}