using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Time
{
    public class Timer
    {
        /// <summary>
        /// pro-ty
        /// </summary>
        public int Time{ get; set; }
        /// <summary>
        /// c-or
        /// </summary>
        /// <param name="sec">seconds</param>
        public  Timer(int sec)
        {
            if (sec <= 0) throw new ArgumentException();
            Time = sec;
        }
        /// <summary>
        /// delegate time
        /// </summary>
        /// <param name="time">time in seconds</param>
        public delegate void TimerCount(int time);
        /// <summary>
        /// event, which work after time is finished and return this time.
        /// </summary>
        public event TimerCount onTime;
        /// <summary>
        /// invoke event and return time
        /// </summary>
        public void StartTimer()
        {
            Thread.Sleep(1000 * Time);
            onTime(Time);
        }
    }
}
