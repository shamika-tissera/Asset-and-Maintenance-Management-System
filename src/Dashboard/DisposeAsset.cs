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

namespace Asset_and_Maintenance_Management_System.src.Dashboard
{
    public partial class DisposeAsset : Form
    {
        private uc_dispose_asset assetInst;

        public void setAssetInstance(uc_dispose_asset assetInst)
        {
            this.assetInst = assetInst;
        }
        public DisposeAsset()
        {
            InitializeComponent();
        }

        public void setAssetCode(string code)
        {
            txtCode.Text = code;
        }
        private void txtCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisposedValue.Text == "")
            {
                MessageBox.Show("Please complete all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult response = MessageBox.Show("You are about to record this asset as DISPOSED. Continue?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.No)
            {
                return;
            }
            string assetCode = txtCode.Text;
            string disposedAmount;
            string dateDisposed = Convert.ToDateTime(this.dateDisposed.Text).ToString("yyyy-MM-dd");
            try
            {
                disposedAmount = (double.Parse(txtDisposedValue.Text)).ToString();
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Please enter a valid value for 'disposed amount'.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid value for 'disposed amount'.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            string storedProcedure = "exec DisposeAsset '" + assetCode + "', '" + dateDisposed + "', " + disposedAmount + ";";
            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(storedProcedure, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Recorded successfully.", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        assetInst.populateAssetRecords();
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Couldn't record information. Please try again later.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TextWriter.writeContent("logs.txt", ex.ToString());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
