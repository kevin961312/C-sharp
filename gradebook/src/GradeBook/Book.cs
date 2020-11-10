using System;
using System.Collections.Generic;

namespace  GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        
        public void showStatistics()
        {
            var result = 0.0;
            int len_grades = grades.Count;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highGrade = Math.Max(number, highGrade);
                result += number;
            }
            //Console.WriteLine(result/len_nbs);
            Console.WriteLine($"The lowest grade is: {lowGrade}");
            Console.WriteLine($"The highest grade is: {highGrade}");
            Console.WriteLine($"The average grade is: {result/len_grades:N3}");
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        private List<double> grades;
        private string name;

    }
}