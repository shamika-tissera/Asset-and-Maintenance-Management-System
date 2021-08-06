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
        private Dashboard.MainDashboard inst;
        public uc_approval_navi()
        {
            InitializeComponent();
            button6.BackColor = Color.FromArgb(207, 220, 228);
        }
        public void resetButtonHighlights()
        {
            button6.BackColor = Color.FromArgb(231, 245, 254);
            button1.BackColor = Color.FromArgb(231, 245, 254);
            button2.BackColor = Color.FromArgb(231, 245, 254);
        }
        public void setDashboardInstance(Dashboard.MainDashboard inst)
        {
            this.inst = inst;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            resetButtonHighlights();
            inst.clickedApprovalBack();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resetButtonHighlights();
            button6.BackColor = Color.FromArgb(207, 220, 228);
            inst.clickedApprovalStockRequests();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetButtonHighlights();
            button1.BackColor = Color.FromArgb(207, 220, 228);
            inst.clickedApprovalStockReception();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetButtonHighlights();
            button2.BackColor = Color.FromArgb(207, 220, 228);
            inst.clickedApprovalEmployeeRequests();
        }
    }
}
