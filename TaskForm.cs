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
    public partial class TaskForm : Form
    {
        private List<Event> userevent = new List<Event>(); 
        private List<Tasks> currentTask = new List<Tasks>();
        private List<RsvpTracking> rsvpTrackings = new List<RsvpTracking>();
        private string username;
        private string password;
        private DateTime dateTime;

        private Event selectedEvent = null;
        Budget userb = new Budget();

        private bool sidebarexpend = true; 
        private static int Sidebarmaxw = 179;
        private static int sidebarminw = 53;
        private static int sidebarstep = 10;
        public TaskForm(string username,string password)
        {
            InitializeComponent();
            this.password = password;
            this.username = username;
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (selectedEvent == null)
            {
                lblInfo.Text = "Select an event first";
                return;
            }
            string taskname = txtTaskname.Text;
            string taskpriority = txtTaskpriority.Text;
            string taskDesc = txtDescription.Text;

            if (taskname == "")
            {
                lblInfo.Text = "You need to add the task name first";
                return;
            }
            if (taskpriority == "")
            {
                lblInfo.Text = "You need to add the task priority level first";
                return;
            }
            if (taskDesc == "")
            {
                lblInfo.Text = "You need to add the task description first";
                return;
            }
            Tasks t = new Tasks(selectedEvent.event_Name, selectedEvent.event_Type, selectedEvent.event_Location, selectedEvent.dt, selectedEvent.time,"", taskname, taskpriority, taskDesc);
            t.event_Name = selectedEvent.event_Name;
            currentTask.Add(t);
            Event_planner.Tasks.SaveTasktoCSV(username+"_"+t.event_Name, currentTask);

            Tasks.Items.Add(t.DisplayEventDetail());
            ClearFields();
        }
        private void ClearFields()
        {
            txtDescription.Text = "";
            txtTaskname.Text = "";
            txtTaskpriority.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainPage mp = new MainPage(username,password);
            mp.Show();
        }

        private void btnEventMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            EventForm ef = new EventForm(username,password,dateTime);
            ef.Show();
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

        private void Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Events.SelectedIndex;
            if (index >= 0 && index < userevent.Count)
            {
                selectedEvent = userevent[index];
                lblInfo.Text = $"Selected event: {selectedEvent.event_Name}";
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            int index = Tasks.SelectedIndex;
            if (selectedEvent == null || index < 0 || index >= currentTask.Count)
            {
                lblInfo.Text = "Select a task to edit";
                return;
            }

            string taskname = txtTaskname.Text;
            string taskpriority = txtTaskpriority.Text;
            string taskDesc = txtDescription.Text;

            if (taskname == "")
            {
                lblInfo.Text = "You need to add the task name first";
                return;
            }
            if (taskpriority == "")
            {
                lblInfo.Text = "You need to add the task priority level first";
                return;
            }
            if (taskDesc == "")
            {
                lblInfo.Text = "You need to add the task description first";
                return;
            }

            currentTask[index].task_Name = taskname;
            currentTask[index].task_Description = taskDesc;
            currentTask[index].task_Priority = taskpriority;
            Event_planner.Tasks.SaveTasktoCSV(username + "_" +selectedEvent.event_Name, currentTask);
            LoadTasksForSelectedEvent();
            ClearFields();
            lblInfo.Text = "Task updated";

            NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
            n.Show();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            int index = Tasks.SelectedIndex;
            if (selectedEvent == null || index < 0 || index >= currentTask.Count)
            {
                lblInfo.Text = "Select a task to delete";
                return;
            }

            currentTask.RemoveAt(index);
            Event_planner.Tasks.SaveTasktoCSV(username + "_" + selectedEvent.event_Name, currentTask);
            LoadTasksForSelectedEvent();
            ClearFields();
            lblInfo.Text = "Task has been deleted";

            NotificationForm n = new NotificationForm("Notification", lblInfo.Text);
            n.Show();
        }
        private void LoadTasksForSelectedEvent() 
        {
            Tasks.Items.Clear();
            currentTask.Clear();

            if (selectedEvent == null)
            {
                lblInfo.Text = "Select an event first";
                return;
            }

            List<Tasks> allTask = Event_planner.Tasks.LoadTasksForUsers(username, selectedEvent.event_Name);

            foreach (Tasks t in allTask)
            {
                if (t.event_Name == selectedEvent.event_Name)
                {
                    currentTask.Add(t);
                    double b = 0;
                    userb.expensesItems.TryGetValue(t.task_Name, out b);
                    Tasks.Items.Add(t.DisplayEventDetail() + $" Budget: {b}");
                }
            }
            if (currentTask.Count > 0)
            {
                lblInfo.Text = $"{currentTask.Count} loaded task(s) for {selectedEvent.event_Name}";
            }
            else
            {
                lblInfo.Text = $"No tasks added to this event";
            }
        }

        private void btnLoadTasks_Click(object sender, EventArgs e)
        {
            if (Events.SelectedIndex < 0)
            {
                lblInfo.Text = "Select an event first";
                return;
            }
            Events_SelectedIndexChanged(sender, e);
            LoadTasksForSelectedEvent();
        }

        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarexpend)
            {
                panel1.Width -= sidebarstep;
                if (panel1.Width <= sidebarminw)
                {
                    label3.Location = new Point(70, 103);
                    label2.Location = new Point(70, 55);
                    label4.Location = new Point(332, 56);
                    txtTaskname.Location = new Point(203, 58);
                    txtTaskpriority.Location = new Point(203, 108);
                    txtDescription.Location = new Point(500, 60);
                    btnBudgetmenu.Location = new Point(339, 94);
                    btnAddTask.Location = new Point(79, 144);
                    btnEditTask.Location = new Point(169, 144);
                    btnDeleteTask.Location = new Point(268, 144);
                    btnLoadTasks.Location = new Point(356, 144);
                    Events.Location = new Point(60, 184);
                    Tasks.Location = new Point(60, 293);
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
                    label3.Location = new Point(196, 103);
                    label2.Location = new Point(196, 55);
                    label4.Location = new Point(458, 56);
                    txtTaskname.Location = new Point(329, 58);
                    txtTaskpriority.Location = new Point(329, 108);
                    txtDescription.Location = new Point(626, 60);
                    btnBudgetmenu.Location = new Point(463, 94);
                    btnAddTask.Location = new Point(205, 144);
                    btnEditTask.Location = new Point(295, 144);
                    btnDeleteTask.Location = new Point(394, 144);
                    btnLoadTasks.Location = new Point(482, 144);
                    Events.Location = new Point(186, 184);
                    Tasks.Location = new Point(186, 293);
                    Sidebartimer.Stop();
                    sidebarexpend = true;
                    UpdatePannelWidth(panel1.Width);
                    panel1.Width = panel1.Width;
                }
            }
        }

        private void btnBudgetmenu_Click(object sender, EventArgs e)
        {
            if (Tasks.SelectedIndex == -1)
            {
                lblInfo.Text = "Select a Task first";
                return;
            }
            using (BudgetForm bf = new BudgetForm(userb, currentTask))
            {
                int selectedi = Tasks.SelectedIndex;
                if (selectedi >= 0 && selectedi < currentTask.Count)
                {
                    string taskname = currentTask[selectedi].task_Name;
                    for (int i = 0; i < bf.tasks.Count; i++)
                    {
                        if (bf.tasks[i].task_Name == taskname)
                        {
                            bf.SelectedIndex = i;
                            i = bf.tasks.Count;
                        }
                    }
                }
                if (bf.ShowDialog() == DialogResult.OK)
                {
                    userb = bf.GetBudget();
                }
            }
        }

        private void btnRSVP_Click(object sender, EventArgs e)
        {
            this.Close();
            RSVPtrackingForm rSVPtrackingForm = new RSVPtrackingForm(username,password);
            rSVPtrackingForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm rf = new ReportsForm(userevent, rsvpTrackings, currentTask, username);
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

        private void btnTemplatesMenu_Click(object sender, EventArgs e)
        {
            TemplateForm f = new TemplateForm(username, password);
            f.Show();
            this.Close();
        }
    }
}
