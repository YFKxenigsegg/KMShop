using KMShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KMShop.Data
{
    interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
