using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeBasedSystem {
    public class Timer {

        public int Time
        {
            get;
            protected set;
        }

        public int TimeStep
        {
            get;
            protected set;
        }

        public Timer(int timeStep = 1) {
            Time = 0;
            TimeStep = timeStep;
        }

        public void Update() {
            Time += TimeStep;
            Console.WriteLine("The current time is: " + Time);
        }

    }
}
