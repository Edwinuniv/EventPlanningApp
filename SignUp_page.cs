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
    public partial class SignUp_page : Form
    {
        public SignUp_page()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpass.Text;
            string email = txtemail.Text;
            string confipass = txtconfirmpass.Text;
            int age;
            bool valide = int.TryParse(txtAge.Text, out age);

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
                else
                {
                    lblinfo1.Text = "Password verification failed";
                }
                return;
            }
            else if(confipass != password)
            {
                lblinfo1.Text = "Password does not match";
                return;
            }

            if(age < 18 || age > 99) 
            {
                lblinfo1.Text = "Age must be between 18 and 99";
                return;
            }

            bool uexist = false;
            bool eexist = false;

            foreach(User u in User.users)
            {
                if(u.username == username)
                {
                    uexist = true;
                }
                if(u.email == email)
                {
                    eexist = true;
                }
            }

            if (uexist)
            {
                lblinfo1.Text = "This username is already taken";
                return;
            }
            if (eexist)
            {
                lblinfo1.Text = "This email is already used";
                return;
            }
         
            Confirmcode_page cc = new Confirmcode_page(email);
            var result = cc.ShowDialog();

            if(result == DialogResult.OK)
            {
                string inputcode = cc.code;
                string accode = cc.confcode;

                bool valid = User.SignUp(username, email, password, age);

                if(valid)
                {
                    User.SaveUsers("Users.csv");
                    lblinfo1.Text = "User created";

                    NotificationForm n = new NotificationForm("Notification", lblinfo1.Text);
                    n.Show();
                    LoginForm f = new LoginForm();
                    f.Show();
                    this.Close();
                }
            }

        }

        private void SignUp_page_Load(object sender, EventArgs e)
        {
            User.ImportUsers("Users.csv");
            checkBoxShowp1.CheckedChanged += checkBoxShowp1_CheckedChanged;
            checkBoxshowp2.CheckedChanged += checkBoxshowp2_CheckedChanged;
        }

        private void checkBoxshowp2_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.UseSystemPasswordChar = !checkBoxshowp2.Checked;
        }

        private void checkBoxShowp1_CheckedChanged(object sender, EventArgs e)
        {
            txtconfirmpass.UseSystemPasswordChar = !checkBoxShowp1.Checked;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtAge.Text = "";
            txtconfirmpass.Text = "";
            txtemail.Text = "";
            txtpass.Text = "";
           txtusername.Text = "";
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
