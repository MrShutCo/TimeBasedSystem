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
            TS.AddUser("Tyler");
            User tyler = TS.GetUser("Tyler");
            TimeEvent t = new TimeEvent(TestEvent, 0, 80, 10);
            TS.GlobalUsers["Tyler"].AddEvent("Test Event", t);


            for (int i = 0; i < 100; i++) {
                TS.Update();
            }
            Console.ReadLine();
        }

        public static void TestEvent() {
            Console.WriteLine("Method has been invoked!");
        } 

    }
}
