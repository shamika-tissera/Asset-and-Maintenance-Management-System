using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;
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

namespace Asset_and_Maintenance_Management_System.src.Maintenance
{
    public partial class uc_corrective_maintenance : UserControl
    {
        public uc_corrective_maintenance()
        {
            InitializeComponent();
            populateDataGridView();
        }
        public void populateDataGridView()
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
                        table.Columns.Add("Performed", typeof(bool));
                        dataGridViewCorrectiveMaintenance.DataSource = table;
                    }
                }
            }
            for (int i = 0; i < dataGridViewCorrectiveMaintenance.Columns.Count; i++)
            {
                dataGridViewCorrectiveMaintenance.Columns[i].Width = 118;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewCorrectiveMaintenance.Rows)
            {
                string a = row.Cells["Performed"].Value.ToString();
                int b = dataGridViewCorrectiveMaintenance.Rows.Count;
                if (row.Cells["Performed"].Value.ToString() == "True")
                {
                    string assetCode = row.Cells["Asset Code"].Value.ToString();

                    string query =
                        "update WorkerReports set performed = 1 where asset_id = '" + assetCode + "';";
                    isChecked = true;
                    using (SqlConnection connection = DBConnection.establishConnection())
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                command.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                TextWriter.writeContent("logs.txt", ex.ToString());
                            }
                        }
                    }
                    dataGridViewCorrectiveMaintenance.Rows.RemoveAt(row.Index);
                }
            }

            if (!isChecked)
            {
                MessageBox.Show("Please select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Successfully recorded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
