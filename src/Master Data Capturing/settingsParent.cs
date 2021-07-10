using Asset_and_Maintenance_Management_System.src.Master_Data_Capturing.Assets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Master_Data_Capturing
{
    public partial class settingsParent : Form
    {
        private addItem_assetCategory assetCategory;
        private Form choice;
        bool isRedirected;
        public settingsParent()
        {
            InitializeComponent();
            assetCategory = new addItem_assetCategory(this);
        }
        public settingsParent(bool isRedirected) : this()
        {
            this.isRedirected = isRedirected;
            this.Show();
            new addItem_assetCategory(this).Show();
        }

        private void assetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new addItem_assetCategory(this).Show();

        }
        public void displayAssetAdditionForm(String formType)
        {
            switch (formType)
            {
                case "Heater":
                    choice = new FormHeater();
                    break;
                case "Network Device":
                    choice = new FormHeater();
                    break;
                case "Sanitation Device":
                    choice = new FormHeater();
                    break;
                case "Printer/Scanner":
                    choice = new FormHeater();
                    break;
                case "Lift":
                    choice = new FormHeater();
                    break;
                case "Fire Extinguisher":
                    choice = new FormHeater();
                    break;
                case "Computer":
                    choice = new FormHeater();
                    break;
                case "Plumbing Device":
                    choice = new FormHeater();
                    break;
                case "Phone":
                    choice = new FormHeater();
                    break;
                case "Sink":
                    choice = new FormHeater();
                    break;
                case "Lighting":
                    choice = new FormHeater();
                    break;
            }
            choice.MdiParent = this;
            choice.Show();
            tblLayout_Options.Visible = false;
        }
    }
}
