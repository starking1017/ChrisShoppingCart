using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace WinOnRadio.Utilities
{

    public static class DateTimeUtils
    {
        /// <summary> 
        /// <para>Truncates a DateTime to a specified resolution.</para> 
        /// <para>A convenient source for resolution is TimeSpan.TicksPerXXXX constants.</para> 
        /// </summary> 
        /// <param name="date">The DateTime object to truncate</param> 
        /// <param name="resolution">e.g. to round to nearest second, TimeSpan.TicksPerSecond</param> 
        /// <returns>Truncated DateTime</returns> 
        //public static DateTime Truncate(this DateTime date, long resolution)
        //{

        //  return new DateTime(date.Ticks - (date.Ticks % resolution), date.Kind);
        //}

        public static DateTime Truncate(this DateTime pDateTime, TimeSpan pTimeSpan)
        {
            return new DateTime(pDateTime.Ticks - (pDateTime.Ticks % pTimeSpan.Ticks), pDateTime.Kind);
        }

        /// <summary>
        /// Common DateTime Methods.
        /// </summary>
        /// 
        public enum Quarter
        {
            First = 1,
            Second = 2,
            Third = 3,
            Fourth = 4
        }

        public enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        #region Year
        public static DateTime GetStartOfYear(this DateTime pDateTime)
        {
            return new DateTime(pDateTime.Year, 1, 1, 0, 0, 0, pDateTime.Kind);
        }
        public static DateTime GetEndOfYear(this DateTime pDateTime)
        {
            return new DateTime(pDateTime.Year, 12, 31, 23, 59, 59, pDateTime.Kind);
        }

        public static DateTime GetStartOfYear(int Year)
        {
            return new DateTime(Year, 1, 1, 0, 0, 0, 0);
        }

        public static DateTime GetEndOfYear(int Year)
        {
            return new DateTime(Year, 12, DateTime.DaysInMonth(Year, 12), 23, 59, 59, 999);
        }

        public static DateTime GetStartOfLastYear(this DateTime pDateTime)
        {
            return pDateTime.GetStartOfYear().AddYears(-1);
        }

        public static DateTime GetStartOfLastYear()
        {
            return GetStartOfYear(DateTime.Now.Year - 1);
        }

        public static DateTime GetEndOfLastYear()
        {
            return GetEndOfYear(DateTime.Now.Year - 1);
        }

        public static DateTime GetStartOfCurrentYear()
        {
            return GetStartOfYear(DateTime.Now.Year);
        }

        public static DateTime GetEndOfCurrentYear()
        {
            return GetEndOfYear(DateTime.Now.Year);
        }
        #endregion

        #region Quarter

        public static Quarter GetQuarter(this DateTime pDateTime)
        {
            return GetQuarter((Month)Enum.Parse(typeof(Month), pDateTime.Month.ToString(), true));
        }

        public static Quarter GetQuarter(Month month)
        {
            if (month <= Month.March)   // 1st Quarter = January 1 to March 31
                return Quarter.First;
            else if ((month >= Month.April) && (month <= Month.June)) // 2nd Quarter = April 1 to June 30
                return Quarter.Second;
            else if ((month >= Month.July) && (month <= Month.September)) // 3rd Quarter = July 1 to September 30
                return Quarter.Third;
            else // 4th Quarter = October 1 to December 31
                return Quarter.Fourth;
        }

        public static DateTime GetStartOfQuarter(this DateTime pDateTime)
        {
            return GetStartOfQuarter(pDateTime.Year, pDateTime.GetQuarter());
        }

        public static DateTime GetStartOfQuarter(int Year, Quarter Qtr)
        {
            if (Qtr == Quarter.First)   // 1st Quarter = January 1 to March 31
                return new DateTime(Year, 1, 1, 0, 0, 0, 0);
            else if (Qtr == Quarter.Second) // 2nd Quarter = April 1 to June 30
                return new DateTime(Year, 4, 1, 0, 0, 0, 0);
            else if (Qtr == Quarter.Third) // 3rd Quarter = July 1 to September 30
                return new DateTime(Year, 7, 1, 0, 0, 0, 0);
            else // 4th Quarter = October 1 to December 31
                return new DateTime(Year, 10, 1, 0, 0, 0, 0);
        }

        public static DateTime GetEndOfQuarter(this DateTime pDateTime)
        {
            return GetEndOfQuarter(pDateTime.Year, pDateTime.GetQuarter());
        }

        public static DateTime GetEndOfQuarter(int Year, Quarter Qtr)
        {
            if (Qtr == Quarter.First)   // 1st Quarter = January 1 to March 31
                return new DateTime(Year, 3, DateTime.DaysInMonth(Year, 3), 23, 59, 59, 999);
            else if (Qtr == Quarter.Second) // 2nd Quarter = April 1 to June 30
                return new DateTime(Year, 6, DateTime.DaysInMonth(Year, 6), 23, 59, 59, 999);
            else if (Qtr == Quarter.Third) // 3rd Quarter = July 1 to September 30
                return new DateTime(Year, 9, DateTime.DaysInMonth(Year, 9), 23, 59, 59, 999);
            else // 4th Quarter = October 1 to December 31
                return new DateTime(Year, 12, DateTime.DaysInMonth(Year, 12), 23, 59, 59, 999);
        }



        public static DateTime GetEndOfLastQuarter(this DateTime pDateTime)
        {
            if (pDateTime.Month <= (int)Month.March) //go to last quarter of previous year
                return GetEndOfQuarter(pDateTime.Year - 1, GetQuarter(Month.December));
            else //return last quarter of current year
                return pDateTime.GetEndOfQuarter();
        }

        public static DateTime GetStartOfLastQuarter(this DateTime pDateTime)
        {
            if (pDateTime.Month <= 3) //go to last quarter of previous year
                return GetStartOfQuarter(pDateTime.Year - 1, GetQuarter(Month.December));
            else //return last quarter of current year
                return pDateTime.GetStartOfQuarter().AddDays(-1);
        }

        public static DateTime GetStartOfCurrentQuarter()
        {
            DateTime CurrentTimeStamp = DateTime.Now;
            return GetStartOfQuarter(CurrentTimeStamp.Year, CurrentTimeStamp.GetQuarter());
        }

        public static DateTime GetEndOfCurrentQuarter()
        {
            DateTime CurrentTimeStamp = DateTime.Now;
            return GetEndOfQuarter(CurrentTimeStamp.Year, CurrentTimeStamp.GetQuarter());
        }
        #endregion

        #region Weeks
        public static DateTime GetStartOfLastWeek(this DateTime pDateTime)
        {
            DateTime currentTimeStamp = DateTime.Now;
            int DaysToSubtract = (int)currentTimeStamp.DayOfWeek + 7;
            DateTime dt = DateTime.Now.Subtract(System.TimeSpan.FromDays(DaysToSubtract));
            return new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
        }

        public static DateTime GetEndOfLastWeek(this DateTime pDateTime)
        {
            DateTime dt = pDateTime.GetStartOfLastWeek().AddDays(6);
            return new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59, 999);
        }

        public static DateTime GetStartOfCurrentWeek(this DateTime pDateTime)
        {
            int DaysToSubtract = (int)pDateTime.DayOfWeek;
            DateTime dt = pDateTime.Subtract(System.TimeSpan.FromDays(DaysToSubtract));
            return new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
        }

        public static DateTime GetEndOfCurrentWeek(this DateTime pDateTime)
        {
            DateTime dt = pDateTime.GetStartOfCurrentWeek().AddDays(6);
            return new DateTime(dt.Year, dt.Month, dt.Day, 23, 59, 59, 999);
        }
        #endregion

        #region Months

        public static DateTime GetStartOfMonth(this DateTime pDateTime)
        {
            return new DateTime(pDateTime.Year, pDateTime.Month, 1);
        }

        public static DateTime GetStartOfMonth(int Month, int Year)
        {
            return new DateTime(Year, Month, 1, 0, 0, 0, 0);
        }


        public static DateTime GetEndOfMonth(this DateTime pDateTime)
        {
            return new DateTime(pDateTime.Year, pDateTime.Month, DateTime.DaysInMonth(pDateTime.Year, pDateTime.Month), 23, 59, 59, pDateTime.Kind);
        }
        public static DateTime GetEndOfMonth(int Month, int Year)
        {
            return new DateTime(Year, Month, DateTime.DaysInMonth(Year, Month), 23, 59, 59, 999);
        }

        public static DateTime GetStartOfLastMonth(this DateTime pDateTime)
        {
            return pDateTime.GetStartOfMonth().AddMonths(-1);
        }

        public static DateTime GetStartOfLastMonth()
        {
            if (DateTime.Now.Month == 1)
                return GetStartOfMonth(12, DateTime.Now.Year - 1);
            else
                return GetStartOfMonth(DateTime.Now.Month - 1, DateTime.Now.Year);
        }

        public static DateTime GetEndOfLastMonth(this DateTime pDateTime)
        {
            return pDateTime.GetStartOfMonth().AddDays(-1);
        }

        public static DateTime GetEndOfLastMonth()
        {
            if (DateTime.Now.Month == 1)
                return GetEndOfMonth(12, DateTime.Now.Year - 1);
            else
                return GetEndOfMonth(DateTime.Now.Month - 1, DateTime.Now.Year);
        }

        public static DateTime GetStartOfCurrentMonth()
        {
            return GetStartOfMonth(DateTime.Now.Month, DateTime.Now.Year);
        }

        public static DateTime GetEndOfCurrentMonth()
        {
            return GetEndOfMonth(DateTime.Now.Month, DateTime.Now.Year);
        }
        #endregion

        #region Days

        public static DateTime TruncateTime(this DateTime pDateTime)
        {
            return pDateTime.GetStartOfDay();
        }

        public static DateTime GetStartOfDay(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, 0);
        }

        public static DateTime GetEndOfDay(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, 23, 59, 59, 999);
        }

        #endregion
    }
}


