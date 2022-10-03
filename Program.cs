namespace Telekocsi {

    class Ride {
        public string Start;
        public string Dest;
        public string License;
        public string PhoneNumber;
        public int NumberOfSeats;

        public Ride(string input) {
            var temp = input.Split(";");
            Start = temp[0];
            Dest = temp[1];
            License = temp[2];
            PhoneNumber = temp[3];
            NumberOfSeats = int.Parse(temp[4]);
        }
    }

    class Need {
        public string Identifier;
        public string Start;
        public string Dest;
        public int NumberOfSeats;

        public Need(string input) {
            var temp = input.Split(";");
            Identifier = temp[0];
            Start = temp[1];
            Dest = temp[2];
            NumberOfSeats = int.Parse(temp[3]);
        }
    }

    internal class Program {
        static void Main(string[] args) {
            var rides = File.ReadAllLines("autok.csv").Skip(1).Select(i => new Ride(i));
            DisplayTask(2);
            Display($"{rides.Count()} autós hírdet fuvart");

            DisplayTask(3);
            var budapestToMiskolc = rides.Where(i => i.Start == "Budapest" && i.Dest == "Miskolc").Sum(i => i.NumberOfSeats);
            Display($"Összesen {budapestToMiskolc} férőhelyet hírdettek az autósok Budapestről Miskolcra");

            DisplayTask(4);
            var hashmap = new Dictionary<string, int>();
            foreach (var item in rides) {
                var route = item.Start + "-" + item.Dest;
                if (hashmap.ContainsKey(route)) hashmap[route] += item.NumberOfSeats;
                else hashmap.Add(route, item.NumberOfSeats);
            }
            var topSeats = hashmap.OrderByDescending(i => i.Value).First();
            Display($"A legtöbb férőhelyet ({topSeats.Value}-et) a {topSeats.Key} útvonalona ajánlották fel a hirdetők");

            DisplayTask(5);
            var needs = new Queue<Need>(File.ReadAllLines("igenyek.csv").Skip(1).Select(i => new Need(i)));
            var avaliableRides = new List<Ride>(rides);
            var file = new StreamWriter("utasuzenetek.txt");
            do {
                var need = needs.Dequeue();
                var requrmentMet = avaliableRides.Find(i => i.Start == need.Start && i.Dest == need.Dest && i.NumberOfSeats >= need.NumberOfSeats);
                if (requrmentMet is null) {
                    file.WriteLine($"{need.Identifier}: Sajnos nem sikerült autót találni");
                    continue;
                }
                avaliableRides.Remove(requrmentMet); // Tételezzük hogy ugyanazt a fuvar >1 ember nem hívhatja
                Display($"{need.Identifier} => {requrmentMet.License}");
                file.WriteLine($"{need.Identifier}: Rendszám: {requrmentMet.License}, Telefonszám: {requrmentMet.PhoneNumber}");
            } while (needs.Count > 0);
            file.Close();
        }

        static void DisplayTask(int num) {
            Console.WriteLine($"{num}. feladat");
        }

        static void Display(string output) {
            Console.WriteLine($"\t {output}");
        }
    }
}