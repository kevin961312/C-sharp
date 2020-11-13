using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheParityOutlier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 2, 4, 0, 100, 4, 11, 2602, 36 };
                int count_odd = 0;
                var index_even = 0;
                var index_odd = 0;
                int count_even = 0;
                for (int i=0; i<integers.Count();i++)
                {
                    if (integers[i] % 2 == 0) { count_even++; index_even = i; }
                    else { count_odd++; index_odd = i; }
                }
                if (count_odd == 1) { Console.WriteLine($"{integers[index_odd]}"); }
                else if (count_even == 1) { Console.WriteLine($"{integers[index_even]}"); }
        }
    }
}
