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

namespace Asset_and_Maintenance_Management_System.src.Analytics
{
    public partial class uc_analytics_intial_dash : UserControl
    {
        Dashboard.MainDashboard inst;
        public uc_analytics_intial_dash()
        {
            InitializeComponent();
            fillWarrantyPieChart();
            fillAssetLifetimePieChart();            
        }
        private void fillWarrantyPieChart()
        {
            string queryAllAssets = "SET NOCOUNT OFF SELECT COUNT(*) as 'COUNT' FROM dbo.NonCurrentAsset;";
            string queryNoWarrantyAssets = "SET NOCOUNT OFF SELECT COUNT(*) as 'COUNT' FROM dbo.NonCurrentAsset WHERE warrantyCode IS NULL;";
            string queryActiveWarrantyAssets = "SELECT COUNT(*) as 'COUNT' FROM dbo.Warranty WHERE endDate >= getdate();";
            int countAllAssets, countNoWarrantyAssets, countWarrantyAssets, countActiveWarrentyAssets, 
                countInactiveWarrantyAssets;
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(queryAllAssets, connection))
                {
                    countAllAssets = (int)command.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand(queryNoWarrantyAssets, connection))
                {
                    countNoWarrantyAssets = (int)command.ExecuteScalar();
                    countWarrantyAssets = countAllAssets - countNoWarrantyAssets;
                }
                using (SqlCommand command = new SqlCommand(queryActiveWarrantyAssets, connection))
                {
                    countActiveWarrentyAssets = (int)command.ExecuteScalar();
                    countInactiveWarrantyAssets = countWarrantyAssets - countActiveWarrentyAssets;
                }
            }
            chart_warranty.Titles.Add("Warranty");
            chart_warranty.Series["s1"].Points.AddXY("Active", countActiveWarrentyAssets);
            chart_warranty.Series["s1"].Points.AddXY("Inactive", countInactiveWarrantyAssets);
            chart_warranty.Series["s1"].Points.AddXY("Not Provided", countNoWarrantyAssets);
        }
        private void fillAssetLifetimePieChart()
        {
            string queryLowLifeAssets = "select COUNT(*) as COUNT from NonCurrentAsset WHERE DATEDIFF(year, getDate(), DATEADD(year, 5, purchaseDate)) < 5;";
            string queryAllAssets = "SET NOCOUNT OFF SELECT COUNT(*) as 'COUNT' FROM dbo.NonCurrentAsset WHERE state != 'Disposed';";
            int countAllAssets, countLowLifeAssets, countHighLifeAssets;
            using(SqlConnection connection = DBConnection.establishConnection())
            {
                using(SqlCommand command = new SqlCommand(queryAllAssets, connection))
                {
                    countAllAssets = (int)command.ExecuteScalar();
                }
                using (SqlCommand command = new SqlCommand(queryLowLifeAssets, connection))
                {
                    countLowLifeAssets = (int)command.ExecuteScalar();
                    countHighLifeAssets = countAllAssets - countLowLifeAssets;
                }
            }
            chart_lifetime.Titles.Add("Asset Lifetime");
            chart_lifetime.Series["d1"].Points.AddXY("< 5 years", countHighLifeAssets);
            chart_lifetime.Series["d1"].Points.AddXY("> 5 years", countLowLifeAssets);
        }
        private bool isWarrantyActive(string endDate)
        {
            if(DateTime.Now < Convert.ToDateTime(endDate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void setDashboardInstance(Dashboard.MainDashboard inst)
        {
            this.inst = inst;
        }

        private void chart_warranty_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_analytics_intial_dash_Load(object sender, EventArgs e)
        {

        }
    }
}
