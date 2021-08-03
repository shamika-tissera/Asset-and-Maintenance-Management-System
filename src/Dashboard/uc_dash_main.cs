using Asset_and_Maintenance_Management_System.src.Master_Data_Capturing;
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
        protected MainDashboard inst;
        public uc_dash_main()
        {
            InitializeComponent();
        }

        protected void btn_assets_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            inst.clickedAssets();
        }

        protected void uc_dash_main_Load(object sender, EventArgs e)
        {

        }

        public void setDashboardInstance(MainDashboard inst)
        {
            this.inst = inst;
        }

        protected void button3_Click(object sender, EventArgs e)
        {
            inst.clickedAnalytics();
        }

        protected void button2_Click(object sender, EventArgs e)
        {
            inst.clickedMaintenance();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            inst.clickedInventory();
        }
        protected void approval_Click(object sender, EventArgs e)
        {
            inst.clickedApproval();
        }

        protected void button4_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to logout?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                inst.logout();
            }
        }

        protected void button5_Click(object sender, EventArgs e)
        {
            settingsParent settings =  new settingsParent();
            settings.setDashboardInstance(inst);
            settings.Show();
        }
    }
}
