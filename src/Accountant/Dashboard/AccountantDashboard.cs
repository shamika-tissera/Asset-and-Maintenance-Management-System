using Asset_and_Maintenance_Management_System.src.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Accountant.Dashboard
{
    public partial class AccountantDashboard : MainDashboard
    {
        public AccountantDashboard()
        {
            InitializeComponent();
            uc_dash_main_accountant1.Visible = true;
            uc_calendar1.Visible = false;
            uc_calendar_accountant1.Visible = true;
            uc_assets_accountant_11.Visible = false;
            uc_inventory_navi_accountant1.Visible = false;
            uc_preventive_accountant1.Visible = false;
            uc_corrective_accountant1.Visible = false;
            uc_dash_main_accountant1.setDashboardInstance(this);
            uc_assets_accountant_11.setInst(this);
            uc_inventory_navi_accountant1.setInst(this);
        }
        public override void clickedAssetsBack()
        {
            uc_assets_accountant_11.Visible = false;
            dashboard_info1.Visible = false;
            uc_dash_main_accountant1.Visible = true;
            uc_calendar_accountant1.Visible = true;
            uc_assets_11.Visible = false;
            uc_asset_browse1.Visible = false;
        }
        public override void clickedAnalyticsBack()
        {
            uc_analytics_navi_one1.Visible = false;
            uc_dash_main_accountant1.Visible = true;
            uc_analytics_intial_dash2.Visible = false;
            uc_calendar_accountant1.Visible = true;
            uc_analytics_warranty1.Visible = false;
            uc_profit_on_disposal1.Visible = false;
            uc_analytics_utilization1.Visible = false;
        }
        public override void clickedMaintenanceBack()
        {
            uc_maintenance_dashboard_info1.Visible = false;
            uc_maintenance_navi1.Visible = false;
            uc_maintenance_backlog1.Visible = false;
            uc_assets_11.Visible = false;
            uc_maintenance_reccomendations1.Visible = false;
            uc_calendar_accountant1.Visible = true;
            uc_dash_main_accountant1.Visible = true;
            uc_preventive_maintenance1.Visible = false;
            uc_corrective_maintenance1.Visible = false;
            uc_preventive_accountant1.Visible = false;
            uc_corrective_accountant1.Visible = false;
        }
        public override void clickedInventoryBack()
        {
            uc_inventory_navi1.Visible = false;
            uc_inventory_dash1.Visible = false;
            uc_assets_11.Visible = false;
            uc_inventory_trends1.Visible = false;
            uc_inventory_levels1.Visible = false;
            uc_calendar_accountant1.Visible = true;
            uc_dash_main_accountant1.Visible = true;
            uc_inventory_navi_accountant1.Visible = false;
        }

        public override void clickedAssets()
        {
            uc_assets_accountant_11.Visible = true;
            dashboard_info1.Visible = true;
            uc_calendar_accountant1.Visible = false;
        }

        public override void clickedAssetsConfig()
        {
            uc_assets_11.Visible = true;
            dashboard_info1.Visible = false;
            uc_navPanel_assets1.resetBtnEmphasis();
            //uc_navPanel_assets1.Visible = true;
            uc_asset_browse1.Visible = true;
            uc_asset_browse1.setAssetCategory("config");
            //uc_navPanel_assets1.BringToFront();
        }

        public override void clickedAnalytics()
        {
            //analyticsNaviInstance.resetButtonHighlights();
            uc_analytics_navi_one1.Visible = true;
            uc_dash_main1.Visible = false;
            uc_analytics_intial_dash2.Visible = true;
            uc_calendar_accountant1.Visible = false;
            uc_analytics_utilization1.Visible = false;
        }

        public override void clickedInventory()
        {
            uc_calendar1.Visible = false;
            uc_inventory_dash1.Visible = true;
            uc_calendar_accountant1.Visible = false;
            uc_dash_main1.Visible = false;
            uc_inventory_navi1.resetBtnEmphasis();
            uc_inventory_navi1.Visible = false;
            uc_inventory_navi_accountant1.Visible = true;
        }
        public override void clickedMaintenance()
        {
            uc_calendar1.Visible = false;
            uc_maintenance_dashboard_info1.Visible = true;
            uc_maintenance_navi1.resetBtnEmphasis();
            uc_maintenance_navi1.Visible = true;
            uc_calendar_accountant1.Visible = false;
            uc_dash_main1.Visible = false;
            uc_maintenance_dashboard_info1.setLabelData();
        }
        public override void clickedMaintenancePreventive()
        {
            uc_maintenance_dashboard_info1.Visible = false;
            uc_calendar1.Visible = false;
            uc_preventive_maintenance1.Visible = false;
            uc_preventive_accountant1.Visible = true;
            uc_maintenance_reccomendations1.Visible = false;
            uc_corrective_maintenance1.Visible = false;
            uc_corrective_accountant1.Visible = false;
            uc_maintenance_backlog1.Visible = false;
            uc_preventive_maintenance1.populateDataGridView();
        }
        public override void clickedMaintenanceCorrective()
        {
            uc_maintenance_dashboard_info1.Visible = false;
            uc_calendar1.Visible = false;
            uc_corrective_maintenance1.Visible = false;
            uc_corrective_accountant1.Visible = true;
            uc_preventive_maintenance1.Visible = false;
            uc_preventive_accountant1.Visible = false;
            uc_maintenance_reccomendations1.Visible = false;
            uc_maintenance_backlog1.Visible = false;
            uc_corrective_maintenance1.populateDataGridView();
        }
        public override void clickedMaintenanceBacklog()
        {
            uc_calendar1.Visible = false;
            uc_maintenance_backlog1.Visible = true;
            uc_maintenance_dashboard_info1.Visible = false;
            uc_corrective_maintenance1.Visible = false;
            uc_preventive_maintenance1.Visible = false;
            uc_corrective_accountant1.Visible = false;
            uc_preventive_accountant1.Visible = false;
            uc_maintenance_reccomendations1.Visible = false;
            uc_maintenance_backlog1.populateDataGridView();
            uc_maintenance_backlog1.loadChart();
        }
    }
}
