using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Models;

namespace Test.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) //передаем данные в базовый конструктор
        {

        }
        public DbSet<Car> Car {get; set;} //список принимающий молели
        public DbSet<Category> Category { get; set; } //список принимающий молели

        public DbSet<ShopCartitem> ShopCartitem { get; set; }
    }
}
