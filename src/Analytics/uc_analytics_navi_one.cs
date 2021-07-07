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
        }

        private void btn_backlog_Click(object sender, EventArgs e)
        {

        }
        public void setDashboardInstance(Dashboard.Dashboard inst)
        {
            this.inst = inst;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedAnalyticsBack();
        }
    }
}
