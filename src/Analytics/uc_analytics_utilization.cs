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
    public partial class uc_analytics_utilization : UserControl
    {
        public uc_analytics_utilization()
        {
            InitializeComponent();
        }
        private void populateDataGridView()
        {
            string query = "select NonCurrentAsset.asset_id as 'Asset ID', NonCurrentAsset.assetType as 'Asset Type', NonCurrentAsset.lifetime*12 as 'Lifetime (months)', DATEDIFF(month, purchaseDate, disposedDate) as 'Actual Lifetime (months)', (DATEDIFF(month, purchaseDate, disposedDate) - NonCurrentAsset.lifetime*12) as 'Varience' from NonCurrentAsset inner join Disposal on NonCurrentAsset.asset_id = Disposal.asset_id;";
        }
        
    }
}
