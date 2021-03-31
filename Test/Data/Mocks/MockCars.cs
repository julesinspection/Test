using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Test.Data.Interfaces;
using Test.Data.Models;

namespace Test.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "Норм",
                        longDesc = "Нормас",
                        img = "/Img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name = "Mersedes-Benz G-class",
                        shortDesc = "G",
                        longDesc = "Очень крутой",
                        img = "/Img/G-CLASS_1.png",
                        price = 60000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mersedes-Benz GLC-class",
                        shortDesc = "GLC",
                        longDesc = "Очень крутой",
                        img = "/Img/GLC-CLASS_1.png",
                        price = 50000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mersedes-Benz E-class",
                        shortDesc = "E-класс",
                        longDesc = "Очень крутой",
                        img = "/Img/E-CLASS_1.png",
                        price = 60000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mersedes-Benz GLE-class",
                        shortDesc = "GLE",
                        longDesc = "Очень крутой",
                        img = "/Img/GLE-CLASS_1.png",
                        price = 60000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mersedes-Benz CLS-class",
                        shortDesc = "CLS",
                        longDesc = "Очень крутой",
                        img = "/Img/CLS-CLASS_1.png",
                        price = 60000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name = "Mersedes-Benz GLS-class",
                        shortDesc = "GLS",
                        longDesc = "Очень крутой",
                        img = "/Img/GLS-CLASS_1.png",
                        price = 50000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    }

                };
            } 
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}
