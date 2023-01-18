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

        
    }
}
