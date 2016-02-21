using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBasedSystem;

namespace TBS_Testing {
    public class Program {
        static void Main(string[] args) {
            TimeSystem TS = new TimeSystem();

            for (int i = 0; i < 100; i++) {
                if (i == 80) {
                    TS.AddEvent("Test Event", i, 10);
                }
                TS.Update();
            }
            Console.ReadLine();
        }
    }
}
