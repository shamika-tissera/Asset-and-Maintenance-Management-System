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

namespace Asset_and_Maintenance_Management_System.src.Approval
{
    public partial class uc_employee_requests : UserControl
    {
        public uc_employee_requests()
        {
            InitializeComponent();
            populateDataGridView();
        }
        private void populateDataGridView()
        {
            string getQuery = "select WorkerReports.asset_id as 'Asset Code', NonCurrentAsset.assetType as 'Asset Name', (UserInfo.FirstName + ' ' + UserInfo.LastName) as 'Reporter', WorkerReports.reported_date as 'Reported Date', NonCurrentAsset.plant as 'Plant', WorkerReports.criticality_machineOperations as 'Machine Criticality', WorkerReports.criticality_activityConstraints as 'Operational Bottleneck', WorkerReports.message as 'Description' from WorkerReports inner join NonCurrentAsset on WorkerReports.asset_id = NonCurrentAsset.asset_id inner join UserInfo on UserInfo.Username = WorkerReports.username where managerRespoded = 0;";
            string updateQuery = "update WorkerReports set managerRespoded = 1 where managerRespoded = 0;";

            string query = "select InventoryOrder.inventoryCode as 'Stock Code', inventoryName as 'Stock Name', orderedQuantity as 'Ordered Quantity', supplierName as 'Supplier Name', (orderedQuantity * CurrentCost) as 'Estimated Cost (Rs.)' from InventoryOrder inner join Supplier on InventoryOrder.supplierID = Supplier.supplierID inner join InventoryItem on InventoryItem.inventoryCode = InventoryOrder.inventoryCode where received = 'false';";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(getQuery, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataTable data = new DataTable())
                        {
                            adapter.Fill(data);
                            data.Columns.Add("Approve", typeof(bool));
                            dataGridViewEmployeeRequests.AllowUserToAddRows = false;
                            dataGridViewEmployeeRequests.DataSource = data;
                            //dataGridViewMain.Columns.Add("Received", typeof(bool));
                            for (int i = 0; i < dataGridViewEmployeeRequests.Columns.Count; i++)
                            {
                                //dataGridViewEmployeeRequests.Columns[i].Width = 150;
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string machineCriticality;
            string operationalBottleneck;
            string plant;
            string reportedDate;
            string description;

            bool isChecked = false;

            foreach (DataGridViewRow row in dataGridViewEmployeeRequests.Rows)
            {
                try
                {
                    string a = row.Cells["Machine Criticality"].ToString();
                    int b = dataGridViewEmployeeRequests.Rows.Count;
                    if (row.Cells["Approve"].Value.ToString() == "True")
                    {
                        machineCriticality = row.Cells["Machine Criticality"].Value.ToString();
                        operationalBottleneck = row.Cells["Operational Bottleneck"].Value.ToString();
                        plant = row.Cells["Plant"].Value.ToString();
                        reportedDate = row.Cells["Reported Date"].Value.ToString();
                        description = row.Cells["Description"].Value.ToString();
                        
                        string query = "UPDATE WorkerReports SET managerRespoded = 'TRUE' WHERE criticality_machineOperations = '" + machineCriticality + "' AND criticality_activityConstraints = '" + operationalBottleneck + "' AND plant = '" + plant + "' AND reported_date = '" + reportedDate + "' AND message = '" + description + "'";
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
                        dataGridViewEmployeeRequests.Rows.RemoveAt(row.Index);
                    }
                }
                catch (NullReferenceException ex)
                {
                    TextWriter.writeContent("logs.txt", ex.ToString());
                    break;
                }
            }
            if (!isChecked)
            {
                MessageBox.Show("Please select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}

