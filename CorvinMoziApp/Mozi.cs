using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace CorvinMoziApp {
    class Mozi {
        public List<Terem> termek = new List<Terem>();

        public void Mentes() {

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

                    char[,] seats = new char[currHeight, currHeight];
                    foreach (var house in currSeats) {
                        var temp2 = house.Split(';');
                        int y = int.Parse(temp[0]), x = int.Parse(temp[1]);
                        seats[y, x] = temp2[2][0];
                    }

                    var currImage = Image.FromFile($"{currName.Split(' ')[0]}.jpg");
                    termek.Add(new Terem(currName, currHeight, currWidth, seats, currImage));
                }
            }
        }
    }
}
