namespace Cars.Controllers
{
    using System;
    using System.Collections.Generic;
    using Cars.Contracts;
    using Cars.Infrastructure;
    using Cars.Models;

    public class CarsController
    {
        private ICarsRepository carsData;

        public CarsController()
            : this(new CarsRepository())
        {
        }

        public CarsController(ICarsRepository data)
        {
            this.carsData = data;
        }

        public IView Index()
        {
            var cars = this.carsData.All();
            return new View(cars);
        }

        public IView Add(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException("Car cannot be null");
            }

            if (string.IsNullOrEmpty(car.Make) || string.IsNullOrEmpty(car.Model))
            {
                throw new ArgumentNullException("Car make and model cannot be empty");
            }

            this.carsData.Add(car);
            return this.Details(car.Id);
        }

        public IView Details(int id)
        {
            var car = this.carsData.GetById(id);

            if (car == null)
            {
                throw new ArgumentNullException("Car could not be found");
            }

            return new View(car);
        }

        public IView Search(string condition)
        {
            var result = this.carsData.Search(condition);
            return new View(result);
        }

        public IView SortByMake()
        {
            ICollection<Car> result = this.carsData.SortedByMake();
            return new View(result);
        }

        public IView SortByYear()
        {
            ICollection<Car> result = this.carsData.SortedByYear();
            return new View(result);
        }
    }
}
