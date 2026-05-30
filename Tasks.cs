using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_planner
{
    public class Tasks : Event
    {
        public string task_Name;
        public string task_Priority;
        public string task_Description;
        public double task_budget;
        public string username;
        public static List<Task> tasks = new List<Task>();

        public Tasks(string eventname, string eventType, string eventLocation, DateTime dt, string time,string username, string task_Name, string task_Priority, string task_Description, double b) : base(eventname, eventType, eventLocation, dt, time, username)
        {
            this.task_Name = task_Name;
            this.task_Priority = task_Priority;
            this.task_Description = task_Description;
            this.task_budget = b;
            this.username = username;
        }
        public Tasks(string eventname, string eventType, string eventLocation, DateTime dt, string time,string username, string task_Name, string task_Priority, string task_Description) : base(eventname, eventType, eventLocation, dt, time  , username)
        {
            this.task_Name = task_Name;
            this.task_Priority = task_Priority;
            this.task_Description = task_Description;
            this.username = username;
        }

        public string TocsvStringtask()
        {
            string s = $"{event_Name},{event_Type},{event_Location},{dt},{time},{username},{task_Name},{task_Priority},{task_Description},{task_budget}";
            return s;
        }

        public static Tasks FromCSV(string l)
        {
            string[] info = l.Split(',');
            string eventname = info[0];
            string eventtype = info[1];
            string eventLoc = info[2];
            DateTime dt;
            bool valid = DateTime.TryParse(info[3], out dt);
            string time = info[4];
            string username = info[5];
            string task_Name = info[6];
            string taskpriority = info[7];
            string taskDescription = info[8];
            double b;
            bool valid1 = double.TryParse(info[9], out b);
            Tasks t = new Tasks(eventname, eventtype, eventLoc, dt, time, username, task_Name, taskpriority, taskDescription, b);
            return t;
        }


        public override string DisplayEventDetail()
        {
            string s = $@"
Task name: {task_Name}. 
Priority: {task_Priority}. 
Description: {task_Description}.";
            return s;
        }
        public static void SaveTasktoCSV(string username, List<Tasks> tasks)
        {
            string filename = $"Tasks_{username}.csv";
            using (StreamWriter sw = new StreamWriter(filename))
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    sw.WriteLine(tasks[i].TocsvStringtask());
                }
            }
        }
        public static List<Tasks> LoadTasksForUsers(string username,string eventname)
        {
            string file = $"Tasks_{username}_{eventname}.csv";
            List<Tasks> t = new List<Tasks>();

            try
            {
                using (StreamReader SR = new StreamReader(file))
                {
                    string line;
                    while ((line = SR.ReadLine()) != null)
                    {
                        t.Add(FromCSV(line));
                    }
                }
            }
            catch (Exception e)
            {

            }

            return t;
        }
    }
}
