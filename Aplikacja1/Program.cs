using Aplikacja1.Figury;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pozycja p = new Pozycja("B5");
            Pozycja p2 = new Pozycja("D4");
            Figura f = new Pionek(p,Kolor.KOLOR_BIALY);
            f.Pozycja = new Pozycja("C2");
            Console.WriteLine(f.CzyMoznaPrzesunac(p2));
            Szachownica sz=new Szachownica();
            sz['A', 1] = "test";
            Console.WriteLine(sz['A',1]);

            Console.ReadKey();
        }
    }
}
