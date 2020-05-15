using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4._1
{
    public class lepsze_liczby : liczby
    {
        private int d;

        public lepsze_liczby():base()
        {
            d = 0;
        }

        public int get_d()
        {
            return d;
        }

        public void set_d(int x)
        {
            d = x;
        }
    }
}