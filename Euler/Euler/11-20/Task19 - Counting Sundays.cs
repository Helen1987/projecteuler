using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

    /// <summary>
    /// You are given the following information, but you may prefer to do some research for yourself.
    /// 
    /// 1 Jan 1900 was a Monday.
    /// Thirty days has September,
    /// April, June and November.
    /// All the rest have thirty-one,
    /// Saving February alone,
    /// Which has twenty-eight, rain or shine.
    /// And on leap years, twenty-nine.
    /// A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
    /// How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
    /// </summary>
    public class Task19
    {
        private const int DAYS_IN_A_WEEK = 7;
        private const int DAYS_IN_A_YEAR = 365;

        private int[] DAYS = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int[] LEAP_DAYS = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private bool IsLeapYear(int year) => (year % 4 == 0) && (year % 400 != 0);

        private Day GetMonthStartDay(int days, Day previousMonthStartDay)
        {
            return (Day)(((int)previousMonthStartDay + days) % DAYS_IN_A_WEEK);
        }

        private int GetPreviousMonthIndex(int currentMonthIndex)
        {
            return currentMonthIndex == 0 ? 11 : currentMonthIndex - 1;
        }

        public int Run()
        {
            Day currentFirstDay = GetMonthStartDay(DAYS_IN_A_YEAR - DAYS[11], Day.Monday);
            int[] daysPerMonth = DAYS;
            int count = 0;
            for (int year = 1901; year <= 2000; ++year)
            {
                daysPerMonth = IsLeapYear(year) ? LEAP_DAYS : DAYS;
                for (int month = 0; month < daysPerMonth.Length; ++month)
                {
                    currentFirstDay = GetMonthStartDay(daysPerMonth[GetPreviousMonthIndex(month)], currentFirstDay);
                    if (currentFirstDay == Day.Sunday)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
