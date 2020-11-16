using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int sum = program.SumsDigits(4959566);
            Console.WriteLine(sum);
        }

        public int SumsDigits(long number)
        {
            long answer = 0;
            long number_digit = number.ToString().ToCharArray().Length;

            for (int i = 0; i <= number_digit; i++)
            {
                answer += number % 10;
                number = Convert.ToInt32(number / 10);
            }
            if (answer > 9)
                return SumsDigits(answer);
            else if (answer <= 9)
                return (int)answer;
            return 0;
        }
    }
}
