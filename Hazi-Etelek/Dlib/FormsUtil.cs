using System;
using System.Windows.Forms;

namespace DLib {
    static class FormsUtil {
        static public void FatalError(string text) {
            MessageBox.Show(text + "\nA Program most leáll", "Kritikus hiba");
            Environment.Exit(1);
        }

        static public void Error(string text) {
            MessageBox.Show(text, "Hiba");
        }
    }
}
