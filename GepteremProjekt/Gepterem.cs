using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProjekt
{
    internal class Gepterem
    {
        private int[,] ertekeles;
        private int helyDb;
        private string nev;
        private int sorDb;

        public Gepterem(string nev, int sorDb, int helyDb, int[,] ertekeles)
        {
            Ertekeles = ertekeles;
            HelyDb = helyDb;
            Nev = nev;
            SorDb = sorDb;
        }

        public int[,] Ertekeles { get => ertekeles; set => ertekeles = value; }
        public int HelyDb { get => helyDb; set => helyDb = value; }
        public string Nev { get => nev; set => nev = value; }
        public int SorDb { get => sorDb; set => sorDb = value; }

        public double Atlag()
        {
            int sum = 0;
            int seats = 0;
            for (int y = 0; y < Ertekeles.GetLength(0); y++)
            {
                for (int x = 0; x < Ertekeles.GetLength(1); x++)
                {
                    if (Ertekeles[y, x] != 0) { sum += Ertekeles[y, x];seats++; }
                }
            }
            return (double)sum/ seats;
        }
    }
}
