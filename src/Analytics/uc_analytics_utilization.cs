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
        public void populateDataGridView()
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
                double usage = double.Parse(row["Actual Lifetime (months)"].ToString());
                double lifetime = double.Parse(row["Lifetime (months)"].ToString());
                string percentage = ((int)((usage / lifetime) * 100)).ToString() + '%';
                row["Percentage"] = percentage;
            }
            //for (int i = 0; i < data.Columns.Count; i++)
            //{
            //    dataGridViewUtilization.Columns[i].Width = 171;
            //}
            
            dataGridViewUtilization.DataSource = table;
            dataGridViewUtilization.Columns[0].Width = 130;
            dataGridViewUtilization.Columns[1].Width = 70;
            dataGridViewUtilization.Columns[2].Width = 70;
            dataGridViewUtilization.Columns[3].Width = 70;
            dataGridViewUtilization.Columns[4].Width = 70;
            dataGridViewUtilization.Columns[5].Width = 90;
        }
        public void loadChart()
        {
            foreach (var series in chartUtilization.Series)
            {
                series.Points.Clear();
            }
            foreach (DataRow row in table.Rows)
            {
                double usage = double.Parse(row["Actual Lifetime (months)"].ToString());
                double lifetime = double.Parse(row["Lifetime (months)"].ToString());
                double percentage = (usage / lifetime) * 100;
                chartUtilization.Series["%"].Points.AddXY(row["Asset ID"].ToString(), percentage);
            }
        }

        private void chartUtilization_Click(object sender, EventArgs e)
        {

        }
    }
}
