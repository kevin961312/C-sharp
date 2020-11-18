using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = x=>x*x;
            Func<int, int, int> add = (x, y) => x + y;
            Action<int> write = x => Console.WriteLine(x); 
            write(square(add(3,5)));
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" },
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex"}
            };
            //Console.WriteLine(developers.Count());
            //IEnumerator<Employee> enumerator = developers.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Name);
            //}
            var query = developers.Where(x => x.Name.Length == 5).OrderBy(x => x.Name);
            var query2 = from developer in developers where developer.Name.Length == 5
                         orderby developer.Name
                         select developer ;
            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }
         }
    }
}
