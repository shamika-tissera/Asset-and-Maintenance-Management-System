﻿using Asset_and_Maintenance_Management_System.src.Analytics;
using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;
using Asset_and_Maintenance_Management_System.src.Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Dashboard
{
    public partial class MainDashboard : Form
    {
        //use this function to make the edges of the form curved
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        protected static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );
        public MainDashboard()
        {
            InitializeComponent();
            //pic_close.BackColor = Color.Transparent;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            uc_dash_main1.setDashboardInstance(this);
            uc_analytics_navi_one1.setDashboardInstance(this);
            uc_assets_11.setDashboardInstance(this);
            uc_navPanel_assets1.setDashboardInstance(this);
            uc_inventory_navi1.setDashboardInstance(this);
            uc_maintenance_navi1.setDashboardInstance(this);
            uc_maintenance_backlog1.setDashboardInstance(this);
            uc_analytics_warranty.setDashboardInstance(this);
            uc_approval_navi1.setDashboardInstance(this);
            //uc_maintenance_dashboard_info.setDashboardInstance(this);
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
            uc_asset_browse1.Visible = false;
            uc_inventory_trends1.Visible = false;
            uc_analytics_warranty1.Visible = false;
            uc_profit_on_disposal1.Visible = false;
            uc_inventory_levels1.Visible = false;
            uc_approval_navi1.Visible = false;
            uc_stock_requests1.Visible = false;
            uc_stock_reception1.Visible = false;
            uc_preventive_maintenance1.Visible = false;
            uc_corrective_maintenance1.Visible = false;
            uc_analytics_utilization1.Visible = false;
            uc_calendar1.BackColor = Color.FromArgb(231, 245, 254);


            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pic_close.DisplayRectangle);
            pic_close.Region = new Region();

            pnl_highlight.Visible = false;
            generateNotifications();
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            navPanel.Visible = false;
        }

        protected void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private uc_analytics_navi_one analyticsNaviInstance;
        public void setAnalyticsNaviInstance(uc_analytics_navi_one analyticsNaviInstance)
        {
            this.analyticsNaviInstance = analyticsNaviInstance;
        }
        public void clickedAssets()
        {
            uc_assets_11.Visible = true;
            dashboard_info1.Visible = true;
            uc_calendar1.Visible = false;
        }

        public void clickedAnalytics()
        {
            //analyticsNaviInstance.resetButtonHighlights();
            uc_analytics_navi_one1.Visible = true;
            uc_dash_main1.Visible = false;
            uc_analytics_intial_dash2.Visible = true;
            uc_calendar1.Visible = false;
            uc_analytics_utilization1.Visible = false;
        }
        public virtual void clickedAnalyticsBack()
        {
            uc_analytics_navi_one1.Visible = false;
            uc_dash_main1.Visible = true;
            uc_analytics_intial_dash2.Visible = false;
            uc_calendar1.Visible = true;
            uc_analytics_warranty1.Visible = false;
            uc_profit_on_disposal1.Visible = false;
            uc_analytics_utilization1.Visible = false;
        }
        public void clickedAnalyticsWarranty()
        {
            uc_profit_on_disposal1.Visible = false;
            uc_analytics_navi_one1.Visible = true;
            uc_dash_main1.Visible = false;
            uc_analytics_intial_dash2.Visible = false;
            uc_calendar1.Visible = false;
            uc_analytics_warranty1.Visible = true;
            uc_analytics_utilization1.Visible = false;
        }
        public void clickedAnalyticsDisposal()
        {
            uc_analytics_warranty1.Visible = false;
            uc_analytics_navi_one1.Visible = true;
            uc_dash_main1.Visible = false;
            uc_analytics_intial_dash2.Visible = false;
            uc_calendar1.Visible = false;
            uc_profit_on_disposal1.Visible = true;
            uc_analytics_utilization1.Visible = false;
        }
        public void clickedAnalyticsUtilization()
        {
            uc_analytics_warranty1.Visible = false;
            uc_analytics_navi_one1.Visible = true;
            uc_dash_main1.Visible = false;
            uc_analytics_intial_dash2.Visible = false;
            uc_calendar1.Visible = false;
            uc_profit_on_disposal1.Visible = false;
            uc_analytics_utilization1.Visible = true;
        }
        public virtual void clickedAssetsBack()
        {
            uc_assets_11.Visible = false;
            dashboard_info1.Visible = false;
            uc_dash_main1.Visible = true;
            uc_calendar1.Visible = true;
            //uc_asset_browse1.Visible = true;
        }

        public void clickedAssetsConfig()
        {
            uc_assets_11.Visible = false;
            dashboard_info1.Visible = false;
            uc_navPanel_assets1.resetBtnEmphasis();
            uc_navPanel_assets1.Visible = true;
            uc_asset_browse1.Visible = true;
            uc_asset_browse1.setAssetCategory("config");
            //uc_navPanel_assets1.BringToFront();
        }

        public void clickedAssetNavBack()
        {
            uc_navPanel_assets1.Visible = false;
            uc_assets_11.Visible = true;
            uc_calendar1.Visible = false;
            uc_asset_browse1.Visible = false;
            dashboard_info1.Visible = true;
        }
        public void clickedInventory()
        {
            uc_inventory_dash1.Visible = true;
            uc_calendar1.Visible = false;
            uc_dash_main1.Visible = false;
            uc_inventory_navi1.resetBtnEmphasis();
            uc_inventory_navi1.Visible = true;
        }
        public virtual void clickedInventoryBack()
        {
            uc_inventory_navi1.Visible = false;
            uc_inventory_dash1.Visible = false;
            uc_assets_11.Visible = false;
            uc_inventory_trends1.Visible = false;
            uc_inventory_levels1.Visible = false;
            uc_calendar1.Visible = true;
            uc_dash_main1.Visible = true;
        }
        public void clickedInventoryLevels()
        {
            uc_inventory_trends1.Visible = false;
            uc_inventory_levels1.Visible = true;
            uc_inventory_dash1.Visible = false;
        }
        public void clickedInventoryTrends()
        {
            uc_inventory_levels1.Visible = false;
            uc_inventory_trends1.Visible = true;
            uc_inventory_dash1.Visible = false;
        }
        public void clickedMaintenance()
        {
            uc_maintenance_dashboard_info1.Visible = true;
            uc_maintenance_navi1.resetBtnEmphasis();
            uc_maintenance_navi1.Visible = true;
            uc_calendar1.Visible = false;
            uc_dash_main1.Visible = false;
        }
        public virtual void clickedMaintenanceBack()
        {
            uc_maintenance_dashboard_info1.Visible = false;
            uc_maintenance_navi1.Visible = false;
            uc_maintenance_backlog1.Visible = false;
            uc_assets_11.Visible = false;
            uc_maintenance_reccomendations1.Visible = false;
            uc_calendar1.Visible = true;
            uc_dash_main1.Visible = true;
            uc_preventive_maintenance1.Visible = false;
            uc_corrective_maintenance1.Visible = false;
        }

        public void clickedMaintenanceBacklog()
        {
            uc_maintenance_backlog1.Visible = true;
            uc_maintenance_dashboard_info1.Visible = false;
            uc_corrective_maintenance1.Visible = false;
            uc_preventive_maintenance1.Visible = false;
            uc_maintenance_reccomendations1.Visible = false;
        }
        public void clickedMaintenanceBacklogBack()
        {
            uc_maintenance_backlog1.Visible = false;
            uc_maintenance_dashboard_info1.Visible = true;
            uc_corrective_maintenance1.Visible = false;
            uc_preventive_maintenance1.Visible = false;
        }

        public String getInfoForMaintenanceNaviBack()
        {
            if (uc_maintenance_backlog1.Visible)
            {
                return "backlog";
            }

            return null;
        }
        public void clickedMaintenancePreventive()
        {
            uc_preventive_maintenance1.Visible = true;
            uc_maintenance_reccomendations1.Visible = false;
            uc_corrective_maintenance1.Visible = false;
            uc_maintenance_backlog1.Visible = false;
        }
        public void clickedMaintenanceCorrective()
        {
            uc_corrective_maintenance1.Visible = true;
            uc_preventive_maintenance1.Visible = false;
            uc_maintenance_reccomendations1.Visible = false;
            uc_maintenance_backlog1.Visible = false;
        }
        public void clickedMaintenanceReccomendations()
        {
            uc_maintenance_reccomendations1.Visible = true;
            uc_preventive_maintenance1.Visible = false;
            uc_corrective_maintenance1.Visible = false;
            uc_maintenance_backlog1.Visible = false;
        }
        public void clickedassetsConfigurational()
        {
            
        }
        public void clickedApproval()
        {
            uc_approval_navi1.Visible = true;
            uc_dash_main1.Visible = false;
            uc_stock_requests1.Visible = true;
        }
        public void clickedApprovalBack()
        {
            uc_approval_navi1.Visible = false;
            uc_dash_main1.Visible = true;
            uc_stock_requests1.Visible = false;
            uc_stock_reception1.Visible = false;
        }
        public void clickedApprovalStockRequests()
        {
            uc_stock_requests1.Visible = true;
            uc_stock_reception1.Visible = false;
        }
        public void clickedApprovalStockReception()
        {
            uc_stock_reception1.Visible = true;
            uc_stock_requests1.Visible = false;
        }
        public void logout()
        {
            this.Dispose();
        }
        public void exit()
        {
            this.Dispose();
        }

        //Button decorations
        /*
            Assets Navigation Pane
        */
        public void clickedHeater(Point location)
        {
            pnl_highlight.Location = location;
            pnl_highlight.Visible = true;
        }

        public void clickedAssetAddItemOK()
        {
            
        }

        protected void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        protected void navPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void uc_assets_11_Load(object sender, EventArgs e)
        {

        }

        protected void uc_dash_main1_Load(object sender, EventArgs e)
        {

        }

        protected void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected void uc_navPanel_assets1_Load(object sender, EventArgs e)
        {

        }

        protected void uc_AllAssets1_Load(object sender, EventArgs e)
        {

        }

        protected void dashboard_info1_Load(object sender, EventArgs e)
        {

        }

        protected void uc_calendar1_Load(object sender, EventArgs e)
        {

        }

        protected void pic_close_Click(object sender, EventArgs e)
        {
            exit();
        }



        protected void generateNotifications()
        {
            /*
             * PRIORITY
             * ========
             * 
             *  1. Low Inventory
             *  2. Maintenance Backlog
             *  3. Upcoming Maintainance Dates
             */
            string queryInventory = "SELECT inventoryName AS 'Inventory Name', threshold - currentQuantity as 'Varience' FROM InventoryItem WHERE currentQuantity < threshold order by (threshold - currentQuantity) desc;";
            string queryBacklog = "set nocount off select asset_id as 'Asset ID', serviceDue as 'Service Due', DATEDIFF(day, serviceDue, getDate()) as 'Delay' from NonCurrentAsset where DATEDIFF(day, serviceDue, getDate()) > 0;";
            string queryServiceDue = "select asset_id as 'Asset Code', serviceDue as 'Due by' from NonCurrentAsset where serviceDue <= DATEADD(month, 2, GETDATE()) and serviceDue > GETDATE();";
            DataTable inventory = new DataTable();
            DataTable backlog = new DataTable();
            DataTable serviceDue = new DataTable();
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(queryInventory, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(inventory);
                    }
                }
                using (SqlCommand command = new SqlCommand(queryBacklog, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(backlog);
                    }
                }
                using (SqlCommand command = new SqlCommand(queryServiceDue, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(serviceDue);
                    }
                }
                if (inventory.Rows.Count > 0)
                {
                    int i = 0;
                    int n = inventory.Rows.Count;
                    uc_calendar1.lblNotif1.Text = "The following stock items need attention: \n";
                    uc_calendar1.lblNotif1.Text += "        ";
                    foreach (DataRow row in inventory.Rows)
                    {
                        uc_calendar1.lblNotif1.Text += row["Inventory Name"].ToString() + ", ";
                    }
                }
                if(backlog.Rows.Count > 0)
                {
                    int i = 0;
                    int n = backlog.Rows.Count;
                    if (uc_calendar1.lblNotif1.Text == "")
                    {
                        uc_calendar1.lblNotif1.Text = "Maintenance dates were past due for the following assets: \n";
                        uc_calendar1.lblNotif1.Text += "        ";
                        foreach (DataRow row in backlog.Rows)
                        {
                            uc_calendar1.lblNotif1.Text += row["Asset ID"].ToString() + ", ";
                        }
                    }
                    else
                    {
                        uc_calendar1.lblNotif2.Text = "Maintenance dates were past due for the following assets: \n";
                        uc_calendar1.lblNotif2.Text += "        ";
                        foreach (DataRow row in backlog.Rows)
                        {
                            uc_calendar1.lblNotif2.Text += row["Asset ID"].ToString() + ", ";
                        }
                    }
                }
                if(serviceDue.Rows.Count > 0)
                {
                    if (uc_calendar1.lblNotif1.Text == "")
                    {
                        uc_calendar1.lblNotif1.Text = "Maintenance dates for the following assets are within the next 2 months: \n";
                        uc_calendar1.lblNotif1.Text += "        ";
                        foreach (DataRow row in serviceDue.Rows)
                        {
                            uc_calendar1.lblNotif1.Text += row["Due by"].ToString() + ", ";
                        }
                    }
                    else if (uc_calendar1.lblNotif2.Text == "")
                    {
                        uc_calendar1.lblNotif2.Text = "Maintenance dates for the following assets are within the next 2 months: \n";
                        uc_calendar1.lblNotif2.Text += "        ";
                        foreach (DataRow row in serviceDue.Rows)
                        {
                            uc_calendar1.lblNotif2.Text += row["Due by"].ToString() + ", ";
                        }
                    }
                    else
                    {
                        uc_calendar1.lblNotif3.Text = "Maintenance dates for the following assets are within the next 2 months: \n";
                        uc_calendar1.lblNotif3.Text += "        ";
                        foreach (DataRow row in serviceDue.Rows)
                        {
                            uc_calendar1.lblNotif3.Text += row["Due by"].ToString() + ", ";
                        }
                    }
                }
            }
        }

    }
}