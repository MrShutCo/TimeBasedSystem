using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBasedSystem {

    public delegate void Event();

    public class TimeEvent {

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

        public bool IsActive() {
            if (currTime >= StartTime && currTime <= EndTime) {
                Event.Invoke();
                return true;
            }
            return false;
        }

        public event Event Event;

        public TimeEvent(Event eventNow, int currentTime, int start, int dur) {
            StartTime = start;
            currTime = currentTime;
            duration = dur;
            Event = eventNow;
        }

        public void Update(int time) {
            currTime += time;
            if (IsActive()) {
                //Just to call it
            }
        }
    }
}
