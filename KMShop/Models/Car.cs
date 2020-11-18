using KMShop.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KMShop.Models
{
    public class Car : EntityBase
    {
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public int YearOfIssue { get; set; }
        public double CarCost { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
