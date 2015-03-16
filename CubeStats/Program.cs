using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileHelpers;

namespace CubeStats
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            System.Console.WriteLine("Cube Stats Console");
            System.Console.WriteLine(args.Length);
            if (args.Length != 1)
                throw new System.ArgumentException("Expects 1 argument: File name to csv to import.");
            FileHelperEngine engine = new FileHelperEngine(typeof(Solve));

            Solve[] res = engine.ReadFile(args[0]) as Solve[];

            Console.WriteLine("Finished reading solves");

            foreach(Solve s in res)
            {
                Console.WriteLine("{0}: Time of: {1}", s.SolvedDateTime, s.SolvedTime);
                //DateTime dt = s.SolvedDateTime.toDateTime();
            }


            //fs = getCSV(args[0]);

            //StreamReader sr = new StreamReader(fs);
            //string header = sr.ReadLine();
            //Console.WriteLine(header);

            //string line;
            //int x = 0;
            //while ((line = sr.ReadLine()) != null)
            //{

            //    Console.WriteLine("{0}: {1}", x++, line);
            //}
            var _ = Console.ReadLine();
        }

        //static FileStream getCSV(string fname)
        //{
        //    FileStream fs = null;
        //    try
        //    {
        //        fs = new FileStream(fname, FileMode.Open);
        //        Console.WriteLine("Filestream opened");
        //    }
        //    catch(FileNotFoundException e)
        //    {
        //        Console.WriteLine("Error opening csv file {0}", e);
        //    }

        //    return fs;
        //}
    }
}
