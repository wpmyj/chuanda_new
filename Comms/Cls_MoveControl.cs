
//接下来是用于移动控件的类：
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.Comms
{
    public class Cls_MoveControl
    {
        public enum MoveDirection
        {
            Any,
            Horizontal,
            Vertical
        }
        private int int_FrmWidth = 200;
        private int int_FrmHeight = 200;
        public int Int_FrmWidth
        {
            get
            {
                return int_FrmWidth;
            }
            set
            {
                int_FrmWidth = value;
            }
        }
        public int Int_FrmHeight
        {
            get
            {
                return int_FrmHeight;
            }
            set
            {
                int_FrmHeight = value;
            }
        }
        public Cls_MoveControl(int width, int height)
        {
            this.int_FrmWidth = width;
            this.int_FrmHeight = height;
        }
        //这里如果传进来的只是窗口可以用form。当然也可以用Control类，因为Form也是派上于Control类
        public Cls_MoveControl(Control frm)
        {
            this.int_FrmWidth = frm.ClientRectangle.Width;
            this.int_FrmHeight = frm.ClientRectangle.Height;
            frm.Resize += delegate(object sender, EventArgs e)
            {
                this.int_FrmWidth = frm.ClientRectangle.Width;
                this.int_FrmHeight = frm.ClientRectangle.Height;
            };
        }
        /*
            * frm.ClientRectangle.Width;这里用ClientRectangle的原因
            * 因为ClientRectangle可以得到窗口可用区域的大小，
            * 可以去掉窗口的标题栏的高度
            * 这里写Control的好处是，可以传入Form。也可以穿容器控件，如panel
            */

        public void ApplyMove(Control control)
        {
            ApplyMove(control, MoveDirection.Any);
        }
        public void ApplyMove(Control control, MoveDirection moveDirection)
        {
            ApplyMove(control, control, moveDirection);
        }
        public void ApplyMove(Control control, Control container, MoveDirection moveDirection)
        {
            bool isDrag = false;
            Point dragStartPoint = Point.Empty;
            control.MouseDown += delegate(object sender, MouseEventArgs e)
            {
                isDrag = true;
                dragStartPoint = new Point(e.X, e.Y);
                control.Cursor = Cursors.SizeAll;
                control.Capture = true;
            };
            control.MouseUp += delegate(object sender, MouseEventArgs e)
            {
                isDrag = false;
                control.Cursor = Cursors.Default;
                control.Capture = false;
            };
            control.MouseMove += delegate(object sender, MouseEventArgs e)
            {
                if (isDrag) //当鼠标有按下才会为true。一旦鼠标放开就为false
                {
                    //横向移动的只能横向移动。纵向移动的只能纵向移动。
                    //任意方向的则都可以移动
                    if (moveDirection != MoveDirection.Vertical) //horizontal和any可以进入
                    {
                        int left = container.Left + e.X - dragStartPoint.X;
                        // container.Left = Math.Max(0, left); //不要超过左边界
                        container.Left = GetMiddleValue(left, container.Width, this.int_FrmWidth);
                    }
                    if (moveDirection != MoveDirection.Horizontal)
                    {
                        int top = container.Top + e.Y - dragStartPoint.Y;
                        // container.Top = Math.Max(0, top);
                        container.Top = GetMiddleValue(top, container.Height, this.int_FrmHeight);

                    }
                }
            };
        }
        /// <summary>
        /// 控制拖动的控件不要超出窗口
        /// </summary>
        /// <param name="val"></param>
        /// <param name="containerWOH"></param>
        /// <param name="FrmWidth"></param>
        /// <returns></returns>
        private int GetMiddleValue(int val, int containerWOH, int FrmWOH)
        {
            int min = 0;
            int max = FrmWOH - containerWOH;
            if (val < min)
            {
                val = min;
            }
            if (val > max)
            {
                val = max;
            }
            Console.WriteLine(val);
            return val;
        }

    }
}
