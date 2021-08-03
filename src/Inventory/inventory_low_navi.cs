using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_and_Maintenance_Management_System.src.Dashboard;
using Org.BouncyCastle.Asn1.Cmp;

namespace Asset_and_Maintenance_Management_System.src.Inventory
{
    public partial class inventory_low_navi : UserControl
    {
        private MainDashboard inst;

        public void setDashboardInstance(MainDashboard inst)
        {
            this.inst = inst;
        }
        public inventory_low_navi()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedInventoryLowDashboardBack();
        }
    }
}
