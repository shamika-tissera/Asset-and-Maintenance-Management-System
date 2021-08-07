using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_and_Maintenance_Management_System.src.Accountant.Dashboard;
using Asset_and_Maintenance_Management_System.src.Dashboard;

namespace Asset_and_Maintenance_Management_System.src.Accountant.Navigation
{
    public partial class uc_assets_accountant_1 : uc_assets_1
    {
        private AccountantDashboard inst;

        public void setInst(AccountantDashboard inst)
        {
            this.inst = inst;
        }
        public uc_assets_accountant_1()
        {
            InitializeComponent();
        }

        protected override void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedAssetsBack();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            inst.clickedAssetsConfig();
        }
        protected override void button9_Click(object sender, EventArgs e)
        {
            inst.clickedAssetsConfig();
        }
    }
}
