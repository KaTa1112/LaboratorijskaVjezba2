using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorijskaVjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
            KomplekniBrojKlasa kbk1 = new KomplekniBrojKlasa(2, 4);
            KomplekniBrojStruktura kbs1 = new KomplekniBrojStruktura(3, 5);

            KomplekniBrojKlasa kbk2 = kbk1;
            KomplekniBrojStruktura kbs2 = kbs1;

            Console.WriteLine($"kbk1={kbk1}");//poziva ToString metodu
            Console.WriteLine($"kbk2={kbk2}");
            Console.WriteLine($"kbs1={kbs1}");
            Console.WriteLine($"kbs2={kbs2}");

            kbk2.RealniDio = 25;
            kbs2.ImaginarniDio = 38;

            Console.WriteLine($"kbk1={kbk1}");//poziva ToString metodu
            Console.WriteLine($"kbk2={kbk2}");
            Console.WriteLine($"kbs1={kbs1}");
            Console.WriteLine($"kbs2={kbs2}");

            Console.ReadKey(false);


        }
    }
}
