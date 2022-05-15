using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground
{
    class Program
    {
        static void Main()
        {
            var days = Weekdays.Monday | Weekdays.Tuesday;
            var workdays = Weekdays.Workdays;
            //bool isMondayInDays = (days & Weekdays.Monday) == Weekdays.Monday;
            //these are the same...
            bool isMondayInDays = days.HasFlag(Weekdays.Monday);
            bool isTuesdayInWorkDays = workdays.HasFlag(Weekdays.Tuesday);
            workdays ^= Weekdays.Tuesday;
            isTuesdayInWorkDays = workdays.HasFlag(Weekdays.Tuesday);

        }

    }

    [Flags]
    public enum Weekdays
    {
        //enum deff is int32
        //None  = 0,
        //Monday = 1,
        //Tuesday = 2,
        //Wednesday = 4,
        //Thursday = 8,
        //Friday = 16,
        //Saturday = 32,
        //Sunday = 64,
        //Workdays = Monday | Tuesday | Wednesday | Thursday | Friday,
        //Holidays = Saturday | Sunday,
        //All = Workdays | Holidays

        None = 0,
        Monday = 1 << 0,
        Tuesday = 1 << 1,
        Wednesday = 1 << 2,
        Thursday = 1 << 3,
        Friday = 1 << 4,
        Saturday = 1 << 5,
        Sunday = 1 << 6,
        Workdays = Monday | Tuesday | Wednesday | Thursday | Friday,
        Holidays = Saturday | Sunday,
        All = Workdays | Holidays

    }

}