using System;
using System.Diagnostics;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Properties;
using System.Drawing;
using System.Text;

namespace ByAeroBeHero.GCSViews
{
    public partial class Help : MyUserControl, IActivate
    {
        public Help()
        {
            InitializeComponent();
            InitControl();
        }

        private void InitControl() 
        {
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;          
        }

        public void Activate()
        {
            MainV2.instance.controlMainMenuColor("MenuHelp");
            try
            {
                CHK_showconsole.Checked = MainV2.config["showconsole"].ToString() == "True";
            }
            catch
            {
            }
        }

        public void BUT_updatecheck_Click(object sender, EventArgs e)
        {
            Utilities.Update.DoUpdate();
        }

        private void CHK_showconsole_CheckedChanged(object sender, EventArgs e)
        {
            MainV2.config["showconsole"] = CHK_showconsole.Checked.ToString();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            string version =Resources.help_text;
            richTextBox1.Rtf = version + "固件版本:" + CurrentState.str_firm_ware + "\\par \t 获取更多帮助请访问博鹰官网：www.byaero.com.";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://firmware.diydrones.com/Tools/ByAeroBeHero/upgrade/ChangeLog.txt");
        }

        private void PIC_wizard_Click(object sender, EventArgs e)
        {
            //var cfg = new Wizard.Wizard();

            //cfg.ShowDialog(this);
        }

        private void BUT_betaupdate_Click(object sender, EventArgs e)
        {
            Utilities.Update.dobeta = true;
            Utilities.Update.DoUpdate();
        }
    }
}