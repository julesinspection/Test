using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Models;

namespace Test.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            
            

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla",
                        shortDesc = "Норм",
                        longDesc = "Нормас",
                        img = "/Img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
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
                        Category = Categories["Классические автомобили"]
                    });
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories {
            get {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category{ categoryName = "Электромобили", desc = "Современный вид транспорта"},
                        new Category{ categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }


    }
}
