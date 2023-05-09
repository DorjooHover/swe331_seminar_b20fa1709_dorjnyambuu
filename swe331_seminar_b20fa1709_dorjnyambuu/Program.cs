using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swe331_seminar_b20fa1709_dorjnyambuu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RSK8I6S;Initial Catalog=Northwind;Integrated Security=True");
            GlobalVar.Connection = conn;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
