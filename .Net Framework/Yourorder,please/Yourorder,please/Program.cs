using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yourorder_please
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "is2 Thi1s T4est 3a";
            string[] array_words = words.Split(' ');
            IEnumerable<int> numbers = Enumerable.Range(0, array_words.Count());
            string[] array_union = new string[array_words.Count()];
            
            foreach (var j in numbers)
            {
                for (int i=0; i<array_union.Count();i++)
                {
                    if (array_words[i].Contains((j+1).ToString())) 
                    {
                        array_union[j]=array_words[i];
                    }
                }
            }
            string union = string.Join(" ", array_union);
            Console.WriteLine(union);
        }
    }
}
