using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLib;

namespace LakoparkProjekt
{
    public class HappyLiving
    {
        private List<Lakopark> lakoparkok = new List<Lakopark>();

        public List<Lakopark> Lakoparkok { get { return lakoparkok; } }

        public HappyLiving(SQL sql)
        {
            var lakopark = sql.Query("SELECT * FROM lakopark");
            var hazak = sql.Query("SELECT * FROM haz");
            foreach (var item in lakopark.Values)
            {
                var id = item[0];
                var name = item[1];
                var height = int.Parse(item[2]);
                var weight = int.Parse(item[3]);
                var homesList = hazak.Values.Where(i => i[1] == id).ToList();
                var homes = new int[height, weight];
                foreach (var home in homesList)
                {
                    homes[int.Parse(home[2]), int.Parse(home[3])] = int.Parse(home[4]);
                }
                lakoparkok.Add(new Lakopark(name, height, weight, homes));
            }
        }

        public HappyLiving(string filenev)
        {
            using (var reader = new StreamReader(filenev))
            {
                var currName = "";
                var currWidth = 0;
                var currMaxHomes = 0;
                var currHomes = new List<string>();
                while (!reader.EndOfStream)
                {
                    currHomes.Clear();
                    currName = reader.ReadLine();
                    var temp = reader.ReadLine().Split(';');
                    currWidth = int.Parse(temp[0]);
                    currMaxHomes = int.Parse(temp[1]);
                    var line = reader.ReadLine();
                    do
                    {
                        currHomes.Add(line);
                        line = reader.ReadLine();
                    } while (!string.IsNullOrEmpty(line));

                    int[,] homes = new int[currWidth, currMaxHomes];
                    foreach (var house in currHomes)
                    {
                        var temp2 = house.Split(';').Select(i => int.Parse(i)).ToArray();
                        homes[temp2[0]-1, temp2[1]-1] = temp2[2];
                    }
                    lakoparkok.Add(new Lakopark(currName, currWidth, currMaxHomes, homes));
                }
                
            }
           
        }
        public Lakopark hasFullyBuiltRoad()
        {
            for (int i = 0; i < Lakoparkok.Count; i++)
            {
                if (Lakoparkok[i].hasFullyBuiltRoad()) return Lakoparkok[i];
            }
            return null;
        }
    }
}
