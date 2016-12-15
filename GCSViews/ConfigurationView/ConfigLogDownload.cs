using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.HIL;
using System.Threading;

namespace ByAeroBeHero.GCSViews.ConfigurationView
{
    public partial class ConfigLogDownload  : UserControl, IActivate
    {
        public ConfigLogDownload()
        {
            InitializeComponent();
            lblLoadLog.ForeColor = System.Drawing.Color.Black;
        }

        public void Activate()
        {
            lblLoadLog.ForeColor = System.Drawing.Color.Black;
        }
    }
}