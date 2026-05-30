using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Security;
using MimeKit;

namespace Event_planner
{
    public partial class Confirmcode_page : Form
    {
        private string email;
        public string code = "";
        public string confcode;
        public Confirmcode_page(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void sendemail()
        {
            try
            {
                var emailmessage = new MimeMessage();
                emailmessage.From.Add(new MailboxAddress("edwin", "edwinmouawad82@gmail.com"));
                if (MailboxAddress.TryParse(this.email, out var recipientemail))
                {
                    emailmessage.To.Add(recipientemail);
                }
                else
                {
                    lblcode.Text = "Invalid email addres";
                    return;
                }

                emailmessage.Subject = "Confirmation code";

                confcode = Methods.getConfcode();

                emailmessage.Body = new TextPart("plain") { Text = $"Your confirmation code is: {confcode} " };

                using(var smtp = new MailKit.Net.Smtp.SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    smtp.Authenticate("yourgmail@gmail.com", "your code"); //https://myaccount.google.com/apppasswords
                    smtp.Send(emailmessage);
                    smtp.Disconnect(true);
                }
                lblinfo.Text = "Email sent succesfully";
            }
            catch(Exception e)
            {
                lblinfo.Text = "Email failed, Please check if your Gmail account has 2-Step Verification enabled," + "\n" +
                    " and that you have generated an app password.";
            }
        }
        private void Confirmcode_page_Load(object sender, EventArgs e)
        {
            sendemail();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            code = txtcode.Text.Trim();

            if(code == "")
            {
                lblinfo.Text = "Please enter the confirmation code";
            }
            else if(code != confcode)
            {
                lblinfo.Text = "Incorrect confirmation code";
            }
            else
            {
                lblinfo.Text = "Confirmation succesful";
                DialogResult = DialogResult.OK;

                NotificationForm n = new NotificationForm("Notification", lblinfo.Text);
                n.Show();
                this.Close();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SignUp_page p = new SignUp_page();
            p.Show();
        }
    }
}
