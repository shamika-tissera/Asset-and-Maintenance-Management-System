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
    public partial class FormNetworkDevice : add_item
    {
        private settingsParent asset;
        public FormNetworkDevice() : base()
        {
            InitializeComponent();
        }
        public FormNetworkDevice(settingsParent asset) : base(asset)
        {
            this.asset = asset;
        }
    }
}
