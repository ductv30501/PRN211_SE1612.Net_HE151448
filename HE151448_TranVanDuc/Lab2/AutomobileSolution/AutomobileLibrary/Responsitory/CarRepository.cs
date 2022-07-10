using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Responsitory
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(int CarID) => CarDBContext.Instance.Remove(CarID);

        public Car GetCarByID(int CarID) => CarDBContext.Instance.GetcarByID(CarID);

        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList();

        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);

        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car); 
    }
}
