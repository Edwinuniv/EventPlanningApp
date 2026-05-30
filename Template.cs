using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_planner
{
    internal class Template : Event
    {
        public string username;
        public Template(string eventname,string eventType, string eventLoc,DateTime dt , string time,string username) : base(eventname, eventType, eventLoc, dt, time, username)
        {
            this.username = username;
        }

        private static List<Template> t = new List<Template>()
        {
             new Template("Birthday party","Celebration","Home",DateTime.Today.AddDays(7),"18:00","username"),
             new Template("Wedding","Celebration","Jezzin",DateTime.Today.AddMonths(1),"14:00","username"),
             new Template("Conference","Business","Conference center",DateTime.Today.AddDays(14),"18:00","username"),
             new Template("Concert","Entertainement","Beirut club",DateTime.Today.AddDays(21),"22:00","username"),
             new Template("Worshop","Education","Community center",DateTime.Today.AddDays(10),"10:00","username"),
             new Template("Sports game","Fun","Ghazir court",DateTime.Today.AddDays(10),"21:00","username")
        };

        public static List<Template> GetTemplates()
        {
            return t;
        }

        public static Event CreateTemplate(Template t1, string username,DateTime newDate)
        {
            return new Event(t1.event_Name, t1.event_Type, t1.event_Location, newDate, t1.time, username);
        }

        public override string DisplayEventDetail()
        {
            return base.DisplayEventDetail();
        }
    }
}
