using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;
using DGVPrinterHelper;
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
    public partial class uc_analytics_warranty : UserControl
    {
        private static Dashboard.MainDashboard inst;
        public static void setDashboardInstance(Dashboard.MainDashboard instance)
        {
            inst = instance;
        }
        public uc_analytics_warranty()
        {
            InitializeComponent();
            populateDataGridView();
        }
        public void populateDataGridView()
        {
            DataTable data;
            string query = "select asset_id as 'Asset Code', assetType as 'Asset Type', DATEDIFF(month, GETDATE(), endDate) as 'Months Remaining', purchaseDate, costOfPurchase, depreciationMethod, depreciationRate from NonCurrentAsset inner join Warranty on NonCurrentAsset.warrantyCode=Warranty.warrantyCode where endDate > GETDATE();";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
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
                dataGridViewWarranty.DataSource = data;

                //resize DataGridView
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    dataGridViewWarranty.Columns[i].Width = 243;
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
        private DataGridView CopyDataGridView(DataGridView dgv_org)
        {
            DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgv_copy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgv_copy.Rows.Add(row);
                }
                dgv_copy.AllowUserToAddRows = false;
                dgv_copy.Refresh();

            }
            catch (Exception ex)
            {
                TextWriter.writeContent("logs.txt", ex.ToString());
            }
            return dgv_copy;
        }
        private void btn_print_Click(object sender, EventArgs e)
        {
            DataGridView copy = CopyDataGridView(dataGridViewWarranty);
            DGVPrinter printer = new DGVPrinter();

            for (int i = 0; i < copy.Columns.Count; i++)
            {
                copy.Columns[i].Width = 150;
            }

            printer.Title = "Warranty Report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "AMMS";
            printer.FooterSpacing = 15;
            //int a = dataGridViewWarranty.Rows.Count;
            printer.PrintDataGridView(copy);
        }
    }
}
