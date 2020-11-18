using KMShop.Data.Interfaces;
using KMShop.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace KMShop.Data.Repository
{
    public class CarRepository : RepositoryBase<Car>, IAllCars
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
