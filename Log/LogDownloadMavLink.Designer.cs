﻿namespace ByAeroBeHero.Log
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
            this.TXT_status = new System.Windows.Forms.TextBox();
            this.BUT_redokml = new ByAeroBeHero.Controls.MyButton();
            this.BUT_firstperson = new ByAeroBeHero.Controls.MyButton();
            this.BUT_bintolog = new ByAeroBeHero.Controls.MyButton();
            this.chk_droneshare = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TXT_seriallog
            // 
            resources.ApplyResources(this.TXT_seriallog, "TXT_seriallog");
            this.TXT_seriallog.Name = "TXT_seriallog";
            this.TXT_seriallog.ReadOnly = true;
            // 
            // BUT_DLall
            // 
            resources.ApplyResources(this.BUT_DLall, "BUT_DLall");
            this.BUT_DLall.Name = "BUT_DLall";
            this.BUT_DLall.UseVisualStyleBackColor = true;
            this.BUT_DLall.Click += new System.EventHandler(this.BUT_DLall_Click);
            // 
            // BUT_DLthese
            // 
            resources.ApplyResources(this.BUT_DLthese, "BUT_DLthese");
            this.BUT_DLthese.Name = "BUT_DLthese";
            this.BUT_DLthese.UseVisualStyleBackColor = true;
            this.BUT_DLthese.Click += new System.EventHandler(this.BUT_DLthese_Click);
            // 
            // BUT_clearlogs
            // 
            resources.ApplyResources(this.BUT_clearlogs, "BUT_clearlogs");
            this.BUT_clearlogs.Name = "BUT_clearlogs";
            this.BUT_clearlogs.UseVisualStyleBackColor = true;
            this.BUT_clearlogs.Click += new System.EventHandler(this.BUT_clearlogs_Click);
            // 
            // CHK_logs
            // 
            this.CHK_logs.CheckOnClick = true;
            this.CHK_logs.FormattingEnabled = true;
            resources.ApplyResources(this.CHK_logs, "CHK_logs");
            this.CHK_logs.Name = "CHK_logs";
            // 
            // TXT_status
            // 
            resources.ApplyResources(this.TXT_status, "TXT_status");
            this.TXT_status.ForeColor = System.Drawing.Color.Red;
            this.TXT_status.Name = "TXT_status";
            this.TXT_status.ReadOnly = true;
            // 
            // BUT_redokml
            // 
            resources.ApplyResources(this.BUT_redokml, "BUT_redokml");
            this.BUT_redokml.Name = "BUT_redokml";
            this.BUT_redokml.UseVisualStyleBackColor = true;
            this.BUT_redokml.Click += new System.EventHandler(this.BUT_redokml_Click);
            // 
            // BUT_firstperson
            // 
            resources.ApplyResources(this.BUT_firstperson, "BUT_firstperson");
            this.BUT_firstperson.Name = "BUT_firstperson";
            this.BUT_firstperson.UseVisualStyleBackColor = true;
            this.BUT_firstperson.Click += new System.EventHandler(this.BUT_firstperson_Click);
            // 
            // BUT_bintolog
            // 
            resources.ApplyResources(this.BUT_bintolog, "BUT_bintolog");
            this.BUT_bintolog.Name = "BUT_bintolog";
            this.BUT_bintolog.UseVisualStyleBackColor = true;
            this.BUT_bintolog.Click += new System.EventHandler(this.BUT_bintolog_Click);
            // 
            // chk_droneshare
            // 
            resources.ApplyResources(this.chk_droneshare, "chk_droneshare");
            this.chk_droneshare.Name = "chk_droneshare";
            this.chk_droneshare.UseVisualStyleBackColor = true;
            this.chk_droneshare.CheckedChanged += new System.EventHandler(this.chk_droneshare_CheckedChanged);
            // 
            // LogDownloadMavLink
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_droneshare);
            this.Controls.Add(this.BUT_bintolog);
            this.Controls.Add(this.BUT_firstperson);
            this.Controls.Add(this.BUT_redokml);
            this.Controls.Add(this.TXT_status);
            this.Controls.Add(this.CHK_logs);
            this.Controls.Add(this.BUT_clearlogs);
            this.Controls.Add(this.BUT_DLthese);
            this.Controls.Add(this.BUT_DLall);
            this.Controls.Add(this.TXT_seriallog);
            this.Name = "LogDownloadMavLink";
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyButton BUT_DLall;
        private Controls.MyButton BUT_DLthese;
        private Controls.MyButton BUT_clearlogs;
        private System.Windows.Forms.CheckedListBox CHK_logs;
        private System.Windows.Forms.TextBox TXT_status;
        private Controls.MyButton BUT_redokml;
        private System.Windows.Forms.TextBox TXT_seriallog;
        private Controls.MyButton BUT_firstperson;
        private Controls.MyButton BUT_bintolog;
        private System.Windows.Forms.CheckBox chk_droneshare;
    }
}