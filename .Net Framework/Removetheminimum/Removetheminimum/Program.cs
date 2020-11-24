using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removetheminimum
{
    class Program
    {
        static void Main(string[] args)
        {
            var listminium = RemoveSmallest(new List<int> { 5, 3, 2, 1, 4,1 });
            foreach (var item in listminium)
            {
                Console.WriteLine(item);
            }
        }
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            int minimun = numbers.Min(x => x);
            numbers.Remove(minimun);
            return numbers;
        }
    }
}
