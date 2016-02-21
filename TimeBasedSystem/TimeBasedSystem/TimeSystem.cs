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
        List<Event> EventList;

        public TimeSystem() {
            Time = new Timer();
            EventList = new List<Event>();
        }

        public void Update() {
            Time.Update();
            for (int i = 0; i < EventList.Count; i++) {
                EventList[i].Update(Time.TimeStep);
                if (EventList[i].HasEnded()) {
                    EventList.RemoveAt(i);
                }
                
            }
        }

        public void AddEvent(string name, int start, int duration) {
            Console.WriteLine("Event created at time: {0}", start);
            EventList.Add(new Event(name, start, duration));
        }

    }
}
