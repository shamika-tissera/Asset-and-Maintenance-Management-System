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
    public partial class uc_installInfo_common : UserControl
    {
        public uc_installInfo_common()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public string getInstallInfoDateInstallation()
        {
            return dateInstallation.Text;
        }

        public string getInstallInfoDateAcceptance()
        {
            return dateAcceptance.Text;
        }

        public string getInstallInfoPlant()
        {
            return comboPlant.Text;
        }
    }
}
