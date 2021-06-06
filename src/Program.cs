using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_and_Maintenance_Management_System.src.Dashboard;

namespace Asset_and_Maintenance_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string fileRelPath = "../../prog_settings/startup.txt";
            bool status;
            if (File.Exists(fileRelPath))
            {
                String val = File.ReadAllText(fileRelPath);
                if (val == "true")
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            else
            {
                File.WriteAllText(fileRelPath, "false");
                status = false;
            }

            if (status == true)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Dashboard());
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new startup_main());
            }
        }
    }
}
