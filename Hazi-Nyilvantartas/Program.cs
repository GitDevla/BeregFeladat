using DLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hazi_Nyilvantartas {
    static class Program {
        public static readonly SQL database = new SQL("localhost", "root", "", "nyilvantartas");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!database.TestConnection())
                FormsUtil.FatalError("Adatbázis nincs csatlakoztatva vagy rosszul van beimportálva");
            User.db = database;
            Application.Run(new VStart());
        }
    }
}
