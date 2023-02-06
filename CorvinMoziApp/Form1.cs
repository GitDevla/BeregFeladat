using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CorvinMoziApp {
    public partial class Form1 : Form {
        public Mozi mozi = new Mozi("CorvinMozi.csv");
        int currIndex = 0;
        int imgSize = 35;

        public Form1() {
            InitializeComponent();
            LoadFilm(mozi.termek[currIndex]);
        }

        private void button_left_Click(object sender, EventArgs e) {
            move(-1);
        }

        private void button_right_Click(object sender, EventArgs e) {
            move(1);
        }

        private void move(int add) {
            currIndex += add;
            button_left.Visible = true;
            button_right.Visible = true;
            if (currIndex == 0) button_left.Visible = false;
            if (currIndex == mozi.termek.Count - 1) button_right.Visible = false;
            LoadFilm(mozi.termek[currIndex]);
        }

        private void LoadFilm(Terem terem) {
            this.Text = terem.Nev + " terem";
            pictureBox.BackgroundImage = terem.Nevadokep;

            panel.Controls.Clear();
            panel.Width = terem.Szekek * imgSize;
            panel.Height = terem.Sorok * imgSize;

            for (int y = 0; y < terem.Sorok; y++) {
                for (int x = 0; x < terem.Szekek; x++) {
                    var picBox = new PictureBox();
                    panel.Controls.Add(picBox);
                    picBox.Location = new Point(x * imgSize, y * imgSize);
                    picBox.Size = new Size(imgSize, imgSize);
                    picBox.SizeMode = PictureBoxSizeMode.Zoom;
                    picBox.MouseClick += mouseDownEventHandler;
                    picBox.Image = chooseImage(terem.Ulesek[y, x]);
                }
            }
        }

        private Image chooseImage(char c) {
            if (c == 'F') return Properties.Resources.felnott;
            if (c == 'D') return Properties.Resources.gyerek;
            return Properties.Resources.ures;
        }

        private char cycleThrough(char c) {
            if (c == 'F') return 'D';
            if (c == 'D') return (char)0;
            return 'F';
        }

        private void mouseDownEventHandler(object sender, MouseEventArgs e) {
            var picBox = (PictureBox)sender;
            var y = picBox.Location.Y / imgSize;
            var x = picBox.Location.X / imgSize;
            var terem = mozi.termek[currIndex];
            terem.Ulesek[y, x] = cycleThrough(terem.Ulesek[y, x]);
            picBox.Image = chooseImage(terem.Ulesek[y, x]);
        }

        private void Backup() {
            var date = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString();
            File.Copy("CorvinMozi.csv", "backup_" + date + ".txt", true);
        }

        private void Serialize() {
            var writer = new StreamWriter("CorvinMozi.csv");
            foreach (var terem in mozi.termek) {
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

        private void button_save_Click(object sender, EventArgs e) {
            Backup();
            try {
                Serialize();
            } catch (Exception ex) {
                MessageBox.Show("Hiba történt mentéskor: " + ex.Message, "Hiba");
                return;
            }
            MessageBox.Show("Mentés sikeres!");
        }
    }
}
