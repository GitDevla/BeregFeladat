using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GepteremProjekt
{
    public partial class Form1 : Form
    {
        private PetrikLajosSzg iskola = new PetrikLajosSzg("petrikgepek.txt");
        int currIndex = 0;
        int imgSize = 50;

        public Form1()
        {
            InitializeComponent();
            LoadFilm(iskola.Gepteremek[currIndex]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadFilm(Gepterem terem)
        {
            this.Text = terem.Nev+$" ({terem.Atlag():.0})";
            var imgname = terem.Nev.Split(' ')[0] + ".jpg";
            pictureBox.BackgroundImage = Image.FromFile("Kepek\\"+ imgname);

            panel.Controls.Clear();
            panel.Width = terem.HelyDb * imgSize;
            panel.Height = terem.SorDb * imgSize;

            for (int y = 0; y < terem.SorDb; y++)
            {
                for (int x = 0; x < terem.HelyDb; x++)
                {
                    var picBox = new PictureBox();
                    panel.Controls.Add(picBox);
                    picBox.Location = new Point(x * imgSize, y * imgSize);
                    picBox.Size = new Size(imgSize, imgSize);
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picBox.MouseClick += mouseDownEventHandler;
                    picBox.Image = chooseImage(terem.Ertekeles[y, x]);
                }
            }

            
        }

        private void mouseDownEventHandler(object sender, MouseEventArgs e)
        {
            var picBox = (PictureBox)sender;
            var y = picBox.Location.Y / imgSize;
            var x = picBox.Location.X / imgSize;
            var terem = iskola.Gepteremek[currIndex];
            terem.Ertekeles[y, x] = cycleThrough(terem.Ertekeles[y, x]);
            picBox.Image = chooseImage(terem.Ertekeles[y, x]);
            this.Text = terem.Nev + $" ({terem.Atlag():.0})";
        }

        private Image chooseImage(int c)
        {
            if (c == 1) return Properties.Resources.Pont1;
            if (c == 2) return Properties.Resources.Pont2;
            if (c == 3) return Properties.Resources.Pont3;
            return Properties.Resources.Pont0;
        }

        private int cycleThrough(int c)
        {
            if (c == 0) { MessageBox.Show("Itt nem ül senki"); return c; }
            var newNum = (c + 1) % 4;
            if (newNum == 0) newNum++;
            return newNum;
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            move(1);
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            move(-1);
        }

        private void move(int add)
        {
            currIndex += add;
            button_left.Visible = true;
            button_right.Visible = true;
            if (currIndex == 0) button_left.Visible = false;
            if (currIndex == iskola.Gepteremek.Count - 1) button_right.Visible = false;
            LoadFilm(iskola.Gepteremek[currIndex]);
        }

        private void Backup()
        {
            File.Copy("petrikgepek.txt", "petrikgepek.bak", true);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Backup();
            try
            {
                Mentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt mentéskor: " + ex.Message, "Hiba");
                return;
            }
            MessageBox.Show("Mentés sikeres!");
        }

        private void Mentes()
        {
            var writer = new StreamWriter("petrikgepek.txt");
            foreach (var terem in iskola.Gepteremek)
            {
                writer.WriteLine(terem.Nev);
                writer.WriteLine(terem.SorDb + ";" + terem.HelyDb);
                for (int y = 0; y < terem.SorDb; y++)
                {
                        writer.WriteLine(String.Join(";",getRow(terem.Ertekeles,y)));
                }
                writer.WriteLine();
            }
            writer.Close();
        }

        private int[] getRow(int[,] matrix, int y)
        {   
            var row = new int[matrix.GetLength(1)];
            for (int x = 0; x < matrix.GetLength(1); x++)
            {
                row[x] = matrix[y, x];
            }
            return row;
        }
    }
}
