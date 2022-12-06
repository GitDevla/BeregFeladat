using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hazi_Etelek {
    public partial class Create : Form {
        public Create() {
            InitializeComponent();
            LoadTypes();
        }
        private void LoadTypes() {
            comboBox_types.Items.Clear();
            foreach (var item in Type.DBRead(Program.database)) {
                comboBox_types.Items.Add(item);
            }
        }
        private void button_edit_Click(object sender, EventArgs e) {
            var food = new Food(0,
                textBox_name.Text,
                ((Type)comboBox_types.SelectedItem).Id,
                checkBox_isVegetarian.Checked,
                (int)numericUpDown_price.Value);
            food.DBCreate(Program.database);
            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
