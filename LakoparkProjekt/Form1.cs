using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LakoparkProjekt
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        HappyLiving happyLiving = new HappyLiving("lakoparkok.txt");
        int currIndex = 0;
        int imgSize = 50;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LoadPuzzle(happyLiving.Lakoparkok[0]);
        }

        private void CreateStats()
        {
            var fullybuilt = happyLiving.hasFullyBuiltRoad();

            var bestPercentage = happyLiving.Lakoparkok.Max(i => i.filledPercentage());
            var best = happyLiving.Lakoparkok.First(i => i.filledPercentage() == bestPercentage);

            var date = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            var writer = new StreamWriter($"statisztika_{date}.txt");
            writer.WriteLine($"Van-e olyan lakópark, amelyben van teljesen beépített utca?: {fullybuilt?.Nev?? "Nincs"}");
            writer.WriteLine($"Arányaiban melyik a legjobban beépített lakópark?: {best.Nev}");
            foreach (var park in happyLiving.Lakoparkok)
            {
                writer.WriteLine($"{park.Nev}: {park.Price()}Ft");
            }
            writer.Close();
        }

        private void LoadPuzzle(Lakopark puzzle)
        {
            pictureBox_img.ImageLocation = "Kepek\\" + puzzle.Nev + ".jpg";
            panel.Controls.Clear();
            panel.Width = puzzle.MaxHazSzam * imgSize;
            panel.Height = puzzle.UtcakSzama * imgSize;

            for (int y = 0; y < puzzle.UtcakSzama; y++)
            {
                for (int x = 0; x < puzzle.MaxHazSzam; x++)
                {
                    var picBox = new PictureBox();
                    panel.Controls.Add(picBox);
                    picBox.Location = new Point(x * imgSize, y * imgSize);
                    picBox.Size = new Size(imgSize, imgSize);
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picBox.MouseClick += mouseDownEventHandler;
                    if (puzzle.Hazak[y, x] != 0)
                        picBox.ImageLocation = "Kepek\\Haz" + puzzle.Hazak[y, x] + ".jpg";
                    else
                        picBox.ImageLocation = "Kepek\\kereszt.jpg";

                }
            }
        }

        private void mouseDownEventHandler(object sender, MouseEventArgs e)
        {
            var picBox = (PictureBox)sender;
            var y = picBox.Location.Y / imgSize;
            var x = picBox.Location.X / imgSize;
            var puzzle = happyLiving.Lakoparkok[currIndex];
                puzzle.Hazak[y, x]= (puzzle.Hazak[y, x]+1)%4;
                
            if (puzzle.Hazak[y, x] != 0)
                picBox.ImageLocation = "Kepek\\Haz" + puzzle.Hazak[y, x] + ".jpg";
            else
                picBox.ImageLocation = "Kepek\\kereszt.jpg";
        }

        private void pictureBox_right_Click(object sender, EventArgs e)
        {
            move(+1);

        }

        private void pictureBox_left_Click(object sender, EventArgs e)
        {
            move(-1);
        }

        private void move(int add)
        {
            currIndex += add;
            pictureBox_left.Visible = true;
            pictureBox_right.Visible = true;
            if (currIndex == 0) pictureBox_left.Visible = false;
            if (currIndex == happyLiving.Lakoparkok.Count-1) pictureBox_right.Visible = false;
            LoadPuzzle(happyLiving.Lakoparkok[currIndex]);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString()+"_"+ DateTime.Now.Hour.ToString()+ DateTime.Now.Minute.ToString();
            File.Copy("lakoparkok.txt", "lakoparkok_"+ date + ".txt",true);
            try
            {
                Serialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt mentéskor: "+ex.Message, "Hiba");
                return;
            }
            MessageBox.Show("Mentés sikeres!");
        }
        private void Serialize()
        {
            var writer = new StreamWriter("lakoparkok.txt");
            foreach (var puzzle in happyLiving.Lakoparkok)
            {
                writer.WriteLine(puzzle.Nev);
                writer.WriteLine(puzzle.UtcakSzama + ";" + puzzle.MaxHazSzam);
                for (int y = 0; y < puzzle.UtcakSzama; y++)
                {
                    for (int x = 0; x < puzzle.MaxHazSzam; x++)
                    {
                        if (puzzle.Hazak[y, x] != 0) writer.WriteLine((y + 1) + ";" + (x + 1) + ";" + puzzle.Hazak[y, x]);
                    }
                }
                writer.WriteLine();
            }
            writer.Close();
        }

        private void button_stats_Click(object sender, EventArgs e)
        {
            CreateStats();
        }
    }
}
