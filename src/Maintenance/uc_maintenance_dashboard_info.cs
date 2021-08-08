using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;

namespace Asset_and_Maintenance_Management_System.src.Maintenance
{
    public partial class uc_maintenance_dashboard_info : UserControl
    {
        private static Dashboard.MainDashboard inst;
        public uc_maintenance_dashboard_info()
        {
            InitializeComponent();
            setLabelData();
        }

        public void setLabelData()
        {
            string queryBackLog =
                "select count(*) from NonCurrentAsset where DATEDIFF(day, serviceDue, getDate()) > 0;";
            string queryPreventive =
                "select count(*) from NonCurrentAsset where serviceDue <= DATEADD(month, 2, GETDATE()) and serviceDue >= DATEADD(month, -3, GETDATE());";
            string queryCorrective =
                "select count(*) from WorkerReports inner join NonCurrentAsset on WorkerReports.asset_id = NonCurrentAsset.asset_id inner join UserInfo on UserInfo.Username = WorkerReports.username where managerRespoded = 'true' and (performed = 0 or performed = null);";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(queryBackLog, connection))
                {
                    int data = int.Parse(command.ExecuteScalar().ToString());
                    lblPastDue.Text = data.ToString();
                }
                using (SqlCommand command = new SqlCommand(queryPreventive, connection))
                {
                    int data = int.Parse(command.ExecuteScalar().ToString());
                    lblPreventive.Text = data.ToString();
                }
                using (SqlCommand command = new SqlCommand(queryCorrective, connection))
                {
                    int data = int.Parse(command.ExecuteScalar().ToString());
                    lblCorrective.Text = data.ToString();
                }
            }
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

        private void uc_maintenance_dashboard_info_Load(object sender, EventArgs e)
        {

        }
    }
}
