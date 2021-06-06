using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Dashboard
{
    public partial class uc_assets_1 : UserControl
    {
        private Dashboard inst;
        public uc_assets_1()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedAssetsBack();
        }

        public void setDashboardInstance(Dashboard inst)
        {
            this.inst = inst;
        }
    }
}
