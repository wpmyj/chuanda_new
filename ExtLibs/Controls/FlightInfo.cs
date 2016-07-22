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
        string _mode = "Manual";
        bool _state = false;
        bool _failsafe = false;
        string _message = "";
        float _ch6out = 0;
        float _ch8out = 0;

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

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public string mode 
        { 
            get 
            { 
                return _mode; 
            } 
            set 
            { 
                if (_mode != value) 
                { 
                    _mode = value; 
                    this.Invalidate(); 
                } 
            } 
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public bool status 
        {
            get 
            {
                return _state;
            }
            set 
            {
                _state = value;

                this.Invalidate();
            }
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public bool failsafe 
        {
            get 
            {
                return _failsafe;
            }
            set 
            {
                _failsafe = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public string message 
        { 
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                this.Invalidate();
            } 
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public DateTime messagetime
        {
            get;
            set;
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float ch6out
        {
            get
            {
                return _ch6out;
            }
            set
            {
                _ch6out = value;
                this.Invalidate();
            }
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float ch8out
        {
            get
            {
                return _ch8out;
            }
            set
            {
                _ch8out = value;
                this.Invalidate();
            }
        }

        bool statuslast = false;
        DateTime armedtimer = DateTime.MinValue;

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
                str = _batterylevel.ToString("0.00v");// +" " + _current.ToString("0.0 A") + " " + (_batteryremaining) + "%";
            }
            else if(this.Name == "fiGPS")
            {
                str = strGPRS();
            }
            else if(this.Name == "fiMode")
            {
                str =mode;
            }
            else if (this.Name == "fiState") 
            {
                str = strFiState();
            }
            else if(this.Name == "fiBad")
            {
                if (message != "" && messagetime.AddSeconds(10) > DateTime.Now)
                {
                    str = message;
                }
            }
            else if(this.Name =="fiType")
            {
                if(ch6out>0 && ch8out ==0)
                {
                    str = "六轴";
                }
                else if (ch8out > 0)
                {
                    str = "八轴";
                }
                else 
                {
                    str = "四轴";
                }
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

        private string strFiState() 
        {
            string state = string.Empty; 
            if (status != statuslast)
            {
                armedtimer = DateTime.Now;
            }

            if (status == false) // not armed
            {
                state = HUDT.DISARMED;
                statuslast = status;
            }
            else if (status == true) // armed
            {
                if ((armedtimer.AddSeconds(8) > DateTime.Now))
                {

                }
                state = HUDT.ARMED;
                statuslast = status;
            }

            if (failsafe == true)
            {
                state = HUDT.FAILSAFE;
                statuslast = status;
            }

            return state;
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
