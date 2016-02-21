using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBasedSystem {
    public class Event {

        public int StartTime
        {
            get;
        }

        public string EventName
        {
            get;
            protected set;
        }

        public int EndTime
        {
            get { return StartTime + duration; }
            set { }
        }

        int duration;
        int currTime;

        public Event(string name, int start, int dur) {
            StartTime = start;
            duration = dur;
            currTime = start;
            EventName = name;
        }

        public void Update(int time) {
            if (!HasEnded()) {
                currTime += time;
            }
        }

        public bool HasEnded()
        {
            if (currTime >= EndTime) {
                Console.WriteLine("Event {0} has ended", EventName);
                return true;
            }
            return false;
        }

    }
}
