using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Vasmegye
{
    class Infant
    {
        public string Gender;
        public string BirthDate;
        public string Errorcheck;

        public Infant(string input)
        {
            var temp = input.Split("-");
            Gender = temp[0];
            BirthDate = temp[1];
            Errorcheck = temp[2];
        }

        public bool CdvEll()
        {
            string temp = Gender + BirthDate + Errorcheck;
            var xd = 1;
            for (int i = 0; i < temp.Length-1; i++)
            {
                xd += (10 - i) * int.Parse(temp[i].ToString());
            }
            var mod = xd % 11;
            var last = int.Parse(temp.Last().ToString());
            return last == mod;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var infants = File.ReadAllLines("vas.txt").Select(i => new Infant(i)).ToList();


            var invalid = new List<Infant>();
            foreach (var item in infants)
            {
                if (item.CdvEll())
                {
                    Console.WriteLine($"Hibás a {item.Gender}-{item.BirthDate}-{item.Errorcheck} személyi azonosito");
                    invalid.Add(item);
                }
            }
            foreach (var item in invalid)
            {
                infants.Remove(item);
            }

            Console.WriteLine($"{infants.Count()} gyerek született");
        }
    }
}
