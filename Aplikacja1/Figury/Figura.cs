using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja1.Figury
{
    class Figura
    {
        protected delegate void ZmianaPozycji();
        protected event ZmianaPozycji OnZmianaPozycji;

        protected Pozycja pozycja = null;
        public Pozycja Pozycja
        {
            get
            {
                return pozycja;
            }
            set
            {
                pozycja = value;
                OnZmianaPozycji();
            }
        }

        public string kolor;

        protected bool CzyPionowo(Pozycja nowaPozycja)
        {
            return Pozycja.Y == nowaPozycja.Y;
        }

        protected bool CzyPoziomo(Pozycja nowaPozycja)
        {
            return Pozycja.X == nowaPozycja.X;
        }

        protected bool CzySkos(Pozycja nowaPozycja)
        {
            return Math.Abs(Pozycja.Y - nowaPozycja.Y) == Math.Abs(Pozycja.X - nowaPozycja.X);
        }

        public virtual bool CzyMoznaPrzesunac(Pozycja nowaPozycja)
        {
            return CzyPionowo(nowaPozycja) || CzyPoziomo(nowaPozycja) || CzySkos(nowaPozycja);
        }

        public Figura(Pozycja pozycja, string kolor)
        {
            OnZmianaPozycji += PozycjaZmieniona;
            this.pozycja = pozycja;
            this.kolor = kolor;
        }

        private void PozycjaZmieniona()
        {
            Console.WriteLine("Pozycja zmieniona\nNowa pozycja X: " + pozycja.X + "\nNowa pozycja Y: " + pozycja.Y);
        }
    }
}
