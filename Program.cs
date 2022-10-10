using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Vasmegye2
{
    class Program
    {
        static List<SzemelyiSzam> szemelyiSzamok = new List<SzemelyiSzam>();
        static void Main(string[] args)
        {
            Console.WriteLine("2. feladat: adatok beolvasása, tárolása");
            adatokBeolvasasa("vas.txt");
            Console.WriteLine("4. feladat: ellenörzés");
            feladat04();
            Console.WriteLine($"5. feladat: Vas megyében a vizsgalt evenk alatt {szemelyiSzamok.Count} született");
            Console.WriteLine($"6. feladat: A fiuk szama {szemelyiSzamok.Where(i => i.isMale()).Count()}");
            Console.WriteLine($"7. feladat: Kező-Vég idő {feladat07()} ");
            Console.WriteLine("8.feladat: "+(feladat08()?"Van":"Nincs")+ " olyan gyerek aki szökőévben születtett");
            feladat09();
            Console.WriteLine("\nProgram Vége");
            Console.ReadKey();
        }

        private static void feladat09()
        {
            var statisztika = szemelyiSzamok.GroupBy(i => i.evSzam()).Select(i => new { ev = i.Key, fo = i.Count() });
            foreach (var item in statisztika) 
            {
                Console.WriteLine($"{item.ev}-{item.fo}");
            }
        }

        private static bool feladat08()
        {
             return szemelyiSzamok.Any(i => isSzökő(i));
        }

        private static bool isSzökő(SzemelyiSzam szemely)
        {
            return szemely.evSzam()%4==0 && szemely.Szam.Substring(4,4)=="0224";
        }
        private static string feladat07()
        {
            var min = szemelyiSzamok.Min(i => i.evSzam());
            var max = szemelyiSzamok.Max(i => i.evSzam());
            return $"{min}-{max}";
        }

        private static void feladat04()
        {
            var hibasSzamok = szemelyiSzamok.FindAll(i => !CdvEll(i.Szam));
            foreach (var item in hibasSzamok)
            {
                Console.WriteLine($"Hibás a {item.Szam} személyi azonosító");
                szemelyiSzamok.Remove(item);
            }
        }

        public static bool CdvEll(string szam)
        {
            string szamNumeric = new string(szam.Where(i => char.IsDigit(i)).ToArray());
            if (szamNumeric.Length != 11) return false;

            double hash = 0;
            for (int i = 0; i < szamNumeric.Length - 1; i++)
            {
                hash += (10 - i) * char.GetNumericValue(szamNumeric[i]);
            }
            return hash % 11 == char.GetNumericValue(szamNumeric[10]);
        }

        private static void adatokBeolvasasa(string adatFile)
        {
            if (!File.Exists(adatFile))
            {
                Console.WriteLine("Forrás adatok hiányoznak");
                Environment.Exit(0);
            }
            using (var sr = new StreamReader(adatFile))
            {
                while (!sr.EndOfStream)
                {
                    szemelyiSzamok.Add(new SzemelyiSzam(sr.ReadLine()));
                }
            }
        }
    }
}
