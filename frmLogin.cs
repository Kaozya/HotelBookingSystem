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
    public partial class frmLogin : Form
    {
        bool isAdmin = false;
        int checker = 1;
        public static List<User> accounts = new List<User>();
        public frmLogin()
        {
            InitializeComponent();
        }
  
        private void frmLogin_Load(object sender, EventArgs e)
        {
            


            
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

        private void cmdLog_Click(object sender, EventArgs e)
        {

            bool isallowed = false;
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Username == txtUser.Text && accounts[i].Password == txtPass.Text)
                {
                    isallowed = true;
                    break;
                }
            }

            if (isallowed == true)
            {
                booking book = new booking();
                book.Show();
               

                
            }
            else
            {
                MessageBox.Show("Wrong username or password! ");
                
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void label11_Click(object sender, EventArgs e)
        {

            frmRegister form = new frmRegister();
            form.Show();
            this.Hide();


        }

        private void txtPrivkey_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

