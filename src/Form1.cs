﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_and_Maintenance_Management_System
{
    public partial class startup_main : Form
    {
        public startup_main()
        {
            InitializeComponent();
            uc_welcome_11.Visible = true;
            uc_compName1.Visible = false;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {

        }
    }
}
