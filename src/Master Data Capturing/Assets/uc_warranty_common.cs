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
    public partial class uc_warranty_common : UserControl
    {
        public uc_warranty_common()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public string WarrantyCode
        {
            get => txtWarrantyCode.Text;
        }

        public string WarrantyType
        {
            get => comboType.Text;
        }

        public string WarrantyStart
        {
            get => dateStart.Text;
        }

        public string WarrantyEnd
        {
            get => dateEnd.Text;
        }
        
}
}
