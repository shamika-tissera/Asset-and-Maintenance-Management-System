using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_and_Maintenance_Management_System.src.Approval;

namespace Asset_and_Maintenance_Management_System.src.Inventory
{
    public partial class uc_inventory_navi : UserControl
    {
        private Dashboard.MainDashboard inst;
        public uc_inventory_navi()
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(231, 245, 254);
            button2.BackColor = Color.FromArgb(231, 245, 254);
            button6.BackColor = Color.FromArgb(231, 245, 254);
        }
        public void setDashboardInstance(Dashboard.MainDashboard inst)
        {
            this.inst = inst;
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedInventoryBack();
        }
        private bool isButtonEmphasized = false;
        public void resetBtnEmphasis()
        {
            button1.BackColor = Color.FromArgb(231, 245, 254);
            button2.BackColor = Color.FromArgb(231, 245, 254);
            button6.BackColor = Color.FromArgb(231, 245, 254);
            isButtonEmphasized = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            inst.clickedInventoryTrends();
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button1.BackColor = Color.FromArgb(183, 194, 201);
            isButtonEmphasized = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button6.BackColor = Color.FromArgb(183, 194, 201);
            isButtonEmphasized = true;
            inst.clickedInventoryLevels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            //button2.BackColor = Color.FromArgb(61, 70, 89);
            //isButtonEmphasized = true;

            StockRequest request = new StockRequest();
            request.Show();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    if (isButtonEmphasized)
        //    {
        //        resetBtnEmphasis();
        //    }
        //    button3.BackColor = Color.FromArgb(61, 70, 89);
        //    isButtonEmphasized = true;
        //}
    }
}
