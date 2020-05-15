using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4._1
{
    public class liczby
    {
        private int a;
        private int b;
        private int c;

        public liczby()
        {
            a = 0;
            b = 0;
            c = 0;
        }

        public int get_a()
        {
            return a;
        }

        public int get_b()
        {
            return b;
        }

        public int get_c()
        {
            return c;
        }

        public void set_a(int x)
        {
            a = x;
        }

        public void set_b(int x)
        {
            b = x;
        }

        public void set_c(int x)
        {
            c = x;
        }
    }
}