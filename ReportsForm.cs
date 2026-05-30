using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Security;
using MimeKit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;

namespace Event_planner
{
    public partial class ReportsForm : Form
    {
        private List<Event> userevent = new List<Event>(); 
        private List<Tasks> tasks = new List<Tasks>();
        private List<RsvpTracking> rsvpTrackings = new List<RsvpTracking>();
        private string username;
        private string password;
        private string email;
        private DateTime dateTime;

        private bool sidebarexpend = true; 
        private static int Sidebarmaxw = 179;
        private static int sidebarminw = 53;
        private static int sidebarstep = 10;
        public ReportsForm(List<Event> ev, List<RsvpTracking> rsvp, List<Tasks> t, string username) 
        {
            InitializeComponent();
            this.userevent = ev;
            this.tasks = t;
            this.rsvpTrackings = rsvp;
            this.username = username;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadEvents();
            btnShare.Visible = false;
            btnShare.Enabled = false;
        }
        private List<Event> FilerUpcomingEvents(List<Event> events) 
        {
            List<Event> result = new List<Event>();
            DateTime now = DateTime.Now;

            foreach (Event ev in events)
            {
                if (ev.dt.Date >= now.Date)
                {
                    result.Add(ev);
                }
            }
            return result;
        }

        private void LoadEvents() 
        {
            Events.Items.Clear();

            userevent = Event.  LoadUserEvents(username);
            userevent = FilerUpcomingEvents(userevent);

            foreach (Event ev in userevent)
            {
                Events.Items.Add(ev.DisplayEventDetail());
            }
            if (Events.Items.Count == 0)
            {
                lblInfo.Text = "There is no loaded events";
            }
            else
            {
                lblInfo.Text = $"{Events.Items.Count} loaded events";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mp = new MainPage(username,password);
            mp.Show();
        }

        private void btnEventsMenu_Click(object sender, EventArgs e)
        {
            EventForm ev = new EventForm(username,password,dateTime);
            ev.Show();
            this.Close();
        }

        private void btnTasksMenu_Click(object sender, EventArgs e)
        {
            TaskForm t = new TaskForm(username,password);
            t.Show();
            this.Close();
        }

        private void btnRSVP_Click(object sender, EventArgs e)
        {
            RSVPtrackingForm rSVPtrackingForm = new RSVPtrackingForm(username,password);
            rSVPtrackingForm.Show();
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (Events.SelectedIndex == -1)
            {
                lblInfo.Text = "Please select an event";
                return;
            }

            Event selectedE = userevent[Events.SelectedIndex];

            rsvpTrackings = RsvpTracking.LoadGuestforuser(username,selectedE.event_Name);
            tasks = Tasks.LoadTasksForUsers(username,selectedE.event_Name);

            try
            {
                string file = Reports.GenerateReports(selectedE, tasks, rsvpTrackings, username);
                if (file == "")
                {
                    lblInfo.Text = "File is empty";
                }
                if (file.StartsWith("Error:"))
                {
                    lblInfo.Text = file;
                }
                else
                {
                    lblInfo.Text = "Report generated";
                    try
                    {
                        txtReport.Text = File.ReadAllText(file);
                    }
                    catch
                    {
                        lblInfo.Text = "Report saved but failed to display";
                    }
                }
            }
            catch
            {
                lblInfo.Text = "Unnexpeted error";
            }
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

                    lblInfo.Location = new Point(151, 53);
                    label2.Location = new Point(590, 53);
                    Events.Location = new Point(75, 88);
                    btnGenerate.Location = new Point(250, 449);
                    txtReport.Location = new Point(523, 84);
                    btnExport.Location = new Point(360, 449);

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
                    label2.Location = new Point(690, 53);
                    lblInfo.Location = new Point(351, 53);
                    Events.Location = new Point(200, 88);
                    btnGenerate.Location = new Point(359, 449);
                    txtReport.Location = new Point(623, 84);
                    btnExport.Location = new Point(460, 449);

                    Sidebartimer.Stop();
                    sidebarexpend = true;
                    UpdatePannelWidth(panel1.Width);
                    panel1.Width = panel1.Width;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string txtPath = txtReport.Text.Trim();

            if (txtPath == "" || txtReport.Text.StartsWith("Error") || txtReport.Text == "File is empty" || txtReport.Text == "Unnexpeted error")
            {
                lblInfo.Text = "Please generate a report before exporting.";
                return;
            }

            try
            {
                string content = txtReport.Text;

                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Export Report to PDF";
                save.Filter = "PDF Files (*.pdf)|*.pdf";
                save.FileName = "Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(save.FileName, FileMode.Create))
                    {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document();
                        iTextSharp.text.pdf.PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        iTextSharp.text.Font font = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 12f);
                        doc.Add(new iTextSharp.text.Paragraph(content, font));

                        doc.Close();
                    }

                    lblInfo.Text = "PDF exported successfully.";

                    NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
                    n.Show();
                }
                else
                {
                    lblInfo.Text = "Export cancelled.";

                    NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
                    n.Show();
                }
            }
            catch (Exception ex)
            {
                lblInfo.Text = "Export failed: " + ex.Message;

                NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
                n.Show();
            }
        }    
        private void btnFeedbackMenu_Click(object sender, EventArgs e)
        {
            FeedbackForm ff = new FeedbackForm();
            this.Close();
            ff.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage m = new MainPage(username, password);
            m.Show();
        }

        private void btnTemplatesMenu_Click(object sender, EventArgs e)
        {
            TemplateForm f = new TemplateForm(username, password);
            f.Show();
            this.Close();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            User.Logout(username, password);
            username = "";
            password = "";
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
        private void btnShare_Click(object sender, EventArgs e)
        {
            /*using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                smtpClient.EnableSsl = true;

                string senderEmail = textBox4.Text;
                string appPassword = textBox3.Text;
                string recipientEmail = textBox1.Text;
                string subject = textBox2.Text;

                smtpClient.Credentials = new NetworkCredential(senderEmail, appPassword);

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = subject;
                mail.Body = "Voici le fichier CSV contenant toutes les tâches.";

                string filePath = "tasks.csv";

                try
                {

                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string fileContent = sr.ReadToEnd();

                        Console.WriteLine(fileContent);
                    }


                    mail.Attachments.Add(new Attachment(filePath));
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Le fichier 'tasks.csv' est introuvable.");
                    return;
                }

            }*/
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

                emailmessage.Subject = "Confirmation code";

                using (var smtp = new MailKit.Net.Smtp.SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    smtp.Authenticate("edwinmouawad82@gmail.com", "omkj gqdb wmzt kjdi"); //https://myaccount.google.com/apppasswords?pli=1&rapt=AEjHL4ONn14UkGYyGBt_9cZ7WQlJPr_s5r59IUxsWbyfGWDdgSQkluxSZdiKGC6aO5bNk9m78OBkN9tXO9IJwkFkXKPXNUeo5aur5b4l4OJjm3sAZcuT-Ko
                    smtp.Send(emailmessage);
                    smtp.Disconnect(true);
                }
                MessageBox.Show("Email sent succesfully");
            }
            catch (Exception e)
            {
            }
        }
    }
}

