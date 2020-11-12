ñusing System;
using System.Collections.Generic;
namespace List_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new List<double>() {1,2,2,2,3};
            var list2 = new List<double>() {2};
            list1.RemoveAll(item => item==list2[0]);
            list1.ToArray();
            list1.ForEach(Console.WriteLine);
        }
    }
}
