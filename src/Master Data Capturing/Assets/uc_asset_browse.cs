﻿using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;
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
    public partial class uc_asset_browse : UserControl
    {
        private string assetCategoryToFetchFromDatabase;
        public uc_asset_browse()
        {
            InitializeComponent();
        }
        public void setAssetCategory(string assetCategoryToFetchFromDatabase)
        {
            this.assetCategoryToFetchFromDatabase = assetCategoryToFetchFromDatabase;
        }
        private void uc_asset_browse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private DataTable populateAssetRecords()
        {
            DataTable data;
            string query = "SELECT assetType, lifetime, costOfPurchase, purchaseDate, manufacturer, serviceInterval, warranty FROM NonCurrentAsset;";
            using(SqlConnection connection = DBConnection.establishConnection())
            {
                using(SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    data = new DataTable();
                    adapter.Fill(data);
                }
            }
            return data;
        }
        private int calculateCarryingValue(double cost, DateTime purchaseDate)
        {

        }
    }
}
