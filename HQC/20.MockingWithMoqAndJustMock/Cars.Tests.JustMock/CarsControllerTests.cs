namespace Cars.Tests.JustMock
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using System.Collections.Generic;
    using Cars.Models;


    [TestClass]
    public class CarsControllerTests
    {
        private ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
            //: this(new MoqCarsRepository())
        {
        }

        public CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A4", model.Model);
            Assert.AreEqual(2005, model.Year);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DetailsOfWrongIdShouldThrowArgumentNullException()
        {
            controller.Details(-1);
        }

        [TestMethod]
        public void SearchingCarShouldReturnView()
        {
            var view = (IView)this.controller.Search("Test");

            var models = (List<Car>)view.Model;

            Assert.AreEqual(2, models[0].Id);
            Assert.AreEqual("325i", models[0].Model);
            Assert.AreEqual("BMW", models[0].Make);         
            Assert.AreEqual(2008, models[0].Year);

            Assert.AreEqual(3, models[1].Id);       
            Assert.AreEqual("330d", models[1].Model);
            Assert.AreEqual("BMW", models[1].Make);
            Assert.AreEqual(2007, models[1].Year);
        }

        [TestMethod]
        public void SortingByMakeShoudBeAccurate()
        {
            var sortedByMake = (IView)this.controller.SortByMake();
            var models = (List<Car>)sortedByMake.Model;

            Assert.AreEqual(1, models[0].Id);
            Assert.AreEqual(2, models[1].Id);
            Assert.AreEqual(3, models[2].Id);
            Assert.AreEqual(4, models[3].Id);
        }

        [TestMethod]
        public void SortingByYearShoudBeAccurate()
        {
            var sortedByMake = (IView)this.controller.SortByYear();
            var models = (List<Car>)sortedByMake.Model;

            Assert.AreEqual(1, models[0].Id);
            Assert.AreEqual(2, models[2].Id);
            Assert.AreEqual(3, models[1].Id);
            Assert.AreEqual(4, models[3].Id);
        }

        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
    }
}
