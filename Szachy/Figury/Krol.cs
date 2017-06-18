using System;
using Szachy.Atrybuty;

namespace Szachy.Figury
{
    /// <summary>
    /// The krol.
    /// </summary>
    public class Krol : Figura
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Krol"/> class.
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
        public Krol(string nazwa, Pozycja pozycja, Kolor kolor)
            : base(nazwa, pozycja, kolor)
        {
        }

        /// <summary>
        /// czy mozliwy ruch.
        /// </summary>
        /// <param name="cel">
        /// cel.
        /// </param>
        /// <returns>
        /// <see cref="bool"/>.
        /// </returns>
        public override bool czyMozliwyRuch(Pozycja cel)
        {
            if ((Math.Abs(cel.X - this.Pozycja.X) == 1 && cel.Y == this.Pozycja.Y) ||
                (Math.Abs(cel.Y - this.Pozycja.Y) == 1 && cel.X == this.Pozycja.X))
            {
                return true;
            }

            return false;
        }
    }
}