using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularDemostration
{
    class Program
    {
        static void Main(string[] args)
        {
            var patterns = new List<string> { "a*b", "a+b", "a?b" };
            var inputs  =  new List <string> { "a", "b", "ab", "aab", "abb"};
            patterns.ForEach(pattern =>
            {
                Console.WriteLine("Regular expression: {0}", pattern);
                var regex = new Regex(pattern);
                inputs.ForEach(input =>
                {
                    Console.WriteLine("\tInput pattern: {0}", input);
                    var results = regex.Matches(input);
                    if(results.Count <= 0)
                        Console.WriteLine("\t\tNo Marches Found");
                    foreach(Match result in results)
                        Console.WriteLine("\t\t Match found at index {0}. Length: {1}.", result.Index,result.Length);
                });
            });
            Console.ReadKey();
        }
    }
}
