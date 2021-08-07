using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Crmf;

namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    public partial class uc_asset_browse : UserControl
    {
        private DataTable table;
        private static string clickedAsset = null;
        public static void setClickedAsset(string asset)
        {
            clickedAsset = asset;
        }
        private string assetCategoryToFetchFromDatabase;
        public uc_asset_browse()
        {
            InitializeComponent();
            populateAssetRecords();
            uc_navPanel_assets.setBrowse(this);
        }
        public void setAssetCategory(string assetCategoryToFetchFromDatabase)
        {
            this.assetCategoryToFetchFromDatabase = assetCategoryToFetchFromDatabase;
        }
        private void uc_asset_browse_Load(object sender, EventArgs e)
        {
            DataTable data;
            string value = txtSearch.Text.Trim();
            string query =
                "select asset_id, assetType, lifetime, costOfPurchase, depreciationMethod, depreciationRate, purchaseDate, manufacturer, serviceInterval, warranty from NonCurrentAsset where asset_id like '%" + value + "%' OR plant like '%" + value + "%' OR depreciationMethod like '%" + value + "%' OR serialNumber like '%" + value + "%' or condition like '%" + value + "%' or state like '%" + value + "%' or assetType like '%" + value + "%' or warrantyCode like '%" + value + "%' or manufacturer like '%" + value + "%';";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                data = new DataTable();
                try
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(data);
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    data = null;
                }

                try
                {
                    data.Columns.Add("CarryingValue", typeof(string));
                    calculateCarryingValue(ref data);

                    //delete all unneccessary columns from the DataTable
                    data.Columns.Remove("costOfPurchase");
                    data.Columns.Remove("depreciationMethod");
                    data.Columns.Remove("depreciationRate");
                    data.Columns.Remove("purchaseDate");
                    //populate DataGridView
                    dataGridViewAssets.DataSource = data;

                    //resize DataGridView
                    for (int i = 0; i < data.Columns.Count; i++)
                    {
                        dataGridViewAssets.Columns[i].Width = 171;
                    }
                }
                catch (NullReferenceException)
                {
                    dataGridViewAssets.DataSource = null;
                }

            }
            table = data;
            lblCount.Text = dataGridViewAssets.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void populateAssetRecords()
        {
            DataTable data;
            string query = "SELECT asset_id, assetType, lifetime, costOfPurchase, depreciationMethod, depreciationRate, purchaseDate, manufacturer, serviceInterval, warranty FROM NonCurrentAsset;";
            using(SqlConnection connection = DBConnection.establishConnection())
            {
                using(SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    data = new DataTable();
                    adapter.Fill(data);
                }
                data.Columns.Add("CarryingValue", typeof(string));
                calculateCarryingValue(ref data);

                //delete all unneccessary columns from the DataTable
                data.Columns.Remove("costOfPurchase");
                data.Columns.Remove("depreciationMethod");
                data.Columns.Remove("depreciationRate");
                data.Columns.Remove("purchaseDate");

                //populate DataGridView
                dataGridViewAssets.DataSource = data;

                //resize DataGridView
                for(int i = 0; i < data.Columns.Count; i++)
                {
                    dataGridViewAssets.Columns[i].Width = 171;
                }
            }
            table = data;
        }
        private void calculateCarryingValue(ref DataTable data)
        {
            foreach(DataRow row in data.Rows)
            {
                switch (row["depreciationMethod"].ToString())
                {
                    case "straight-line":
                        //string tes= row["purchaseDate"].ToString();
                        int purchaseYear = DateTime.Parse(row["purchaseDate"].ToString()).Year;
                        int currentYear = DateTime.Now.Year;
                        int yearDifference = currentYear - purchaseYear;
                        //int test = int.Parse(row["depreciationRate"].ToString());
                        double perYearDepreciation = double.Parse(row["depreciationRate"].ToString()) / 100 
                            * double.Parse(row["costOfPurchase"].ToString());
                        int carryingValue = yearDifference * (int)perYearDepreciation;
                        if(carryingValue > int.Parse(row["costOfPurchase"].ToString()))
                        {
                            row["CarryingValue"] = "EOL";
                        }
                        else
                        {
                            row["CarryingValue"] = carryingValue;
                        }                        
                        break;

                    case "reducing-balance":
                        int purchase_Year = DateTime.Parse(row["purchaseDate"].ToString(), new CultureInfo("en-US")).Year;
                        int current_Year = DateTime.Now.Year;
                        int year_Difference = current_Year - purchase_Year;
                        int carrying_value = int.Parse(row["costOfPurchase"].ToString());

                        for (int i = 0; i < year_Difference; i++)
                        {
                            carrying_value -= int.Parse(row["depreciationRate"].ToString()) / 100 * carrying_value;
                        }
                        row["CarryingValue"] = carrying_value;
                        break;
                }
            }
        }
        public void sortAssets(string assetType)
        {
            DataTable newDataTable = new DataTable();
            foreach(DataRow row in table.Rows)
            {
                if ((string)row["assetType"] == assetType)
                {
                    string test = (string)row["assetType"];
                    newDataTable.ImportRow(row);
                }
            }
            foreach(DataRow row in newDataTable.Rows)
            {
                MessageBox.Show(row.ToString());
            }
            dataGridViewAssets.AutoGenerateColumns = true;
            dataGridViewAssets.DataSource = null;
            dataGridViewAssets.DataSource = newDataTable;
            dataGridViewAssets.Refresh();

            //switch (assetType)
            //{
            //    case "Heater":

            //        break;
            //    case "Network Device":

            //        break;
            //    case "Sanitation Device":

            //        break;
            //    case "Printer/Scanner":

            //        break;
            //    case "Lift":

            //        break;
            //    case "Fire Extinguisher":

            //        break;
            //    case "Computer":

            //        break;
            //    case "Plumbing Device":

            //        break;
            //    case "Phone":

            //        break;
            //    case "Sink":

            //        break;
            //    case "Lighting":

            //        break;
            //}
        }
    }
}
