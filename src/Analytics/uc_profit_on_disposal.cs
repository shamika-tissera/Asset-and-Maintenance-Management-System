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

namespace Asset_and_Maintenance_Management_System.src.Analytics
{
    public partial class uc_profit_on_disposal : UserControl
    {
        public uc_profit_on_disposal()
        {
            InitializeComponent();
            populateDataGridView();
        }
        private void populateDataGridView()
        {
            DataTable data;
            string query = "select NonCurrentAsset.asset_id as 'Asset Code', assetType as 'Asset Type', disposedValue as 'Disposal Value', purchaseDate, costOfPurchase, depreciationMethod, depreciationRate from NonCurrentAsset inner join Disposal on NonCurrentAsset.asset_id = Disposal.asset_id;";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    data = new DataTable();
                    adapter.Fill(data);
                }
                data.Columns.Add("CarryingValue", typeof(string));
                calculateCarryingValue(ref data);

                data.Columns.Add("Profit", typeof(string));
                for(int i = 0; i < data.Rows.Count; i++)
                {
                    data.Rows[i]["Profit"] = (int.Parse(data.Rows[i]["Disposal Value"].ToString()) - int.Parse(data.Rows[i]["CarryingValue"].ToString())).ToString();
                }

                //delete all unneccessary columns from the DataTable
                data.Columns.Remove("costOfPurchase");
                data.Columns.Remove("depreciationMethod");
                data.Columns.Remove("depreciationRate");
                data.Columns.Remove("purchaseDate");

                //populate DataGridView
                dataGridViewProfitOnDisposal.DataSource = data;

                //resize DataGridView
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    dataGridViewProfitOnDisposal.Columns[i].Width = 194;
                }
            }
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
    }
}
