using System;
using System.Linq;
using System.Windows.Forms;

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
            textBox_type.Text = selected.Type.ToString();
            checkBox_isVegetarian.Checked = selected.Vegetarian;
            numericUpDown_price.Value = selected.Price;
        }
    }
}
