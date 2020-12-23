using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using static OdeToFood.Core.Restaurant;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        public class InMemoryRestaurantData : IRestaurantData
        {
            List<Restaurant> restaurants;
            public InMemoryRestaurantData()
            {
                restaurants = new List<Restaurant>()
                {
                    new Restaurant { Id = 1, Name = "Nirvana", Location = "Lublin", Cuisine = CuisineType.Italian},
                    new Restaurant { Id = 2, Name = "Chinkalia", Location = "Warszawa", Cuisine = CuisineType.Indian},
                    new Restaurant { Id = 3, Name = "Mexicana", Location = "Katowice", Cuisine = CuisineType.Mexican}
                };
            }
            public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
            {
                return from r in restaurants
                       where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                       orderby r.Name
                       select r;
                
            }
        }
    }
}
