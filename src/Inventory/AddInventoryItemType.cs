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

namespace Asset_and_Maintenance_Management_System.src.Inventory
{
    public partial class AddInventoryItemType : Form
    {
        public AddInventoryItemType()
        {
            InitializeComponent();
            comboType.SelectedIndex = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtCode.Text = "";
            txtCurrentCost.Text = "";
            txtName.Text = "";
            txtThreshold.Text = "";
            comboType.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string query =
                "insert into InventoryItem(inventoryCode, inventoryName, inventoryType, threshold, currentQuantity, CurrentCost) values ('" + txtCode.Text.Trim() + "', '" + txtName.Text.Trim() + "', '" + comboType.Text + "', " + txtThreshold.Text.Trim() + ", 0, " + txtCurrentCost.Text.Trim() + ");";
            if (txtCode.Text.Trim() != "" && txtCurrentCost.Text.Trim() != "" && txtName.Text.Trim() != "" &&
                txtThreshold.Text.Trim() != "")
            {
                using (SqlConnection connection = DBConnection.establishConnection())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            int rows = command.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Record not added. Please try again later.", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Record not added. Please try again later.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        TextWriter.writeContent("logs.txt", ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
