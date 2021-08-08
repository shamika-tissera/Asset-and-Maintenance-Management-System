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
    public partial class uc_inventory_dash : UserControl
    {
        public uc_inventory_dash()
        {
            InitializeComponent();
            setLabelData();
            this.BackColor = Color.FromArgb(231, 245, 254);

            //chart.Titles.Add("Carriage Outwards");
            //chart.Series["Series1"].Points.AddXY("1", "1000");
            //chart.Series["Series1"].Points.AddXY("2", "500");
            //chart.Series["Series1"].Points.AddXY("3", "1500");
            //chart.Series["Series1"].Points.AddXY("4", "2000");

            //chart.Series["Series2"].Points.AddXY("1", "1080");
            //chart.Series["Series2"].Points.AddXY("2", "500");
            //chart.Series["Series2"].Points.AddXY("3", "1500");
            //chart.Series["Series2"].Points.AddXY("4", "2000");
        }

        public void setLabelData()
        {
            string queryCategories = "select count(distinct inventoryName) from InventoryItem;";
            string queryLowStock = "SELECT count(*) FROM InventoryItem WHERE currentQuantity < threshold;";
            string queryOutOfStock = "SELECT count(*) FROM InventoryItem WHERE currentQuantity = 0;";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(queryCategories, connection))
                {
                    int data = int.Parse(command.ExecuteScalar().ToString());
                    lblCategories.Text = data.ToString();
                }
                using (SqlCommand command = new SqlCommand(queryLowStock, connection))
                {
                    int data = int.Parse(command.ExecuteScalar().ToString());
                    lblLowStock.Text = data.ToString();
                }
                using (SqlCommand command = new SqlCommand(queryOutOfStock, connection))
                {
                    int data = int.Parse(command.ExecuteScalar().ToString());
                    lblOutOfStock.Text = data.ToString();
                }
            }
        }
        private void uc_inventory_dash_Load(object sender, EventArgs e)
        {

        }
    }
}
