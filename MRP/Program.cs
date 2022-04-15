using MRP.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //MRPMain mRP = new MRPMain();
            //MyApplicationContext context = new MyApplicationContext();
            Application.Run(new MRPMain());

        }

        public class MyApplicationContext : ApplicationContext
        {
            private MRPMain form1 = new MRPMain();

            public MyApplicationContext()
            {
                form1 = new MRPMain();
                form1.Show();
            }
        }
    }
}
