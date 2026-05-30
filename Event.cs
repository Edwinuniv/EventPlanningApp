using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_planner
{
    public class Event 
    {
        public string event_Name;
        public string event_Type;
        public string event_Location;
        public DateTime dt;
        public string time;
        public string username;

        public Event()
        {
            
        }

        public Event(string event_Name, string event_Type, string event_Descryption, DateTime dt, string time, string username)
        {
            this.event_Name = event_Name;
            this.event_Type = event_Type;
            this.event_Location = event_Descryption;
            this.dt = dt;
            this.time = time;
            this.username = username;
        }

        public virtual string DisplayEventDetail()
        {
            string s = $@"Event: {event_Name}
Type: {event_Type} 
Location: {event_Location}
Date: {dt}
Time: {time}

";
            return s;
        }

        public string TocsvString()
        {
            string s = $"{event_Name},{event_Type},{event_Location},{dt},{time},{username}";
            return s;
        }

        public static Event FromCSVString(string filename)
        {
            string[] info = filename.Split(',');
            DateTime dt;
            bool valid = DateTime.TryParse(info[3], out dt);
            Event ev = new Event(info[0], info[1], info[2], dt, info[4], info[5]);
            return ev;
        }

        public static void SaveUserEvents(string username,List<Event> eventS)
        {
            string filename = $"Events_{username}.csv";
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("Event name, Event type, Event location, Date, Time,username");
                for (int i = 0; i < eventS.Count; i++)
                {
                    sw.WriteLine(eventS[i].TocsvString());
                }
            }
        }
        
        public static List<Event> LoadUserEvents(string username)
        {
            List<Event> ev = new List<Event>();
            string file = $"Events_{username}.csv";
            try
            {
                using (StreamReader SR = new StreamReader(file))
                {
                    string line;
                    bool valid = true;

                    while ((line = SR.ReadLine()) != null)
                    {
                        if (valid)
                        {
                            valid = false;
                            continue;
                        }
                        Event ev1 = FromCSVString(line);
                        if (ev1 != null)
                        {
                            ev.Add(ev1);
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }

            return ev;
        }
    }
}
