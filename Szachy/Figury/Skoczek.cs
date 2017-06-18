using Szachy.Atrybuty;

namespace Szachy.Figury
{
    /// <summary>
    /// skoczek.
    /// </summary>
    internal class Skoczek : Figura
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Skoczek"/> class.
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
        public Skoczek(string nazwa, Pozycja pozycja, Kolor kolor) : base(nazwa, pozycja, kolor)
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
            if ((cel.X != this.Pozycja.X + 1 && cel.Y != this.Pozycja.Y + 2) &&
                (cel.X != this.Pozycja.X - 2 && cel.Y != this.Pozycja.Y + 1) &&
                (cel.X != this.Pozycja.X + 3 && cel.Y != this.Pozycja.Y - 1) &&
                (cel.X != this.Pozycja.X - 1 && cel.Y != this.Pozycja.Y - 3))
            {
                return false;
            }

            return true;
        }
    }
}