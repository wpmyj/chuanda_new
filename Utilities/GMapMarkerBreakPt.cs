using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using GMap.NET;
using GMap.NET.WindowsForms;
using ByAeroBeHero.Properties;

namespace ByAeroBeHero.Utilities
{
    [Serializable]
    public class GMapMarkerBreakPt : GMapMarker
   {
      public float? Bearing;

      static readonly System.Drawing.Size SizeSt = new System.Drawing.Size(Resources.marker_02.Width, Resources.marker_02.Height);

      //static Bitmap localcache1 = Resources.shadow50;
      static Bitmap localcache2 = Resources.marker_05;

      public int Alt { get; set; }

      public float BreakPointParam1 { get; set; }

      public GMapMarkerBreakPt(PointLatLng p)
         : base(p)
      {
         Size = SizeSt;
         Offset = new Point(-10, -40);
      }

      public GMapMarkerBreakPt(double lat, double lon, string reason, float p1)
          : base(new PointLatLng(lat / 1e7, lon / 1e7))
      {
          Size = SizeSt;
          Offset = new Point(-10, -40);
          ToolTipMode = MarkerTooltipMode.OnMouseOver;
          ToolTipText = "飞行断点" + "\n断点返航原因: " + reason;
          BreakPointParam1 = p1;
      }

      static readonly Point[] Arrow = new Point[] { new Point(-7, 7), new Point(0, -22), new Point(7, 7), new Point(0, 2) };

      public override void OnRender(Graphics g)
      {
#if !PocketPC      
          g.DrawImage(localcache2, LocalPosition.X, LocalPosition.Y,Size.Width,Size.Height);
     
#else
        //    DrawImageUnscaled(g, Resources.shadow50, LocalPosition.X, LocalPosition.Y);
            DrawImageUnscaled(g, Resources.marker, LocalPosition.X, LocalPosition.Y);
#endif
      }
   }
}
