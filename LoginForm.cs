using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_planner
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            User.ImportUsers("Users.csv");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxShowp1.CheckedChanged += checkBoxShowp1_CheckedChanged;
        }        

        private void lblusername_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp_page sp = new SignUp_page();
            sp.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtemail.Text = "";
            txtpass.Text = "";
            txtusername.Text = "";
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string email = txtemail.Text;
            string password = txtpass.Text;


            if (username.Length <= 3)
            {
                lblinfo1.Text = "Username must have more then 3 characters";
                return;
            }
            else if (!Methods.VerifyPassword(password))
            {
                if (password.Length < 8)
                {
                    lblinfo1.Text = "Password must have a minimum of 8 characters";
                }
                else if (!Methods.VerifyUpperLetter(password))
                {
                    lblinfo1.Text = "Password must have an upper letter";
                }
                else if (!Methods.VerifyLowerLetter(password))
                {
                    lblinfo1.Text = "Password must have a lower letter";
                }
                else if (!Methods.VerifySymbol(password))
                {   
                    lblinfo1.Text = "Password must include a symbol";
                }
                else if (!Methods.Verifydigit(password))
                {
                    lblinfo1.Text = "Password must include a digit";
                }
                return;
            }
            else
            {
                bool efound = false;
                int index = -1;
                string hashed = Methods.ComputeHash(password);

                for (int i = 0; i < User.users.Count; i++)
                {
                    if (User.users[i].username == username && User.users[i].email == email && User.users[i].Password == hashed)
                    {
                        index = i;
                        efound = true;
                        i = User.users.Count;
                    }
                }

                if (!efound)
                {
                    lblinfo1.Text = "Wrong username,email,or password";
                    return;
                }
                else
                {
                    lblinfo1.Text = "Welcome " + username;
                    MainPage mp = new MainPage(username,password);
                    mp.Show();

                    NotificationForm n = new NotificationForm("Notification", lblinfo1.Text);
                    n.Show();
                }
            }
        }

        private void checkBoxShowp1_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = !checkBoxShowp1.Checked;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
