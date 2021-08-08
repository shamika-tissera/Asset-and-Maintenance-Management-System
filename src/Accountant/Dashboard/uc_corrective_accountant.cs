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
using Asset_and_Maintenance_Management_System.src.Maintenance;

namespace Asset_and_Maintenance_Management_System.src.Accountant.Dashboard
{
    public partial class uc_corrective_accountant : uc_corrective_maintenance
    {
        public uc_corrective_accountant()
        {
            InitializeComponent();
        }
        public override void populateDataGridView()
        {
            string query = "select WorkerReports.asset_id as 'Asset Code', NonCurrentAsset.assetType as 'Asset Name', (UserInfo.FirstName + ' ' + UserInfo.LastName) as 'Reporter', WorkerReports.reported_date as 'Reported Date', NonCurrentAsset.plant as 'Plant', WorkerReports.criticality_machineOperations as 'Machine Criticality', WorkerReports.criticality_activityConstraints as 'Operational Bottleneck', WorkerReports.message as 'Description' from WorkerReports inner join NonCurrentAsset on WorkerReports.asset_id = NonCurrentAsset.asset_id inner join UserInfo on UserInfo.Username = WorkerReports.username where managerRespoded = 'true' and (performed = 0 or performed = null);";
            DataTable table = new DataTable();
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        //table.Columns.Add("Performed", typeof(bool));
                        dataGridViewCorrectiveMaintenance.DataSource = table;
                    }
                }
            }
            for (int i = 0; i < dataGridViewCorrectiveMaintenance.Columns.Count; i++)
            {
                dataGridViewCorrectiveMaintenance.Columns[i].Width = 136;
            }
        }
    }
}
