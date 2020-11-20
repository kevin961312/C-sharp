using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesandZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = binaryArrayToNumber(new int[] { 0, 0, 1, 1 });
            Console.WriteLine(result);
        }
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            var casa =BinaryArray.ToString();
            return Int32.Parse(casa);
            
        }
    }
}
