﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using ByAeroBeHero.Controls;
using ByAeroBeHero.GCSViews;

namespace ByAeroBeHero
{
    public class GridPlugin : ByAeroBeHero.Plugin.Plugin
    {
        

        ToolStripMenuItem but;
        MyButton button;

        public override string Name
        {
            get { return "Grid"; }
        }

        public override string Version
        {
            get { return "1.0"; }
        }

        public override string Author
        {
            get { return "By Aero"; }
        }

        public override bool Init()
        {
            return true;
        }

        public override bool Loaded()
        {
            Grid.Host2 = Host;

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridUI));
            var temp = (string)(resources.GetObject("$this.Text"));

            but = new ToolStripMenuItem(temp);
            but.Click += but_Click;

            bool hit = false;
            ToolStripItemCollection col = Host.FPMenuMap.Items;
            int index = col.Count;
            foreach (ToolStripItem item in col)
            {
                if (item.Text.Equals(Strings.AutoWP))
                {
                    index = col.IndexOf(item);
                    ((ToolStripMenuItem)item).DropDownItems.Add(but);
                    hit = true;
                    break;
                }
            }

            button = new MyButton();
            button.Dock = DockStyle.Fill;
            button.Width =109;
            button.Height= 27;
            button.Text = temp;
            Host.FPTLPanel.Controls.Add(button);

            button.Click += but_Click;

            if (hit == false)
                col.Add(but);

            return true;
        }

        void but_Click(object sender, EventArgs e)
        {

            
        }

        public override bool Exit()
        {
            return true;
        }
    }
}
