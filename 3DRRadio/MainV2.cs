using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ByAeroBeHero.Comms;

namespace ByAeroBeHero
{
    class MainV2
    {
        public static portproxy comPort = new portproxy();
    }

    class portproxy: IDisposable
    {
        public SerialPort BaseStream = new SerialPort();

        public void Dispose()
        {
            BaseStream.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
