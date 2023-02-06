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

        public int Income() {
            var income = 0;
            for (int y = 0; y < sorok; y++)
                for (int x = 0; x < szekek; x++)
                    income += ticketPrice(ulesek[y, x]);
            return income;
        }
        private int ticketPrice(char c) {
            if (c == 'F') return 1700;
            if (c == 'D') return 1200;
            return 0;
        }

        public double ratio() {
            var empty = 0;
            for (int y = 0; y < sorok; y++)
                for (int x = 0; x < szekek; x++)
                    if (ulesek[y, x] == (char)0) empty++;
            return (double)empty/(sorok*szekek);
        }

        public (int y,int x)? findEmptyDuo() {
            for (int y = 0; y < sorok; y++) {
                var empty = false;
                for (int x = 0; x < szekek; x++) {
                    if (ulesek[y, x] == (char)0 && empty) return (y, x);
                    else if (ulesek[y, x] == (char)0) empty = true;
                    else empty = false;
                }
            }
            return null;
        } 
    }
}
