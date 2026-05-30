using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_planner
{
    public class RsvpTracking : Event
    {
        public string name;
        public string last_name;
        public int age;
        public string phone_number;
        public string email;
        public string username;
        public static List<RsvpTracking> rsvp = new List<RsvpTracking>();

        public RsvpTracking(string event_Name, string event_Type, string event_Descryption, DateTime dt, string time,string username, string name, string last_name, int age, string phone_number, string email) : base(event_Name, event_Type, event_Descryption, dt, time,username)
        {
            this.name = name;
            this.last_name = last_name;
            this.age = age;
            this.phone_number = phone_number;
            this.email = email;
            this.username = username;
        }

        public string DisplayGuests()
        {
            string s = $@"Guest name: {name}
 Guest lastname: {last_name}
 Age: {age}
 Phone number: {phone_number}
 Email: {email}";
            return s;
        }

        public static List<RsvpTracking> LoadGuestforuser(string username,string eventname)
        {
            string filename = $"Guests_{username}_{eventname}.csv";
            List<RsvpTracking> t = new List<RsvpTracking>();

            try
            {
                using (StreamReader SR = new StreamReader(filename))
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
        public string TocsvStringguest()
        {
            string s = $"{event_Name},{event_Type},{event_Location},{dt},{time},{username},{name},{last_name},{age},{phone_number},{email}";
            return s;
        }

        public static void SaveGueststoCSV(string username,string eventname, List<RsvpTracking> guests)
        {
            string filename = $"Guests_{username}_{eventname}.csv";
            using (StreamWriter sw = new StreamWriter(filename))
            {
                for (int i = 0; i < guests.Count; i++)
                {
                    sw.WriteLine(guests[i].TocsvStringguest());
                }
            }
        }

        public static RsvpTracking FromCSV(string l)
        {
            string[] info = l.Split(',');
            string eventname = info[0];
            string eventtype = info[1];
            string eventLoc = info[2];
            DateTime dt;
            bool valid = DateTime.TryParse(info[3], out dt);
            string time = info[4];
            string username = info[5];
            string name = info[6];
            string Lastname = info[7];
            int age;
            bool valid1 = int.TryParse(info[8], out age);
            string phone = info[9];
            string email = info[10];
            RsvpTracking r = new RsvpTracking(eventname, eventtype, eventLoc, dt, time,username, name, Lastname, age, phone, email);
            return r;
        }
    }
}
