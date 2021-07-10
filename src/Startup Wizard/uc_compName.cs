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
            string[] info = uc_initial_welcome1.getTxtInfo();
            return info;
        }

        public void resetTxt()
        {
            uc_initial_welcome1.resetTxt();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
