using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System
{
    public partial class startup_main : Form
    {
        public startup_main()
        {
            InitializeComponent();
            uc_welcome_11.Visible = true;
            uc_compName1.Visible = false;
            assetTypes1.Visible = false;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            if (uc_welcome_11.Visible)
            {
                uc_welcome_11.Visible = false;
                uc_compName1.Visible = true;
                assetTypes1.Visible = false;
            }
            else if (uc_compName1.Visible)
            {
                bool isValid = false;

                string[] info = uc_compName1.getTxtInfo();

                isValid = Validation(info);
                if (!isValid)
                {
                    MessageBox.Show("Please enter valid information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    uc_compName1.Visible = false;
                    uc_compName1.resetTxt();
                    uc_compName1.Visible = true;
                }
                else
                {
                    uc_welcome_11.Visible = false;
                    uc_compName1.Visible = false;
                    assetTypes1.Visible = true;
                }                
                
            }
            else
            {
                string[,] assetData = assetTypes1.getData();
                /**
                 **
                 */

                //TODO validation

                //When the startup wizard has been run for the first time
                string fileRelPath = "../../prog_logs/startup.txt";
                File.WriteAllText(fileRelPath, "true");
            }
        }

        private bool Validation(string[] info)
        {
            try
            {
                if (info[0] == "" || info[1] == "")
                {
                    return false;
                }
                int num = int.Parse(info[1]);
                //if (!int.TryParse(info[1], out num))
                //{
                //    return false;
                //}
            }
            catch (FormatException ex)
            {
                return false;
            }

            return true;
        }

        private void uc_compName1_Load(object sender, EventArgs e)
        {

        }
    }
}
