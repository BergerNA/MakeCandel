using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandelMaker
{
    class Candel
    {
        public int date, time;
        public double open, high, low, close;
        public int volume;

        public Candel() { }

        public Candel(int d, int t, double o, double h, double l, double c, int v)
        {
            date = d;
            time = t;
            open = o;
            high = h;
            low = l;
            close = c;
            volume = v;
        }

        public String ToString()
        {
            return date + " " + time + " " + open + " " + high + " " + low + " " + close + " " + volume;
        }
    }
}
