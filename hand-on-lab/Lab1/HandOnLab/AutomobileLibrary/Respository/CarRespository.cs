using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Respository
{
     public class CarRepository : ICarRepository
    {
        public void deleteCar(int carID)
        {
            CarDBContext.Intance.Remove(carID);
        }

        public Car GetCarByID(int carID)
        {
            return CarDBContext.Intance.GetCarByID(carID);
        }

        public IEnumerable<Car> GetCars()
        {
            return CarDBContext.Intance.GetCarList;
        }

        public void insertCar(Car car)
        {
            CarDBContext.Intance.AddNew(car);
        }

        public void updateCar(Car car)
        {
            CarDBContext.Intance.update(car);
        }
    }
}
