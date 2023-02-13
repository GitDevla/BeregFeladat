using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GepteremProjekt
{
    internal class PetrikLajosSzg
    {
        private List<Gepterem> gepteremek = new List<Gepterem>();

        internal List<Gepterem> Gepteremek { get => gepteremek; set => gepteremek = value; }

        public PetrikLajosSzg(string filenev)
        {
            using (var reader = new StreamReader(filenev))
            {
                while (!reader.EndOfStream)
                {
                    var currName = reader.ReadLine();
                    var temp = reader.ReadLine().Split(';');
                    var currHeight = int.Parse(temp[0]);
                    var currWidth = int.Parse(temp[1]);
                    var currSeats = new int[currHeight, currWidth];
                    var line = reader.ReadLine();
                    int y = 0;
                    do
                    {
                        var nums = line.Split(';');
                        for (int x = 0; x < currWidth; x++)
                        {
                            currSeats[y, x] = int.Parse(nums[x]);
                        }
                        line = reader.ReadLine();
                        y++;
                    } while (!string.IsNullOrEmpty(line));

                    Gepteremek.Add(new Gepterem(currName, currHeight, currWidth, currSeats));
                }
            }
        }
    }
}
