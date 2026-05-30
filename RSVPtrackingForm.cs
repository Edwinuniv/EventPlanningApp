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
    public partial class RSVPtrackingForm : Form
    {
        private List<Event> userevent = new List<Event>();
        private List<RsvpTracking> userguest = new List<RsvpTracking>();
        private List<Tasks> tasks = new List<Tasks>();
        private string username;
        private string password;
        private DateTime dateTime;

        private Event selectedEvent = null;
        private bool sidebarexpend = true; 
        private static int Sidebarmaxw = 179;
        private static int sidebarminw = 53;
        private static int sidebarstep = 10;

        private List<RsvpTracking> guestList = new List<RsvpTracking>();

        public RSVPtrackingForm(string username,string password)
        {
            InitializeComponent();
            this.password = password;
            this.username = username;
        }

        private void RSVPtrackingForm_Load(object sender, EventArgs e)
        {
            LoadEvents();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sidebartimer.Start();
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
                    label3.Location = new Point(70, 53);
                    label2.Location = new Point(70, 85);
                    label6.Location = new Point(70, 125);
                    label4.Location = new Point(362, 53);
                    label5.Location = new Point(362, 86);
                    txtName.Location = new Point(233, 53);
                    txtLastName.Location = new Point(233, 89);
                    txtEmail.Location = new Point(233, 129);
                    txtAge.Location = new Point(519, 58);
                    txtPhoneNumber.Location = new Point(519, 90);
                    btnAddguest.Location = new Point(98, 179);
                    btnEditGuest.Location = new Point(199, 179);
                    btnDeleteguest.Location = new Point(296, 179);
                    btnLoadguest.Location = new Point(395, 179);
                    Events.Location = new Point(117, 240);
                    Guests.Location = new Point(117, 343);
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
                    label3.Location = new Point(187, 53);
                    label2.Location = new Point(187, 85);
                    label6.Location = new Point(187, 125);
                    label4.Location = new Point(479, 53);
                    label5.Location = new Point(479, 86);
                    txtName.Location = new Point(350, 53);
                    txtLastName.Location = new Point(350, 89);
                    txtEmail.Location = new Point(350, 129);
                    txtAge.Location = new Point(636, 58);
                    txtPhoneNumber.Location = new Point(636, 90);
                    btnAddguest.Location = new Point(215, 179);
                    btnEditGuest.Location = new Point(316, 179);
                    btnDeleteguest.Location = new Point(413, 179);
                    btnLoadguest.Location = new Point(512, 179);
                    Events.Location = new Point(215, 240);
                    Guests.Location = new Point(215, 343);
                    Sidebartimer.Stop();
                    sidebarexpend = true;
                    UpdatePannelWidth(panel1.Width);
                    panel1.Width = panel1.Width;
                }
            }
        }

        private void btnTasksMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            TaskForm tf = new TaskForm(username, password);
            tf.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mp = new MainPage(username,password);
            mp.Show();
        }

        private void btnAddguest_Click(object sender, EventArgs e)
        {
            if (selectedEvent == null)
            {
                lblInfo.Text = "Select an event first";
                return;
            }

            string name = txtName.Text;
            string laastname = txtLastName.Text;
            int age;
            bool valid = int.TryParse(txtAge.Text, out age);
            string phone = txtPhoneNumber.Text;
            string email = txtEmail.Text;

            if (name == "")
            {
                lblInfo.Text = "Enter the guest name";
                return;
            }
            if (laastname == "")
            {
                lblInfo.Text = "Enter the guest last name";
                return;
            }
            if (age < 0)
            {
                lblInfo.Text = "A guest cannot have an age under 0";
                return;
            }
            if (age >= 100)
            {
                lblInfo.Text = "A guest cannot have an age above 100";
                return;
            }
            if (!valid)
            {
                lblInfo.Text = "Enter a valid age";
                return;
            }
            if (phone == "")
            {
                lblInfo.Text = "Enter the guest phone number";
                return;
            }
            if (!Methods.VerifyphoneNumber(phone))
            {
                lblInfo.Text = "Enter a valid phone number";
                return;
            }
            if (email == "")
            {
                lblInfo.Text = "Enter the guest email";
                return;
            }
            if (!Methods.VerifyEmail(email))
            {
                lblInfo.Text = "Enter the correct email format";
                return;
            }

            userguest = RsvpTracking.LoadGuestforuser(username,selectedEvent.event_Name);
            RsvpTracking r = new RsvpTracking(selectedEvent.event_Name, selectedEvent.event_Type, selectedEvent.event_Location, selectedEvent.dt, selectedEvent.time,"", name, laastname, age, phone, email);
            userguest.Add(r);
            RsvpTracking.SaveGueststoCSV(username,selectedEvent.event_Name, userguest);

            foreach(RsvpTracking r1 in userguest)
            {
                Guests.Items.Add(r1.DisplayGuests());

            }
            ClearFields();
        }
        private void ClearFields()
        {
            txtAge.Text = "";
            txtEmail.Text = "";
            txtLastName.Text = "";
            txtName.Text = "";
            txtPhoneNumber.Text = "";
        }

        private void btnEventMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            EventForm ef = new EventForm(username, password,dateTime);
            ef.Show();
        }

        private void btnEditGuest_Click(object sender, EventArgs e)
        {
            int index = Guests.SelectedIndex;
            if (selectedEvent == null || index < 0 || index >= userguest.Count)
            {
                lblInfo.Text = "Select a task to edit";
                return;
            }
            string name = txtName.Text;
            string laastname = txtLastName.Text;
            int age;
            bool valid = int.TryParse(txtAge.Text, out age);
            string phone = txtPhoneNumber.Text;
            string email = txtEmail.Text;

            if (name == "")
            {
                lblInfo.Text = "Enter the guest name";
                return;
            }
            if (laastname == "")
            {
                lblInfo.Text = "Enter the guest last name";
                return;
            }
            if (age < 0)
            {
                lblInfo.Text = "A guest cannot have an age under 0";
                return;
            }
            if (age >= 100)
            {
                lblInfo.Text = "A guest cannot have an age above 100";
                return;
            }
            if (!valid)
            {
                lblInfo.Text = "Enter a valid age";
                return;
            }
            if (phone == "")
            {
                lblInfo.Text = "Enter the guest phone number";
                return;
            }
            if (!Methods.VerifyphoneNumber(phone))
            {
                lblInfo.Text = "Enter a valid phone number";
                return;
            }
            if (email == "")
            {
                lblInfo.Text = "Enter the guest email";
                return;
            }
            if (!Methods.VerifyEmail(email))
            {
                lblInfo.Text = "Enter the correct email format";
                return;
            }

            userguest[index].name = name;
            userguest[index].last_name = laastname;
            userguest[index].age = age;
            userguest[index].phone_number = phone;
            userguest[index].email = email;
            RsvpTracking.SaveGueststoCSV(username , selectedEvent.event_Name, userguest);
            LoadGuestsForSelectedEvent();
            ClearFields();
            lblInfo.Text = "Task updated";

            NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
            n.Show();
        }

        private void btnDeleteguest_Click(object sender, EventArgs e)
        {
            int index = Guests.SelectedIndex;
            if (selectedEvent == null || index < 0 || index >= userguest.Count)
            {
                lblInfo.Text = "Select a guest to delete";
                return;
            }
            
            userguest.RemoveAt(index);
            RsvpTracking.SaveGueststoCSV(username , selectedEvent.event_Name, userguest);
            LoadGuestsForSelectedEvent();
            ClearFields();
            lblInfo.Text = "Guest has been deleted";

            NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
            n.Show();
        }
        private void LoadGuestsForSelectedEvent() 
        {
            Guests.Items.Clear();
            userguest.Clear();

            if (selectedEvent == null)
            {
                lblInfo.Text = "Select an event first";
                return;
            }

            List<RsvpTracking> allguests = RsvpTracking.LoadGuestforuser(username , selectedEvent.event_Name);

            foreach (RsvpTracking r in allguests)
            {
                if (r.event_Name == selectedEvent.event_Name)
                {
                    userguest.Add(r);
                    Guests.Items.Add(r.DisplayGuests());
                }
            }
            if (userguest.Count > 0)
            {
                lblInfo.Text = $"{userguest.Count} loaded guest(s) for {selectedEvent.event_Name}";

                NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
                n.Show();
            }
            else
            {
                lblInfo.Text = $"No guests added to this event";

                NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
                n.Show();
            }
        }

        private void btnLoadguest_Click(object sender, EventArgs e)
        {

            if (Events.SelectedIndex < 0)
            {
                lblInfo.Text = "Select an event first";
                return;
            }

            Events_SelectedIndexChanged(sender, e);
            LoadGuestsForSelectedEvent();
        }

        private void Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Events.SelectedIndex;
            if (index >= 0 && index < userevent.Count)
            {
                selectedEvent = userevent[index];
                LoadGuestsForSelectedEvent();
                lblInfo.Text = $"Selected event: {selectedEvent.event_Name}";
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm(userevent, userguest, tasks, username);
            rf.Show();
            this.Close();
        }

        private void btnFeedbackMenu_Click(object sender, EventArgs e)
        {
            FeedbackForm ff = new FeedbackForm();
            ff.Show();
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

        private void btnTemplatesMenu_Click(object sender, EventArgs e)
        {
            TemplateForm f = new TemplateForm(username, password);
            f.Show();
            this.Close();
        }
    }
}
