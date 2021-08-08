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

namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    public partial class dashboard_info : UserControl
    {
        public dashboard_info()
        {
            InitializeComponent();
            setValues();
        }

        private void setValues()
        {
            string assetsRecordsQuery = "select count(*) from NonCurrentAsset where state != 'Disposed';";
            string assetsTypesQuery = "select count(distinct assetType) from NonCurrentAsset where state != 'Disposed';";
            string assetsInStock = "select count(*) from NonCurrentAsset where state = 'In stock';";
            string assetsInUse = "select count(*) from NonCurrentAsset where state = 'In use';";

            string allLocationsSitesQuery = "select count(distinct plant) from NonCurrentAsset;";

            string needsAttentionHighQuery =
                "select count(*) from WorkerReports where criticality_machineOperations = 'high'";
            string needsAttentionModerateQuery =
                "select count(*) from WorkerReports where criticality_machineOperations = 'moderate'";
            string needsAttentionLowQuery =
                "select count(*) from WorkerReports where criticality_machineOperations = 'low'";
            using (SqlConnection connection = DBConnection.establishConnection())
            {

                //Sets values for 'All Assets' Field
                using (SqlCommand command = new SqlCommand(assetsRecordsQuery, connection))
                {
                    lblAssetsRecords.Text = command.ExecuteScalar().ToString();
                }
                using (SqlCommand command = new SqlCommand(assetsTypesQuery, connection))
                {
                    lblAssetsTypes.Text = command.ExecuteScalar().ToString();
                }
                using (SqlCommand command = new SqlCommand(assetsInStock, connection))
                {
                    lblAssetsInStock.Text = command.ExecuteScalar().ToString();
                }
                using (SqlCommand command = new SqlCommand(assetsInUse, connection))
                {
                    lblAssetsInUse.Text = command.ExecuteScalar().ToString();
                }

                //Sets values for 'All locations' Field
                using (SqlCommand command = new SqlCommand(allLocationsSitesQuery, connection))
                {
                    lblAllLocationsSites.Text = command.ExecuteScalar().ToString();
                }

                //Sets values for 'Needs Attention' Field
                using (SqlCommand command = new SqlCommand(needsAttentionHighQuery, connection))
                {
                    lblNeedsAttentionCritical.Text = command.ExecuteScalar().ToString();
                }
                using (SqlCommand command = new SqlCommand(needsAttentionModerateQuery, connection))
                {
                    lblNeedsAttentionModerate.Text = command.ExecuteScalar().ToString();
                }
                using (SqlCommand command = new SqlCommand(needsAttentionLowQuery, connection))
                {
                    lblNeedsAttentionLow.Text = command.ExecuteScalar().ToString();
                }
            }
        }

        private void lbl_uname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
