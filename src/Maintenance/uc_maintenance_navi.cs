﻿using System;
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
    public partial class uc_maintenance_navi : UserControl
    {
        private Dashboard.Dashboard inst;
        public uc_maintenance_navi()
        {
            InitializeComponent();
        }
        
        private void uc_maintenance_navi_Load(object sender, EventArgs e)
        {

        }

        private void setInstance(Dashboard.Dashboard inst)
        {
            this.inst = inst;
        }
    }
}
