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
using DGVPrinterHelper;

namespace Asset_and_Maintenance_Management_System.src.Maintenance
{
    public partial class uc_maintenance_backlog : UserControl
    {
        Dashboard.MainDashboard inst;
        public void setDashboardInstance(Dashboard.MainDashboard inst)
        {
            this.inst = inst;
        }
        public uc_maintenance_backlog()
        {
            InitializeComponent();
            populateDataGridView();
            loadChart();
        }
        public void populateDataGridView()
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
        public void loadChart()
        {
            foreach (var series in chartVarience.Series)
            {
                series.Points.Clear();
            }
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
            DataGridView copy = CopyDataGridView(dataGridViewMain);
            DGVPrinter printer = new DGVPrinter();

            for (int i = 0; i < copy.Columns.Count; i++)
            {
                copy.Columns[i].Width = 150;
            }

            printer.Title = "Maintenance Backlog";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;

            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "~ AMMS ~";
            printer.FooterSpacing = 15;
            //int a = dataGridViewWarranty.Rows.Count;
            printer.PrintDataGridView(copy);
        }
    }
}
