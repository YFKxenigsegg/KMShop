using KMShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KMShop.Data
{
    public class DBObjects
    {
        public static void Initial(CarDbContext context)
        {
            if (!context.Categories.Any())
                context.Categories.AddRange(Categories.Select(c => c.Value));

            if (!context.Cars.Any())
            {
                context.AddRange(
                    new Car
                    {
                        CarName = "BMW",
                        CarModel = "M5",
                        YearOfIssue = 2000,
                        CarCost = 800,
                        Category = Categories["Седан"]
                    },
                    new Car
                    {
                        CarName = "BMW",
                        CarModel = "M4",
                        YearOfIssue = 2001,
                        CarCost = 700,
                        Category = Categories["Купе"]
                    },
                    new Car
                    {
                        CarName = "BMW",
                        CarModel = "M3",
                        YearOfIssue = 2002,
                        CarCost = 400,
                        Category = Categories["Купе"]
                    } 
                ); ; ; ;
              
            }
            context.SaveChanges();
        }

        static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { CategotyName = "Электромобили"},
                        new Category { CategotyName = "Седан"},
                        new Category { CategotyName = "Купе"},
                        new Category { CategotyName = "Универсал"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.CategotyName, el);
                }
                return category;
            }

        }
    }
}
