using KMShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KMShop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly CarDbContext carContext;
        public CategoryRepository(CarDbContext carContext)
        {
            this.carContext = carContext;
        }
        public IEnumerable<Category> AllCategories => carContext.Categories;
    }
}
