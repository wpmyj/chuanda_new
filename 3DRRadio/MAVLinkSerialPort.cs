using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ByAeroBeHero.Comms
{
    class MAVLinkSerialPort: ByAeroBeHero.Comms.SerialPort
    {
        private ByAeroBeHero.portproxy portproxy;
        private int p;

        public MAVLinkSerialPort(ByAeroBeHero.portproxy portproxy, int p)
        {
            // TODO: Complete member initialization
            this.portproxy = portproxy;
            this.p = p;
        }
    }
}
