using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjekt
{
    public class Lakopark
    {
        private int[,] hazak;
        private int maxHazSzam;
        private string nev;
        private int utcakSzama;

        public Lakopark(string nev,int utcakSzama,int maxHazSzam, int[,] hazak)
        {
            this.hazak = hazak;
            this.maxHazSzam = maxHazSzam;
            this.nev = nev;
            this.utcakSzama = utcakSzama;
        }

        public int[,] Hazak { get { return hazak; } }
        public int MaxHazSzam { get { return maxHazSzam; } }
        public string Nev { get { return nev; } }
        public int UtcakSzama { get { return utcakSzama; } }

        public bool hasFullyBuiltRoad()
        {
            for (int y = 0; y < utcakSzama; y++)
            {
                var emptySpace = false;
                for (int x = 0; x < maxHazSzam; x++)
                {
                    if (hazak[y,x]==0) emptySpace = true;
                }
                if (!emptySpace) return true;
            }
            return false;
        }

        public double filledPercentage()
        {
            int house = 0;
            for (int y = 0; y < utcakSzama; y++)
            {
                for (int x = 0; x < maxHazSzam; x++)
                {
                    if (hazak[y, x] != 0) house++;
                }
            }
            return house/(utcakSzama*maxHazSzam);
        }

        public double Price()
        {
            var size = 0;
            for (int y = 0; y < utcakSzama; y++)
            {
                for (int x = 0; x < maxHazSzam; x++)
                {
                    if (hazak[y, x] == 0) continue;
                    if (hazak[y, x] >= 1) size += 80;
                    if (hazak[y, x] >= 2) size += 70;
                    if (hazak[y, x] >= 3) size += 50;
                }
            }
            return size * 300000;
        }
    }
}
