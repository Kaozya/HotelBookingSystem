using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class frmRegister : Form
    {
        bool isAdmin;
        int checker = 1;
        public frmRegister()
        {
            InitializeComponent();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                MessageBox.Show("Your Account has been successfully created", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtPassword.Text != txtComPassword.Text)
            {
                MessageBox.Show("Passwords do not match, please Re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";
                txtPassword.Focus();

            }
            else
            {
                if (isAdmin == true)
                {
                    try
                    {
                        AdminUser user = new AdminUser();
                        user.Realname = txtFirstName.Text + ' ' + txtLastName.Text;
                        user.Username = txtUsername.Text;
                        user.Password = txtPassword.Text;
                        user.Private_key = txtPrivkey.Text;

                        frmLogin.accounts.Add(user);
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.ToString());
                    }

                }
                else
                {
                    try
                    {
                        User user = new User();
                        user.Realname = txtFirstName.Text + ' ' + txtLastName.Text;
                        user.Username = txtUsername.Text;
                        user.Password = txtPassword.Text;


                        frmLogin.accounts.Add(user);
                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show(exe.ToString());
                    }

                }

            }

        }

        private void frmBooking_Load(object sender, EventArgs e)
        {

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '.';
                txtPassword.PasswordChar = '.';

            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checker++;

            if (checker % 2 == 0)
            {
                panel1.Visible = true;
                isAdmin = true;
            }
            else
            {
                panel1.Visible = false;
                isAdmin = false;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

      
    }
}
