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

namespace Asset_and_Maintenance_Management_System.src.Approval
{
    public partial class uc_stock_requests : UserControl
    {
        public uc_stock_requests()
        {
            InitializeComponent();
            populateDataGridView();
        }
        private void populateDataGridView()
        {
            string query = "select  InventoryOrder.inventoryCode as 'Stock Code', inventoryName as 'Stock Name', orderedQuantity as 'Ordered Quantity', supplierName as 'Supplier Name', (orderedQuantity * CurrentCost) as 'Estimated Cost (Rs.)', responsiblePerson as 'In charge', plant as 'Plant' from InventoryOrder inner join Supplier on InventoryOrder.supplierID = Supplier.supplierID inner join InventoryItem on InventoryItem.inventoryCode = InventoryOrder.inventoryCode where received = 0;";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataTable data = new DataTable())
                        {
                            adapter.Fill(data);
                            //foreach(DataRow row in data.Rows)
                            //{
                            //    switch(row["Stock Name"].ToString())
                            //    {
                            //        case "PVC":
                            //            string dataPresent = row["Ordered Quantity"].ToString();
                            //            row["Ordered Quantity"] = dataPresent + "kg";
                            //            break;
                            //    }
                            //}
                            dataGridViewMain.DataSource = data;
                            for (int i = 0; i < dataGridViewMain.Columns.Count; i++)
                            {
                                dataGridViewMain.Columns[i].Width = 150;
                            }
                        }
                    }
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
        private void button1_Click(object sender, EventArgs e)
        {
            StockRequest stockRequest = new StockRequest();
            stockRequest.setParentInstance(this);
            stockRequest.Show();
        }

        public void clickedRequestSubmit()
        {
            populateDataGridView();
            dataGridViewMain.Update();
            dataGridViewMain.Refresh();
        }
        public void refreshData()
        {
            dataGridViewMain.Refresh();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            DataGridView copy = CopyDataGridView(dataGridViewMain);
            DGVPrinter printer = new DGVPrinter();

            for (int i = 0; i < copy.Columns.Count; i++)
            {
                copy.Columns[i].Width = 150;
            }

            printer.Title = "Stock Requests";
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
