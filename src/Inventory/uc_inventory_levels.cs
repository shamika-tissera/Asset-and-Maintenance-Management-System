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

namespace Asset_and_Maintenance_Management_System.src.Inventory
{
    public partial class uc_inventory_levels : UserControl
    {
        public uc_inventory_levels()
        {
            InitializeComponent();
            loadChart();
        }

        public void loadChart()
        {
            foreach (var series in chartInventoryLevels.Series)
            {
                series.Points.Clear();
            }
            DataTable table;
            string query = "SELECT inventoryName AS 'Inventory Name', currentQuantity, threshold FROM InventoryItem;";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        table = new DataTable();
                        adapter.Fill(table);
                    }
                }
            }
            table.Columns.Remove("threshold");
            foreach(DataRow row in table.Rows)
            {
                chartInventoryLevels.Series["Units"].Points.AddXY(row["Inventory Name"].ToString(), int.Parse(row["currentQuantity"].ToString()));
            }
        }
    }
}
