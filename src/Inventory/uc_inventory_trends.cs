using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void populateMostRequestedStocks()
        {
            string query = "select top 3 supplierName as 'Supplier Name', count(Supplier.supplierName) as 'Count' from InventoryOrder inner join Supplier on InventoryOrder.supplierID = Supplier.supplierID inner join InventoryItem on InventoryItem.inventoryCode = InventoryOrder.inventoryCode where received = 'false' group by Supplier.supplierName order by count(Supplier.supplierName) desc;";
        }

        private void lbl_uname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
