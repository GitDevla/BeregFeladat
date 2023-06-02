using System;
using System.Windows.Forms;

namespace Hazi_Etelek {
    partial class Modify : Form {
        Food Food;
        public Modify(Food food) {
            InitializeComponent();
            Food = food;
        }

        private void LoadTypes() {
            comboBox_types.Items.Clear();
            foreach (var item in Type.DBRead(Program.database)) {
                comboBox_types.Items.Add(item);
            }
        }

        private void Modify_Load(object sender, EventArgs e) {
            LoadTypes();
            textBox_name.Text = Food.Name;
            var type = Food.GetTType(Program.database);
            Type xd = null;
            foreach (Type item in comboBox_types.Items) {
                if (item.Id == type.Id) xd = item;
            }
            comboBox_types.SelectedItem = xd;
            checkBox_isVegetarian.Checked = Food.Vegetarian;
            numericUpDown_price.Value = Food.Price;
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void button_edit_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(textBox_name.Text)
                || comboBox_types.SelectedItem is null)
            {
                DLib.FormsUtil.Error("Valmi nincs kitöltve");
                return;
            }
            var food = new Food(0,
                textBox_name.Text,
                ((Type)comboBox_types.SelectedItem).Id,
                checkBox_isVegetarian.Checked,
                (int)numericUpDown_price.Value);
            Food.DBUpdate(Program.database, food);
            Close();
        }
    }
}
