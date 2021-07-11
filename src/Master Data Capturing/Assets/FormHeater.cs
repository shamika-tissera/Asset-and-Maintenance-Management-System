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
    public partial class FormHeater : add_item
    {
        private settingsParent asset;

        public FormHeater() : base()
        {
            InitializeComponent();
        }
        public FormHeater(settingsParent asset) : base(asset)
        {
            this.asset = asset;
        }
        private void FormHeater_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            asset.clickedAddItemOK();
            btn_reset_Click(sender, e);
        }
    }
}
