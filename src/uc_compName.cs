using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System
{
    public partial class uc_compName : UserControl
    {
        public uc_compName()
        {
            InitializeComponent();
        }

        private void txt_compName_TextChanged(object sender, EventArgs e)
        {

        }

        public string[] getTxtInfo()
        {
            string[] info = {txt_compName.Text, txt_fascilCount.Text};
            return info;
        }

        public void resetTxt()
        {
            txt_compName.ResetText();
            txt_fascilCount.ResetText();
        }
    }
}
