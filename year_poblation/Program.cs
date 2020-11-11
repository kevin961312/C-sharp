using System;

namespace year_poblation
{
    class Program
    {
        static void Main(string[] args)
        {
            var p_init = 1000;
            var p_finis = 1200;
            double percent=2.0;
            int aug=50;
            int year=1;
            while(p_init < p_finis)
            {
                year +=1;
                percent = Math.Floor(p_init*percent/100);
                p_init =  p_init + percent+aug;
            }
            Console.WriteLine(year);
        }
    }
}
