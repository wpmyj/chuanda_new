using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace MissionPlanner.Controls
{
    public class ProgressReporterSphere : ProgressReporterDialogue
    {
        private System.Windows.Forms.CheckBox CHK_rotate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_auto;

        public bool autoaccept = true;

        public ProgressReporterSphere()
        {
            InitializeComponent();
            try
            {
                if (ConfigurationManager.AppSettings["sphereautocomplete"] != null)
                {

                    string value = ConfigurationManager.AppSettings["sphereautocomplete"].ToString();
                    autoaccept = bool.Parse(value);

                }
            }
            catch { }

            chk_auto.Checked = autoaccept;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressReporterSphere));
            this.CHK_rotate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_auto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btnCancel, "btnCancel");
            // 
            // CHK_rotate
            // 
            resources.ApplyResources(this.CHK_rotate, "CHK_rotate");
            this.CHK_rotate.Checked = true;
            this.CHK_rotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_rotate.Name = "CHK_rotate";
            this.CHK_rotate.UseVisualStyleBackColor = true;
            this.CHK_rotate.CheckedChanged += new System.EventHandler(this.CHK_rotate_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // chk_auto
            // 
            resources.ApplyResources(this.chk_auto, "chk_auto");
            this.chk_auto.Checked = true;
            this.chk_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_auto.Name = "chk_auto";
            this.chk_auto.UseVisualStyleBackColor = true;
            this.chk_auto.CheckedChanged += new System.EventHandler(this.chk_auto_CheckedChanged);
            // 
            // ProgressReporterSphere
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.chk_auto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CHK_rotate);
            this.Name = "ProgressReporterSphere";
            this.Controls.SetChildIndex(this.CHK_rotate, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.chk_auto, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CHK_rotate_CheckedChanged(object sender, EventArgs e)
        {
            sphere1.rotatewithdata = CHK_rotate.Checked;
            sphere2.rotatewithdata = CHK_rotate.Checked;
        }

        private void chk_auto_CheckedChanged(object sender, EventArgs e)
        {
            autoaccept = chk_auto.Checked;

            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.AppSettings.Settings.Remove("sphereautocomplete");

                config.AppSettings.Settings.Add(new KeyValueConfigurationElement("sphereautocomplete", autoaccept.ToString()));

                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
            }
            catch { }
        }
    }
}
