using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;

namespace learning_Timers {
    class Program {
        static void Main(string[] args)
        {
            int numberRemaining = 5;
            Timer timer = new Timer(500);

            ElapsedEventHandler loopedEvent = (x, y) =>
            {
                Console.WriteLine(numberRemaining);

                numberRemaining--;
                if (numberRemaining <= 0)
                {
                    timer.Stop();
                }
            };
            timer.Elapsed += loopedEvent;
            timer.Start();

            Console.ReadKey();
        }
    }
}
