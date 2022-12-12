using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hazi_Feljegyzes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                openFileDialog.AddExtension = true;
                var path = openFileDialog.FileName;
                if(string.IsNullOrWhiteSpace(path)) return;
                textBox_name.Text = openFileDialog.SafeFileName;
                richTextBox.Text = File.ReadAllText(path);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = textBox_name.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                var date = dateTimePicker_date.Value;
                var path = saveFileDialog.FileName;
                File.AppendAllText(path, $"\n====={date}=====\n");
                File.AppendAllLines(path,richTextBox.Text.Split('\n').Where(i=>!i.Contains("=====")));
                richTextBox.Text = File.ReadAllText(path);
            }
        }
    }
}
