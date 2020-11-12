using System;
using System.Linq;

namespace Numeros_descendentes
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 121;
            var listN = result.ToString().Select(c => int.Parse(c.ToString())).ToList();
            listN.Sort();
            listN.Reverse();
            var resultC =String.Join("",listN);
            int resultN = Int32.Parse(resultC);
            System.Console.WriteLine(resultN);
        }
    }
}
