using ShopTest.Data.Interfaces;
using ShopTest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopTest.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla", 
                        shortDescription = "", 
                        longDescription = "", 
                        price = 45000, 
                        isfavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
