using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\kevin.pineda\Desktop\C-sharp\.Net Framework\AllCountries\AllCountries\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();

            var filteredCountries = countries.Take(20).Where(x => !x.Name.Contains(','));
            var filteredCountries2 = from country in countries 
                                       where !country.Name.Contains(',') 
                                       select country;


            foreach (Country country in filteredCountries2)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
         }
    }
}

