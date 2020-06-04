using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_1
{
    public class silnia
    {
        public int n;

        public  long oblicz(int n)
        {
            if (n < 2)
              return 1; 

            return n * oblicz(n - 1);
        }



    }
}
