using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            var lists = FilterIntegers(new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 }));
            foreach (var list in lists)
                Console.WriteLine(list);
        }
        public static IEnumerable<int> FilterIntegers(List<object> ListStringAndInteger)
        {
            return ListStringAndInteger.OfType<int>();
        }

    }
}
