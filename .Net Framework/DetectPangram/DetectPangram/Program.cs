using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectPangram
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var result = program.IsPangram("casa!");
            Console.WriteLine(result);
        }
        public bool IsPangram(string str)
        {
            var result = str.ToLower().Where(x => Char.IsLetter(x)).Distinct().Count()==26;
            return result;
        }
    }
}
