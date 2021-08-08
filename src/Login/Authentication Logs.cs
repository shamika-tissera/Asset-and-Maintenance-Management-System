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

        private void btnDispose_Click(object sender, EventArgs e)
        {
            DataGridView copy = CopyDataGridView(dataGridView1);
            DGVPrinter printer = new DGVPrinter();

            for (int i = 0; i < copy.Columns.Count; i++)
            {
                copy.Columns[i].Width = 150;
            }

            printer.Title = "Authentication Logs";
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
