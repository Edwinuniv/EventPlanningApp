using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MailKit.Security;
using MimeKit;

namespace Event_planner
{
    internal class User
    {
        public string username;
        private string password;
        private int age;
        public string email;
        public bool verified;
        public static List<User> users = new List<User>();
        public static User currentuser = null;

        public List<Event> events = new List<Event>();

        public User(string username,string email,string password,int age) 
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.age = age;
            this.verified = false;
            this.events = new List<Event>();
            LoadUserEvents();
        }   

        public User(string username,string password)
        {
            this.username = username;
            this.password = password;
            this.events = new List<Event>();
        }

        private void LoadUserEvents()
        {
            this.events = Event.LoadUserEvents(this.username);
        }
      
        public string Password
        {
            get { return password; }
        }

        public static bool SignUp(string username,string email,string password,int age)
        {
            foreach(User u1 in users)
            {
                if(u1.username == username)
                {
                    return false;
                }
            }

            if (!Methods.VerifyPassword(password))
            {
                return false;
            }

            if(age < 18)
            {
                return false;
            }

            string hashed = Methods.ComputeHash(password);
            User u = new User(username,email,hashed,age);
            users.Add(u);
            SaveUsers("Users.csv");
            return true;
        }

        public static void Logout(string username,string password)
        {
            string hashed = Methods.ComputeHash(password);
            for(int i = 0; i < users.Count; i++)
            {
                if (users[i].username == username && users[i].password == hashed)
                {
                    users.RemoveAt(i);
                    i = users.Count;
                }
            }
        }

        private string getcsvInfo()
        {
            string s = this.username + "," + this.email + "," + this.password + "," + this.age;
            return s;
        }

        public static void SaveUsers(string filename)
        {
            using(StreamWriter sw = new StreamWriter(filename))
            {
                for(int i = 0; i < users.Count; i++)
                {
                    sw.WriteLine(users[i].getcsvInfo());
                }
            }
        }

        public static void ImportUsers(string filename)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] info = line.Split(',');
                        int n;
                        bool valid = int.TryParse(info[3], out n);
                        User u = new User(info[0], info[1], info[2], n);
                        users.Add(u);
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
