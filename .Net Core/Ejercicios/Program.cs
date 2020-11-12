using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            var number_one = 3.4157;
            var number_two = 8.9877545;
            Console.WriteLine(number_one+number_two);
            // variables tipadas, y numeros en este caso una variable de punto flotante
            var number_one1 = 3.1548;
            var number_two1 = 798.23236;
            var result = number_one1+number_two1;
            Console.WriteLine(result);
            // Generar matriz de numeros en C#
            var numbers = new double[3] {3.1, 3.6, 3.3};
            var results = 0.0;
            foreach (var number in numbers)
            {
                results += number;
                Console.WriteLine(results);
            }
        }
    }
}
