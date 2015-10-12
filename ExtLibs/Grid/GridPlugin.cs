using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET.WindowsForms;

namespace ByAeroBeHero
{
    public class GridPlugin : ByAeroBeHero.Plugin.Plugin
    {
        

        ToolStripMenuItem but;

        public override string Name
        {
            get { return "Grid"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        public override string Author
        {
            get { return "Michael Oborne"; }
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

            if (hit == false)
                col.Add(but);

            return true;
        }

        void but_Click(object sender, EventArgs e)
        {
            var gridui = new GridUI(this);
            ByAeroBeHero.Utilities.ThemeManager.ApplyThemeTo(gridui);

            if (Host.FPDrawnPolygon != null && Host.FPDrawnPolygon.Points.Count > 2)
            {
                gridui.ShowDialog();
            }
            else
            {
                if (CustomMessageBox.Show("没有定义多边形。加载文件?", "加载文件", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gridui.LoadGrid();
                    gridui.ShowDialog();
                }
                else
                {
                    CustomMessageBox.Show("请定义一个多边形.", "错误");
                }
            }
        }

        public override bool Exit()
        {
            return true;
        }
    }
}
