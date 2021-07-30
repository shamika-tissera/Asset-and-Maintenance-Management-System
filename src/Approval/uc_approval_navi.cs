using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Approval
{
    public partial class uc_approval_navi : UserControl
    {
        private Dashboard.Dashboard inst;
        public uc_approval_navi()
        {
            InitializeComponent();
        }
        public void setDashboardInstance(Dashboard.Dashboard inst)
        {
            this.inst = inst;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedApprovalBack();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inst.clickedApprovalStockRequests();
        }
    }
}
