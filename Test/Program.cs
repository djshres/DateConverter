using DateConversion;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Converter.EngToNep(DateTime.Now));
            Console.WriteLine(Converter.NepToEng(new NepDate {
                Year=2053,
                Month=6,
                Day=28
            }));
        }
    }
}
