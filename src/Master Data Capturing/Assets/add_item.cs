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
    public partial class add_item : Form
    {
        /*
         General
	        Code, Name, Serial Number, Manufacturer, Supplier, State

        Location
	        Branch, Building, Floor, Room

        Maintenance
	        Maintained by, Condition, Criticality, Last Checked Date
	
        Warranty
	        Warranty code, warranty type, warranty start, warranty end

        Installation Information
	        Installation date, acceptance date, plant

        Administrative
	        purchase price, invoice number, current value, disposal date, years of life, depreciation start, depreciation end, depreciation method, depreciation rate, fully depreciated

         */
        protected string[] general;
        protected string[] location;
        protected string[] maintenance;
        protected string[] warranty;
        protected string[] installation;
        protected string[] administrative;
        private settingsParent inst;
        public add_item()
        {
            InitializeComponent();
        }
        public add_item(settingsParent asset)
        {
            InitializeComponent();
            this.inst = asset;            
        }
        protected void collectInformation()
        {
            general = uc_general_common1.getInformation();
            location = uc_location_common1.getInformation();
            maintenance = uc_maintenance_common1.getInformation();
            warranty = uc_warranty_common1.getInformation();
            installation = uc_installInfo_common1.getInformation();
            administrative = uc_administrative_common1.getInformation();
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
        protected void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void uc_warranty_common1_Load(object sender, EventArgs e)
        {

        }

        private void add_item_Load(object sender, EventArgs e)
        {

        }

        private void uc_administrative_common1_Load(object sender, EventArgs e)
        {

        }

        private void uc_installInfo_common1_Load(object sender, EventArgs e)
        {

        }
        protected void btn_reset_Click(object sender, EventArgs e)
        {
            uc_general_common1.resetContents();
            uc_administrative_common1.resetContent();
            uc_installInfo_common1.resetContent();
            uc_location_common1.resetContent();
            uc_maintenance_common1.resetContent();
            uc_warranty_common1.resetContent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btn_reset_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            inst.clickedAddItemCancel();
        }
    }
}
