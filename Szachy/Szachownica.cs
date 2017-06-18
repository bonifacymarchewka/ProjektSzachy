using System;
using System.Collections.Generic;
using Szachy.Atrybuty;
using Szachy.Figury;

namespace Szachy
{
    /// <summary>
    /// Szachownica.
    /// </summary>
    public class Szachownica
    {
        /// <summary>
        /// Figury.
        /// </summary>
        private List<Figura> Figury;

        /// <summary>
        /// Initializes a new instance of the <see cref="Szachownica"/> class.
        /// </summary>
        public Szachownica()
        {
            Figury = new List<Figura>();
            Figury.Add(new Pionek("Pionek 1", new Pozycja(0, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 2", new Pozycja(1, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 3", new Pozycja(2, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 4", new Pozycja(3, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 5", new Pozycja(4, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 6", new Pozycja(5, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 7", new Pozycja(6, 1), Kolor.Bialy));
            Figury.Add(new Pionek("Pionek 8", new Pozycja(7, 1), Kolor.Bialy));
            Figury.Add(new Wieza("Wieza 1", new Pozycja(0, 0), Kolor.Bialy));
            Figury.Add(new Wieza("Wieza 2", new Pozycja(7, 0), Kolor.Bialy));
            Figury.Add(new Krol("Krol", new Pozycja(4, 0), Kolor.Bialy));
            Figury.Add(new Krol("Skoczek", new Pozycja(1, 0), Kolor.Bialy));
            Figury.Add(new Krol("Skoczek", new Pozycja(4, 0), Kolor.Bialy));

            Figury.Add(new Pionek("Pionek 1", new Pozycja(0, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 2", new Pozycja(1, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 3", new Pozycja(2, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 4", new Pozycja(3, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 5", new Pozycja(4, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 6", new Pozycja(5, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 7", new Pozycja(6, 6), Kolor.Czarny));
            Figury.Add(new Pionek("Pionek 8", new Pozycja(7, 6), Kolor.Czarny));
            Figury.Add(new Wieza("Wieza 1", new Pozycja(0, 5), Kolor.Czarny));
            Figury.Add(new Wieza("Wieza 2", new Pozycja(7, 5), Kolor.Czarny));
            Figury.Add(new Krol("Krol", new Pozycja(4, 5), Kolor.Czarny));
            Figury.Add(new Krol("Skoczek", new Pozycja(1, 5), Kolor.Czarny));
            Figury.Add(new Krol("Skoczek", new Pozycja(4, 5), Kolor.Czarny));
        }

        /// <summary>
        /// pobierz figure.
        /// </summary>
        /// <param name="pozycja">
        /// pozycja.
        /// </param>
        /// <returns>
        /// <see cref="Figura"/>.
        /// </returns>
        public Figura PobierzFigure(Pozycja pozycja)
        {
            foreach (var figura in Figury)
            {
                if (pozycja.X == figura.Pozycja.X && pozycja.Y == figura.Pozycja.Y)
                {
                    return figura;
                }
            }

            return null;
        }

        public int ileFigur()
        {
            return Figury.Count;
        }

        /// <summary>
        /// przestaw figure.
        /// </summary>
        /// <param name="staraPozycja">
        /// stara pozycja.
        /// </param>
        /// <param name="nowaPozycja">
        /// nowa pozycja.
        /// </param>
        /// <returns>
        /// <see cref="bool"/>.
        /// </returns>
        public bool PrzestawFigure(Pozycja staraPozycja, Pozycja nowaPozycja)
        {
            Figura figura = PobierzFigure(staraPozycja);

            if (figura != null && PobierzFigure(nowaPozycja) == null && figura.czyMozliwyRuch(nowaPozycja))
            {
                Console.WriteLine(figura.ToString());
                figura.Pozycja = nowaPozycja;
                return true;
            }

            return false;
        }
    }
}