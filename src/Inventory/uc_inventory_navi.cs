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
    public partial class uc_inventory_navi : UserControl
    {
        private Dashboard.Dashboard inst;
        public uc_inventory_navi()
        {
            InitializeComponent();
        }
        public void setDashboardInstance(Dashboard.Dashboard inst)
        {
            this.inst = inst;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedInventoryBack();
        }
    }
}
