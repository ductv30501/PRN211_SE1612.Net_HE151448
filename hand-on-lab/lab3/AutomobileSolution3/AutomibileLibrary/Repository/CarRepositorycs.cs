using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomibileLibrary.DataAccess;
using AutomibileLibrary.Repository;

namespace AutomibileLibrary.Repository
{
    public class CarRepositorycs : ICarRepository
    {
        public void DeleteCar(int carId) => CarDAO.Instance.Remove(carId);

        public Car GetCarById(int carId) => CarDAO.Instance.GetCarByID(carId);

        public IEnumerable<Car> GetCars() => CarDAO.Instance.GetCarList();

        public void InsertCar(Car car) => CarDAO.Instance.AddNew(car);

        public void UpdateCar(Car car) => CarDAO.Instance.Update(car);

    }
}
