using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakoparkProjekt
{
    public class HappyLiving
    {
        private List<Lakopark> lakoparkok = new List<Lakopark>();

        public List<Lakopark> Lakoparkok { get { return lakoparkok; } }

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
    }
}
