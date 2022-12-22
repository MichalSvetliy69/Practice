﻿using System.Linq;
using WebAppMVC1.interfaces;
using WebAppMVC1.Models;

namespace WebAppMVC1.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _сategoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> 
                { 
                    new Car {name = "Tesla", ShortDesc = "****", longDesc = "**********", img ="img_1", price = 4500, isFavorite = true, available = true, Category = _сategoryCars.AllCategories.First()},
                    new Car {name = "BMW", ShortDesc = "**$**", longDesc = "*****$*****", img ="img_2", price = 6500, isFavorite = true, available = true, Category = _сategoryCars.AllCategories.Last()}
                };
            }
        }
                
        public IEnumerable<Car>? GetFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
