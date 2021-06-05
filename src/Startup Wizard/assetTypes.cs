using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System.src
{
    public partial class assetTypes : UserControl
    {
        public assetTypes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Use this function to get the data from the table
        public string[,] getData()
        {
            string[,] data = new string[dataGridView1.RowCount - 1, dataGridView1.ColumnCount];
            try
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        data[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                return data;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            
        }
    }
}
