using System;
using System.Collections.Generic;
using System.Text;

namespace Turntabl
{
    class Timer : IDisposable
    {
        private string message;
        DateTime startTime;
        DateTime stopTime;
        public Timer(string message)
        {
            this.message = message;
            startTime = DateTime.Now;
        }

        public void Dispose()
        {
            stopTime = DateTime.Now;
            TimeSpan ts = stopTime - startTime;
            Console.Error.WriteLine("Start time: "   + startTime);
            Console.Error.WriteLine("Elapsed time: " + ts.TotalMilliseconds);
        }
    }
}
