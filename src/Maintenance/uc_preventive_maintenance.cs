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
        public virtual void populateDataGridView()
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
                        table.Columns.Add("Performed", typeof(bool));
                        dataGridViewPreventiveMaintenance.DataSource = table;
                        for (int i = 0; i < dataGridViewPreventiveMaintenance.Columns.Count; i++)
                        {
                            dataGridViewPreventiveMaintenance.Columns[i].Width = 207;
                        }
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewPreventiveMaintenance.Rows)
            {
                string a = row.Cells["Performed"].Value.ToString();
                int b = dataGridViewPreventiveMaintenance.Rows.Count;
                if (row.Cells["Performed"].Value.ToString() == "True")
                {
                    string assetCode = row.Cells["Asset Code"].Value.ToString();
                    
                    string query =
                        "UPDATE NonCurrentAsset SET serviceDue = DATEADD(month, NonCurrentAsset.serviceInterval*12, NonCurrentAsset.serviceDue) WHERE asset_id = '" + assetCode + "';";
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
                    dataGridViewPreventiveMaintenance.Rows.RemoveAt(row.Index);
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
