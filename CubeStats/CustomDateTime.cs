using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace CubeStats
{
    public class CustomDateTime
    {
        //public char MonthName;
        public char MonthName;
        public int DayofMonth;
        public int Year;
        public string Time12HR;
        public string Meridian;

        public override string ToString()
        {
            return MonthName + " " + DayofMonth + " " + Year + " " + Time12HR + " " + Meridian;
        }

        //public DateTime toDateTime()
        //{
        //    //return DateTime.Parse();
        //}
    }

    
}
