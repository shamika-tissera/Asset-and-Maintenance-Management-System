using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets
{
    public partial class uc_administrative_common : UserControl
    {
        public uc_administrative_common()
        {
            InitializeComponent();
            radBtn_reducingBalance.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public string getPurchasePrice
        {
            get => txtPurchasedPrice.Text;
        }

        public string getInvoiceNumber
        {
            get => txtInvoiceNumber.Text;
        }

        public string getCurrentValue
        {
            get => txtCurrentVal.Text;
        }

        public string getDisposalDate
        {
            get => dateDisposal.Text;
        }

        public string getYearsOfLife
        {
            get => txtYearsOfLife.Text;
        }

        public string getDepreciationStart
        {
            get => dateDepreciationStart.Text;
        }

        public string getDepreciationEnd
        {
            get => dateDepreciationEnd.Text;
        }

        public string getDepreciationMethod
        {
            get => groupDepreciationMethod.Text;
        }

        public string getDepreciationRate
        {
            get => txtDepreciationRate.Text;
        }

        public bool getIsFullyDepreciated
        {
            get => checkboxFullyDepreciated.Checked;
        }
        public string[] getInformation()
        {
            string[] info = new string[10];
            if (isValidationSuccessful())
            {
                info[0] = txtPurchasedPrice.Text.ToString().Trim();
                info[1] = txtInvoiceNumber.Text.ToString().Trim();
                info[2] = txtCurrentVal.Text.ToString().Trim();
                info[3] = dateDisposal.Text.ToString();
                info[4] = txtYearsOfLife.Text.ToString().Trim();
                info[5] = dateDepreciationStart.Text.ToString();
                info[6] = dateDepreciationEnd.Text.ToString();
                if (radBtn_reducingBalance.Checked)
                {
                    info[7] = "reducing-balance";
                }
                else
                {
                    info[7] = "straight-line";
                }
                info[8] = txtDepreciationRate.Text.ToString().Trim();
                info[9] = checkboxFullyDepreciated.Checked.ToString();
            }
            return info;
        }
        private bool isValidationSuccessful()
        {
            if(txtPurchasedPrice.Text.ToString().Trim() == "" || txtInvoiceNumber.Text.ToString().Trim() == "" || txtCurrentVal.Text.ToString().Trim() == "" || txtYearsOfLife.Text.ToString().Trim() == "" || txtDepreciationRate.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Please complete all fields in 'Administrative' section!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        public void resetContent()
        {
            txtCurrentVal.ResetText();
            txtDepreciationRate.ResetText();
            txtInvoiceNumber.ResetText();
            txtYearsOfLife.ResetText();
            txtPurchasedPrice.ResetText();
            dateDepreciationStart.ResetText();
            dateDisposal.ResetText();
            dateDepreciationEnd.ResetText();
            checkboxFullyDepreciated.Checked = false;
        }
    }
}
