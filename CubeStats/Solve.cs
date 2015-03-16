using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace CubeStats
{
    [DelimitedRecord(",")]
    [IgnoreFirst(1)]
    public class Solve
    {
        //[FieldConverter(ConverterKind.Date)]
        //public DateTime SolvedDate;
        //public string SolvedDateTime;
        [FieldConverter(typeof(CustomDateConverter))]
        public CustomDateTime SolvedDateTime;
        public string SolvedTime;
    }
}
