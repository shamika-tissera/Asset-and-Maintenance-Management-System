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
    public partial class uc_preventive_accountant : uc_preventive_maintenance
    {
        public uc_preventive_accountant()
        {
            InitializeComponent();
        }
        public override void populateDataGridView()
        {
            string query = "select asset_id as 'Asset Code', assetType as 'Asset Name', plant as 'Plant', serviceDue as 'Due by' from NonCurrentAsset where serviceDue <= DATEADD(month, 2, GETDATE()) and serviceDue >= DATEADD(month, -3, GETDATE());";
            DataTable table = new DataTable();
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        //table.Columns.Add("Performed", typeof(bool));
                        dataGridViewPreventiveMaintenance.DataSource = table;
                        for (int i = 0; i < dataGridViewPreventiveMaintenance.Columns.Count; i++)
                        {
                            dataGridViewPreventiveMaintenance.Columns[i].Width = 240;
                        }
                    }
                }
            }
        }
    }
}
