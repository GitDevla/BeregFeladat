using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hazi_Gyumolcs {
    public partial class Window : Form {
        readonly SQL database = new SQL("localhost", "root", "", "gyumolcsok");
        public Window() {
            InitializeComponent();
        }

        /* Event Handlers */

        private void Window_Load(object sender, EventArgs e) {
            TestConnection();
            updateList();
        }

        private void listBox_fruits_SelectedIndexChanged(object sender, EventArgs e) {
            var selected = (Fruit)listBox_fruits.SelectedItem;
            if (selected is null) return;
            textBox_id.Text = selected.Id.ToString();
            textBox_name.Text = selected.Name;
            numericUpDown_price.Value = selected.Price;
            numericUpDown_quantity.Value = selected.Quantity;
        }

        private void button_create_Click(object sender, EventArgs e) {
            if (!TestInput()) return;
            var fruit = createFruitFromInput();
            createFruit(fruit);
            updateList();
        }

        private void button_update_Click(object sender, EventArgs e) {
            if (!TestInput()) return;
            var from = (Fruit)listBox_fruits.SelectedItem;
            if (from is null) return;
            var to = createFruitFromInput();
            updateFruit(from, to);
            updateList();
        }

        private void button_delete_Click(object sender, EventArgs e) {
            var fruit = (Fruit)listBox_fruits.SelectedItem;
            if (fruit is null) return;
            removeFruit(fruit);
            updateList();
        }

        /* CRUDs */

        private void createFruit(Fruit fruit) {
            database.Query("INSERT INTO `gyumolcs` (`nev`, `egysegar`, `mennyiseg`) VALUES (@1, @2, @3);"
                , fruit.Name, fruit.Price, fruit.Quantity);
        }

        private List<Fruit> getAllFruits() {
            var res = database.Query("SELECT `id`, `nev`, `egysegar`, `mennyiseg` FROM `gyumolcs`;");
            List<Fruit> fruits = new List<Fruit>();
            foreach (var item in res.Values) {
                var id = int.Parse(item[0]);
                var name = item[1];
                var price = int.Parse(item[2]);
                var quantity = int.Parse(item[3]);
                fruits.Add(new Fruit(id, name, price, quantity));
            }
            return fruits;
        }

        private void updateFruit(Fruit from, Fruit to) {
            database.Query("UPDATE `gyumolcs` SET `nev` = @1, `egysegar` = @2, `mennyiseg` = @3 WHERE `gyumolcs`.`id` = @id;",
                from.Id, to.Name, to.Price, to.Quantity);
        }

        private void removeFruit(Fruit fruit) {
            database.Query("DELETE FROM gyumolcs WHERE `gyumolcs`.`id` = @1;", fruit.Id);
        }

        /* Helpers */
        private void Alert(string alert) {
            MessageBox.Show(alert, "Hiba");
        }

        private void updateList() {
            listBox_fruits.Items.Clear();
            foreach (var item in getAllFruits())
                listBox_fruits.Items.Add(item);
        }

        private bool TestInput() {
            if (string.IsNullOrWhiteSpace(textBox_name.Text)) {
                Alert("A név nem lehet üres");
                textBox_name.Focus();
                return false;
            }
            return true;
        }

        private Fruit createFruitFromInput() {
            var name = textBox_name.Text;
            var price = (int)numericUpDown_price.Value;
            var quantity = (int)numericUpDown_quantity.Value;
            return new Fruit(0, name, price, quantity);
        }

        private void TestConnection() {
            try {
                database.Query("SELECT '' FROM `gyumolcs`;");
            } catch (Exception) {
                MessageBox.Show("Nincs adatbázis csatlakoztatva\nImportálja be az adatbázist a database.sql file-ból");
                Environment.Exit(1);
            }
        }
    }
}
