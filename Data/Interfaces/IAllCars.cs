﻿using ShopTest.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopTest.Data.Interfaces
{
    interface IAllCars
    {
        IEnumerable<Car> Cars {get; }
        IEnumerable<Car> getFavCars { set; get; }
        Car getObjectCar(int carId);
    }
}
