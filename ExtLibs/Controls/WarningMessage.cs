using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Collections;
using System.Threading;
 
using System.Drawing.Drawing2D;
using log4net;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace ByAeroBeHero.Controls
{
    public class WarningMessage : GLControl
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        object paintlock = new object();
        object streamlock = new object();
        MemoryStream _streamjpg = new MemoryStream();

        public WarningMessage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // HUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "HUD";
            this.ResumeLayout(false);

        }
    }
}