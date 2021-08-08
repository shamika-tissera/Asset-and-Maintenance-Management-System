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
using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;
using DGVPrinterHelper;

namespace Asset_and_Maintenance_Management_System.src.Worker_Interface
{
    public partial class uc_previously_reported : UserControl
    {
        public uc_previously_reported()
        {
            InitializeComponent();
        }

        private string username;
        public void setUsername(string username)
        {
            this.username = username;
            populateDataGridView();
        }
        public void populateDataGridView()
        {
            string query =
                "select asset_id as 'Asset Code', reported_date as 'Reported Date', managerRespoded as 'Approved1', performed as 'Completed1' from WorkerReports where username = '" + username + "';";
            DataTable table = new DataTable();
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        table.Columns.Add("Approved", typeof(string));
                        table.Columns.Add("Completed", typeof(string));

                        foreach (DataRow row in table.Rows)
                        {
                            if (row["Approved1"].ToString() == "1" || row["Approved1"].ToString() == "True" ||
                                row["Approved1"].ToString() == "true" || row["Approved1"].ToString() == "TRUE")
                            {
                                row["Approved"] = "Approved";
                            }
                            else
                            {
                                row["Approved"] = "Not Approved";
                            }

                            if (row["Completed1"].ToString() == "1" || row["Completed1"].ToString() == "True" ||
                                row["Completed1"].ToString() == "true" || row["Completed1"].ToString() == "TRUE")
                            {
                                row["Completed"] = "Done";
                            }
                            else
                            {
                                row["Completed"] = "Not yet";
                            }
                        }

                        table.Columns.Remove("Approved1");
                        table.Columns.Remove("Completed1");

                        dataGridView1.DataSource = table;

                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            dataGridView1.Columns[i].Width = 235;
                        }
                    }
                }
            }

            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15.5F, GraphicsUnit.Pixel);
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

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView copy = CopyDataGridView(dataGridView1);
            DGVPrinter printer = new DGVPrinter();

            for (int i = 0; i < copy.Columns.Count; i++)
            {
                copy.Columns[i].Width = 150;
            }

            printer.Title = "Previously Reported - " + username;
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
