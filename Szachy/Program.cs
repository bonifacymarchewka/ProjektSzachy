using System;
using Szachy.Atrybuty;
using Szachy.Figury;

namespace Szachy
{
    /// <summary>
    /// The program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// main.
        /// </summary>
        /// <param name="args">
        /// args.
        /// </param>
        private static void Main(string[] args)
        {
            var szachownica = new Szachownica();

            var figura = szachownica.PobierzFigure(new Pozycja(2, 1));

            Console.WriteLine(figura.ToString());
            Console.WriteLine(((Pionek)figura).ToString()); // Ta sama metoda ToString zwraca co innego w zaleznosci do czego rzutujemy.
            Console.WriteLine(((Pionek)figura).ToString("moj")); // Metode nadpisana przez 'new' mozna przeciazac.

            var cel = new Pozycja(2, 2);
            szachownica.PrzestawFigure(figura.Pozycja, cel);

            szachownica.IleFigur();
        }
    }
}