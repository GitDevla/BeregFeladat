using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace atletikaGUI {
    public partial class Window : Form {
        public Window() {
            InitializeComponent();
        }
        private readonly SQL database = new SQL("localhost", "root", "", "atletikavb2017");
        private QueryResponse Query(string query) {
            try {
                return database.Query(query);
            } catch (MySqlException e) {
                MessageBox.Show("Adatbázis hiba:\n"+e.Message,"Hiba");
                Environment.Exit(0);
                return null;
            }
        }

        private void Window_Load(object sender, EventArgs e) {
            var nations = Query("SELECT `NemzetId`,`Nemzet` FROM `nemzetek`;");
            foreach (var nation in nations.Values) 
                listBox_nations.Items.Add(nation[1]);

            var events = Query("SELECT DISTINCT`Versenyszam` FROM `versenyekszamok`;");
            foreach (var @event in events.Values)
                listBox_events.Items.Add(@event[0]);
        }
    }
}
