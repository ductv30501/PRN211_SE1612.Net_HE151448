using AutomobileLibrary.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AutomobileLibrary.DataAcess
{
    public class CarDBContext : BaseDAL
    {
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        
        public IEnumerable<Car> GetCarList()
        {
            IDataReader dataReader = null;
            string sql = "SELECT [CarID],[CarName],[Manufacturer],[Price],[ReleasedYear] FROM .[Cars]";
            var cars = new List<Car>();
            try
            {
                
                dataReader = dataProvider.GetDataReader(sql, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    cars.Add(new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufactor = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return cars;
        }

        public Car GetcarByID(int carID)
        {
            Car car = null;
            IDataReader dataReader = null;
            string sql = "SELECT [CarID],[CarName],[Manufacturer],[Price],[ReleasedYear] FROM [Cars]" +
                "WHERE CarID = @CarID";
            try
            {
                var param = dataProvider.CreateParameter("@CarID", 4, carID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(sql, CommandType.Text, out connection,param);
                if (dataReader.Read())
                {
                     car = new Car
                    {
                        CarID = dataReader.GetInt32(0),
                        CarName = dataReader.GetString(1),
                        Manufactor = dataReader.GetString(2),
                        Price = dataReader.GetDecimal(3),
                        ReleaseYear = dataReader.GetInt32(4)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return car;
        }
        public void AddNew(Car car)
        {
            
            try
            {
                Car pro = GetcarByID(car.CarID);
                if (pro == null)
                {
                    string sql = "INSERT INTO [Cars] ([CarName]," +
                        "[Manufacturer],[Price],[ReleasedYear])VALUES(@CarName,@Manufactor,@Price,@ReleaseYear)";
                    var parameters = new List<SqlParameter>();
                    //parameters.Add(dataProvider.CreateParameter("@CarID", 4, car.CarID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Manufactor", 50, car.Manufactor, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@ReleaseYear", 4, car.ReleaseYear, DbType.Int32));
                    dataProvider.Insert(sql, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("the car is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Update(Car car)
        {

            try
            {
                Car pro = GetcarByID(car.CarID);
                if (pro != null)
                {
                    string sql = "UPDATE [Cars] SET [CarName] = @CarName,[Manufacturer] = @Manufactor," +
                        "[Price] = @Price,[ReleasedYear] = @ReleaseYear WHERE [CarID] = @CarID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@CarID", 4, car.CarID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@CarName", 50, car.CarName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Manufactor", 50, car.Manufactor, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Price", 50, car.Price, DbType.Decimal));
                    parameters.Add(dataProvider.CreateParameter("@ReleaseYear", 4, car.ReleaseYear, DbType.Int32));
                    dataProvider.Update(sql, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("the car does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void Remove(int carID)
        {

            try
            {
                Car pro = GetcarByID(carID);
                if (pro != null)
                {
                    string sql = "DELETE FROM [Cars] WHERE CarID = @CarID";
                    var parameter = dataProvider.CreateParameter("@CarID", 4, carID, DbType.Int32);
                    dataProvider.Delete(sql, CommandType.Text, parameter);
                }
                else
                {
                    throw new Exception("the car does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

    }
}
