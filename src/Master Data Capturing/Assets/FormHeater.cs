using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    public partial class FormHeater : add_item
    {
        protected string[] general;
        protected string[] location;
        protected string[] maintenance;
        protected string[] warranty;
        protected string[] installation;
        protected string[] administrative;

        private static settingsParent asset;

        public FormHeater() : base()
        {
            InitializeComponent();
        }
        public static void setSettingsParentInstance(settingsParent assetInst)
        {
            asset = assetInst;
        }
        private void FormHeater_Load(object sender, EventArgs e)
        {

        }
        protected void collectInformation()
        {
            
        }
        protected void updateDatabase(string assetType)
        {
            string updateWarranty = "insert into Warranty(warrantyCode, type, startDate, endDate) values ('" + warranty[0] + "', '" + warranty[1] + "', '" + /*DateTime.ParseExact(warranty[2], "dd-MM-yyyy", null)*/"1/1/2019" + "', '" + /*DateTime.ParseExact(warranty[3], "dd-MM-yyyy", null)*/"1/1/2019" + "');";
            string updateAsset = "insert into NonCurrentAsset(asset_id, assetType, serialNumber, manufacturer, state, plant, condition, criticality, warrantyCode, installationDate, purchaseDate, costOfPurchase, invoiceNumber, currentMarketValue, lifetime, depreciationMethod, depreciationRate) values " +
                "('" + general[0] + "', '" + assetType + "', '" + general[2] + "', '" + general[3] + "', '" + general[5] + "', '" + installation[2] + "', '" + maintenance[1] + "', '" + maintenance[2] + "', '" + warranty[0] + "', " + installation[0] + ", " + /*installation[1]*/"1/1/2019" + ", " + administrative[0] + ", '" + administrative[1] + "', " + administrative[2] + ", " + administrative[4] + ", '" + administrative[7] + "', " + administrative[8] + ");";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(updateWarranty, connection))
                {
                    command.ExecuteNonQuery();
                }
                using (SqlCommand command = new SqlCommand(updateAsset, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            asset.clickedAddItemOK();
            btn_reset_Click(sender, e);
            collectInformation();
            updateDatabase("Heater");
        }
    }
}
