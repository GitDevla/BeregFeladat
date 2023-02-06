using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
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

        private void button_save_Click(object sender, EventArgs e) {
            Backup();
            try {
                mozi.Mentes();
            } catch (Exception ex) {
                MessageBox.Show("Hiba történt mentéskor: " + ex.Message, "Hiba");
                return;
            }
            MessageBox.Show("Mentés sikeres!");
        }

        private void button_stats_Click(object sender, EventArgs e) {
            var date = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
            var fileName = "statisztika_" + date + ".txt";
            var writer = new StreamWriter(fileName);

            writer.WriteLine("1. Melyik teremben mennyi az értékesítésből származó bevétel, ha felnőtt jegy ár 1 700 Ft, a diák jegy ára 1 200 Ft?");
            foreach (var terem in mozi.termek)
                writer.WriteLine($"\t{terem.Nev}: {terem.Income()} Ft");

            var sum = mozi.termek.Sum(i => i.Income());
            writer.WriteLine("2. Mennyi a Corvin mozi teljes bevétele?: " + sum + "Ft");

            writer.WriteLine("3. Melyik teremben mi az üres helyek és az összes helyek aránya? Az eredményt százalékosan add meg két tizedesjegy pontossággal!");
            foreach (var terem in mozi.termek) 
                writer.WriteLine($"\t{terem.Nev}: {terem.ratio()*100:0.00} %");

            var duo = mozi.termek.First(i => i.findEmptyDuo() != null);
            var pos = duo.findEmptyDuo();
            writer.WriteLine("4. Melyik teremben van egymás mellett két üres szék?");
            writer.WriteLine($"A {duo.Nev} teremben a {pos.Value.y+1} sorban a {pos.Value.x} és {pos.Value.x+1} ülés");
            writer.Close();
            Process.Start(fileName);
        }
    }
}
