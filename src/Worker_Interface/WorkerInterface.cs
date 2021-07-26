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
            populateAssetIDCombo();
        }

        private void populateAssetIDCombo()
        {
            comboAssetID.DataSource = fetchAssetIDs();
        }

        //this method accesses the database and fetches all the asset ids and returns them as a list.
        private List<string> fetchAssetIDs()
        {
            string query = "SELECT asset_id FROM NonCurrentAsset;";
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
            btn_previouslyReported.BackColor = Color.FromArgb(232, 234, 237);
            btn_reporting.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_reporting.BackColor = Color.FromArgb(232, 234, 237);
            btn_previouslyReported.BackColor = Color.FromArgb(255, 255, 255);
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



            string query = "insert into WorkerReports(username, reported_date, asset_id, plant, criticality_machineOperations, criticality_activityConstraints, managerRespoded) values('" + lbl_uname.Text + "', '7/25/2021', 'ASSET-001', 'Minuwangoda', 'high', 'high', 0); ";
        }
    }
}
