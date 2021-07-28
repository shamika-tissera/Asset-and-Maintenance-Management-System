using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Analytics
{
    public partial class uc_analytics_navi_one : UserControl
    {
        Dashboard.Dashboard inst;
       
        public uc_analytics_navi_one()
        {
            InitializeComponent();
            //inst.setAnalyticsNaviInstance(this);
            resetButtonHighlights();
        }

        private void btn_backlog_Click(object sender, EventArgs e)
        {
            resetButtonHighlights();
            inst.clickedAnalyticsWarranty();
            btn_warranty.BackColor = Color.FromArgb(61, 70, 89);
        }
        public void setDashboardInstance(Dashboard.Dashboard inst)
        {
            this.inst = inst;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedAnalyticsBack();
        }
        public void resetButtonHighlights()
        {
            btn_warranty.BackColor = Color.FromArgb(31, 46, 76);
            btn_disposal.BackColor = Color.FromArgb(31, 46, 76);
            btn_utilization.BackColor = Color.FromArgb(31, 46, 76);
        }

        private void btn_disposal_Click(object sender, EventArgs e)
        {
            resetButtonHighlights();
            btn_disposal.BackColor = Color.FromArgb(61, 70, 89);
            inst.clickedAnalyticsDisposal();
        }

        private void btn_utilization_Click(object sender, EventArgs e)
        {
            resetButtonHighlights();
            btn_utilization.BackColor = Color.FromArgb(61, 70, 89);
        }
    }
}
