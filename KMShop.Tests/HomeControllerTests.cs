using Microsoft.AspNetCore.Mvc;
using KMShop.Controllers;
using KMShop.Models;
using Moq;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace KMShop.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexReturnsAViewResultWithAListOfCars()
        {
            // Arrange
            var mock = new Mock<CarDbContext>(); 
            mock.Setup(repo => repo.Cars).Returns(GetQueryableMockDbSet(GetTestCars()));
            var controller = new HomeController(mock.Object);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Car>>(viewResult.Model);
            Assert.Equal(GetTestCars().Count, model.Count());
        }

        private List<Car> GetTestCars()
        {
            var cars = new List<Car>
            {
                new Car { Id=0, CarName="Nissan", CarModel="juke", YearOfIssue=200,
                CarCost=200.2, CategoryId=1},
                new Car { Id=1, CarName="Nissan", CarModel="juk22e", YearOfIssue=2100,
                CarCost=2020.2, CategoryId=1},
                new Car { Id=2, CarName="Nissafadn", CarModel="jukfae", YearOfIssue=201,
                CarCost=100.2, CategoryId=1},
            };
            return cars;
        }
        private static DbSet<T> GetQueryableMockDbSet<T>(List<T> sourceList) where T : class
        {
            var queryable = sourceList.AsQueryable();

            var dbSet = new Mock<DbSet<T>>();
            dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());
            dbSet.Setup(d => d.Add(It.IsAny<T>())).Callback<T>((s) => sourceList.Add(s));

            return dbSet.Object;
        }
    }
}
