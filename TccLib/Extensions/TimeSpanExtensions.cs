using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TccLib.Extensions
{
    public static class TimeSpanExtensions
    {
        public static string ToRelativePastTimeString(this TimeSpan timeSpan)
        {
            const int lcSecondsInMinute = 60;
            const int lcMinutesInHour = 60;
            const int lcHoursInDay = 24;
            const int lcDaysInMonth = 30;
            const int lcMonthsInYear = 12;
            const int lcDaysInYear = 365;

            var lDeltaSeconds = Math.Abs(timeSpan.TotalSeconds);

            if (lDeltaSeconds < 0)
            {
                return "not yet";
            }
            else if (lDeltaSeconds < 1 * lcSecondsInMinute)
            {
                return (timeSpan.Seconds == 1) ? "one second ago" : timeSpan.Seconds + " seconds ago";
            }
            else if (lDeltaSeconds < 2 * lcSecondsInMinute)
            {
                return "a minute ago";
            }
            else if (lDeltaSeconds < 45 * lcSecondsInMinute)
            {
                return timeSpan.Minutes + " minutes ago";
            }
            else if (lDeltaSeconds < 90 * lcSecondsInMinute)
            {
                return "an hour ago";
            }
            else if (lDeltaSeconds < lcHoursInDay * lcMinutesInHour * lcSecondsInMinute)
            {
                return timeSpan.Hours + " hours ago";
            }
            else if (lDeltaSeconds < 2 * lcHoursInDay * lcMinutesInHour * lcSecondsInMinute)
            {
                return "yesterday";
            }
            else if (lDeltaSeconds < lcDaysInMonth * lcHoursInDay * lcMinutesInHour * lcSecondsInMinute)
            {
                return timeSpan.Days + " days ago";
            }
            else if (lDeltaSeconds < lcMonthsInYear * lcDaysInMonth * lcHoursInDay * lcMinutesInHour * lcSecondsInMinute)
            {
                int lMonths = Convert.ToInt32(Math.Floor((double)timeSpan.Days / lcDaysInMonth));
                return (lMonths <= 1) ? "one month ago" : lMonths + " months ago";
            }
            else
            {
                int lYears = Convert.ToInt32(Math.Floor((double)timeSpan.Days / lcDaysInYear));
                return (lYears <= 1) ? "one year ago" : lYears + " years ago";
            }
        }
    }
}
