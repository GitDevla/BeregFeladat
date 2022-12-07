using System;
using System.Linq;
using System.Windows.Forms;
using DLib;

namespace Hazi_Etelek {
    public partial class Home : Form {
        public Home() {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e) {
            LoadTypes();
            LoadFoods();
        }

        private void LoadTypes() {
            comboBox_types.Items.Clear();
            comboBox_types.Items.Add(new Type(0, "Minden"));
            foreach (var item in Type.DBRead(Program.database)) {
                comboBox_types.Items.Add(item);
            }
            comboBox_types.SelectedIndex = 0;
        }

        private void LoadFoods() {
            var filter = (Type)comboBox_types.SelectedItem;
            listBox_foods.Items.Clear();
            if (filter.Id == 0) {
                foreach (var item in Food.DBRead(Program.database)) {
                    listBox_foods.Items.Add(item);
                }
            } else {
                foreach (var item in Food.DBRead(Program.database).Where(i=>i.Type == filter.Id)) {
                    listBox_foods.Items.Add(item);
                }
            }
        }

        private void comboBox_types_SelectedIndexChanged(object sender, EventArgs e) {
            LoadFoods();
        }

        private void listBox_foods_SelectedIndexChanged(object sender, EventArgs e) {
            var selected = (Food)listBox_foods.SelectedItem;
            textBox_name.Text = selected.Name;
            textBox_type.Text = selected.GetTType(Program.database).Name;
            checkBox_isVegetarian.Checked = selected.Vegetarian;
            numericUpDown_price.Value = selected.Price;
        }

        private void clearOuput()
        {
            textBox_name.Text = "";
            textBox_type.Text = "";
            checkBox_isVegetarian.Checked = false;
            numericUpDown_price.Value = 0;
        }

        private void button_delete_Click(object sender, EventArgs e) {
            var selected = (Food)listBox_foods.SelectedItem;
            if (selected is null) {
                FormsUtil.Error("Nincs kiválasztva semmi");
                return;
            }
            var res = MessageBox.Show($"Biztos benne hogy kitörli a \"{selected.Name}\"-t ?", "", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes) {
                selected.DBDelete(Program.database);
                LoadFoods();
                clearOuput();
            }
        }

        private void button_edit_Click(object sender, EventArgs e) {
            var selected = (Food)listBox_foods.SelectedItem;
            if (selected is null) {
                FormsUtil.Error("Nincs kiválasztva semmi");
                return;
            }
            new Modify(selected).ShowDialog();
            LoadFoods();
        }

        private void button_new_Click(object sender, EventArgs e) {
            new Create().ShowDialog();
            LoadFoods();
            listBox_foods.SelectedIndex = listBox_foods.Items.Count - 1;
        }
    }
}
