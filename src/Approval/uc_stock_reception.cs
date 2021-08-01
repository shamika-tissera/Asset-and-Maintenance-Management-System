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

namespace Asset_and_Maintenance_Management_System.src.Approval
{
    public partial class uc_stock_reception : UserControl
    {
        public uc_stock_reception()
        {
            InitializeComponent();
            populateDataGridView();
        }
        private void populateDataGridView()
        {
            string query = "select inventoryName as 'Stock Name', orderedQuantity as 'Ordered Quantity', supplierName as 'Supplier Name', (orderedQuantity * CurrentCost) as 'Estimated Cost (Rs.)' from InventoryOrder inner join Supplier on InventoryOrder.supplierID = Supplier.supplierID inner join InventoryItem on InventoryItem.inventoryCode = InventoryOrder.inventoryCode where received = 'false';";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataTable data = new DataTable())
                        {
                            adapter.Fill(data);
                            data.Columns.Add("Received", typeof(bool));
                            dataGridViewMain.AllowUserToAddRows = false;
                            dataGridViewMain.DataSource = data;
                            //dataGridViewMain.Columns.Add("Received", typeof(bool));
                            for (int i = 0; i < dataGridViewMain.Columns.Count; i++)
                            {
                                dataGridViewMain.Columns[i].Width = 150;
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stockName;
            int orderedQuantity;
            string supplierName;
            bool isChecked = false;

            foreach(DataGridViewRow row in dataGridViewMain.Rows)
            {
                try
                {
                    if(row.Cells["Received"].Value.ToString() == "true")
                    {
                        stockName = row.Cells["Stock Name"].Value.ToString();
                        orderedQuantity = int.Parse(row.Cells["Ordered Quantity"].Value.ToString());
                        supplierName = row.Cells["Supplier Name"].Value.ToString();
                        string query = "UPDATE InventoryOrder SET received = 'TRUE' WHERE stockType = '" + stockName + "' AND supplierName = '" + supplierName + "' AND units = '" + orderedQuantity + "'";
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
                        dataGridViewMain.Rows.RemoveAt(row.Index);
                    }
                    if (!isChecked)
                    {
                        MessageBox.Show("Please select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                catch (NullReferenceException ex)
                {
                    TextWriter.writeContent("logs.txt", ex.ToString());
                    break;
                }
            }
        }
    }
}
