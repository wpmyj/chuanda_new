using System;
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

            but = new ToolStripMenuItem("航线扫描");
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
            button.Text = "航线扫描";
            Host.FPTLPanel.Controls.Add(button);

            button.Click += but_Click;

            if (hit == false)
                col.Add(but);

            return true;
        }

        void but_Click(object sender, EventArgs e)
        {
            var gridui = new GridUI(this);

            int a = Host.FPDrawnPolygonLimit.Points.Count;
            if (Host.FPDrawnPolygon != null && Host.FPDrawnPolygon.Points.Count > 2)
            {
                foreach (Control ctl in Host.splitContainer1.Panel2.Controls)
                {
                    ctl.Visible = false;
                }

                Host.splitContainer1.Panel2.Controls.Add(gridui);

                ByAeroBeHero.Utilities.ThemeManager.ApplyThemeTo(gridui);

                gridui.Dock = DockStyle.Fill;
                gridui.Invalidate();

                gridui.Show();
                gridui.Visible = true;
            }
            else
            {

                ShowFliahtPlanner(); 
                gridui.Hide();
                gridui.Visible = false;
                CustomMessageBox.Show("请加载区域工作文件，再进行规划。", "提示");

                //if (CustomMessageBox.Show("没有进行区域规划。加载文件?", "加载文件", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                //    gridui.LoadGrid();
                //    gridui.Show();
                //}
                //else
                //{
                //    CustomMessageBox.Show("请进行区域规划.", "错误");
                //}
            }
            
        }

        public void ShowFliahtPlanner() 
        {
            foreach (MainSwitcher.Screen sc in MainV2.View.screens)
            {
                if (sc.Name == "FlightPlanner")
                {
                    Host.splitContainer1.Panel2.Controls.Add(sc.Control);
                    ByAeroBeHero.Utilities.ThemeManager.ApplyThemeTo(sc.Control);

                    sc.Control.Dock = DockStyle.Fill;
                    sc.Control.Visible = true;

                    if (sc.Control is IActivate)
                    {
                        ((IActivate)(sc.Control)).Activate();
                    }

                    break;
                }
            }
        }

        public override bool Exit()
        {
            return true;
        }
    }
}
