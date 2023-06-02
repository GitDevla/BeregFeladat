using DLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LakoparkProjekt
{
    internal static class Program
    {

        static public SQL Database = new DLib.SQL("localhost", "root", "", "lakopark");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                var a = Database.TestConnection();
                if (!a) throw new Exception("Nem lehet csatlakozni az adatbázishoz");
            }
            catch (Exception e)
            {
                FormsUtil.FatalError(e.Message);
            }
            Application.Run(new MainForm());
        }
    }
}
