using System;
using System.Collections.Generic;
using System.Text;

namespace MonefyStats.ChartJs
{
    public class ColorRgba
    {
        public ColorRgba() : this(0, 0, 0)
        {
        }
        public ColorRgba(byte red, byte green, byte blue) : this(red, green, blue, 1)
        {
        }
        public ColorRgba(byte red, byte green, byte blue, decimal alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public decimal Alpha { get; set; }
    }
}
