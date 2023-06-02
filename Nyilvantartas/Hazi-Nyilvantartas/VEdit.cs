using System;
using System.IO;
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
                pictureBox.ImageLocation = ".\\img\\" + user.Id;
            else
                pictureBox.ImageLocation = ".\\img\\ missing.png";
        }

        private void button_picture_Click(object sender, EventArgs e) {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            if (!File.Exists(openFileDialog.FileName)) return;
            pictureBox.ImageLocation = openFileDialog.FileName;
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
            if (openFileDialog.SafeFileName != "") {
                File.Delete(".\\img\\" + user.Id);
                pictureBox.Image.Save(".\\img\\" + user.Id);
            }
            Close();
        }
    }
}
