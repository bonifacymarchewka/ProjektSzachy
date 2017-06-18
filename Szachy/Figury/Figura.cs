using System;
using Szachy.Atrybuty;

namespace Szachy.Figury
{
    public delegate void PozycjaZmienionaEventHandler(Pozycja obecnaPozycja);

    /// <summary>
    /// figura.
    /// </summary>
    public abstract class Figura
    {
        /// <summary>
        /// nazwa.
        /// </summary>
        protected string nazwa;

        /// <summary>
        /// pozycja.
        /// </summary>
        protected Pozycja pozycja;

        /// <summary>
        /// kolor.
        /// </summary>
        protected Kolor kolor;

        /// <summary>
        /// Gets or sets nazwa.
        /// </summary>
        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }

        /// <summary>
        /// Gets or sets pozycja.
        /// </summary>
        public Pozycja Pozycja
        {
            get { return pozycja; }
            set
            {
                PozycjaZmieniona(pozycja);
                pozycja = value;
            }
        }

        /// <summary>
        /// Gets or sets kolor.
        /// </summary>
        public Kolor Kolor
        {
            get { return kolor; }
            set { kolor = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Figura"/> class.
        /// </summary>
        /// <param name="nazwa">
        /// nazwa.
        /// </param>
        /// <param name="pozycja">
        /// pozycja.
        /// </param>
        /// <param name="kolor">
        /// kolor.
        /// </param>
        public Figura(string nazwa, Pozycja pozycja, Kolor kolor)
        {
            this.nazwa = nazwa;
            this.pozycja = pozycja;
            this.kolor = kolor;
            PozycjaZmieniona = ZmianaPola;
            PozycjaZmieniona += BylRuch;
        }

        /// <summary>
        /// czy mozliwy ruch.
        /// </summary>
        /// <param name="pozycja">
        /// pozycja.
        /// </param>
        /// <returns>
        /// <see cref="bool"/>.
        /// </returns>
        public abstract bool czyMozliwyRuch(Pozycja pozycja);

        /// <summary>
        /// to string.
        /// </summary>
        /// <returns>
        /// <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return nazwa + " " + kolor + " " + pozycja.X + "," + pozycja.Y;
        }

        /// <summary>
        /// zmiana pola.
        /// </summary>
        private void ZmianaPola(Pozycja obecnaPozycja)
        {
            Console.WriteLine("Zdarzenie 1. Nowa pozycja to: {0} {1}", obecnaPozycja.X, obecnaPozycja.Y);
        }

        /// <summary>
        /// byl ruch.
        /// </summary>
        private void BylRuch(Pozycja obecnaPozycja)
        {
            Console.WriteLine("Zdarzenie 2. Nastapil ruch");
        }

        /// <summary>
        /// PozycjaZmieniona delegat.
        /// </summary>
        public event PozycjaZmienionaEventHandler PozycjaZmieniona;
    }
}
