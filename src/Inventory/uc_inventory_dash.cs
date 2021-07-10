using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Inventory
{
    public partial class uc_inventory_dash : UserControl
    {
        public uc_inventory_dash()
        {
            InitializeComponent();
            chart.Titles.Add("Carriage Outwards");
            chart.Series["Series1"].Points.AddXY("1", "1000");
            chart.Series["Series1"].Points.AddXY("2", "500");
            chart.Series["Series1"].Points.AddXY("3", "1500");
            chart.Series["Series1"].Points.AddXY("4", "2000");

            chart.Series["Series2"].Points.AddXY("1", "1080");
            chart.Series["Series2"].Points.AddXY("2", "500");
            chart.Series["Series2"].Points.AddXY("3", "1500");
            chart.Series["Series2"].Points.AddXY("4", "2000");
        }

        private void uc_inventory_dash_Load(object sender, EventArgs e)
        {

        }
    }
}
