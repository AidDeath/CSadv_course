using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLinqSelect.Classes
{
    static class CountryRepository
    {
        public static List<Country> GetCountries()
        {
            return new List<Country>()
            {
                new Country(){District = new District()
                {City = new City() 
                {Neighborhood = new Neighborhood()
                    {HouseNumber = 321, StreetName = "Wolf Street"}}}},
                new Country(){District = new District()
                {City = new City()
                {Neighborhood = new Neighborhood()
                    {HouseNumber = 942, StreetName = "Fox Street"}}}},
                new Country(){District = new District()
                {City = new City()
                {Neighborhood = new Neighborhood()
                    {HouseNumber = 666, StreetName = "Rabbit Street"}}}},
                new Country(){District = new District()
                {City = new City()
                {Neighborhood = new Neighborhood()
                    {HouseNumber = 81, StreetName = "Goat Street"}}}},
                new Country(){District = new District()
                {City = new City()
                {Neighborhood = new Neighborhood()
                    {HouseNumber = 1, StreetName = "Owl Street"}}}},
                new Country(){District = new District()
                {City = new City()
                {Neighborhood = new Neighborhood()
                    {HouseNumber = 781, StreetName = "Owl Street"}}}},
                new Country(){District = new District()
                {City = new City()
                {Neighborhood = new Neighborhood()
                    {HouseNumber = 22, StreetName = "Eagle Street"}}}},
                new Country(){District = new District()
                {City = new City()
                {Neighborhood = new Neighborhood()
                    {HouseNumber = 72, StreetName = "Lizard Street"}}}},

            };

        }
    }
}
