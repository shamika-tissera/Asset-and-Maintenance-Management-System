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
    public partial class WorkerInterface : Form
    {
        public WorkerInterface()
        {
            InitializeComponent();
            btn_reporting.BackColor = Color.FromArgb(255, 255, 255);
            comboType.SelectedIndex = 0;
            comboPlant.SelectedIndex = 0;
            comboCriticalOperational.SelectedIndex = 0;
            comboCriticalActivity.SelectedIndex = 0;
            

            uc_item_usage1.Visible = false;
            uc_previously_reported1.Visible = false;
            populateAssetIDCombo();
        }

        private void populateAssetIDCombo()
        {
            comboAssetID.DataSource = fetchAssetIDs();
        }

        //this method accesses the database and fetches all the asset ids and returns them as a list.
        private List<string> fetchAssetIDs()
        {
            string query = "SELECT asset_id FROM NonCurrentAsset where state != 'Disposed';";
            DataTable table = new DataTable();
            DataColumn column = new DataColumn();
            using(SqlConnection connection = DBConnection.establishConnection())
            {
                using(SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.Fill(table);
                }
            }
            List<string> assetID = new List<string>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                assetID.Add(table.Rows[i]["asset_id"].ToString());
            }
            return assetID;
        }

        public void setUsernameLabel(String username)
        {
            lbl_uname.Text = username;
        }

        private void btn_reporting_Click(object sender, EventArgs e)
        {
            btnItemUsage.BackColor = Color.FromArgb(232, 234, 237);
            btn_reporting.BackColor = Color.FromArgb(255, 255, 255);
            btnPreviouslyReported.BackColor = Color.FromArgb(232, 234, 237);
            uc_item_usage1.Visible = false;
            uc_previously_reported1.Visible = false;
            uc_previously_reported1.SendToBack();
            uc_item_usage1.SendToBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_reporting.BackColor = Color.FromArgb(232, 234, 237);
            btnItemUsage.BackColor = Color.FromArgb(255, 255, 255);
            btnPreviouslyReported.BackColor = Color.FromArgb(232, 234, 237);
            uc_previously_reported1.Visible = false;
            uc_item_usage1.Visible = true;
            uc_item_usage1.loadComboBoxes();
            uc_item_usage1.BringToFront();
        }
        private void click_previouslyReported(object sender, EventArgs e)
        {
            btnItemUsage.BackColor = Color.FromArgb(232, 234, 237);
            btnPreviouslyReported.BackColor = Color.FromArgb(255, 255, 255);
            btn_reporting.BackColor = Color.FromArgb(232, 234, 237);
            uc_previously_reported1.setUsername(lbl_uname.Text);
            uc_previously_reported1.Visible = true;
            uc_previously_reported1.populateDataGridView();
            uc_previously_reported1.BringToFront();
        }

        private void txtWarrantyCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void prepareDataGridViewData()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtMessage.Text == "")
            {
                if(MessageBox.Show("You are about to submit the report without a descriptive message." +
                    "\nAre you sure you want to proceed?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            string query = "INSERT INTO WorkerReports(username, reported_date, asset_id, plant, criticality_machineOperations, criticality_activityConstraints, managerRespoded, message) VALUES('" + lbl_uname.Text + "', '" + DateTime.Now.ToString("MM-dd-yy") + "', '" + comboAssetID.Text + "', '" + comboPlant.Text + "', '" + comboCriticalOperational.Text + "', '" + comboCriticalActivity.Text + "', 0, '" + txtMessage.Text + "'); ";
            using(SqlConnection connection = DBConnection.establishConnection())
            {
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int rowsEffected = command.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            MessageBox.Show("Report submitted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMessage.ResetText();
                            comboAssetID.ResetText();
                        }
                        else
                        {
                            MessageBox.Show("An error occurred. Couldn't submit report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch(System.Data.SqlClient.SqlException ex)
                    {
                        TextWriter.writeContent("logs.txt", ex.ToString());
                        MessageBox.Show("You have already submitted a report today on this asset!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void assetCode_SelectionChanged(object sender, EventArgs e)
        {
            string assetID = comboAssetID.Text;
            string query = "select assetType, plant from NonCurrentAsset where asset_id = '" + assetID + "';";
            DataTable table = new DataTable();
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                        string assetType = table.Rows[0]["assetType"].ToString();
                        string plant = table.Rows[0]["plant"].ToString();
                        comboType.Text = assetType;
                        comboPlant.Text = plant;
                    }
                }
            }
        }

        private Login.Login login;
        public void setLoginInstance(Login.Login login, string uname)
        {
            this.login = login;
            lbl_uname.Text = uname;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                login.resetContent();
                this.Dispose();
                login.Show();
            }
        }
    }
}
