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
    public partial class uc_navPanel_assets : UserControl
    {
        private Dashboard.Dashboard inst;
        private add_item item;
        public uc_navPanel_assets()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        public void setDashboardInstance(Dashboard.Dashboard inst)
        {
            this.inst = inst;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedAssetNavBack();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            item = new add_item(this);
            item.ShowDialog();
        }

        public void clickedAddItemOK()
        {
            inst.clickedAssetAddItemOK();
            item.Hide();
        }

        public void clickedAddItemCancel()
        {
            
        }
    }
}
