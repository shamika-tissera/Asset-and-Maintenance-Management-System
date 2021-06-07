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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            uc_dash_main1.setDashboardInstance(this);
            uc_assets_11.setDashboardInstance(this);
            uc_navPanel_assets1.setDashboardInstance(this);
            uc_dash_main1.Visible = true;
            uc_assets_11.Visible = false;
            uc_navPanel_assets1.Visible = false;
            uc_AllAssets1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navPanel.Visible = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        public void clickedAssets()
        {
            uc_assets_11.Visible = true;
            uc_AllAssets1.Visible = true;
        }

        public void clickedAssetsBack()
        {
            uc_assets_11.Visible = false;
            uc_AllAssets1.Visible = false;
            uc_dash_main1.Visible = true;
        }

        public void clickedAssetsConfig()
        {
            uc_assets_11.Visible = false;
            uc_navPanel_assets1.Visible = true;
        }

        public void clickedAssetNavBack()
        {
            uc_navPanel_assets1.Visible = false;
            uc_assets_11.Visible = true;
        }

        public void clickedAssetAddItemOK()
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void navPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_assets_11_Load(object sender, EventArgs e)
        {

        }

        private void uc_dash_main1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
