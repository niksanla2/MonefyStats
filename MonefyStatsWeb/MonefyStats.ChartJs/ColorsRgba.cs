using System;
using System.Collections.Generic;
using System.Text;

namespace MonefyStats.ChartJs
{
    public static class ColorsRgba
    {
        public static ColorRgba Red => new ColorRgba(200, 0, 0, 0.3m);
        public static ColorRgba Green => new ColorRgba(0, 200, 0, 0.3m);
        public static ColorRgba Blue => new ColorRgba(0, 0, 200, 0.3m);
   
        public static ColorRgba Random(decimal alpha = 0.3m)
        {
            var rnd = new Random();
            return new ColorRgba((byte)rnd.Next(0, 256), (byte)rnd.Next(0, 256), (byte)rnd.Next(0, 256), alpha);
        }
    }
}
