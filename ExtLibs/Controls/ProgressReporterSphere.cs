using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ByAeroBeHero.Controls
{
    public class ProgressReporterSphere : ProgressReporterDialogue2
    {
        private System.Windows.Forms.CheckBox CHK_rotate;
        public Sphere sphere2;
        private System.Windows.Forms.CheckBox chk_auto;
        public Sphere sphere1;
        private System.Windows.Forms.Label label2;

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
            this.sphere1 = new ByAeroBeHero.Controls.Sphere();
            this.CHK_rotate = new System.Windows.Forms.CheckBox();
            this.sphere2 = new ByAeroBeHero.Controls.Sphere();
            this.chk_auto = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            // 
            // sphere1
            // 
            this.sphere1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.sphere1, "sphere1");
            this.sphere1.Name = "sphere1";
            this.sphere1.rotatewithdata = true;
            this.sphere1.VSync = false;
            // 
            // CHK_rotate
            // 
            resources.ApplyResources(this.CHK_rotate, "CHK_rotate");
            this.CHK_rotate.Checked = true;
            this.CHK_rotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_rotate.ForeColor = System.Drawing.Color.White;
            this.CHK_rotate.Name = "CHK_rotate";
            this.CHK_rotate.UseVisualStyleBackColor = true;
            this.CHK_rotate.CheckedChanged += new System.EventHandler(this.CHK_rotate_CheckedChanged);
            // 
            // sphere2
            // 
            this.sphere2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.sphere2, "sphere2");
            this.sphere2.Name = "sphere2";
            this.sphere2.rotatewithdata = true;
            this.sphere2.VSync = false;
            // 
            // chk_auto
            // 
            resources.ApplyResources(this.chk_auto, "chk_auto");
            this.chk_auto.Checked = true;
            this.chk_auto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_auto.ForeColor = System.Drawing.Color.White;
            this.chk_auto.Name = "chk_auto";
            this.chk_auto.UseVisualStyleBackColor = true;
            this.chk_auto.CheckedChanged += new System.EventHandler(this.chk_auto_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // ProgressReporterSphere
            // 
            this.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chk_auto);
            this.Controls.Add(this.sphere2);
            this.Controls.Add(this.CHK_rotate);
            this.Controls.Add(this.sphere1);
            this.Name = "ProgressReporterSphere";
            this.Controls.SetChildIndex(this.btnClose, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.sphere1, 0);
            this.Controls.SetChildIndex(this.CHK_rotate, 0);
            this.Controls.SetChildIndex(this.sphere2, 0);
            this.Controls.SetChildIndex(this.chk_auto, 0);
            this.Controls.SetChildIndex(this.label2, 0);
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
