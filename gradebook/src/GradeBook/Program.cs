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

            var book = new Book("Kevin GradeBook");
            book.AddGrade(89.5);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.showStatistics();

        }
    }
}
