using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda
{
    static class Program
    {
        //static string providerName= "System.Data.SqlClient";
        public static string providerName = "MySql.Data.MySqlClient";
       public static string connectionStr= "Server=localhost;Database=db_agenda;Uid=root;Pwd=mysql123!;";

        [STAThread]
        static void Main()
        {
            DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                
            List<compromisso> agenda = new();

            Application.Run(new FormAgenda(agenda));


        }
    }
}
