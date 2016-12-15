using System;
using System.Diagnostics;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.Properties;
using System.Drawing;
using System.Text;
using ByAeroBeHero.Log;

namespace ByAeroBeHero.GCSViews
{
    public partial class Help : MyUserControl, IActivate
    {
        public Help()
        {
            InitializeComponent();
            InintControl(); 
        }

        public void Activate()
        {
            this.BackColor = Color.DimGray;
            MainV2.instance.controlMainMenuColor("MenuHelp");
        }

        private void InintControl() 
        {
            this.BackColor = Color.DimGray;
            this.label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor = label5.ForeColor = label6.ForeColor =
                label7.ForeColor = label8.ForeColor = label9.ForeColor = label10.ForeColor = lblframType.ForeColor = System.Drawing.Color.Black;        
        }

        private void Help_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.DimGray;
            lblframType.Text = CurrentState.str_firm_ware;
            this.lblframType.ForeColor = System.Drawing.Color.Black;  
        }
    }
}