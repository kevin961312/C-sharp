using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteNumberinExpandedForm
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = ExpandedForm(150665);
            Console.WriteLine(result);
        }
        public static string ExpandedForm(long num)
        {
            var digit = num.ToString().ToCharArray();
            var expandedForm = "";
            for (int i = 0; i < digit.Length; i++)
            {
                if (digit[i] != '0')
                {
                    var convert = (int)Char.GetNumericValue(digit[i]);
                    expandedForm += $"{convert * (long)Math.Pow(10, digit.Length - i - 1)} ";
                    
                }
            }
            return expandedForm.Trim().Replace(" ", " + ");
        }
    }
}
