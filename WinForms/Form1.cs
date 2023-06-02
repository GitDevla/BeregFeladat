using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void test_button_Click(object sender, EventArgs e)
        {
            List<string> hibak = new List<string>();
            if (id_input.Value == 0) hibak.Add("Azonosító");
            if (string.IsNullOrWhiteSpace(name_input.Text)) hibak.Add("Név");
            if (lang_input.SelectedIndex == -1) hibak.Add("Nyelv");
            if (birthDate_input.Value > DateTime.Today) hibak.Add("Születési idő");
            if (birthPlace_input.SelectedIndex == -1) hibak.Add("Születési hely");
            if(hibak.Count != 0)
            {
                MessageBox.Show("A követkető adatok nincsenek megadva: " + string.Join(", ", hibak)
                    ,"Hiba",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Minden Jó","OK",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
