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
    public partial class EventForm : Form
    {
        private List<Event> userevent = new List<Event>();
        private List<Tasks> tasks = new List<Tasks>();
        private List<RsvpTracking> rsvpTrackings = new List<RsvpTracking>();
        private string username;
        private string password;
        public DateTime dateTime;
        public bool EventAdded = false;

        private bool sidebarexpend = true;
        private static int Sidebarmaxw = 179;
        private static int sidebarminw = 53;
        private static int sidebarstep = 10;
        public EventForm(string username, string password,DateTime dateTime)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            userevent = Event.LoadUserEvents(username);
            this.dateTime = dateTime;
            if(this.dateTime < DateTime.Now)
            {
                lblInfo.Text = "Can't add an event in the past";
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
                dateTimePicker1.Value = this.dateTime;
            }
        }

        private void refreshevent()
        {
            Events.Items.Clear();
            foreach(Event ev in userevent)
            {
                Events.Items.Add(ev.DisplayEventDetail());
            }
        }
        private void UpdatePannelWidth(int width)
        {
            panel3.Width = width;
            panel2.Width = width;
            panel4.Width = width;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            userevent = Event.LoadUserEvents(username);

            List<Event> events = new List<Event>();
            foreach (Event ev in userevent)
            {
                TimeSpan diffrence = ev.dt.Date - DateTime.Today;
                if (diffrence.TotalDays >= 0 && diffrence.TotalDays <= 1)
                {
                    events.Add(ev);
                }
            }
            if (events.Count > 0)
            {
                string s = $"You have {events.Count} event(s) today";
                foreach (Event ev in events)
                {
                    s += "\n- " + ev.event_Name + "\n";
                }
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = "Todays events";
                notifyIcon1.BalloonTipText = s;
                notifyIcon1.ShowBalloonTip(3000);

            }

            dateTimePicker1.MinDate = DateTime.Now;
            numericUpDownHour.Minimum = 1;
            numericUpDownHour.Maximum = 12;
            numericUpDownHour.Value = 12;
            numericUpDownMinute.Minimum = 0;
            numericUpDownMinute.Maximum = 59;
            numericUpDownMinute.Value = 0;
            numericUpDownMinute.Increment = 5;

            radioButtonAM.Checked = true;
            radioButtonPM.Checked = false;
        }

        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpend)
            {
                panel1.Width -= sidebarstep;
                if (panel1.Width <= sidebarminw)
                {
                    label3.Location = new Point(70, 107);
                    label2.Location = new Point(70, 58);
                    label4.Location = new Point(314, 58);
                    label6.Location = new Point(115, 156);
                    label5.Location = new Point(315, 107);
                    label7.Location = new Point(321, 153);
                    txtEventname.Location = new Point(196, 63);
                    txtEventType.Location = new Point(196, 112);
                    txtLocation.Location = new Point(468, 64);
                    btnaddevent.Location = new Point(85, 199);
                    btnEditevent.Location = new Point(166, 199);
                    btnDeleteevent.Location = new Point(254, 199);
                    btnload.Location = new Point(166, 232);
                    btnhistory.Location = new Point(85, 232);
                    Events.Location = new Point(75, 317);
                    dateTimePicker1.Location = new Point(431, 112);
                    numericUpDownHour.Location = new Point(196, 158);
                    numericUpDownMinute.Location = new Point(417, 158);
                    radioButtonAM.Location = new Point(551, 153);
                    radioButtonPM.Location = new Point(616, 153);
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
                    label3.Location = new Point(195, 107);
                    label2.Location = new Point(195, 58);
                    label4.Location = new Point(439, 58);
                    label6.Location = new Point(240, 156);
                    label5.Location = new Point(439, 107);
                    label7.Location = new Point(445, 153);
                    txtEventname.Location = new Point(321, 63);
                    txtEventType.Location = new Point(321, 112);
                    txtLocation.Location = new Point(593, 64);
                    btnaddevent.Location = new Point(210, 199);
                    btnEditevent.Location = new Point(291, 199);
                    btnDeleteevent.Location = new Point(379, 199);
                    btnload.Location = new Point(291, 232);
                    btnhistory.Location = new Point(210, 232);
                    Events.Location = new Point(200, 317);
                    dateTimePicker1.Location = new Point(555, 112);
                    numericUpDownHour.Location = new Point(321, 158);
                    numericUpDownMinute.Location = new Point(543, 158);
                    radioButtonAM.Location = new Point(677, 153);
                    radioButtonPM.Location = new Point(742, 153);
                    Sidebartimer.Stop();
                    sidebarexpend = true;
                    UpdatePannelWidth(panel1.Width);
                    panel1.Width = panel1.Width;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sidebartimer.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mp = new MainPage(username,password);
            mp.Show();
        }

        private void btnaddevent_Click(object sender, EventArgs e)
        {
            string evname = txtEventname.Text;
            string evtype = txtEventType.Text;
            string evlocation = txtLocation.Text;
            DateTime dt = dateTimePicker1.Value;
            bool valid = true;

            if (evname == "")
            {
                lblInfo.Text = "Enter a name please.";
                return;
            }
            if (evtype == "")
            {
                lblInfo.Text = "Enter a type please.";
                return;
            }
            if (evlocation == "")
            {
                lblInfo.Text = "Enter a location please.";
                return;
            }

            if (dt < DateTime.Today)
            {
                lblInfo.Text = "You cannot create an event in a past date.";
                valid = false;
                return;
            }

            int hour = (int)numericUpDownHour.Value;
            int minute = (int)numericUpDownMinute.Value;
            if (radioButtonAM.Checked && hour == 12)
            {
                hour = 0;
            }
            else if (radioButtonPM.Checked && hour == 12)
            {
                hour += 12;
            }

            string eventTime = new DateTime(1, 1, 1, hour, minute, 0).ToString("hh:mm tt");


            Event ev = new Event(evname, evtype, evlocation, dt, eventTime,username);
            userevent.Add(ev);
            Event.SaveUserEvents(username, userevent);
            lblInfo.Text = "Event added succesfully";
            EventAdded = true;
            notifyIcon1.BalloonTipTitle = "New Event";
            notifyIcon1.BalloonTipText = "Event added";
            notifyIcon1.ShowBalloonTip(3000);
            ClearFields();

            refreshevent();
        }
        private void ClearFields()
        { 
            txtEventname.Text = "";
            txtEventType.Text = "";
            txtLocation.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            numericUpDownHour.Value = 1;
            numericUpDownMinute.Value = 0;
            radioButtonAM.Checked = false;
            radioButtonPM.Checked = true;
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            Events.Items.Clear();

            userevent = Event.LoadUserEvents(username);
            userevent = FilerUpcomingEvents(userevent);

            foreach (Event ev in userevent)
            {
                Events.Items.Add(ev.DisplayEventDetail());
            }

            if (Events.Items.Count == 0)
            {
                lblInfo.Text = "There is no loaded events";

                NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
                n.Show();
            }
            else
            {
                lblInfo.Text = $"{Events.Items.Count} loaded events";

                NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
                n.Show();
            }
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

        private void ShowPastEvents()
        { 
            Events.Items.Clear();
            foreach (Event ev in userevent)
            {
                if (ev.dt.Date < DateTime.Now.Date)
                {   
                    string s = ev.DisplayEventDetail();
                    Events.Items.Add(s);
                }
                else
                {
                    lblInfo.Text = "There are no events in the past.";

                    NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
                    n.Show();
                }
            }
        }

        private void btnDeleteevent_Click(object sender, EventArgs e)
        {
            int index = Events.SelectedIndex;

            if (index >= 0 && index < userevent.Count)
            {
                userevent.RemoveAt(index);
                Event.SaveUserEvents(username, userevent);

                Events.Items.RemoveAt(index);
                lblInfo.Text = "Event deleted";

                NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
                n.Show();

                ClearFields();
            }
            else
            {
                lblInfo.Text = "Select an event to delete";
            }
        }

        private void btnEditevent_Click(object sender, EventArgs e)
        {
            int index = Events.SelectedIndex;
            string evname = txtEventname.Text;
            string evtype = txtEventType.Text;
            string evlocation = txtLocation.Text;
            DateTime dt = dateTimePicker1.Value;
            bool valid = true;

            if (index >= 0 && index < userevent.Count)
            {
                Event ev = userevent[index];

                ev.event_Name = txtEventname.Text;
                ev.event_Type = txtEventType.Text;
                ev.event_Location = txtLocation.Text;
                ev.dt = dateTimePicker1.Value;
                if (evname == "")
                {
                    lblInfo.Text = "Enter a name please.";
                    return;
                }
                if (evtype == "")
                {
                    lblInfo.Text = "Enter a type please.";
                    return;
                }
                if (evlocation == "")
                {
                    lblInfo.Text = "Enter a location please.";
                    return;
                }

                if (dt < DateTime.Now)
                {
                    lblInfo.Text = "You cannot create an event in a past date.";
                    valid = false;
                    return;
                }
                int hour = (int)numericUpDownHour.Value;
                int minute = (int)numericUpDownMinute.Value;

                if (radioButtonAM.Checked && hour == 12)
                {
                    hour = 0;
                }
                else if (radioButtonPM.Checked && hour != 12)
                {
                    hour += 12;
                }

                ev.time = new DateTime(1, 1, 1, hour, minute, 0).ToString("hh:mm tt");

                Event.SaveUserEvents(username,userevent);

                Events.Items[index] = ev.DisplayEventDetail();
                lblInfo.Text = "Event updated";

                NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
                n.Show();

                ClearFields();

            }
            else
            {
                lblInfo.Text = "Select an event to edit";
            }
        }

        private void btnTasksMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            TaskForm tf = new TaskForm(username,password);
            tf.Show();
        }

        private void btnRSVP_Click(object sender, EventArgs e)
        {
            this.Close();
            RSVPtrackingForm rSVPtrackingForm = new RSVPtrackingForm(username,password);
            rSVPtrackingForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm(userevent, rsvpTrackings, tasks, username);
            rf.Show();
            this.Close();
        }

        private void btnFeedbackMenu_Click(object sender, EventArgs e)
        {
            FeedbackForm ff = new FeedbackForm();
            this.Close();
            ff.Show();
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

        private void btnhistory_Click(object sender, EventArgs e)
        {
            ShowPastEvents();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTemplatesMenu_Click(object sender, EventArgs e)
        {
            TemplateForm f = new TemplateForm(username, password);
            f.Show();
            this.Close();
        }
    }
}
