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
    public partial class FeedbackForm : Form
    {
        private List<Event> userevent = new List<Event>(); 
        private List<Tasks> tasks = new List<Tasks>();
        private List<RsvpTracking> rsvpTrackings = new List<RsvpTracking>();
        private string username;
        private string password;
        private DateTime dateTime;

        private bool sidebarexpend = true; 
        private static int Sidebarmaxw = 179;
        private static int sidebarminw = 53;
        private static int sidebarstep = 10;
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            txtToemail.Text = "footballforever844@gmail.com";
            txtToemail.ReadOnly = true;
            txtpass.Text = "omkj gqdb wmzt kjdi";
            txtpass.ReadOnly = true;
            txtpass.Visible = false;
            label7.Visible = false;
            txtToemail.Visible = false;
            label6.Visible = false;
        }
        private void SendEmail()
        {
            try
            {
                var email = new MimeMessage();
                email.From.Add(new MailboxAddress("Your Name", txtEmail.Text));
                string recipientEmail = "footballforever844@gmail.com";
                try
                {
                    var parsed = MailboxAddress.Parse(recipientEmail);
                    email.To.Add(parsed);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid email address format.", "Error");
                }
                email.Subject = txtSubject.Text;
                email.Body = new TextPart("plain") { Text = txtContent.Text };

                using (var smtp = new MailKit.Net.Smtp.SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    smtp.Authenticate(txtEmail.Text, txtpass.Text);
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }

                lblInfo.Text = "Email sent successfully!";
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Email failed: \n" +
                              "Please check if your Gmail account\n has 2-Step Verification enabled,\n and that you have generated an app password.";
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendEmail();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sidebartimer.Start();
        }
        private void UpdatePannelWidth(int width) 
        {
            panel3.Width = width;
            panel2.Width = width;

        }

        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpend)
            {
                panel1.Width -= sidebarstep;
                if (panel1.Width <= sidebarminw)
                {
                    label3.Location = new Point(70, 101);
                    txtEmail.Location = new Point(140, 107);
                    label7.Location = new Point(270, 101);
                    txtpass.Location = new Point(392, 107);
                    label6.Location = new Point(70, 156);
                    txtToemail.Location = new Point(160, 162);
                    label5.Location = new Point(270, 160);
                    txtSubject.Location = new Point(392, 162);
                    label4.Location = new Point(70, 235);
                    txtContent.Location = new Point(75, 269);
                    btnSend.Location = new Point(375, 321);
                    Sidebartimer.Stop();
                    sidebarexpend = false;
                    UpdatePannelWidth(panel1.Width);
                }
            }

            else
            {
                panel1.Width += sidebarstep;
                if (panel1.Width >= Sidebarmaxw)
                {
                    label3.Location = new Point(260, 101);
                    txtEmail.Location = new Point(373, 107);
                    label7.Location = new Point(521, 101);
                    txtpass.Location = new Point(634, 107);
                    label6.Location = new Point(260, 156);
                    txtToemail.Location = new Point(372, 162);
                    label5.Location = new Point(521, 160);
                    txtSubject.Location = new Point(634, 162);
                    label4.Location = new Point(260, 235);
                    txtContent.Location = new Point(265, 269);
                    btnSend.Location = new Point(575, 321);
                    Sidebartimer.Stop();
                    sidebarexpend = true;
                    UpdatePannelWidth(panel1.Width);
                    panel1.Width = panel1.Width;
                }
            }
        }

        private void btnEventsMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            EventForm ev = new EventForm(username,password,dateTime);
            ev.Show();
        }

        private void btnTasksMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            TaskForm ev = new TaskForm(username,password);
            ev.Show();
        }

        private void btnRSVP_Click(object sender, EventArgs e)
        {
            this.Close();
            RSVPtrackingForm ev = new RSVPtrackingForm(username, password);
            ev.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportsForm ev = new ReportsForm(userevent, rsvpTrackings, tasks, username);
            ev.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mp = new MainPage(username,password);
            mp.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            User.Logout(username, password);
            username = "";
            password = "";
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnTemplatesMenu_Click(object sender, EventArgs e)
        {
            TemplateForm f = new TemplateForm(username, password);
            f.Show();
            this.Close();
        }
    }
}
