using System;
using System.Collections.Generic;
using System.Linq;

namespace KMShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; } 

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
