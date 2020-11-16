using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardMask
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            string number = program.CreditCard("54545412");
            Console.WriteLine(number);
        }
        public string CreditCard(string number_card)
        {
            if (number_card.Length <= 4)
            {
                return number_card;
            }
            else if (number_card.Length > 4)
            {
                var character = number_card.ToArray();
                for (int i = 0; i < number_card.Length - 4; i++) { character[i] = '#'; }
                return String.Concat(character);
            }
            return "";// por qué, es necesario ese return?
        }
    }
}
