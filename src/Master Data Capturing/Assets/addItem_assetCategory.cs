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
    public partial class addItem_assetCategory : Form
    {
        private Dashboard.Dashboard dashboardInst;
        private add_item itemFormInstance;
        public addItem_assetCategory()
        {
            InitializeComponent();
        }

        public addItem_assetCategory(Dashboard.Dashboard dashboardInst, add_item itemFormInstance)
            :this()
        {
            this.dashboardInst = dashboardInst;
            this.itemFormInstance = itemFormInstance;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboAssetCategories.Text == "")
            {
                MessageBox.Show("Please select an asset category to proceed.");
            }
            else
            {
                itemFormInstance.ShowDialog();
                this.Hide();
            }
        }
    }
}
