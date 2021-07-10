using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Maintenance
{
    public partial class uc_maintenance_backlog : UserControl
    {
        Dashboard.Dashboard inst;
        public void setDashboardInstance(Dashboard.Dashboard inst)
        {
            this.inst = inst;
        }
        public uc_maintenance_backlog()
        {
            InitializeComponent();
        }

        private void uc_maintenance_backlog_Load(object sender, EventArgs e)
        {

        }
    }
}
