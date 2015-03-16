using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace CubeStats
{
    public class CustomDateConverter: ConverterBase
    {
        public override object StringToField(string from)
        {
            string[] splited = from.Split(' ');
            CustomDateTime res = new CustomDateTime();
            res.MonthName = splited[0].Trim().ToCharArray()[0];
            res.DayofMonth = int.Parse(splited[1].Trim());
            res.Year = int.Parse(splited[2]);
            res.Time12HR = splited[3];
            res.Meridian = splited[4];

            return res;
        }

    }
}
