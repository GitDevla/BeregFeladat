using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrvosiNobeldijasokGUI {
    public partial class Window : Form {
        public Window() {
            InitializeComponent();
        }
        private readonly SQL database = new SQL("localhost", "root", "", "nobel");

        private void button_save_Click(object sender, EventArgs e) {
            var error = testUserInput();
            if(error != "") {
                MessageBox.Show(error, "Hiba");
                return;
            }
            int[] birthDeath = textBox_birthDate.Text.Split('-').Select(i=>int.Parse(i)).ToArray();
            Award award = new Award() {
                Year = int.Parse(textBox_year.Text),
                Name = textBox_name.Text,
                Birth = birthDeath[0],
                Death = birthDeath[1],
                Country = textBox_country.Text
            };
            addAward(award);
            clearInputFields();
        }

        private void clearInputFields() {
            textBox_year.Clear();
            textBox_name.Clear();
            textBox_birthDate.Clear();
            textBox_country.Clear();
        }

        private string testUserInput() {
            if (string.IsNullOrWhiteSpace(textBox_name.Text)
                || string.IsNullOrWhiteSpace(textBox_year.Text)
                || string.IsNullOrWhiteSpace(textBox_birthDate.Text)
                || string.IsNullOrWhiteSpace(textBox_country.Text))
                return "Töltsön ki minden mezőt!";

            if (!Regex.IsMatch(textBox_year.Text, "^[0-9]{4}$")
                || int.Parse(textBox_year.Text)<1989)
                return "Hiba! Az évszám nem megfelelő!";

            if (!Regex.IsMatch(textBox_birthDate.Text, "^[0-9]{4}-[0-9]{4}$"))
                return "Hibás születés/halálozási idő (pl. 1893-1985)!";

            return "";
        }

        private void addAward(Award award) {
            try {
                database.Query($@"INSERT INTO `awards` (`got_award_in`, `name`, `birth`, `death`, `country`)
                                VALUES ('{award.Birth}', '{award.Name}', '{award.Birth}', '{award.Death}', '{award.Country}')");
                // valn: SQL injection
                MessageBox.Show("Sikeres hozzádas");
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void Window_Load(object sender, EventArgs e) {
            try {
                database.Query("SELECT '' FROM `awards`;");
            } catch (Exception) {
                MessageBox.Show("Nincs adatbázis csatlakoztatva\nImportálja be az adatbázist a database.sql file-ból");
                Environment.Exit(1);
            }
        }
    }
}
