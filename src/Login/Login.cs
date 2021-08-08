using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_and_Maintenance_Management_System.src.Accountant.Dashboard;
using Asset_and_Maintenance_Management_System.src.Dashboard;
using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;
using Asset_and_Maintenance_Management_System.src.Worker_Interface;

namespace Asset_and_Maintenance_Management_System.src.Login
{
    public partial class Login : Form
    {
        private string username;
        private string password;
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

        public void resetContent()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var regexString1 = new Regex(@"[\t\r\n]|(--[^\r\n]*)|(/\*[\w\W]*?(?=\*/)\*/)");
            var regexString2 = new Regex(@"('(''|[^'])*')|(;)|(\b(ALTER|CREATE|DELETE|DROP|EXEC|alter|create|delete|drop|exec(UTE){0,1}|INSERT( +INTO){0,1}|MERGE|SELECT|UPDATE|UNION( +ALL){0,1})\b)");
            username = txtUsername.Text;
            password = txtPassword.Text;
            string empCat = null;
            string query = "SELECT empcategory FROM UserInfo WHERE username = '" + username + "' AND password = '" + password + "';";

            string logQuery = null;

            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter a password and username.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (regexString1.IsMatch(txtUsername.Text) || regexString2.IsMatch(txtPassword.Text))
                {
                    TextWriter.writeContent("logs.txt", "SQLi Detected!");
                    MessageBox.Show("Invalid username or password!\n" +
                                    "If you are facing any difficulties logging in, " +
                                    "please contact the system administrator.", "Login Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] loginDetails= { txtUsername.Text, txtPassword.Text }; //loginDetails[0]:Username, loginDetails[1]:password
                username = txtUsername.Text;
                password = txtPassword.Text;

                using(SqlConnection connection = DBConnection.establishConnection())
                {
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        empCat = (string)command.ExecuteScalar();
                    }
                }

                switch (empCat)
                {
                    case "acc":
                        AccountantDashboard acc = new AccountantDashboard();
                        acc.Show();
                        this.Visible = false;
                        logQuery = "INSERT INTO LoginLogs(loginTime, username, category) VALUES(GETDATE(), '" +
                                   username + "', 'Accountant');";
                        break;
                    case "man":
                        Dashboard.MainDashboard dashboard = new Dashboard.MainDashboard();
                        dashboard.setLoginInstance(this, username);
                        dashboard.Show();
                        this.Visible = false;
                        logQuery = "INSERT INTO LoginLogs(loginTime, username, category) VALUES(GETDATE(), '" +
                                   username + "', 'Manager');";
                        break;
                    case "wor":
                        WorkerInterface interf = new WorkerInterface();
                        interf.setUsernameLabel(username);
                        interf.setLoginInstance(this, username);
                        logQuery = "INSERT INTO LoginLogs(loginTime, username, category) VALUES(GETDATE(), '" +
                                   username + "', 'Worker');";
                        interf.Show();
                        break;
                    default:
                        MessageBox.Show("Invalid username or password!\n" +
                            "If you are facing any difficulties logging in, " +
                            "please contact the system administrator.", "Login Error", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                using (SqlConnection connection = DBConnection.establishConnection())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(logQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        TextWriter.writeContent("logs.txt", ex.ToString());
                    }
                }
            }
        }
    }
}
