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
    public partial class uc_dash_main : UserControl
    {
        private Dashboard inst;
        public uc_dash_main()
        {
            InitializeComponent();
        }

        private void btn_assets_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            inst.clickedAssets();
        }

        private void uc_dash_main_Load(object sender, EventArgs e)
        {

        }

        public void setDashboardInstance(Dashboard inst)
        {
            this.inst = inst;
        }
    }
}
