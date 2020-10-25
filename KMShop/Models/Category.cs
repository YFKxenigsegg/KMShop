using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KMShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategotyName { get; set; }     
        public string CategotyDescription { get; set; }
        public List<Car> Cars { get; set; }
    }
}
