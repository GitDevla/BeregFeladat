using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Hazi_Lotto {
    public partial class Form1 : Form {
        private List<int> selected = new List<int>(5);

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            fillPanel();
        }

        private void fillPanel() {
            var panel = flowLayoutPanel;
            //panel.MaximumSize = panel.Size;
            const int size = 50;
            for (int i = 1; i < 91; i++) {
                var button = new Button();
                button.Width = size;
                button.Height = size;
                button.Margin = new Padding(0);
                button.Text = i.ToString();
                button.BackColor = Color.AliceBlue;
                button.Click += onclick;
                panel.Controls.Add(button);
            }
        }

        private void onclick(object sender, EventArgs e) {
            var button = (Button)sender;
            var value = int.Parse(button.Text);
            if (selected.Contains(value)) {
                button.BackColor = Color.AliceBlue;
                selected.Remove(value);
            } else {
                if (selected.Count >= 5) return;
                button.BackColor = Color.Red;
                selected.Add(value);
            }
            updateSelectedNums();
        }

        private void updateSelectedNums() {
            selected.Sort();
            label_playedNums.Text = string.Join(", ", selected);
        }

        private void updateWinnerNums(int[] nums) {
            Array.Sort(nums);
            label_winnerNums.Text = string.Join(", ", nums);
        }

        private void updateCorrectNums(int[] nums) {
            Array.Sort(nums);
            label_wonNums.Text = string.Join(", ", nums);
        }

        private void button_bet_Click(object sender, EventArgs e) {
            if (selected.Count < 5) {
                MessageBox.Show("Kérem válaszon ki 5 számot!");
                return;
            }
            var winnerNums  = rollNums();
            updateWinnerNums(winnerNums);
            var correct = winnerNums.Where(i => selected.Contains(i)).ToArray();
            updateCorrectNums(correct);
            // if (correct.Length == 0) {
            //     MessageBox.Show("Sajnos nem talált");
            // }
        }

        private static int[] rollNums() {
            HashSet<int> rolls = new HashSet<int>();
            var rng = new Random();
            while (rolls.Count < 5)
                rolls.Add(rng.Next(1, 91));
            return rolls.ToArray();
        }
    }
}
