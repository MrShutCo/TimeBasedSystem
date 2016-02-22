using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBasedSystem {
    public class User {

        public Dictionary<string, TimeEvent> userEvents;

        public User() {
            userEvents = new Dictionary<string, TimeEvent>();
        }

        public void AddEvent(string eventname, TimeEvent e) {
            userEvents.Add(eventname, e);
        } 

        public TimeEvent FindEvent(string eventName) {
            return userEvents[eventName];
        }

    }
}
