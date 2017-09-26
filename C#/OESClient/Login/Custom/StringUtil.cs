using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client.Custom
{
    public class StringUtil
    {
        /// <summary>
        /// Compare time max
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public static bool CompareMax(DateTime date1, DateTime date2)
        {
            DateTime time1 = Convert.ToDateTime(date1.ToString("yyyy-MM-dd HH:mm:ss"));
            DateTime time2 = Convert.ToDateTime(date2.ToString("yyyy-MM-dd HH:mm:ss"));

            return DateTime.Compare(time1, time2) >= 0 ? true : false;
        }

        /// <summary>
        /// Time difference
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        public static int TimeDifference(DateTime date1, DateTime date2)
        {
            TimeSpan ts1 = new TimeSpan(date1.Ticks);
            TimeSpan ts2 = new TimeSpan(date2.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();

            return (int)ts.Days * 24 * 60 * 60 + (int)ts.Hours * 60 * 60 + (int)ts.Minutes * 60 + (int)ts.Seconds; ;
        }

        /// <summary>
        /// String IsEmpty
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsEmpty(string str)
        {
            return str == string.Empty || str == "";
        }
    }
}