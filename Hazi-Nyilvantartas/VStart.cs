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

        private void listBox_users_SelectedIndexChanged(object sender, EventArgs e) {
            var selected = (User)listBox_users.SelectedItem;
            if (selected is null) return;
            DisplayUser(selected);
        }
    }
}
