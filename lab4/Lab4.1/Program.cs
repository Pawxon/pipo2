using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            liczby L1 = new liczby();
            liczby L2 = new liczby();

            L1.set_a(5);
            L1.set_b(23);
            L1.set_c(7);

            L2.set_a(10);
            L2.set_b(34);
            L2.set_c(21);

            Console.WriteLine("liczby L1");
            Console.WriteLine("a=" + L1.get_a());
            Console.WriteLine("b=" + L1.get_b());
            Console.WriteLine("c=" + L1.get_c());

            Console.WriteLine("");
            Console.WriteLine("liczby L2");
            Console.WriteLine("a=" + L2.get_a());
            Console.WriteLine("b=" + L2.get_b());
            Console.WriteLine("c=" + L2.get_c());

            Console.WriteLine("");

            lepsze_liczby LL1 = new lepsze_liczby();

            LL1.set_a(69);
            LL1.set_b(96);
            LL1.set_c(100);

            LL1.set_d(3);

            Console.WriteLine("lepsze_liczby LL1");
            Console.WriteLine("a=" + LL1.get_a());
            Console.WriteLine("b=" + LL1.get_b());
            Console.WriteLine("c=" + LL1.get_c());

            Console.WriteLine("d=" + LL1.get_d());
            Console.ReadKey();
        }
    }
}
