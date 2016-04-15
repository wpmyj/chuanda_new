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
    public class GMapMarkerLimitPt : GMapMarker
   {
      public float? Bearing;

      static readonly System.Drawing.Size SizeSt = new System.Drawing.Size(Resources.marker_02.Width, Resources.marker_02.Height);

      //static Bitmap localcache1 = Resources.shadow50;
      static Bitmap localcache2 = Resources.marker_05;

      public float Alt { get; set; }

      public float Radius { get; set; }

      public GMapMarkerLimitPt(PointLatLng p)
         : base(p)
      {
         Size = SizeSt;
         Offset = new Point(-10, -40);
      }

      public GMapMarkerLimitPt(MAVLink.mavlink_obstacle_point_t mark)
          : base(new PointLatLng(mark.lat / 1e7, mark.lng / 1e7))
      {
          Size = SizeSt;
          Offset = new Point(-10, -40);
          Alt = mark.alt;
          Radius = mark.radius;
          ToolTipMode = MarkerTooltipMode.OnMouseOver;
          ToolTipText = "障碍航点" + "\n高度: " + mark.alt +" |半径" +mark.radius;
      }

      static readonly Point[] Arrow = new Point[] { new Point(-7, 7), new Point(0, -22), new Point(7, 7), new Point(0, 2) };

      public override void OnRender(Graphics g)
      {
#if !PocketPC      
          g.DrawImage(localcache2, LocalPosition.X, LocalPosition.Y, SizeSt.Width, SizeSt.Height);
     
#else
        //    DrawImageUnscaled(g, Resources.shadow50, LocalPosition.X, LocalPosition.Y);
            DrawImageUnscaled(g, Resources.marker, LocalPosition.X, LocalPosition.Y);
#endif
      }
   }
}
