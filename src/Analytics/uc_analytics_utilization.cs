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
    public partial class uc_analytics_utilization : UserControl
    {
        DataTable table;
        public uc_analytics_utilization()
        {
            InitializeComponent();
            populateDataGridView();
            loadChart();
        }
        private void populateDataGridView()
        {
            table = new DataTable();
            string query = "select NonCurrentAsset.asset_id as 'Asset ID', NonCurrentAsset.assetType as 'Asset Type', NonCurrentAsset.lifetime*12 as 'Lifetime (months)', DATEDIFF(month, purchaseDate, disposedDate) as 'Actual Lifetime (months)', (DATEDIFF(month, purchaseDate, disposedDate) - NonCurrentAsset.lifetime*12) as 'Varience' from NonCurrentAsset inner join Disposal on NonCurrentAsset.asset_id = Disposal.asset_id;";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            table.Columns.Add("Percentage", typeof(string));
            foreach (DataRow row in table.Rows)
            {
                int usage = int.Parse(row["Actual Lifetime (months)"].ToString());
                int lifetime = int.Parse(row["Lifetime (months)"].ToString());
                string percentage = ((usage / lifetime) * 100).ToString() + '%';
                row["Percentage"] = percentage;
            }
            dataGridViewUtilization.DataSource = table;
        }
        private void loadChart()
        {
            foreach (DataRow row in table.Rows)
            {
                int usage = int.Parse(row["Actual Lifetime (months)"].ToString());
                int lifetime = int.Parse(row["Lifetime (months)"].ToString());
                int percentage = (usage / lifetime) * 100;
                chartUtilization.Series["%"].Points.AddXY(row["Asset Type"].ToString(), percentage);
            }
        }

    }
}
