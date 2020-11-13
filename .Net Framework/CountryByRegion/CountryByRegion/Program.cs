using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryByRegion
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\kevin.pineda\Desktop\C-sharp\.Net Framework\CountryByRegion\CountryByRegion\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            Dictionary<string,List<Country>> countries = reader.ReadAllCountries();
            foreach (string region in countries.Keys)
                Console.WriteLine(region);

            Console.Write("Which of the above regions do you want?");
            string chosenRegion = Console.ReadLine();

            if (countries.ContainsKey(chosenRegion))
            {
                foreach (Country country in countries[chosenRegion].Take(10))
                    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}:{country.Name}");
            }
            else
                Console.WriteLine("Tha<t is not a valid region");
         }  

    }
}

