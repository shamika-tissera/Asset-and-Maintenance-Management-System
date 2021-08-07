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
using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;

namespace Asset_and_Maintenance_Management_System.src.Dashboard
{
    public partial class uc_dispose_asset : UserControl
    {
        private DataTable table;
        public uc_dispose_asset()
        {
            InitializeComponent();
            populateAssetRecords();
        }
        public void populateAssetRecords()
        {
            DataTable data;
            string query = "SELECT asset_id as 'Asset Code', assetType, lifetime, costOfPurchase, depreciationMethod, depreciationRate, purchaseDate, manufacturer, serviceInterval, warranty FROM NonCurrentAsset WHERE state != 'Disposed';";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    data = new DataTable();
                    adapter.Fill(data);
                }
                data.Columns.Add("CarryingValue", typeof(string));
                calculateCarryingValue(ref data);
                data.Columns.Add("Dispose", typeof(bool));
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
                    dataGridViewAssets.Columns[i].Width = 125;
                }
            }
            table = data;
        }

        private void calculateCarryingValue(ref DataTable data)
        {
            foreach (DataRow row in data.Rows)
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
                        if (carryingValue > int.Parse(row["costOfPurchase"].ToString()))
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

        private void textChangeEvent(object sender, EventArgs e)
        {
            DataTable data;
            string value = txtSearch.Text.Trim();
            string query =
                "select asset_id as 'Asset Code', assetType, lifetime, costOfPurchase, depreciationMethod, depreciationRate, purchaseDate, manufacturer, serviceInterval, warranty from NonCurrentAsset where (asset_id like '%" + value + "%' OR plant like '%" + value + "%' OR depreciationMethod like '%" + value + "%' OR serialNumber like '%" + value + "%' or condition like '%" + value + "%' or state like '%" + value + "%' or assetType like '%" + value + "%' or warrantyCode like '%" + value + "%' or manufacturer like '%" + value + "%') and (state != 'Disposed');";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                data = new DataTable();
                try
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(data);
                    }
                    data.Columns.Add("Dispose", typeof(bool));
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
        }

        private void btnDispose_Click(object sender, EventArgs e)
        {
            string assetID;
            bool isChecked = false;

            foreach (DataGridViewRow row in dataGridViewAssets.Rows)
            {
                try
                {
                    string a = row.Cells["Dispose"].Value.ToString();
                    int b = dataGridViewAssets.Rows.Count;
                    if (row.Cells["Dispose"].Value.ToString() == "True")
                    {
                        assetID = row.Cells["Asset Code"].Value.ToString();
                        DisposeAsset disposal = new DisposeAsset();
                        disposal.setAssetCode(assetID);
                        disposal.setAssetInstance(this);
                        disposal.Show();
                        //orderedQuantity = int.Parse(row.Cells["Ordered Quantity"].Value.ToString());
                        //supplierName = row.Cells["Supplier Name"].Value.ToString().Replace("\r\n", " ").Trim();
                        //string query = "UPDATE InventoryOrder SET received = 'TRUE' WHERE inventoryCode = '" + inventoryCode + "' AND orderedQuantity = '" + orderedQuantity + "'";
                        isChecked = true;
                        //using (SqlConnection connection = DBConnection.establishConnection())
                        //{
                        //    using (SqlCommand command = new SqlCommand(query, connection))
                        //    {
                        //        try
                        //        {
                        //            command.ExecuteNonQuery();
                        //        }
                        //        catch (SqlException ex)
                        //        {
                        //            TextWriter.writeContent("logs.txt", ex.ToString());
                        //        }
                        //    }
                        //}
                        //dataGridViewMain.Rows.RemoveAt(row.Index);
                    }
                }
                catch (NullReferenceException ex)
                {
                    TextWriter.writeContent("logs.txt", ex.ToString());
                    MessageBox.Show("lol");
                    break;
                }
            }
            if (!isChecked)
            {
                MessageBox.Show("Please select an item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
