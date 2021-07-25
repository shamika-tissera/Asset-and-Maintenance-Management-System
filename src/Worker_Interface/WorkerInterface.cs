using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Worker_Interface
{
    public partial class WorkerInterface : Form
    {
        public WorkerInterface()
        {
            InitializeComponent();
            btn_reporting.BackColor = Color.FromArgb(255, 255, 255);
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
            string query = "insert into WorkerReports(username, reported_date, asset_id, plant, criticality_machineOperations, criticality_activityConstraints, managerRespoded) values('" + lbl_uname.Text + "', '7/25/2021', 'ASSET-001', 'Minuwangoda', 'high', 'high', 0); ";
        }
    }
}
