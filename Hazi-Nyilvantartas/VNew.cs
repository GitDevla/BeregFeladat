using System;
using System.IO;
using System.Windows.Forms;

namespace Hazi_Nyilvantartas {
    public partial class VNew : Form {
        public VNew() {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBox_name.Text)
                || dateTimePicker.Value > DateTime.Now) {
                DLib.FormsUtil.Error("Hibás adatok");
                return;
            }
            var user = new User(0, textBox_name.Text, dateTimePicker.Value);
            user.DBCreate();
            var id = User.LastId();
            pictureBox.Image.Save(".\\img\\" + id);
            Close();
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
    }
}
