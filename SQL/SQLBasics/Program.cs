using System;

namespace SQLBasics {
    class Program {
        static SQL database = new SQL("localhost", "root", "", "pizza");

        static void Main(string[] args) {
            f23();
            f24();
            f25();
            f26();
            f27();
            f28();
            Exit("Program vége");
        }

        static void f23() {
            Task(23,"Hány házhoz szállítása volt az egyes futároknak?",
            @"SELECT fnev, Count(DISTINCT razon) FROM futar JOIN rendeles USING(fazon) GROUP BY fazon;");
        }

        static void f24() {
            Task(24, "A fogyasztás alapján mi a pizzák népszerűségi sorrendje?",
            @"SELECT pnev, Sum(db) som FROM pizza JOIN tetel USING(pazon) GROUP BY pazon ORDER BY som DESC;");
        }

        static void f25() {
            Task(25, "A rendelések összértéke alapján mi a vevők sorrendje?",
            @"SELECT vnev, Sum(db * par) som FROM vevo JOIN rendeles USING (vazon) JOIN tetel USING(razon) JOIN pizza USING (pazon) GROUP BY vazon ORDER BY som DESC;");
        }

        static void f26() {
            Task(26, "Melyik a legdrágább pizza?",
            @"SELECT pnev, par FROM pizza ORDER BY par DESC LIMIT 1;");
        }

        static void f27() {
            Task(27, "Ki szállította házhoz a legtöbb pizzát?",
            @"SELECT fnev, Count(DISTINCT razon) cunt FROM futar JOIN rendeles USING(fazon) GROUP BY fazon ORDER BY cunt DESC LIMIT 1;");
        }

        static void f28() {
            Task(28, "Ki ette a legtöbb pizzát?",
            @"SELECT vnev, Sum(db)som FROM vevo JOIN rendeles USING(vazon) JOIN tetel USING(razon) GROUP BY vazon ORDER BY som DESC LIMIT 1;");
        }

        static void Task(int num, string task, string query) {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{num}. {task}");
            Console.ForegroundColor = color;
            createTable(Query(query));
            Console.WriteLine();
        }

        static QueryResponse Query(string query) {
            try {
                var table = database.Query(query);
                return table;
            } catch (Exception ex) {
                Exit("Adatbázis hiba: " + ex.Message);
            }
            return null;
        }

        static void createTable(QueryResponse table) {
            Console.WriteLine(string.Join("\t", table.Headers));
            foreach (var row in table.Values)
                Console.WriteLine(string.Join("\t", row));
        }

        static void Exit(string mess) {
            Console.WriteLine(mess);
            Console.ReadKey();
            Environment.Exit(1);
        }
    }
}
