using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Tls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Event_planner
{
    public partial class MainPage : Form
    {
        private List<Event> events = new List<Event>();
        private List<Tasks> tasks = new List<Tasks>();
        private List<RsvpTracking> rsvpTrackings = new List<RsvpTracking>();
        private string username;
        private string password;

        private DateTime date;
        private int month;
        private int year;

        private bool sidebarexpend = true; 
        private static int Sidebarmaxw = 179;
        private static int sidebarminw = 53;
        private static int sidebarstep = 10;
        public MainPage(string username,string password)
        {
            InitializeComponent();
            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Event planner app";
            this.username = username;
            this.password = password;
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;
            events = Event.LoadUserEvents(username);
            DisplayDays();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            label2.Text = "Hello " + username;
            reminderTimer.Tick += ReminderTimer_Tick;
            reminderTimer.Start();
        }

        private void ReminderTimer_Tick(object sender, EventArgs e)
        {

        }

        private void btnEventMenu_Click(object sender, EventArgs e)
        {
            EventForm ev = new EventForm(username, password, date);
            ev.dateTime = date;
            ev.Show();
            this.Hide();
            if (ev.EventAdded)
            {
                events = Event.LoadUserEvents(username);
                DisplayDays();
            }
            this.Close();
        }
        private void UpdatePannelWidth(int width)
        {
            panel3.Width = width;
            panel2.Width = width;
            panel4.Width = width;
        }

        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpend)
            {
                panel1.Width -= sidebarstep;
                if (panel1.Width <= sidebarminw)
                {
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
                    Sidebartimer.Stop();
                    sidebarexpend = true;
                    UpdatePannelWidth(panel1.Width);
                    panel1.Width = panel1.Width;
                }
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm(events, rsvpTrackings, tasks, username);
            rf.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sidebartimer.Start();
        }

        private void btnTasksMenu_Click(object sender, EventArgs e)
        {
            TaskForm t = new TaskForm(username,password);
            t.Show();
            this.Close();
        }

        private void btnFeedbackMenu_Click(object sender, EventArgs e)
        {
            FeedbackForm ff = new FeedbackForm();
            ff.Show();
            this.Close();
        }

        private void btnRSVP_Click(object sender, EventArgs e)
        {
            RSVPtrackingForm rSVPtrackingForm = new RSVPtrackingForm(username,password);
            rSVPtrackingForm.Show();
            this.Close();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void DisplayDays()
        {
            string months = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonth.Text = $"{months} {year}";

            int dayInmonth = DateTime.DaysInMonth(year, month);
            DateTime dayOne = new DateTime(year, month, 1);
            int index = 0;

           foreach(Control control in daycontainer.Controls)
           {
                if(control is Button btn)
                {
                    index++;

                    if(index <= dayInmonth)
                    {
                        DateTime thisdate = new DateTime(year, month, index);
                        btn.Text = index.ToString();
                        btn.Tag = thisdate;
                        btn.Visible = true;

                        bool valid = false;
                        foreach(Event ev in events)
                        {
                            if(ev.dt.Date == thisdate.Date)
                            {
                                valid = true;
                            }
                        }
                        if (valid)
                        {
                            btn.BackColor = Color.Blue;
                            btn.Text += " *";
                        }
                        else
                        {
                            btn.BackColor = Color.FromArgb(15, 40, 80);
                        }

                        btn.Click -= btnEventMenu_Click;
                        btn.Click += btnEventMenu_Click;
                    }
                    else
                    {
                        btn.Visible = false;
                    }
                }
           }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            events = Event.LoadUserEvents(username);
            DisplayDays();
            string message = "";
            foreach(Event ev in events)
            {
                if(ev.username == username && ev.dt.Month == month && ev.dt.Year == year)
                {
                    message += ev.DisplayEventDetail() + "\n\n";

                    NotificationForm n = new NotificationForm("Notification", "Event loaded");
                    n.Show();
                }
            }

            if(message == "")
            {
                txtEvents.Text = "";
                label3.Text = "No events today";
            }
            else
            {
                txtEvents.Text = message;
                label3.Text = "";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            month++;
            if(month > 12)
            {
                month = 1;
                year++;
            }
            DisplayDays();
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            month--;
            if(month < 1)
            {
                month = 12;
                year--;
            }
            DisplayDays();
        }

        private void daycontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnTemplatesMenu_Click(object sender, EventArgs e)
        {
            TemplateForm f = new TemplateForm(username, password);
            f.Show();
            this.Close();
        }

        private void reminderTimer_Tick(object sender, EventArgs e)
        {
            string username = this.username;

            List<Event> events = Event.LoadUserEvents(username);

            DateTime NOW = DateTime.Now;

            foreach (Event ev in events)
            {
                DateTime evDate;
                bool valid = DateTime.TryParse(ev.dt.ToString(), out evDate);

                if (valid)
                {
                    TimeSpan time = evDate - NOW;

                    if (time.TotalMinutes <= 10 && time.TotalMinutes > 0)
                    {
                        notifyIcon1.Text = "Umpcoming events";
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
