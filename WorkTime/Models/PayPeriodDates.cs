using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkTime.Models
{
    public class PayPeriodDates
    {
        public DayOfWeek PayDay { get;  set; } //day of week employee is paid
        public string PayPeriod { get; set; } //periodicity of pay
        public DayOfWeek FirstDayOfPeriod { get; set; }


        public List<string> DatesForWeek()
        {
            DayOfWeek day = DateTime.Now.DayOfWeek;
            return new List<string>();
        }
    }
}