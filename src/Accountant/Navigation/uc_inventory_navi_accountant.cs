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
using Asset_and_Maintenance_Management_System.src.Inventory;

namespace Asset_and_Maintenance_Management_System.src.Accountant.Navigation
{
    public partial class uc_inventory_navi_accountant : uc_inventory_navi
    {
        private AccountantDashboard inst;

        public void setInst(AccountantDashboard inst)
        {
            this.inst = inst;
        }
        public uc_inventory_navi_accountant()
        {
            InitializeComponent();
        }

        protected override void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedInventoryBack();
        }
        protected override void button1_Click(object sender, EventArgs e)
        {
            inst.clickedInventoryTrends();
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button1.BackColor = Color.FromArgb(183, 194, 201);
            isButtonEmphasized = true;
        }

        protected override void button6_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button6.BackColor = Color.FromArgb(183, 194, 201);
            isButtonEmphasized = true;
            inst.clickedInventoryLevels();
        }

        //Levels
        private void button6_Click_1(object sender, EventArgs e)
        {
            button6_Click(sender, e);
        }

        //Trends
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
