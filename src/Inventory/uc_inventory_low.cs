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

namespace Asset_and_Maintenance_Management_System.src.Inventory
{
    public partial class uc_inventory_low : UserControl
    {
        public uc_inventory_low()
        {
            InitializeComponent();
            populateDataGridView();
        }
        private void populateDataGridView()
        {
            string query = "SELECT inventoryName AS 'Inventory Name', InventoryItem.currentQuantity as 'Current Quantity', InventoryItem.threshold as 'Threshold', currentQuantity - threshold as 'Varience' FROM InventoryItem WHERE currentQuantity < threshold order by (threshold - currentQuantity) asc;";
            DataTable table = new DataTable();
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            dataGridViewLowInventory.DataSource = table;
            for (int i = 0; i < dataGridViewLowInventory.Columns.Count; i++)
            {
                dataGridViewLowInventory.Columns[i].Width = 241;
            }
            table.Dispose();
        }
    }
    
}
