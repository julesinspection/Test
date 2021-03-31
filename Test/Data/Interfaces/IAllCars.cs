﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Test.Data.Models;

namespace Test.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getObjectCar(int carid);
    }
}
