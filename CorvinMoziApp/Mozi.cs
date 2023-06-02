using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace CorvinMoziApp {
    public class Mozi {
        public List<Terem> termek = new List<Terem>();

        public void Mentes() {
            var writer = new StreamWriter("CorvinMozi.csv");
            foreach (var terem in termek) {
                writer.WriteLine(terem.Nev);
                writer.WriteLine(terem.Sorok + ";" + terem.Szekek);
                for (int y = 0; y < terem.Sorok; y++) {
                    for (int x = 0; x < terem.Szekek; x++) {
                        if (terem.Ulesek[y, x] != (char)0) writer.WriteLine((y + 1) + ";" + (x + 1) + ";" + terem.Ulesek[y, x]);
                    }
                }
                writer.WriteLine();
            }
            writer.Close();
        }

        public Mozi(string forras) {
            using (var reader = new StreamReader(forras)) {
                while (!reader.EndOfStream) {
                    var currName = reader.ReadLine();
                    var temp = reader.ReadLine().Split(';');
                    var currHeight = int.Parse(temp[0]);
                    var currWidth = int.Parse(temp[1]);
                    var currSeats = new List<string>();
                    var line = reader.ReadLine();
                    do {
                        currSeats.Add(line);
                        line = reader.ReadLine();
                    } while (!string.IsNullOrEmpty(line));

                    char[,] seats = new char[currHeight, currWidth];
                    foreach (var house in currSeats) {
                        var temp2 = house.Split(';');
                        int y = int.Parse(temp2[0])-1, x = int.Parse(temp2[1])-1;
                        seats[y, x] = temp2[2][0];
                    }

                    var currImage = Image.FromFile($"kepek/{currName.Split(' ')[0]}.jpg");
                    termek.Add(new Terem(currName, currHeight, currWidth, seats, currImage));
                }
            }
        }
    }
}
