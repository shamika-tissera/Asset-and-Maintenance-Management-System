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
    }
}
