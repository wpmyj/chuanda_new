﻿namespace ByAeroBeHero.GCSViews
{
    partial class SoftwareConfig
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoftwareConfig));
            this.backstageView = new ByAeroBeHero.Controls.BackstageView.BackstageView();
            this.SuspendLayout();
            // 
            // backstageView
            // 
            this.backstageView.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.backstageView, "backstageView");
            this.backstageView.HighlightColor1 = System.Drawing.SystemColors.Highlight;
            this.backstageView.HighlightColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.backstageView.Name = "backstageView";
            this.backstageView.WidthMenu = 1000;
            // 
            // SoftwareConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.backstageView);
            resources.ApplyResources(this, "$this");
            this.MinimumSize = new System.Drawing.Size(1000, 450);
            this.Name = "SoftwareConfig";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SoftwareConfig_FormClosing);
            this.Load += new System.EventHandler(this.SoftwareConfig_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BackstageView.BackstageView backstageView;
    }
}
