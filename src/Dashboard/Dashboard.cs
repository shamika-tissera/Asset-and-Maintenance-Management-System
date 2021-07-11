using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Dashboard
{
    public partial class Dashboard : Form
    {
        //use this function to make the edges of the form curved
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );
        public Dashboard()
        {
            InitializeComponent();
            //pic_close.BackColor = Color.Transparent;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            uc_dash_main1.setDashboardInstance(this);
            uc_assets_11.setDashboardInstance(this);
            uc_navPanel_assets1.setDashboardInstance(this);
            uc_inventory_navi1.setDashboardInstance(this);
            uc_maintenance_navi1.setDashboardInstance(this);
            uc_maintenance_backlog1.setDashboardInstance(this);
            uc_analytics_navi_one1.setDashboardInstance(this);
            uc_dash_main1.Visible = true;
            uc_maintenance_backlog1.Visible = false;
            uc_assets_11.Visible = false;
            uc_navPanel_assets1.Visible = false;
            uc_maintenance_reccomendations1.Visible = false;
            uc_analytics_navi_one1.Visible = false;
            dashboard_info1.Visible = false;
            uc_analytics_intial_dash2.Visible = false;
            uc_inventory_dash1.Visible = false;
            uc_inventory_navi1.Visible = false;
            uc_maintenance_dashboard_info1.Visible = false;
            uc_maintenance_navi1.Visible = false;


            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pic_close.DisplayRectangle);
            pic_close.Region = new Region();
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
            dashboard_info1.Visible = true;
            uc_calendar1.Visible = false;
        }

        public void clickedAnalytics()
        {
            uc_analytics_navi_one1.Visible = true;
            uc_dash_main1.Visible = false;
            uc_analytics_intial_dash2.Visible = true;
            uc_calendar1.Visible = false;
        }
        public void clickedAnalyticsBack()
        {
            uc_analytics_navi_one1.Visible = false;
            uc_dash_main1.Visible = true;
            uc_analytics_intial_dash2.Visible = false;
            uc_calendar1.Visible = true;
        }

        public void clickedAssetsBack()
        {
            uc_assets_11.Visible = false;
            dashboard_info1.Visible = false;
            uc_dash_main1.Visible = true;
            uc_calendar1.Visible = true;
        }

        public void clickedAssetsConfig()
        {
            uc_assets_11.Visible = true;
            uc_navPanel_assets1.Visible = true;
            uc_navPanel_assets1.BringToFront();
        }

        public void clickedAssetNavBack()
        {
            uc_navPanel_assets1.Visible = false;
            uc_assets_11.Visible = true;
            uc_calendar1.Visible = true;
        }
        public void clickedInventory()
        {
            uc_inventory_dash1.Visible = true;
            uc_calendar1.Visible = false;
            uc_dash_main1.Visible = false;
            uc_inventory_navi1.Visible = true;
        }
        public void clickedInventoryBack()
        {
            uc_inventory_navi1.Visible = false;
            uc_inventory_dash1.Visible = false;
            uc_assets_11.Visible = false;
            uc_calendar1.Visible = true;
            uc_dash_main1.Visible = true;
        }
        public void clickedMaintenance()
        {
            uc_maintenance_dashboard_info1.Visible = true;
            uc_maintenance_navi1.Visible = true;
            uc_calendar1.Visible = false;
            uc_dash_main1.Visible = false;
        }
        public void clickedMaintenanceBack()
        {
            uc_maintenance_dashboard_info1.Visible = false;
            uc_maintenance_navi1.Visible = false;
            uc_maintenance_backlog1.Visible = false;
            uc_assets_11.Visible = false;
            uc_maintenance_reccomendations1.Visible = false;
            uc_calendar1.Visible = true;
            uc_dash_main1.Visible = true;
        }

        public void clickedMaintenanceBacklog()
        {
            uc_maintenance_backlog1.Visible = true;
            uc_maintenance_backlog1.BringToFront();
            uc_maintenance_dashboard_info1.Visible = false;
        }
        public void clickedMaintenanceBacklogBack()
        {
            uc_maintenance_backlog1.Visible = false;
            uc_maintenance_dashboard_info1.Visible = true;
        }

        public String getInfoForMaintenanceNaviBack()
        {
            if (uc_maintenance_backlog1.Visible)
            {
                return "backlog";
            }

            return null;
        }
        public void clickedMaintenanceReccomendations()
        {
            uc_maintenance_reccomendations1.Visible = true;
            uc_maintenance_reccomendations1.BringToFront();
        }
        public void logout()
        {
            this.Dispose();
        }
        public void exit()
        {
            this.Dispose();
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

        private void uc_navPanel_assets1_Load(object sender, EventArgs e)
        {

        }

        private void uc_AllAssets1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_info1_Load(object sender, EventArgs e)
        {

        }

        private void uc_calendar1_Load(object sender, EventArgs e)
        {

        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}