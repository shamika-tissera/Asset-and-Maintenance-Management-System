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

namespace Asset_and_Maintenance_Management_System.src.Inventory
{
    public partial class uc_inventory_low : UserControl
    {
        public uc_inventory_low()
        {
            InitializeComponent();
            populateDataGridView();
        }
        public void populateDataGridView()
        {
            string query = "SELECT inventoryName AS 'Inventory Name', InventoryItem.currentQuantity as 'Current Quantity', InventoryItem.threshold as 'Threshold', currentQuantity - threshold as 'Varience' FROM InventoryItem WHERE currentQuantity < threshold order by (threshold - currentQuantity) asc;";
            DataTable table = new DataTable();
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

            dataGridViewLowInventory.DataSource = table;
            for (int i = 0; i < dataGridViewLowInventory.Columns.Count; i++)
            {
                dataGridViewLowInventory.Columns[i].Width = 241;
            }
            table.Dispose();
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
            DataGridView copy = CopyDataGridView(dataGridViewLowInventory);
            DGVPrinter printer = new DGVPrinter();

            for (int i = 0; i < copy.Columns.Count; i++)
            {
                copy.Columns[i].Width = 150;
            }

            printer.Title = "Low Inventory Items";
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
