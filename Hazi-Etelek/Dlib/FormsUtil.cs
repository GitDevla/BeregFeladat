using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLib {
    static class FormsUtil {
        static public void FatalError(string text) {
            MessageBox.Show(text+"\nA Program most leáll","Kritikus hiba");
            Environment.Exit(1);
        }
    }
}
