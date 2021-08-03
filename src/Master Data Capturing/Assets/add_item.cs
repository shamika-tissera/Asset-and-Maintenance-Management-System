using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    public partial class add_item : Form
    {
        /*
        ARRAY DATA DESCRIPTION
        ======================

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
        private string[] sinkBrands = { "Rocell", "Nantucket", "Rohl", "American Standard", "Kohler", "Bochchi", "Crestwood", "Blanco", "Häfele" };
        private string[] heaterBrands = { "A.O. Smith", "Rheem", "Kenmore", "Bradford White", "American Standard", "Bosch", "EcoSmart", "Navien", "Noritz", "Reliance", "Rinnai", "Stiebel Eltron", "Takagi", "Whirlpool", "Bajaj", "LG", "Samsung", "Voltas" };
        private string[] lightingBrands = { "PINCH ", "Calligaris", "DelightFULL", "Bert Frank", "Art et Floritude", "IQlight ", "David Hunt", "Le Deun Luminaires", "PSLAB ", "Andromeda Murano", "DIMO", "Hayleys", "Photonics", "Philips", "Voltas" };
        private string[] phoneBrands = { "ASUS ", "Huawei", "ZTE", "Gigaset", "TP-Link", "Alcatel", "Motorola", "Prolink" };
        private string[] plumbingBrands = { "Rocell", "Nantucket", "Rohl", "American Standard", "Kohler", "Bochchi", "Crestwood", "Blanco", "Häfele" };
        private string[] computerBrands = { "ASUS ", "Acer", "Dell", "HP", "Lenovo", "Apple", "Samsung", "MSI", "Alienware", "Microsoft", "Sony", "Toshiba", "Compaq", "IBM", "Iball" };
        private string[] fireExtinguisherBrands = { "Amerex", "First Alert", "Kidde", "Buckeye", "Total Safety", "Johnson Controls", "United Technologies Corp", "Cleanguard" };
        private string[] liftBrands = { "Kone", "Fujitec", "Mitsubishi electric", "Schindler elevator", "Otis elevator", "Hitachi", "Kinetic Hyundai", "ESCON elevators", "Expedite Automation LLP", "ThyssenKrupp Elevator" };
        private string[] printerScannerBrands = { "Ricoh", "HP", "RISO", "Lexmark", "Brother", "Hitachi", "Canon", "Epson", "Kyocera " };
        private string[] sanitationBrands = { "Kohler", "TOTO", "Aquant", "Duravit", "VitrA", "American Standard", "Jaquar", "Cera", "Hindware" };
        private string[] networkDeviceBrands = { "Cisco", "Netgear", "Hewlett Packard", "TP-Link", "D-Link", "TRENDnet", "Juniper Networks", "Brocade Communications", "IBM", "ZTE", "Huawei" };
        private settingsParent inst;
        private string assetType;
        public add_item()
        {
            InitializeComponent();
        }
        public add_item(settingsParent asset)
        {
            InitializeComponent();
            this.inst = asset;            
        }
        public add_item(settingsParent asset, string assetType)
        {
            InitializeComponent();
            this.assetType = assetType;
            prefillContents();
            this.inst = asset;
        }
        public add_item(string assetType)
        {
            InitializeComponent();
            this.assetType = assetType;
            prefillContents();
            //this.Text = "Add " + assetType;
        }
        private void prefillContents()
        {
            string fileRelPath = "../../prog_logs/tracker/";
            int n = int.Parse(File.ReadAllText(fileRelPath + assetType + ".txt"));
            txt_general_code.Text = "ASS-" + assetType.ToUpper() + "-" + n;
            txt_general_code.Enabled = false;
            try
            {
                File.WriteAllText(fileRelPath + assetType + ".txt", (++n).ToString());
            }
            catch (Exception)
            {
                //continues even if an exception occurs
            }

            //Filling combo-boxes
            switch (assetType)
            {
                case "Heater":
                    combo_general_manu.DataSource = heaterBrands;
                    break;
                case "Network Device":
                    combo_general_manu.DataSource = networkDeviceBrands;
                    break;
                case "Sanitation Device":
                    combo_general_manu.DataSource = sanitationBrands;
                    break;
                case "PrinterScanner":
                    combo_general_manu.DataSource = printerScannerBrands;
                    break;
                case "Lift":
                    combo_general_manu.DataSource = liftBrands;
                    break;
                case "Fire Extinguisher":
                    combo_general_manu.DataSource = fireExtinguisherBrands;
                    break;
                case "Computer":
                    combo_general_manu.DataSource = computerBrands;
                    break;
                case "Plumbing Device":
                    combo_general_manu.DataSource = plumbingBrands;
                    break;
                case "Phone":
                    combo_general_manu.DataSource = phoneBrands;
                    break;
                case "Sink":
                    combo_general_manu.DataSource = heaterBrands;
                    break;
                case "Lighting":
                    combo_general_manu.DataSource = lightingBrands;
                    break;
            }

        }
        protected void collectInformation()
        {
            
        }
        protected bool updateDatabase(string assetType)
        {
            bool success;
            string updateWarranty = "insert into Warranty(warrantyCode, type, startDate, endDate) values ('" + warranty[0] + "', '" + warranty[1] + "', '" + warranty[2] + "', '" + warranty[3] + "');";
            string updateAsset = "insert into NonCurrentAsset(asset_id, assetType, serialNumber, manufacturer, state, plant, condition, criticality, warrantyCode, installationDate, purchaseDate, costOfPurchase, invoiceNumber, currentMarketValue, lifetime, depreciationMethod, depreciationRate) values " +
                "('" + general[0] + "', '" + assetType + "', '" + general[2] + "', '" + general[3] + "', '" + general[5] + "', '" + installation[2] + "', '" + maintenance[1] + "', '" + maintenance[2] + "', '" + warranty[0] + "', '" + installation[0] + "', '" + installation[1] + "', " + administrative[0] + ", '" + administrative[1] + "', " + administrative[2] + ", " + administrative[4] + ", '" + administrative[7] + "', " + administrative[8] + ");";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(updateWarranty, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        success = true;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Couldn't submit information.");
                        TextWriter.writeContent("logs.txt", ex.ToString());
                        success = false;
                        return success;
                    }
                }
                using (SqlCommand command = new SqlCommand(updateAsset, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Couldn't submit information.");
                        TextWriter.writeContent("logs.txt", ex.ToString());
                        success = false;
                        return success;
                    }
                }
            }
            return success;
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
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btn_reset_Click(sender, e);
            general = getGeneralInformation();
            administrative = getAdministrativeInformation();
            warranty = getWarrantyInformation();
            installation = getInstallInformation();
            maintenance = getMaintenanceInformation();
            location = getLocationInformation();
            bool success = updateDatabase(assetType);
            if (success)
            {
                MessageBox.Show("Submitted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
        public string[] getGeneralInformation()
        {
            string[] info = new string[6];
            if (true)
            {
                info[0] = txt_general_code.Text.Trim();
                string a = txt_general_code.Text.Trim();
                info[1] = txt_general_name.Text.Trim();
                info[2] = txt_general_serial.Text.Trim();
                info[3] = combo_general_manu.Text;
                info[4] = combo_general_supplier.Text;
                info[5] = combo_general_state.Text;
                return info;
            }
            else
            {
                return info;
            }
        }
        public string[] getAdministrativeInformation()
        {
            string[] info = new string[10];
            if (true)
            {
                info[0] = txtPurchasedPrice.Text.ToString().Replace('.', ' ').Trim();
                info[1] = txtInvoiceNumber.Text.ToString().Trim();
                info[2] = txtCurrentVal.Text.ToString().Replace('.', ' ').Trim();
                info[3] = dateDisposal.Text.ToString();
                info[4] = txtYearsOfLife.Text.ToString().Replace('.', ' ').Trim();
                info[5] = dateDepreciationStart.Text.ToString();
                info[6] = dateDepreciationEnd.Text.ToString();
                if (radBtn_reducingBalance.Checked)
                {
                    info[7] = "reducing-balance";
                }
                else
                {
                    info[7] = "straight-line";
                }
                info[8] = txtDepreciationRate.Text.ToString().Replace('.', ' ').Trim();
                info[9] = checkboxFullyDepreciated.Checked.ToString();
            }
            return info;
        }
        public string[] getWarrantyInformation()
        {
            string[] info = new string[4];
            if (true)
            {
                info[0] = txtWarrantyCode.Text.ToString().Trim();
                info[1] = comboType.Text.ToString();
                info[2] = dateStart.Text.ToString();
                info[3] = dateEnd.Text.ToString();
            }
            return info;
        }
        public string[] getInstallInformation()
        {
            string[] info = new string[3];
            info[0] = dateInstallation.Text.ToString();
            info[1] = dateAcceptance.Text.ToString();
            info[2] = comboPlant.Text.ToString();
            return info;
        }
        public string[] getMaintenanceInformation()
        {
            string[] info = new string[4];
            info[0] = comboMaintainedBy.Text.ToString();
            info[1] = comboCondition.Text.ToString();
            info[2] = comboCriticality.Text.ToString();
            info[3] = dateLastChecked.Text.ToString();
            return info;
        }
        public string[] getLocationInformation()
        {
            string[] info = new string[4];
            info[0] = comboBranch.Text.ToString();
            info[1] = comboBuilding.Text.ToString();
            info[2] = comboFloor.Text.ToString();
            info[3] = comboRoom.Text.ToString();
            return info;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            inst.clickedAddItemCancel();
        }
    }
}
