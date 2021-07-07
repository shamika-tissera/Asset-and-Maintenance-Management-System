using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Analytics
{
    public partial class uc_analytics_intial_dash : UserControl
    {
        Dashboard.Dashboard inst;
        public uc_analytics_intial_dash()
        {
            InitializeComponent();
            chart_warranty.Titles.Add("Warranty");
            chart_warranty.Series["s1"].Points.AddXY("Active", "33");
            chart_warranty.Series["s1"].Points.AddXY("Inactive", "34");
            chart_warranty.Series["s1"].Points.AddXY("Not Provided", "33");

            chart_lifetime.Titles.Add("Asset Lifetime");
            chart_lifetime.Series["d1"].Points.AddXY("< 5 years", "33");
            chart_lifetime.Series["d1"].Points.AddXY("> 5 years", "34");
        }

        public void setDashboardInstance(Dashboard.Dashboard inst)
        {
            this.inst = inst;
        }

        private void chart_warranty_Click(object sender, EventArgs e)
        {

        }
    }
}
