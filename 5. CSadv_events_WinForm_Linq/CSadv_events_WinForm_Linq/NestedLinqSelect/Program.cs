using System;
using System.Linq;
using NestedLinqSelect.Classes;

namespace NestedLinqSelect
{
    class Program
    {
        static void Main(string[] args)
        {
           var streetNames = CountryRepository.GetCountries().Select(country => country
                .District
                .City
                .Neighborhood
                .StreetName)
                .Distinct();

            //var streetNamesToo = CountryRepository.GetCountries()
            //    .Select(country => new {country.District.City.Neighborhood.StreetName})
            //    .Distinct();

            foreach (var streetName in streetNames)
            {
                Console.WriteLine(streetName);
            }
        }
    }
}
