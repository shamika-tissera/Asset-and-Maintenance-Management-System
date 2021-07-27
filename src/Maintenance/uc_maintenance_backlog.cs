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

namespace Asset_and_Maintenance_Management_System.src.Maintenance
{
    public partial class uc_maintenance_backlog : UserControl
    {
        Dashboard.Dashboard inst;
        public void setDashboardInstance(Dashboard.Dashboard inst)
        {
            this.inst = inst;
        }
        public uc_maintenance_backlog()
        {
            InitializeComponent();
            populateDataGridView();
            loadChart();
        }
        private void populateDataGridView()
        {
            string query = "set nocount off select asset_id as 'Asset ID', serviceDue as 'Service Due', DATEDIFF(day, serviceDue, getDate()) as 'Delay' from NonCurrentAsset where DATEDIFF(day, serviceDue, getDate()) > 0;";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataTable data = new DataTable())
                        {
                            adapter.Fill(data);
                            dataGridViewMain.DataSource = data;
                            for(int i = 0; i < dataGridViewMain.Columns.Count; i++)
                            {
                                dataGridViewMain.Columns[i].Width = 125;
                            }
                        }
                    }
                }
            }
        }
        private void loadChart()
        {
            string query = "set nocount off select asset_id as 'Asset ID', DATEDIFF(day, serviceDue, getDate()) as 'Days' from NonCurrentAsset where DATEDIFF(day, serviceDue, getDate()) > 0;";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataTable data = new DataTable())
                        {
                            adapter.Fill(data);
                            foreach(DataRow row in data.Rows)
                            {
                                chartVarience.Series["Days"].Points.AddXY(row["Asset ID"].ToString(), int.Parse(row["Days"].ToString()));
                            }
                        }
                    }
                }
            }
        }
        private void uc_maintenance_backlog_Load(object sender, EventArgs e)
        {

        }
    }
}
