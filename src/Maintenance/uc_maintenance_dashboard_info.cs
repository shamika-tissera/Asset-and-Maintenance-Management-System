using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Maintenance
{
    public partial class uc_maintenance_dashboard_info : UserControl
    {
        private static Dashboard.MainDashboard inst;
        public uc_maintenance_dashboard_info()
        {
            InitializeComponent();
        }

        private void clickedBacklog()
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        public static void setDashboardInstance(Dashboard.MainDashboard instance)
        {
            inst = instance;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbl_uname_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //inst.clickedMaintenanceReccomendations();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //inst.clickedMaintenanceReccomendations();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           // inst.clickedMaintenanceReccomendations();
        }
    }
}
