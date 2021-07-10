using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src.Maintenance
{
    public partial class uc_maintenance_reccomendations : UserControl
    {
        public uc_maintenance_reccomendations()
        {
            InitializeComponent();
            populateTable();
        }

        private void uc_maintenance_reccomendations_Load(object sender, EventArgs e)
        {

        }

        //For table population
        private void populateTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Asset ID", typeof(string));
            table.Columns.Add("Site", typeof(string));
            table.Columns.Add("Description", typeof(string));

            table.Rows.Add("MACH-0593", "Headquaters", "Another machine of this type is available in the store. Consider occasional replacement to avoid overuse.");
            table.Rows.Add("MACH-0593", "Headquaters", "Another machine of this type is available in the store. Consider occasional replacement to avoid overuse.");
            table.Rows.Add("MACH-0593", "Headquaters", "Another machine of this type is available in the store. Consider occasional replacement to avoid overuse.");
            table.Rows.Add("MACH-0593", "Headquaters", "Another machine of this type is available in the store. Consider occasional replacement to avoid overuse.");
            table.Rows.Add("MACH-0593", "Headquaters", "Another machine of this type is available in the store. Consider occasional replacement to avoid overuse.");
            table.Rows.Add("MACH-0593", "Headquaters", "Another machine of this type is available in the store. Consider occasional replacement to avoid overuse.");

            //DataRow row = table.NewRow();
            //row["Asset ID"] = "MACH-0593";
            //row["Site"] = "Headquaters";
            //row["Description"] = "Another machine of this type is available in the store. Consider occasional replacement to avoid overuse.";
            //row = table.NewRow();
            //row["Asset ID"] = "MACH-0593";
            //row["Site"] = "Headquaters";
            //row["Description"] = "Another machine of this type is available in the store. Consider occasional replacement to avoid overuse.";

            dataGridView1.DataSource = table;

            //adjust column width
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Width = 808;

            //adjust row width
            int numOfRows = dataGridView1.RowCount;
            int heightOfRow = 12;
            for(int i = 0; i < numOfRows; i++)
            {
                dataGridView1.Rows[i].Height = heightOfRow;
            }
            dataGridView1.Height = (100 + (heightOfRow * numOfRows));
        }
    }
}
