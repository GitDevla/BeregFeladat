using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Kémia
{
    class Program
    {
        static List<Found> findings = new List<Found>();
        static void Main(string[] args)
        {
            StoreData(ReadFile("felfedezesek.csv"));
            Console.WriteLine($"3. feladat: Elemek száma: {findings.Count}");
            Console.WriteLine($"4. feladat: Felfedezések ókorban száma: {findings.Where(i => i.Year == "Ókor").Count()}");
            var task5 = input("5. feladat: Kérek egy vegyjelet:  ", isValid);
            task6(task5);
            Console.WriteLine($"7. feladat: {longestStreak()} év volt a leghosszabb idő felfedezés nélkül");
            task8();
            Exit("Program vége");
        }

        private static void task8()
        {
            Console.WriteLine("8. feladat: Statisztika");

            var hashmap = discoveriesPerYear().Where(i => i.Value > 3 && i.Key != "Ókor");
            foreach (var item in hashmap)
            {
                Console.WriteLine($"\t{item.Key}: {item.Value} db");
            }
        }

        private static Dictionary<string,int> discoveriesPerYear()
        {
            return findings.GroupBy(i => i.Year)
               .ToDictionary(i => i.Key, i => i.ToList().Count());
        }

        private static int longestStreak()
        {
            var diff = 0;
            var longestDiff = 0;
            for (int i = 0; i < findings.Count - 1; i++)
            {
                if (findings[i].Year == "Ókor") continue;
                diff = int.Parse(findings[i + 1].Year) - int.Parse(findings[i].Year);
                if (diff > longestDiff) longestDiff = diff;
            }
            return longestDiff;
        }

        private static void task6(string sign)
        {
            Console.WriteLine("6. feladat: Keresés");
            var found = findings.Find(i => i.Compound.Sign.ToLower() == sign.ToLower());
            if (found is null) Console.WriteLine("Nincs ilyen elem az adat forrásban");
            else
            {
                Console.WriteLine($"\tAz elem vegyjele: {found.Compound.Sign} ");
                Console.WriteLine($"\tAz elem neve: {found.Compound.Name} ");
                Console.WriteLine($"\tRendszama: {found.Compound.Number} ");
                Console.WriteLine($"\tFelfedezés éve: {found.Year} ");
                Console.WriteLine($"\tFelfedező: {found.Discoverer} ");

            }
        }

        private static string input(string output, Func<string, bool> test)
        {
            var valid = true;
            var input = "";
            do
            {
                Console.Write(output);
                input = Console.ReadLine();
                valid = test(input);
            } while (!valid);
            return input;
        }

        private static bool isValid(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z]{2}$");
        }

        static void StoreData(IEnumerable<string> input)
        {
            foreach (var item in input.Skip(1))
            {
                var temp = item.Split(';').ToArray();
                var compund = new Compound(temp[1], temp[2], int.Parse(temp[3]));
                findings.Add(new Found(temp[0], compund, temp[4]));
            }
        }

        static void Exit(string output)
        {
            Console.WriteLine("\n" + output);
            Console.ReadKey();
            Environment.Exit(0);
        }

        static IEnumerable<string> ReadFile(string path)
        {
            if (!File.Exists(path)) Exit($"A {path} file nem létezik");
            return File.ReadAllLines(path);
        }
    }
}
