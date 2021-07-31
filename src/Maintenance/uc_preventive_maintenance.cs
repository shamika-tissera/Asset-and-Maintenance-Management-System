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
//using System.Windows.Controls;

namespace Asset_and_Maintenance_Management_System.src.Maintenance
{
    public partial class uc_preventive_maintenance : UserControl
    {
        public uc_preventive_maintenance()
        {
            InitializeComponent();
            populateDataGridView();
        }

        private void uc_preventive_maintenance_Load(object sender, EventArgs e)
        {

        }
        private void populateDataGridView()
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
                        dataGridViewPreventiveMaintenance.DataSource = table;
                        for(int i = 0; i < dataGridViewPreventiveMaintenance.Rows.Count; i++)
                        {
                            if (Convert.ToDateTime(dataGridViewPreventiveMaintenance.Rows[i].Cells["Due by"].ToString()) < DateTime.Today)
                            {
                                dataGridViewPreventiveMaintenance.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }
    }
}
