using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset_and_Maintenance_Management_System.src.DatabaseHandlers;

namespace Asset_and_Maintenance_Management_System.src.Login
{
    public partial class AddUser : Form
    {
        private int n;
        readonly string fileRelPath = "../../prog_logs/tracker/User.txt";
        public AddUser()
        {
            InitializeComponent();
            n = int.Parse(File.ReadAllText(fileRelPath));
            txtEmpID.Text = "E-" + n;
        }

        private void leave_usernameField(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string query = "select count(*) from UserInfo where username = '" + user + "';";

            using (SqlConnection connection = DBConnection.establishConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int count = int.Parse(command.ExecuteScalar().ToString());
                    if (count > 0)
                    {
                        MessageBox.Show("Username has been taken already. Please select another.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtConfirmPassword.Text.Trim() == "" || txtEmpID.Text.Trim() == "" ||
                txtFName.Text.Trim() == "" || txtLName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please complete all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Password do not match. Please try again.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    string type = null;
                    switch (comboType.Text)
                    {
                        case "Manager":
                            type = "man";
                            break;
                        case "Accountant":
                            type = "acc";
                            break;
                        case "Worker":
                            type = "wor";
                            break;
                    }

                    string query =
                        "insert into UserInfo(EmpID, FirstName, LastName, Username, Password, EmpCategory) values ('" + txtEmpID.Text + "', '" + txtFName.Text + "', '" + txtLName.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '" + type + "');";
                    using (SqlConnection connection = DBConnection.establishConnection())
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            try
                            {
                                command.ExecuteNonQuery();
                                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                TextWriter.writeContent("logs.txt", ex.ToString());
                                MessageBox.Show("User not added! Please try again later.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    File.WriteAllText(fileRelPath, (++n).ToString());
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmpID.Text = "";
            txtConfirmPassword.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
