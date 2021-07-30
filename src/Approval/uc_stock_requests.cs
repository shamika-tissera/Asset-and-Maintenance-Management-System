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
    public partial class uc_stock_requests : UserControl
    {
        public uc_stock_requests()
        {
            InitializeComponent();
            populateDataGridView();
        }
        private void populateDataGridView()
        {
            string query = "select inventoryName as 'Stock Name', orderedQuantity as 'Ordered Quantity', supplierName as 'Supplier Name', (orderedQuantity * CurrentCost) as 'Estimated Cost (Rs.)' from InventoryOrder inner join Supplier on InventoryOrder.supplierID = Supplier.supplierID inner join InventoryItem on InventoryItem.inventoryCode = InventoryOrder.inventoryCode;";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataTable data = new DataTable())
                        {
                            adapter.Fill(data);
                            //foreach(DataRow row in data.Rows)
                            //{
                            //    switch(row["Stock Name"].ToString())
                            //    {
                            //        case "PVC":
                            //            string dataPresent = row["Ordered Quantity"].ToString();
                            //            row["Ordered Quantity"] = dataPresent + "kg";
                            //            break;
                            //    }
                            //}
                            dataGridViewMain.DataSource = data;
                            for (int i = 0; i < dataGridViewMain.Columns.Count; i++)
                            {
                                dataGridViewMain.Columns[i].Width = 150;
                            }
                        }
                    }
                }
            }
        }
    }
}
