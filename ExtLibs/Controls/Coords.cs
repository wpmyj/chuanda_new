﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeoUtility.GeoSystem;

namespace ByAeroBeHero.Controls
{
    public partial class Coords : UserControl
    {
        [System.ComponentModel.Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public string Sys { get { return CMB_coordsystem.Text; } set { CMB_coordsystem.Text = value; } }
        public double Lat { get { return point.Latitude; } set { point.Latitude = value; this.Invalidate(); } }
        public double Lng { get { return point.Longitude; } set { point.Longitude = value; this.Invalidate(); } }
        public double Alt { get { return _alt; } set { _alt = value; this.Invalidate(); } }
        public string AltUnit { get { return _unit; } set { _unit = value; this.Invalidate(); } }

        [System.ComponentModel.Browsable(true)]
        public bool Vertical { get; set; }

        double _alt = 0;
        private string _unit = "米";
        Geographic point = new Geographic();

        public enum CoordsSystems
        {
            GEO,
            UTM,
            MGRS
        }

        public Coords()
        {
            Vertical = false;

            InitializeComponent();
            this.DoubleBuffered = true;
            CMB_coordsystem.DataSource = Enum.GetNames(typeof(CoordsSystems));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Near;
            drawFormat.LineAlignment = StringAlignment.Center;  

            PointF text = new PointF(10, 10);

            if (Sys == CoordsSystems.GEO.ToString())
            {
                e.Graphics.DrawString("纬度：" + Lat.ToString("0.000000") + "度" + "     " + "经度：" + Lng.ToString("0.000000") + "度" + "     " + "海拔：" + Alt.ToString("0.00") + "米", this.Font, new SolidBrush(this.ForeColor), text, drawFormat);
            }
            else if (Sys == CoordsSystems.UTM.ToString())
            {
                try
                {
                    if (point.Latitude > 84 || point.Latitude < -80 || point.Longitude >= 180 || point.Longitude <= -180)
                        return;

                    UTM utm = (UTM)point;
                    //utm.East.ToString("0.00") + " " + utm.North.ToString("0.00")
                    string[] parts = utm.ToString().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                    if (Vertical)
                    {
                        e.Graphics.DrawString(parts[0] + "\n" + parts[1] + "\n" + parts[2] + "\n" + Alt.ToString("0.00") + AltUnit, this.Font, new SolidBrush(this.ForeColor), text, StringFormat.GenericDefault);
                    }
                    else
                    {
                        e.Graphics.DrawString(utm.ToString() + "   " + Alt.ToString("0.00") + AltUnit, this.Font, new SolidBrush(this.ForeColor), text, StringFormat.GenericDefault);
                    }
                }
                catch { }
            }
            else if (Sys == CoordsSystems.MGRS.ToString())
            {
                try
                {
                    if (point.Latitude > 84 || point.Latitude < -80 || point.Longitude >= 180 || point.Longitude <= -180)
                        return;

                    MGRS mgrs = (MGRS)point;
                    mgrs.Precision = 5;

                    if (Vertical)
                    {
                        e.Graphics.DrawString(mgrs.ToString() + "\n" + Alt.ToString("0.00") + AltUnit, this.Font, new SolidBrush(this.ForeColor), new Point(5, CMB_coordsystem.Bottom + 2), StringFormat.GenericDefault);
                    }
                    else
                    {
                        e.Graphics.DrawString(mgrs.ToString() + "   " + Alt.ToString("0.00") + AltUnit, this.Font, new SolidBrush(this.ForeColor), text, StringFormat.GenericDefault);
                    }
                }
                catch { }
            }  
        }

        private void CMB_coordsystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
