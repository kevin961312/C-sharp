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
            reader.RemoveCommaCountries(countries);

            Country lilliput = new Country("Lilliput", "LIL", "Somewhere", 2_000_000);

            int lilliputIndex = countries.FindIndex(x=>x.Population<2_000_000);

            countries.Insert(lilliputIndex, lilliput);

            countries.RemoveAt(lilliputIndex);

            Console.Write("Enter no. of countries to display>");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if (!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type in a +ve integer. Exiting");
                return;
            }

            //int maxToDisplay = Math.Min(userInput, countries.Count);
            int maxToDisplay = userInput;
            //foreach (Country country in countries)
            for (int i =0; i< countries.Count; i++)
            {
                if (i > 0 && (i % maxToDisplay == 0))
                {
                    Console.WriteLine("hit return to continue anything else to quit>");
                    if (Console.ReadLine() != "")
                        break;
                }
                Country country = countries[i];
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            if (userInput > countries.Count)
            {
                Console.WriteLine($"There aren't {userInput} countries, just {countries.Count}");
            }

            /* Dictionary<string, Country> countries = reader.ReadAllCountries();

             Console.WriteLine("Which country code do you want to look up? ");
             string userInput = Console.ReadLine();

             bool gotCountry = countries.TryGetValue(userInput, out Country country);
             if (!gotCountry)
             {
                 Console.WriteLine($"Sorry, {userInput}");
             }
             else 
             {
                 Console.WriteLine($"{country.Name} has population {PopulationFormatter.FormatPopulation(country.Population)}");
             }*/

        }
    }
}
