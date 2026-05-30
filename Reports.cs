using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_planner
{
    public class Reports
    {
        public static string GenerateReports(Event e, List<Tasks> tasks, List<RsvpTracking> guests, string username)
        {
            List<string> report = new List<string>();

            report.Add("Event report");

            report.Add("====================");
            report.Add($"Event name: {e.event_Name}");
            report.Add($"Event type: {e.event_Type}");
            report.Add($"Event location: {e.event_Location}");
            report.Add($"Event date: {e.dt.ToShortDateString()}");
            report.Add($"Event time: {e.time}");
            report.Add("");

            List<RsvpTracking> rGuests = new List<RsvpTracking>();

            foreach (RsvpTracking g in guests)
            {
                if (g.event_Name == e.event_Name && g.dt.Date == e.dt.Date && g.time == e.time)
                {
                    rGuests.Add(g);
                }
            }
            if (rGuests.Count > 0)
            {
                report.Add("Guests");

                foreach (RsvpTracking g in rGuests)
                {
                    report.Add($"Guest name: {g.name}");
                    report.Add($"Guest last name: {g.last_name}");
                    report.Add($"Guest age: {g.age}");
                    report.Add($"Guest phone number: {g.phone_number}");
                    report.Add($"Guest email: {g.email}");
                    report.Add("");
                }
            }
            else
            {
                report.Add("No guests have been added");
                report.Add("");
            }

            List<Tasks> rTasks = new List<Tasks>();
            foreach (Tasks t in tasks)
            {
                if (t.event_Name == e.event_Name && t.dt.Date == e.dt.Date && t.time == e.time)
                {
                    rTasks.Add(t);
                }
            }
            if (rTasks.Count > 0)
            {
                report.Add("Tasks");

                foreach (Tasks t in rTasks)
                {
                    report.Add($"Task name: {t.task_Name}");
                    report.Add($"Task description: {t.task_Description}");
                    report.Add($"Task priority: {t.task_Priority}");
                    report.Add("");
                }
            }
            else
            {
                report.Add("No tasks have been added");
                report.Add("");
            }

            try
            {
                string file = "Reports\\EventReport_" + e.event_Name.Replace(" ", "_").Replace(":", "_") + "_" + e.dt.ToString("yyyyMMdd") + ".txt";


                using (StreamWriter sw = new StreamWriter(file))
                {
                    foreach (string line in report)
                    {
                        sw.WriteLine(line);
                    }
                }
                return file;
            }
            catch
            {
                return "Error";
            }
        }
    }
}
