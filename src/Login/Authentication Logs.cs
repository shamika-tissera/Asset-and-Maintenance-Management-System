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

namespace Asset_and_Maintenance_Management_System.src.Login
{
    public partial class Authentication_Logs : Form
    {
        public Authentication_Logs()
        {
            InitializeComponent();
            populateDataGridView();
        }

        private void populateDataGridView()
        {
            string query =
                "select username as 'Username', category as 'Employee Type', convert(varchar, loginTime, 0) as 'Time' from LoginLogs";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            using (DataTable table = new DataTable())
                            {
                                adapter.Fill(table);
                                dataGridView1.DataSource = table;

                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    dataGridView1.Columns[i].Width = 246;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Couldn't load data. Try again later.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    TextWriter.writeContent("logs.txt", ex.ToString());
                    this.Close();
                }
            }
        }
    }
}
