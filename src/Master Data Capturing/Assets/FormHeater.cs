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
        private static settingsParent asset;

        public FormHeater()
        {
            InitializeComponent();
        }
        public static void setSettingsParentInstance(settingsParent assetInst)
        {
            asset = assetInst;
        }
        private void FormHeater_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            asset.clickedAddItemOK();
            btn_reset_Click(sender, e);
            collectInformation();
            updateDatabase("Heater");
        }
    }
}
