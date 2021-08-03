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
    public partial class uc_general_common : UserControl
    {
        public uc_general_common()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public string getGeneralManu()
        {
            return combo_general_manu.Text;
        }
        public string getGeneralCode()
        {
            return txt_general_code.Text;
        }

        public string getGeneralName()
        {
            return txt_general_name.Text;
        }

        public string getGeneralSerial()
        {
            return txt_general_serial.Text;
        }

        public string getGeneralSupplier()
        {
            return combo_general_supplier.Text;
        }

        public string getGeneralState()
        {
            return combo_general_state.Text;
        }

        private void combo_general_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string[] getInformation()
        {
            string[] info = new string[6];
            if (true)
            {
                info[0] = txt_general_code.Text;
                string a = txt_general_code.Text;
                info[1] = txt_general_name.Text;
                info[2] = txt_general_serial.Text;
                info[3] = combo_general_manu.Text;
                info[4] = combo_general_supplier.Text;
                info[5] = combo_general_state.Text;
                return info;
            }
            else
            {
                return info;
            }
        }
        private bool isValidationSuccess()
        {
            if(txt_general_name.Text.ToString().Trim() == "" || txt_general_serial.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Please complete all fields in the 'General Section'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        public void resetContents()
        {
            combo_general_state.ResetText();
            combo_general_manu.ResetText();
            combo_general_supplier.ResetText();
            txt_general_code.ResetText();
            txt_general_name.ResetText();
            txt_general_serial.ResetText();
        }
    }
}
