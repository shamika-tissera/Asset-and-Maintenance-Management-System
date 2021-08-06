using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_and_Maintenance_Management_System.src.Master_Data_Capturing;

namespace Asset_and_Maintenance_Management_System.src.Dashboard
{
    public partial class uc_assets_1 : UserControl
    {
        private MainDashboard inst;
        public uc_assets_1()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedAssetsBack();
        }

        public void setDashboardInstance(MainDashboard inst)
        {
            this.inst = inst;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inst.clickedAssetsConfig();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            settingsParent settings = new settingsParent(true, inst);
        }
    }
}
