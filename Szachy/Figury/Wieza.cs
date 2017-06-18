using Szachy.Atrybuty;

namespace Szachy.Figury
{
    /// <summary>
    /// wieza.
    /// </summary>
    public class Wieza : Figura
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wieza"/> class.
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
        public Wieza(string nazwa, Pozycja pozycja, Kolor kolor) : base(nazwa, pozycja, kolor)
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
            if (cel.X != this.Pozycja.X && cel.Y != this.Pozycja.Y)
            {
                return false;
            }

            return true;
        }
    }
}