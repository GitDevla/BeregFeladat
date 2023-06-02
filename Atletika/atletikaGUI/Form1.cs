using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace atletikaGUI {
    public partial class Window : Form {
        public Window() {
            InitializeComponent();
        }
        private readonly SQL database = new SQL("localhost", "root", "", "atletikavb2017");

        private void Window_Load(object sender, EventArgs e) {
            var events = getEvents();
            foreach (var @event in events.Values)
                listBox_events.Items.Add(@event[0]);
        }

        private void button_nations_Click(object sender, EventArgs e) {
            var nations = getGoldenNations();
            foreach (var nation in nations.Values)
                listBox_nations.Items.Add(nation[0]);
            button_nations.Hide();
        }

        private void button_search_Click(object sender, EventArgs e) {
            string @event = (string)listBox_events.SelectedItem;
            int placement = (int)numericUpDown_placement.Value;
            if (1 > placement || placement > 3) {
                Error("Csak érmes helyezéseket tartalmaz a statisztika!");
                return;
            }
            if (string.IsNullOrWhiteSpace(@event)) {
                Error("Nem választott ki versenyszámot!");
                return;
            }
            var con = findPerson(@event, placement);
            label_name.Text = con.Values[0][0];
            label_score.Text = con.Values[0][1];
            label_nation.Text = con.Values[0][2];
        }

        public void Error(string msg) {
            MessageBox.Show(msg, "Hiba");
        }

        // -----
        private QueryResponse Query(string query) {
            try {
                return database.Query(query);
            } catch (MySqlException e) {
                Error("Adatbázis hiba:\n" + e.Message);
                Environment.Exit(0);
                return null;
            }
        }

        private QueryResponse getEvents() {
            return Query(@"SELECT DISTINCT`Versenyszam` FROM `versenyekszamok`;");
        }

        private QueryResponse getGoldenNations() {
            return Query(@"SELECT DISTINCT Nemzet FROM versenyekszamok 
                            join nemzetek on NemzetKod = NemzetId
                            where Helyezes = 1;");
        }

        private QueryResponse findPerson(string @event, int placement) {
            return Query($@"SELECT `VersenyzoNev`,`Eredmeny`,`Nemzet` FROM versenyekszamok
                            join nemzetek on NemzetKod=NemzetId
                            where Versenyszam='{@event}' AND Helyezes='{placement}';");
        }
    }
}
