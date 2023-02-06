using System.Drawing;

namespace CorvinMoziApp {
    public class Terem {
        private string nev;
        private Image nevadokep;
        private int sorok;
        private int szekek;
        private char[,] ulesek;

        public string Nev { get => nev; set => nev = value; }
        public Image Nevadokep { get => nevadokep; set => nevadokep = value; }
        public int Sorok { get => sorok; set => sorok = value; }
        public int Szekek { get => szekek; set => szekek = value; }
        public char[,] Ulesek { get => ulesek; set => ulesek = value; }

        public Terem(string nev, int sorok, int szekek, char[,] ulesek, Image nevadokep) {
            Nev = nev;
            Nevadokep = nevadokep;
            Sorok = sorok;
            Szekek = szekek;
            Ulesek = ulesek;
        }

    }
}
