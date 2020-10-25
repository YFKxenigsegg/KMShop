using KMShop.Data.Interfaces;
using KMShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace KMShop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly CarDbContext carContext;
        public CarRepository(CarDbContext carContext)
        {
            this.carContext = carContext;
        }
        public IEnumerable<Car> Cars { get => carContext.Cars.Include(c => c.CarName); }

        public Car getCar(int carId) => carContext.Cars.FirstOrDefault(c => c.Id == carId);
       
    }
}
