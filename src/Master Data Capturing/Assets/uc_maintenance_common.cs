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
    public partial class uc_maintenance_common : UserControl
    {
        public uc_maintenance_common()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public string getMaintenanceMaintainedBy()
        {
            return comboMaintainedBy.Text;
        }

        public string getMaintenanceCondition()
        {
            return comboCondition.Text;
        }

        public string getMaintenanceCriticality()
        {
            return comboCriticality.Text;
        }

        public string getMaintenanceCheckedDate()
        {
            return dateLastChecked.Text;
        }
        public string[] getInformation()
        {
            string[] info = new string[4];
            info[0] = comboMaintainedBy.Text.ToString();
            info[1] = comboCondition.Text.ToString();
            info[2] = comboCriticality.Text.ToString();
            info[3] = dateLastChecked.Text.ToString();
            return info;
        }

        public void resetContent()
        {
            comboCriticality.ResetText();
            comboCondition.ResetText();
            comboMaintainedBy.ResetText();
            dateLastChecked.ResetText();
        }
    }
}
