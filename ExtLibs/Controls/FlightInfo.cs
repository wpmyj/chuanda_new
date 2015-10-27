using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ByAeroBeHero.Controls
{
    public partial class FlightInfo : UserControl
    {

        [System.ComponentModel.Browsable(true)]
        public string desc
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                if (lblName.Text == value)
                    return;
                
                lblName.Text = value;
            }
        }
        [System.ComponentModel.Browsable(true)]

        public string text 
        { 
            get 
            { 
                return lblData.Text; 
            } 
            set 
            {
                if (lblData.Text == value) 
                    return;
                lblData.Text = value;

                this.Invalidate(); 
            }
        }

        float _batterylevel = 0;
        float _batteryremaining = 0;
        float _current = 0;
        float _gpsfix = 0;

        [System.ComponentModel.Browsable(true)]
        public Color numberColor 
        { 
            get 
            { 
                return lblData.ForeColor; 
            } 
            set 
            { 
                if (lblData.ForeColor == value) 
                    return; lblData.ForeColor = value; 
            }
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float batterylevel 
        { 
            get 
            { 
                return _batterylevel; 
            } 
            set 
            { 
                if (_batterylevel != value) 
                { 
                    _batterylevel = value;

                    this.Invalidate(); 
                } 
            } 
        }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float batteryremaining 
        { 
            get 
            { 
                return _batteryremaining; 
            } 
            set 
            { 
                if (_batteryremaining != value) 
                { 
                    _batteryremaining = value;

                    this.Invalidate(); 
                } 
            } 
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float current 
        { 
            get 
            { 
                return _current; 
            } 
            set 
            { 
                if (_current != value)
                {
                    _current = value; 
                    
                    this.Invalidate(); 
                    //if (_current > 0) 
                    //    batteryon = true; 
                } 
            } 
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float gpsfix 
        {
            get 
            { 
                return _gpsfix; 
            } 
            set 
            { 
                if (_gpsfix != value)
                { 
                    _gpsfix = value;
                    this.Invalidate(); 
                } 
            } 
        }
        

        public FlightInfo()
        {
            InitializeComponent();
        }

        public override void Refresh()
        {
            if (this.Visible)
                base.Refresh();
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            if (this.Visible && this.ThisReallyVisible())
                base.OnInvalidated(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Visible)
                base.OnPaint(e);

            string str =string.Empty;
            if (this.Name == "fiBat")
            {
                str = _batterylevel.ToString("0.00v") + " " + _current.ToString("0.0 A") + " " + (_batteryremaining) + "%";
            }
            else if(this.Name =="fiGPS")
            {
                str = strGPRS();
            }

            this.text = str;
        }

        private string strGPRS()
        {
            string gps = "";

            if (_gpsfix == 0)
            {
               gps = (HUDT.GPS0);
             }
            else if (_gpsfix == 1)
            {
                gps = (HUDT.GPS1);
            }
            else if (_gpsfix == 2)
            {
            gps = (HUDT.GPS2);
            }
            else if (_gpsfix == 3)
            {
                gps = (HUDT.GPS3);
            }
            else if (_gpsfix == 4)
            {
                gps = (HUDT.GPS4);
            }
            else if (_gpsfix == 5)
            {
                gps = (HUDT.GPS5);
            } 
            
            return gps;
        }

        void GetFontSize()
        {
            Size extent = TextRenderer.MeasureText(lblData.Text, this.Font);

            float hRatio = (lblData.Height) / (float)(extent.Height);
            float wRatio = this.Width / (float)extent.Width;
            float ratio = (hRatio < wRatio) ? hRatio : wRatio;

            float newSize = this.Font.Size * ratio;

            if (newSize < 8)
                newSize = 8;

            lblData.Font = new Font(lblData.Font.FontFamily, 9, lblData.Font.Style);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.ResizeRedraw = true;

            GetFontSize();
        }

        private void QuickView_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
