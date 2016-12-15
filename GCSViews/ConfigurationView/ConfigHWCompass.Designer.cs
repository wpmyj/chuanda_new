namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    partial class ConfigHWCompass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigHWCompass));
            this.lblIMU2z = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblIMU2y = new System.Windows.Forms.Label();
            this.lblIMU2x = new System.Windows.Forms.Label();
            this.lblIMUz = new System.Windows.Forms.Label();
            this.lblIMUy = new System.Windows.Forms.Label();
            this.lblIMUx = new System.Windows.Forms.Label();
            this.lblIMU2State = new System.Windows.Forms.Label();
            this.lblIMUState = new System.Windows.Forms.Label();
            this.BUT_MagCalibrationLive = new ByAeroBeHero.Controls.MyButton();
            this.btnCanelPress = new ByAeroBeHero.Controls.MyButton();
            this.lblPressCount = new System.Windows.Forms.Label();
            this.lblConpassPress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblx = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblReason = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblCheckCompass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIMU2z
            // 
            resources.ApplyResources(this.lblIMU2z, "lblIMU2z");
            this.lblIMU2z.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "mz2", true));
            this.lblIMU2z.ForeColor = System.Drawing.Color.White;
            this.lblIMU2z.Name = "lblIMU2z";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(ByAeroBeHero.CurrentState);
            // 
            // lblIMU2y
            // 
            resources.ApplyResources(this.lblIMU2y, "lblIMU2y");
            this.lblIMU2y.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "my2", true));
            this.lblIMU2y.ForeColor = System.Drawing.Color.White;
            this.lblIMU2y.Name = "lblIMU2y";
            // 
            // lblIMU2x
            // 
            resources.ApplyResources(this.lblIMU2x, "lblIMU2x");
            this.lblIMU2x.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "mx2", true));
            this.lblIMU2x.ForeColor = System.Drawing.Color.White;
            this.lblIMU2x.Name = "lblIMU2x";
            // 
            // lblIMUz
            // 
            resources.ApplyResources(this.lblIMUz, "lblIMUz");
            this.lblIMUz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "mz", true));
            this.lblIMUz.ForeColor = System.Drawing.Color.White;
            this.lblIMUz.Name = "lblIMUz";
            // 
            // lblIMUy
            // 
            resources.ApplyResources(this.lblIMUy, "lblIMUy");
            this.lblIMUy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "my", true));
            this.lblIMUy.ForeColor = System.Drawing.Color.White;
            this.lblIMUy.Name = "lblIMUy";
            // 
            // lblIMUx
            // 
            resources.ApplyResources(this.lblIMUx, "lblIMUx");
            this.lblIMUx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "mx", true));
            this.lblIMUx.ForeColor = System.Drawing.Color.White;
            this.lblIMUx.Name = "lblIMUx";
            // 
            // lblIMU2State
            // 
            resources.ApplyResources(this.lblIMU2State, "lblIMU2State");
            this.lblIMU2State.ForeColor = System.Drawing.Color.White;
            this.lblIMU2State.Name = "lblIMU2State";
            // 
            // lblIMUState
            // 
            resources.ApplyResources(this.lblIMUState, "lblIMUState");
            this.lblIMUState.ForeColor = System.Drawing.Color.White;
            this.lblIMUState.Name = "lblIMUState";
            // 
            // BUT_MagCalibrationLive
            // 
            this.BUT_MagCalibrationLive.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.BUT_MagCalibrationLive, "BUT_MagCalibrationLive");
            this.BUT_MagCalibrationLive.BGGradBot = System.Drawing.Color.Transparent;
            this.BUT_MagCalibrationLive.BGGradTop = System.Drawing.Color.Transparent;
            this.BUT_MagCalibrationLive.ForeColor = System.Drawing.Color.White;
            this.BUT_MagCalibrationLive.Name = "BUT_MagCalibrationLive";
            this.BUT_MagCalibrationLive.UseVisualStyleBackColor = false;
            this.BUT_MagCalibrationLive.Click += new System.EventHandler(this.BUT_MagCalibration_Click);
            // 
            // btnCanelPress
            // 
            this.btnCanelPress.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.btnCanelPress, "btnCanelPress");
            this.btnCanelPress.BGGradBot = System.Drawing.Color.Transparent;
            this.btnCanelPress.BGGradTop = System.Drawing.Color.Transparent;
            this.btnCanelPress.ForeColor = System.Drawing.Color.White;
            this.btnCanelPress.Name = "btnCanelPress";
            this.btnCanelPress.UseVisualStyleBackColor = false;
            this.btnCanelPress.Click += new System.EventHandler(this.btnCanelPress_Click);
            // 
            // lblPressCount
            // 
            resources.ApplyResources(this.lblPressCount, "lblPressCount");
            this.lblPressCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPressCount.Name = "lblPressCount";
            // 
            // lblConpassPress
            // 
            resources.ApplyResources(this.lblConpassPress, "lblConpassPress");
            this.lblConpassPress.BackColor = System.Drawing.Color.Transparent;
            this.lblConpassPress.Name = "lblConpassPress";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lblIMUState);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.lblIMU2z);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Name = "panel4";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.lblIMU2y);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Name = "panel7";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.lblIMUy);
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Name = "panel8";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.lblIMUz);
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Name = "panel6";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.lblIMU2x);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Name = "panel5";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Controls.Add(this.lblIMUx);
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Name = "panel9";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lblIMU2State);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Name = "panel2";
            // 
            // lblx
            // 
            resources.ApplyResources(this.lblx, "lblx");
            this.lblx.BackColor = System.Drawing.Color.Transparent;
            this.lblx.Name = "lblx";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LightGray;
            this.panel10.Controls.Add(this.lblReason);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.btnCanelPress);
            this.panel10.Controls.Add(this.panel6);
            this.panel10.Controls.Add(this.lblPressCount);
            this.panel10.Controls.Add(this.BUT_MagCalibrationLive);
            this.panel10.Controls.Add(this.lblConpassPress);
            this.panel10.Controls.Add(this.lblx);
            this.panel10.Controls.Add(this.progressBar1);
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.panel9);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.panel8);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.panel7);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.panel3);
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // lblReason
            // 
            resources.ApplyResources(this.lblReason, "lblReason");
            this.lblReason.BackColor = System.Drawing.Color.Transparent;
            this.lblReason.Name = "lblReason";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.lblCheckCompass);
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // lblCheckCompass
            // 
            resources.ApplyResources(this.lblCheckCompass, "lblCheckCompass");
            this.lblCheckCompass.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckCompass.Name = "lblCheckCompass";
            // 
            // ConfigHWCompass
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel10);
            this.Name = "ConfigHWCompass";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyButton BUT_MagCalibrationLive;
        private System.Windows.Forms.Label lblIMU2z;
        private System.Windows.Forms.Label lblIMU2y;
        private System.Windows.Forms.Label lblIMU2x;
        private System.Windows.Forms.Label lblIMUz;
        private System.Windows.Forms.Label lblIMUy;
        private System.Windows.Forms.Label lblIMUx;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblIMU2State;
        private System.Windows.Forms.Label lblIMUState;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConpassPress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPressCount;
        private Controls.MyButton btnCanelPress;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblCheckCompass;
        private System.Windows.Forms.Label lblReason;
    }
}
