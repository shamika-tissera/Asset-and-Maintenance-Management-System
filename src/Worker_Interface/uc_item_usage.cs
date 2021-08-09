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
    public partial class uc_item_usage : UserControl
    {
        public uc_item_usage()
        {
            InitializeComponent();
            loadComboBoxes();
            comboType.SelectedIndex = 1;

            DataTable table = new DataTable();
            string query = "select threshold, currentQuantity from InventoryItem where inventoryName = '" + comboType.Text + "';";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        txtCurrentLevel.Text = table.Rows[0]["currentQuantity"].ToString();
                        txtThreshold.Text = table.Rows[0]["threshold"].ToString();
                    }
                }
            }
        }

        public void loadComboBoxes()
        {
            DataTable table = new DataTable();
            string[] items;
            string query = "select distinct inventoryName from InventoryItem;";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        int i = 0;
                        items = new string[table.Rows.Count];
                        foreach (DataRow row in table.Rows)
                        {
                            items[i] = row["inventoryName"].ToString();
                            i++;
                        }

                        comboType.DataSource = items;
                    }
                }
            }
        }
        private void changedStockCategoryDropDown(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            string query = "select threshold, currentQuantity from InventoryItem where inventoryName = '" + comboType.Text + "';";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        txtCurrentLevel.Text = table.Rows[0]["currentQuantity"].ToString();
                        txtThreshold.Text = table.Rows[0]["threshold"].ToString();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int usage = 0;
            try
            {
                usage = int.Parse(txtUsage.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter a valid number as 'usage'.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                TextWriter.writeContent("logs.txt", ex.ToString());
                return;
            }

            string procedure = "EXEC UpdateCurrentStockLevelsAfterUsage '" + comboType.Text + "', " + usage + ";";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(procedure, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Successfully recorded the information.", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    TextWriter.writeContent("logs.txt", ex.ToString());
                    MessageBox.Show("Sorry, couldn't submit details. Please contact the administrator", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            loadComboBoxes();
        }
    }
}
