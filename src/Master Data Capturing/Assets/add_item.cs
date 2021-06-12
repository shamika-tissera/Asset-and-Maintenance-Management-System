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
    public partial class add_item : Form
    {
        private uc_navPanel_assets inst;
        public add_item()
        {
            InitializeComponent();
        }
        public add_item(uc_navPanel_assets asset)
        {
            InitializeComponent();
            this.inst = asset;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void uc_warranty_common1_Load(object sender, EventArgs e)
        {

        }

        private void add_item_Load(object sender, EventArgs e)
        {

        }

        private void uc_administrative_common1_Load(object sender, EventArgs e)
        {

        }

        private void uc_installInfo_common1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            inst.clickedAddItemOK();
            btn_reset_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            inst.clickedAddItemCancel();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            uc_general_common1.resetContents();
            uc_administrative_common1.resetContent();
            uc_installInfo_common1.resetContent();
            uc_location_common1.resetContent();
            uc_maintenance_common1.resetContent();
            uc_warranty_common1.resetContent();
        }
    }
}
