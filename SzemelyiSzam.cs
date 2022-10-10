using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vasmegye2
{
    class SzemelyiSzam
    {
        readonly string szam;

        public string Szam => szam;

        public SzemelyiSzam(string szam)
        {
            this.szam = szam;     
        }

        public bool isMale() => char.GetNumericValue(Szam[0]) == 1 || char.GetNumericValue(Szam[0]) == 3;
        

        public int evSzam()
        {
            return int.Parse(((char.GetNumericValue(szam[0]) <= 2) ? "19" : "20") + szam.Substring(2, 2));
        }
    }
}
