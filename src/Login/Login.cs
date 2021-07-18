using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_and_Maintenance_Management_System.src.Dashboard;

namespace Asset_and_Maintenance_Management_System.src.Login
{
    public partial class Login : Form
    {
        //use this function to make the edges of the form curved
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

        );
        
        public Login()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        //private Dashboard inst;
        //public setDashboardInst(Dashboard inst)
        //{
        //    this.inst = inst;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter a password and username.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] loginDetails= { txtUsername.Text, txtPassword.Text }; //loginDetails[0]:Username, loginDetails[1]:password


                Dashboard.Dashboard dashboard = new Dashboard.Dashboard();
                dashboard.Show();
                this.Visible = false;
            }
        }
    }
}
