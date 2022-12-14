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

namespace Hazi_Nyilvantartas {
    public partial class VStart : Form {
        public VStart() {
            InitializeComponent();
        }

        private void VStart_Load(object sender, EventArgs e) {
            LoadUsers();
        }

        private void LoadUsers() {
            listBox_users.Items.Clear();
            foreach (var item in User.DBRead())
                listBox_users.Items.Add(item);
        }

        private void DisplayUser(User user) {
            textBox_name.Text = user.Name;
            dateTimePicker.Value = user.Birth;
            if (File.Exists(".\\img\\" + user.Id))
                pictureBox.Image = Image.FromFile(".\\img\\" + user.Id);
            else
                pictureBox.Image = Image.FromFile(".\\img\\missing.png");
        }

        private void Clear() {
            textBox_name.Text = "";
            dateTimePicker.Value = DateTime.Today;
            pictureBox.Image.Dispose();
            pictureBox.Image = null;
        }

        private void listBox_users_SelectedIndexChanged(object sender, EventArgs e) {
            var selected = (User)listBox_users.SelectedItem;
            if (selected is null) return;
            DisplayUser(selected);
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e) {
            new VNew().ShowDialog();
            LoadUsers();
        }

        private void törölToolStripMenuItem_Click(object sender, EventArgs e) {
            var selected = (User)listBox_users.SelectedItem;
            if (selected is null) return;
            var res = MessageBox.Show($"Biztosan ki akarod törölni a {selected.Name} nevű felhasználót?","U sure",MessageBoxButtons.YesNo);
            if (res != DialogResult.Yes) return;
            Clear();
            selected.DBDelete();
            File.Delete(".\\img\\" + selected.Id);
            LoadUsers();
        }
    }
}
