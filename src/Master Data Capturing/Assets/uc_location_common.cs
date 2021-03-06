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
    public partial class uc_location_common : UserControl
    {
        public uc_location_common()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public string getBranch
        {
            get => comboBranch.Text;
        }

        public string getBuilding
        {
            get => comboBuilding.Text;
        }

        public string getFloor
        {
            get => comboFloor.Text;
        }

        public string getRoom
        {
            get => comboRoom.Text;
        }

        public void resetContent()
        {
            comboFloor.ResetText();
            comboBuilding.ResetText();
            comboBranch.ResetText();
            comboRoom.ResetText();
        }
        public string[] getInformation()
        {
            string[] info = new string[4];
            info[0] = comboBranch.Text.ToString();
            info[1] = comboBuilding.Text.ToString();
            info[2] = comboFloor.Text.ToString();
            info[3] = comboRoom.Text.ToString();
            return info;
        }
    }
}
