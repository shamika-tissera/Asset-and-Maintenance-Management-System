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
    public partial class main_window : Form
    {
        private settingsParent settingsParentInst;
        public main_window()
        {
            InitializeComponent();
        }
        public main_window(settingsParent settingsParentInst) : this()
        {
            InitializeComponent();
            this.settingsParentInst = settingsParentInst;
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            add_item form = new add_item(settingsParentInst);
            form.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
