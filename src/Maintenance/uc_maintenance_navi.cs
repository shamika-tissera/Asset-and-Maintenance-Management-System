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
    public partial class uc_maintenance_navi : UserControl
    {
        private Dashboard.Dashboard inst;
        public uc_maintenance_navi()
        {
            InitializeComponent();
        }
        
        private void uc_maintenance_navi_Load(object sender, EventArgs e)
        {

        }

        public void setDashboardInstance(Dashboard.Dashboard inst)
        {
            this.inst = inst;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            inst.clickedMaintenanceBack();

            //switch (inst.getInfoForMaintenanceNaviBack())
            //{
            //    case "backlog":
            //        inst.clickedMaintenanceBacklogBack();
            //        break;
            //    case "preventive":

            //        break;
            //    case "corrective":

            //        break;
            //    case "recommendations":

            //        break;
            //    case "notifications":

            //        break;
            //    default:
            //        inst.clickedMaintenanceBack();
            //        break;
            //}
        }

        private void btn_backlog_Click(object sender, EventArgs e)
        {
            inst.clickedMaintenanceBacklog();
        }

        public void btn_recommendations_Click(object sender, EventArgs e)
        {
            inst.clickedMaintenanceReccomendations();
        }
    }
}
