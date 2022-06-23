using AutomobileLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        private static List<Car> CarList = new List<Car>()
        {
            new Car{ CarID =1, CarName= "CRV",Munafacturer = "Honda", Price = 30000, ReleaseYear= 2020},
            new Car{ CarID =1, CarName= "Camry",Munafacturer = "Honda", Price = 50000, ReleaseYear= 2021}
        };
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Intance
        {
            get
            {
                lock(instanceLock){
                    if(instance == null){
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        public List<Car> GetCarList => CarList;

        public Car GetCarByID(int carID)
        {
            Car car = CarList.SingleOrDefault(pro => pro.CarID == carID);
            return car;
        }
        // add new car
        public void AddNew (Car car)
        {
            Car pro = GetCarByID(car.CarID);
            if (pro == null)
            {
                CarList.Add(car);
            }
            else
            {
                throw new Exception("car is already exists.");
            }
        }
        public void update(Car car)
        {
            Car c = GetCarByID(car.CarID);
            if (c != null)
            {
                var index = CarList.IndexOf(c);
                CarList[index] = car;
            }
            else
            {
                throw new Exception("car does not already exists.");
            }
        }
        public void Remove(int carID)
        {
            Car p = GetCarByID(carID);
            if (p != null)
            {
                CarList.Remove(p);
            }
            else
            {
                throw new Exception("car does not already exists.");
            }
        }
    }
}
