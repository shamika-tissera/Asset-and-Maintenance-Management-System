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
        private void populateDataGridView()
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
    }
}
