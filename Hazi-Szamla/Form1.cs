using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hazi_Szamla
{
    public partial class window : Form
    {
        readonly SQL database = new SQL("localhost", "root", "", "szamlak");
        public window()
        {
            InitializeComponent();
        }

        private void window_Load(object sender, EventArgs e)
        {
            TestConnection();
            updateList();
        }

        private void updateList()
        {
            listBox_checks.Items.Clear();
            foreach (var item in getAllChecks())
                listBox_checks.Items.Add(item);
        }

        private List<Check> getAllChecks()
        {
            var res = database.Query("SELECT * FROM `szamlak`;");
            List<Check> checks = new List<Check>();
            foreach (var item in res.Values)
            {
                var id = int.Parse(item[0]);
                var name = item[1];
                var balance = int.Parse(item[2]);
                var date = DateTime.Parse(item[3]);
                checks.Add(new Check(id, name, balance, date));
            }
            return checks;
        }

        private void listBox_checks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Check)listBox_checks.SelectedItem;
            if (selected is null) return;
            textBox_id.Text = selected.Id.ToString();
            textBox_name.Text = selected.Name;
            numericUpDown_balance.Value = selected.Balance;
            dateTimePicker_date.Value = selected.Date;
        }

        private void TestConnection()
        {
            try
            {
                database.Query("SELECT '' FROM `szamlak`;");
            }
            catch (Exception)
            {
                MessageBox.Show("Nincs adatbázis csatlakoztatva\nImportálja be az adatbázist a database.sql file-ból");
                Environment.Exit(1);
            }
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (!TestInput()) return;
            var check = createCheckFromInput();
            createCheck(check);
            updateList();
        }

        private void createCheck(Check check)
        {
            database.Query("INSERT INTO `szamlak` (`tulajdonosNeve`, `egyenleg`, `nyitasdatum`) VALUES (@1, @2, @3);"
                , check.Name, check.Balance, check.Date);
        }
        private bool TestInput()
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                Alert("A név nem lehet üres");
                textBox_name.Focus();
                return false;
            }
            return true;
        }

        private Check createCheckFromInput()
        {
            var name = textBox_name.Text;
            var balane = (int)numericUpDown_balance.Value;
            var date = dateTimePicker_date.Value;
            return new Check(0, name, balane, date);
        }
        private void Alert(string alert)
        {
            MessageBox.Show(alert, "Hiba");
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (!TestInput()) return;
            var from = (Check)listBox_checks.SelectedItem;
            if (from is null) return;
            var to = createCheckFromInput();
            updateCheck(from, to);
            updateList();
        }

        private void updateCheck(Check from, Check to)
        {
            database.Query("UPDATE `szamlak` SET `tulajdonosNeve` = @1, `egyenleg` = @2, `nyitasdatum` = @3 WHERE `id` = @4;",
                to.Name, to.Balance, to.Date,from.Id);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var check = (Check)listBox_checks.SelectedItem;
            if (check is null) return;
            updateCheck(check);
            updateList();
        }

        private void updateCheck(Check check)
        {
            database.Query("DELETE FROM szamlak WHERE `id` = @1;", check.Id);
        }
    }
}
