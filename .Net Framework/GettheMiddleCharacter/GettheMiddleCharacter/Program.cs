using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettheMiddleCharacter
{
    class Program
    {
        static void Main()
        {
            var testWord = GetMiddle("test");
            Console.WriteLine(testWord);
        }
        public static string GetMiddle(string word)
        {
            var middle = (int) word.Length / 2;
            if (word.Length % 2 == 0) return word.Substring(middle-1,2);
            if(word.Length % 2 == 1) return word.Substring(middle,1);
            return word;
        }
    }
}
