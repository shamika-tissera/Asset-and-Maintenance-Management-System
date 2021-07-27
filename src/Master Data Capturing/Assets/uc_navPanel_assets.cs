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
    public partial class uc_navPanel_assets : UserControl
    {
        private Dashboard.Dashboard inst;
        private add_item item;
        private static uc_asset_browse browse;
        public static void setBrowse(uc_asset_browse inst)
        {
            browse = inst;
        }
        public uc_navPanel_assets()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            isButtonEmphasized = true;
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button11.BackColor = Color.FromArgb(61, 70, 89);
            browse.sortAssets("Sink");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isButtonEmphasized = true;
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button5.BackColor = Color.FromArgb(61, 70, 89);
        }
        public void setDashboardInstance(Dashboard.Dashboard inst)
        {
            this.inst = inst;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            inst.clickedAssetNavBack();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            settingsParent settings = new settingsParent(true, inst);
            

            //item = new add_item(this);
            //addItem_assetCategory selectCat = new addItem_assetCategory(inst, item);
            //selectCat.ShowDialog();
        }

        public void clickedAddItemOK()
        {
            inst.clickedAssetAddItemOK();
            
            //perform database entry here
            //if database entry successful, message will display
            MessageBox.Show("Added record successfully!");
        }

        public void clickedAddItemCancel()
        {
            item.Hide();
        }
        bool isButtonEmphasized = false;
        public void resetBtnEmphasis()
        {
            button2.BackColor = Color.FromArgb(31, 46, 76);
            button5.BackColor = Color.FromArgb(31, 46, 76);
            button10.BackColor = Color.FromArgb(31, 46, 76);
            button8.BackColor = Color.FromArgb(31, 46, 76);
            button3.BackColor = Color.FromArgb(31, 46, 76);
            button1.BackColor = Color.FromArgb(31, 46, 76);
            button13.BackColor = Color.FromArgb(31, 46, 76);
            button6.BackColor = Color.FromArgb(31, 46, 76);
            button7.BackColor = Color.FromArgb(31, 46, 76);
            button11.BackColor = Color.FromArgb(31, 46, 76);
            button4.BackColor = Color.FromArgb(31, 46, 76);
            isButtonEmphasized = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //inst.clickedHeater(button2.Location);            
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button2.BackColor = Color.FromArgb(61, 70, 89);
            isButtonEmphasized = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {            
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button10.BackColor = Color.FromArgb(61, 70, 89);
            isButtonEmphasized = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button8.BackColor = Color.FromArgb(61, 70, 89);
            isButtonEmphasized = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button3.BackColor = Color.FromArgb(61, 70, 89);
            isButtonEmphasized = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button1.BackColor = Color.FromArgb(61, 70, 89);
            isButtonEmphasized = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button13.BackColor = Color.FromArgb(61, 70, 89);
            isButtonEmphasized = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button6.BackColor = Color.FromArgb(61, 70, 89);
            isButtonEmphasized = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button7.BackColor = Color.FromArgb(61, 70, 89);
            isButtonEmphasized = true;
            browse.sortAssets("Phone");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isButtonEmphasized)
            {
                resetBtnEmphasis();
            }
            button4.BackColor = Color.FromArgb(61, 70, 89);
            isButtonEmphasized = true;
        }
    }
}
