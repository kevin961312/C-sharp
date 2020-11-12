using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            IBook book = new DiskBook("Kevin GradeBook");
            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);
            
            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is: {stats.Low}");
            Console.WriteLine($"The highest grade is: {stats.High}");
            Console.WriteLine($"The average grade is: {stats.Average:N3}");
            Console.WriteLine($"The average grade is: {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
        
            while (true)
            {
                Console.WriteLine("Enter a grade or 'q'to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.Write(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.Write(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }
        }

        static void OnGradeAdded(object sender , EventArgs e)
        {
            Console.WriteLine("A grade was added");
        }
    }
}
