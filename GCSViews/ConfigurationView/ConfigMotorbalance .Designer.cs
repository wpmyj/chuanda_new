namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    partial class ConfigMotorbalance 
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigMotorbalance));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblCheckReson = new System.Windows.Forms.Label();
            this.lblprogress = new System.Windows.Forms.Label();
            this.lblprogress1 = new System.Windows.Forms.Label();
            this.lblPositive1 = new System.Windows.Forms.Label();
            this.lblPositive = new System.Windows.Forms.Label();
            this.lblNegative1 = new System.Windows.Forms.Label();
            this.lblNegative = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblDiff1 = new System.Windows.Forms.Label();
            this.lblCheckReson1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnChenckbalance = new ByAeroBeHero.Controls.MyButton();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // lblCheckReson
            // 
            resources.ApplyResources(this.lblCheckReson, "lblCheckReson");
            this.lblCheckReson.ForeColor = System.Drawing.Color.White;
            this.lblCheckReson.Name = "lblCheckReson";
            // 
            // lblprogress
            // 
            resources.ApplyResources(this.lblprogress, "lblprogress");
            this.lblprogress.ForeColor = System.Drawing.Color.White;
            this.lblprogress.Name = "lblprogress";
            // 
            // lblprogress1
            // 
            resources.ApplyResources(this.lblprogress1, "lblprogress1");
            this.lblprogress1.ForeColor = System.Drawing.Color.White;
            this.lblprogress1.Name = "lblprogress1";
            // 
            // lblPositive1
            // 
            resources.ApplyResources(this.lblPositive1, "lblPositive1");
            this.lblPositive1.ForeColor = System.Drawing.Color.White;
            this.lblPositive1.Name = "lblPositive1";
            this.toolTip1.SetToolTip(this.lblPositive1, resources.GetString("lblPositive1.ToolTip"));
            // 
            // lblPositive
            // 
            resources.ApplyResources(this.lblPositive, "lblPositive");
            this.lblPositive.ForeColor = System.Drawing.Color.White;
            this.lblPositive.Name = "lblPositive";
            // 
            // lblNegative1
            // 
            resources.ApplyResources(this.lblNegative1, "lblNegative1");
            this.lblNegative1.ForeColor = System.Drawing.Color.White;
            this.lblNegative1.Name = "lblNegative1";
            this.toolTip1.SetToolTip(this.lblNegative1, resources.GetString("lblNegative1.ToolTip"));
            // 
            // lblNegative
            // 
            resources.ApplyResources(this.lblNegative, "lblNegative");
            this.lblNegative.ForeColor = System.Drawing.Color.White;
            this.lblNegative.Name = "lblNegative";
            // 
            // lblDiff
            // 
            resources.ApplyResources(this.lblDiff, "lblDiff");
            this.lblDiff.ForeColor = System.Drawing.Color.White;
            this.lblDiff.Name = "lblDiff";
            // 
            // lblDiff1
            // 
            resources.ApplyResources(this.lblDiff1, "lblDiff1");
            this.lblDiff1.ForeColor = System.Drawing.Color.White;
            this.lblDiff1.Name = "lblDiff1";
            this.toolTip1.SetToolTip(this.lblDiff1, resources.GetString("lblDiff1.ToolTip"));
            // 
            // lblCheckReson1
            // 
            resources.ApplyResources(this.lblCheckReson1, "lblCheckReson1");
            this.lblCheckReson1.ForeColor = System.Drawing.Color.White;
            this.lblCheckReson1.Name = "lblCheckReson1";
            // 
            // BtnChenckbalance
            // 
            resources.ApplyResources(this.BtnChenckbalance, "BtnChenckbalance");
            this.BtnChenckbalance.Name = "BtnChenckbalance";
            this.BtnChenckbalance.UseVisualStyleBackColor = true;
            this.BtnChenckbalance.Click += new System.EventHandler(this.BtnChenckbalance_Click);
            // 
            // ConfigMotorbalance
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCheckReson1);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.lblDiff1);
            this.Controls.Add(this.lblNegative);
            this.Controls.Add(this.lblNegative1);
            this.Controls.Add(this.lblPositive);
            this.Controls.Add(this.lblPositive1);
            this.Controls.Add(this.lblprogress1);
            this.Controls.Add(this.lblprogress);
            this.Controls.Add(this.lblCheckReson);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.BtnChenckbalance);
            this.Name = "ConfigMotorbalance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyButton BtnChenckbalance;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblCheckReson;
        private System.Windows.Forms.Label lblprogress;
        private System.Windows.Forms.Label lblprogress1;
        private System.Windows.Forms.Label lblPositive1;
        private System.Windows.Forms.Label lblPositive;
        private System.Windows.Forms.Label lblNegative1;
        private System.Windows.Forms.Label lblNegative;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblDiff1;
        private System.Windows.Forms.Label lblCheckReson1;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
