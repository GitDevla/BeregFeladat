using System;
using System.Drawing;
using System.Windows.Forms;

namespace LakoparkProjekt
{
    public partial class Form : System.Windows.Forms.Form
    {
        HappyLiving happyLiving = new HappyLiving("lakoparkok.txt");

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            LoadPuzzle(happyLiving.Lakoparkok[0]);
        }

        private void LoadPuzzle(Lakopark puzzle)
        {
            var imgSize = 50;
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
                    if(puzzle.Hazak[y, x] != 0)
                     picBox.ImageLocation = "Kepek\\Haz" + puzzle.Hazak[y,x] + ".jpg";
                    else
                        picBox.ImageLocation = "Kepek\\kereszt.jpg";

                }
            }
        }
    }
}
