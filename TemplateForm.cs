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
    public partial class TemplateForm : Form
    {
        private List<Event> userevent = new List<Event>();
        private List<Tasks> currentTask = new List<Tasks>();
        private List<RsvpTracking> rsvpTrackings = new List<RsvpTracking>();

        private string username;
        private string password;

        private List<Template> l = new List<Template>();
        private DateTime dateTime;

        private bool sidebarexpend = true;
        private static int Sidebarmaxw = 179;
        private static int sidebarminw = 53;
        private static int sidebarstep = 10;

        public TemplateForm(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            l = Template.GetTemplates();
            userevent = new List<Event>();
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            foreach(Template t in l)
            {
                LTemplates.Items.Add(t.DisplayEventDetail());
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

        private void btnCT_Click(object sender, EventArgs e)
        {
            int selectI = LTemplates.SelectedIndex;
            if(selectI < 0)
            {
                lblInfo.Text = "Select a template";
                return;
            }
            Template t1 = l[selectI];
            DateTime dt = dateTimePicker1.Value.Date;

            int hour = (int)numericUpDownHour.Value;
            int minute = (int)numericUpDownMinute.Value;

            if(radioButtonAM.Checked && hour == 12)
            {
                hour = 0;
            }
            else if(radioButtonPM.Checked && hour != 12)
            {
                hour += 12;
            }

            DateTime fD = new DateTime(dt.Year, dt.Month, dt.Day, hour, minute,0);
            string s = fD.ToString("hh:mm tt");

            Event ev = Template.CreateTemplate(t1, username, dt);

            ev.time = s;

            List<Event> currentUser = Event.LoadUserEvents(username);
            currentUser.Add(ev);

            Event.SaveUserEvents(username,currentUser);

            CreatedEventsL.Items.Add(t1.DisplayEventDetail());
            lblInfo.Text = "Done";
        }

        private void btnTasksMenu_Click(object sender, EventArgs e)
        {
            TaskForm t = new TaskForm(username, password);
            t.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage m = new MainPage(username,password);
            m.Show();
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

        private void btnFeedbackMenu_Click(object sender, EventArgs e)
        {
            FeedbackForm ff = new FeedbackForm();
            this.Close();
            ff.Show();
        }

        private void btnRSVP_Click(object sender, EventArgs e)
        {
            RSVPtrackingForm rSVPtrackingForm = new RSVPtrackingForm(username, password);
            rSVPtrackingForm.Show();
            this.Close();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            EventForm ev = new EventForm(username, password, dateTime);
            ev.Show();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

            ReportsForm rf = new ReportsForm(userevent, rsvpTrackings, currentTask, username);
            rf.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sidebartimer.Start();
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
        private void UpdatePannelWidth(int width)
        {
            panel3.Width = width;
            panel2.Width = width;
            panel4.Width = width;
        }
    }
}
