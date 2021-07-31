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
    public partial class uc_inventory_trends : UserControl
    {
        public uc_inventory_trends()
        {
            InitializeComponent();
            populateMostRequestedStocks();
            populateSupplierContacts();
        }

        private void populateMostRequestedStocks()
        {
            DataTable table = new DataTable();
            string query = "select top 3 InventoryItem.inventoryName as 'Stock Name', count(InventoryItem.inventoryName) as 'Count' from InventoryOrder inner join InventoryItem on InventoryOrder.inventoryCode = InventoryItem.inventoryCode group by InventoryItem.inventoryName order by count(InventoryItem.inventoryName) desc";
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
            if (table.Rows.Count == 3)
            {
                lblMostRequestedStocks3.Text = table.Rows[2]["Stock Name"].ToString();
                lblMostRequestedStocks2.Text = table.Rows[1]["Stock Name"].ToString();
                lblMostRequestedStocks1.Text = table.Rows[0]["Stock Name"].ToString();
            }
            if (table.Rows.Count == 2)
            {
                lblMostRequestedStocks3.Text = "";
                lblMostRequestedStocks2.Text = table.Rows[1]["Stock Name"].ToString();
                lblMostRequestedStocks1.Text = table.Rows[0]["Stock Name"].ToString();
            }
            if (table.Rows.Count == 1)
            {
                lblMostRequestedStocks3.Text = "";
                lblMostRequestedStocks2.Text = "";
                lblMostRequestedStocks1.Text = table.Rows[0]["Stock Name"].ToString();
            }
            if (table.Rows.Count == 0)
            {
                lblMostRequestedStocks3.Text = "";
                lblMostRequestedStocks2.Text = "";
                lblMostRequestedStocks1.Text = "";
            }
            foreach (DataRow row in table.Rows)
            {
                chartMostRequestedStocks.Series["Times"].Points.AddXY(row["Stock Name"].ToString(), int.Parse(row["Count"].ToString()));
            }
        }
        private void populateSupplierContacts()
        {
            DataTable table = new DataTable();
            string query = "select top 3 Supplier.supplierName as 'Supplier Name', count(supplierName) as 'Count' from InventoryOrder inner join Supplier on InventoryOrder.supplierID = Supplier.supplierID group by supplierName order by count(supplierName) desc;";
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
            if (table.Rows.Count == 3)
            {
                lblSupplierContacts3.Text = table.Rows[2]["Supplier Name"].ToString();
                lblSupplierContacts2.Text = table.Rows[1]["Supplier Name"].ToString();
                lblSupplierContacts1.Text = table.Rows[0]["Supplier Name"].ToString();
            }
            if (table.Rows.Count == 2)
            {
                lblSupplierContacts3.Text = "";
                lblSupplierContacts2.Text = table.Rows[1]["Supplier Name"].ToString();
                lblSupplierContacts1.Text = table.Rows[0]["Supplier Name"].ToString();
            }
            if (table.Rows.Count == 1)
            {
                lblSupplierContacts3.Text = "";
                lblSupplierContacts2.Text = "";
                lblSupplierContacts1.Text = table.Rows[0]["Supplier Name"].ToString();
            }
            if (table.Rows.Count == 0)
            {
                lblSupplierContacts3.Text = "";
                lblSupplierContacts2.Text = "";
                lblSupplierContacts1.Text = "";
            }
            foreach (DataRow row in table.Rows)
            {
                chartSupplierContacts.Series["Times"].Points.AddXY(row["Supplier Name"].ToString(), int.Parse(row["Count"].ToString()));
            }
        }
        private void lbl_uname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
