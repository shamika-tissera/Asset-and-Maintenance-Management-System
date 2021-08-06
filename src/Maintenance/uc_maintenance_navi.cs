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
        private Dashboard.MainDashboard inst;
        public uc_maintenance_navi()
        {
            InitializeComponent();
        }
        
        private void uc_maintenance_navi_Load(object sender, EventArgs e)
        {

        }

        public void setDashboardInstance(Dashboard.MainDashboard inst)
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
        private bool isButtonEmphasized = false;
        public void resetBtnEmphasis()
        {
            btn_backlog.BackColor = Color.FromArgb(231, 245, 254);
            btn_preventive.BackColor = Color.FromArgb(231, 245, 254);
            btn_corrective.BackColor = Color.FromArgb(231, 245, 254);
            btn_recommendations.BackColor = Color.FromArgb(231, 245, 254);
            isButtonEmphasized = false;
        }
        private void btn_backlog_Click(object sender, EventArgs e)
        {
            inst.clickedMaintenanceBacklog();            
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            btn_backlog.BackColor = Color.FromArgb(207, 220, 228);
            isButtonEmphasized = true;
        }

        private void btn_recommendations_Click(object sender, EventArgs e)
        {
            inst.clickedMaintenanceReccomendations();
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            btn_recommendations.BackColor = Color.FromArgb(207, 220, 228);
            isButtonEmphasized = true;
        }

        private void btn_preventive_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            btn_preventive.BackColor = Color.FromArgb(207, 220, 228);
            isButtonEmphasized = true;
            inst.clickedMaintenancePreventive();
        }

        private void btn_corrective_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            btn_corrective.BackColor = Color.FromArgb(207, 220, 228);
            isButtonEmphasized = true;
            inst.clickedMaintenanceCorrective();
        }
    }
}
