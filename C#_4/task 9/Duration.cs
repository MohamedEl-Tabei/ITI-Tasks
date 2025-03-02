using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    internal class Duration
    {
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }
        public int TotalSeconds {  get; }

        public Duration(int hours, int minutes, int seconds)
        {
            TotalSeconds = seconds + hours * 3600 + minutes * 60;
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            TotalSeconds = totalSeconds;
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Duration)
            {
                Duration objR = (Duration)obj;
                return Hours == objR.Hours && Minutes == objR.Minutes && Seconds == objR.Seconds;
            }
            return false;
        }


        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds + d2.TotalSeconds);
        }
        public static Duration operator +(Duration d, int num)
        {
            return new Duration(d.TotalSeconds + num);
        }
        public static Duration operator +(int num, Duration d)
        {
            return new Duration(num + d.TotalSeconds);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds + 60);
        }

        public static Duration operator --(Duration d)
        {
            return new Duration(d.TotalSeconds - 60);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds > d2.TotalSeconds;
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds < d2.TotalSeconds;
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds >= d2.TotalSeconds;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds <= d2.TotalSeconds;
        }
        public static bool operator true(Duration d)
        {
            return d.Hours != 0 || d.Minutes != 0 || d.Seconds != 0;
        }
        public static bool operator false(Duration d)
        {
            return d.Hours == 0 && d.Minutes == 0 && d.Seconds == 0;
        }
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime().AddSeconds(d.TotalSeconds);
        }

       
    }
}
