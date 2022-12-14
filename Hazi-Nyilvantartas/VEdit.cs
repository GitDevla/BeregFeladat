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
    public partial class VEdit : Form {
        User user;
        public VEdit(User user) {
            InitializeComponent();
            this.user = user;
        }

        private void VEdit_Load(object sender, EventArgs e) {
            textBox_name.Text = user.Name;
            dateTimePicker.Value = user.Birth;
            if (File.Exists(".\\img\\" + user.Id))
                pictureBox.Image = Image.FromFile(".\\img\\" + user.Id);
            else
                pictureBox.Image = Image.FromFile(".\\img\\missing.png");
        }

        private void button_picture_Click(object sender, EventArgs e) {
            pictureBox.Image.Dispose();
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            if (!File.Exists(openFileDialog.FileName)) return;
            pictureBox.Image = Image.FromFile(openFileDialog.FileName);
            button_picture.Text = openFileDialog.SafeFileName;
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void button_ok_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBox_name.Text)
                || dateTimePicker.Value > DateTime.Now) {
                DLib.FormsUtil.Error("Hibás adatok");
                return;
            }
            var newUser = new User(0, textBox_name.Text, dateTimePicker.Value);
            user.DBUpdate(newUser);
            File.Delete(".\\img\\" + user.Id);
            pictureBox.Image.Save(".\\img\\" + user.Id);
            Close();
        }
    }
}
