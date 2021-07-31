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
using System.Net;
using System.Net.Mail;

namespace Asset_and_Maintenance_Management_System.src.Approval
{
    public partial class StockRequest : Form
    {
        public StockRequest()
        {
            InitializeComponent();
            populateComboBoxes();
        }
        private void populateComboBoxes()
        {
            string querySupplierNames = "select supplierName from Supplier;";
            string queryInventoryTypes = "select inventoryName from InventoryItem order by inventoryName asc;";
            string queryInventoryCode = "select inventoryCode from InventoryItem order by inventoryName asc;";
            DataTable supplierNames = new DataTable();
            DataTable inventoryTypes = new DataTable();
            DataTable inventoryCodes = new DataTable();

            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(queryInventoryCode, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(inventoryCodes);
                    }
                }
                using (SqlCommand command = new SqlCommand(queryInventoryTypes, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(inventoryTypes);
                    }
                }
                using (SqlCommand command = new SqlCommand(querySupplierNames, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(supplierNames);
                    }
                }
                comboStockCode.DataSource = inventoryCodes;
                comboStockType.DataSource = inventoryTypes;
                comboSupplier.DataSource = supplierNames;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_units.Text == "")
            {
                MessageBox.Show("Please complete the 'units' field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult response = MessageBox.Show("You are about to initiate a stock request. Continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(response == DialogResult.Yes)
                {
                    try
                    {
                        string responsiblePerson = "NULL";
                        if(txtResponsiblePerson.Text.Trim() != "")
                        {
                            responsiblePerson = txtResponsiblePerson.Text.Trim();
                        }
                        string query = "insert into InventoryOrder(plant, requestTime, responsiblePerson, stockType, supplierName, units) values ('" + comboPlant.Text + "', '" + DateTime.Today + "', '" + responsiblePerson + "', '" + comboStockType.Text + "', '" + comboSupplier.Text + "', " + txt_units.Text + ")";

                        using (SqlConnection connection = new SqlConnection())
                        {
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                                if(rowsAffected > 0)
                                {
                                    MessageBox.Show("Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch(SqlException ex)
                    {
                        TextWriter.writeContent("log.txt", ex.ToString());
                    }

                }
            }
        }
        private void sendEmail()
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
