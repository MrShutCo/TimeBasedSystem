using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBasedSystem
{
    public class TimeSystem
    {

        Timer Time;
        public Dictionary<string, User> GlobalUsers;

        public TimeSystem() {
            Time = new Timer();
            GlobalUsers = new Dictionary<string, User>();
        }

        public void Update() {
            Time.Update();
            foreach(var value in GlobalUsers.Values) {
                foreach(var value2 in value.userEvents.Values) {
                    value2.Update(Time.TimeStep);
                }
            }
        }

        public User GetUser(string name) {
            return GlobalUsers[name];
        }

        public void AddUser(string name) {
            GlobalUsers.Add(name, new User());
        }

    }
}
