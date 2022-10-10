using System.Collections.Generic;
using System.Text.Encodings.Web;

namespace Jackie {
    internal class Program {

        static List<Year> years = new List<Year>();
        static void Main(string[] args) {
            StoreData(ReadFile("jackie.txt"));
            Console.WriteLine($"3. feladat: az állomány {years.Count} sort tartalmaz");
            Console.WriteLine($"4. feladat: {mostActiveYear().date}-ben indult a legtöbb versenyre");
            task5();
            task6();
            Exit("Program vége");
        }

        private static void task6() {
            var html = generateHTML();
            File.WriteAllText("jackie.html", html);
        }

        private static string generateHTML() {
            var document = new HTML();
            document.AppendStyle("td { border:1px solid black; }");
            document.AppendBody("h1", "Jackie Stewart");
            List<string> rows = new List<string>();
            foreach (var row in years) {
                var date = HTML.CreateElement("td", row.date);
                var races = HTML.CreateElement("td", row.races);
                var wins = HTML.CreateElement("td", row.wins);
                rows.Add(HTML.CreateElement("tr", $"{date}{races}{wins}"));
            }
            document.AppendBody("table", string.Join("\n", rows));
            return document.generateRawHTML();
        }

        private static void task5() {
            var data = winsPerDecade();
            Console.WriteLine($"5. feladat:");
            foreach (var item in data)
                Console.WriteLine($"\t{item.Key}-es évek: {item.Value} megnyert verseny");
        }

        private static Dictionary<int,int> winsPerDecade() {
            var hashmap = new Dictionary<int, int>();
            foreach (var item in years) {
                var decade = (item.date % 100) / 10 * 10;
                if (hashmap.ContainsKey(decade)) hashmap[decade] += item.wins;
                else hashmap.Add(decade, item.wins);
            }
            return hashmap;
        }

        private static Year mostActiveYear() {
            return years.First(i => i.races == years.Max(i => i.races));
        }

        static void StoreData(IEnumerable<string> input) {
            foreach (var item in input.Skip(1)) {
                var temp = item.Split('\t').Select(i => int.Parse(i)).ToArray();
                years.Add(new Year(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5]));
            }
        }

        static void Exit(string output) {
            Console.WriteLine("\n"+output);
            Console.ReadKey();
            Environment.Exit(0);
        }

        static IEnumerable<string> ReadFile(string path) {
            if (!File.Exists(path)) Exit($"A {path} file nem létezik");
            return File.ReadAllLines(path);
        }

        
    }
}
