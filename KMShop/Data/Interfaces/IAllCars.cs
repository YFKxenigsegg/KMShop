using KMShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KMShop.Data.Interfaces
{
    public interface IAllCars : IRepository<Car>
    {
        IEnumerable<Car> Cars { get; }
        Car getCar(int carId);
    }
}
