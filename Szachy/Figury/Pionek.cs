using Szachy.Atrybuty;

namespace Szachy.Figury
{
    /// <summary>
    /// pionek.
    /// </summary>
    public class Pionek : Figura
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pionek"/> class.
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
        public Pionek(string nazwa, Pozycja pozycja, Kolor kolor)
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
            if (cel.X != this.Pozycja.X || cel.Y - 1 != this.Pozycja.Y)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// to string.
        /// </summary>
        /// <returns>
        /// <see cref="string"/>.
        /// </returns>
        public new string ToString()
        {
            return "To skoczek o nazwie: " + nazwa;
        }

        /// <summary>
        /// to string.
        /// </summary>
        /// <returns>
        /// <see cref="string"/>.
        /// </returns>
        public new string ToString(string czyj)
        {
            return "To " + czyj + " skoczek o nazwie: " + nazwa;
        }
    }
}