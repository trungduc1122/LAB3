using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Data_Access
{
    public class CarDAO
    {
        private static CarDAO instance = null;
        private static readonly object instanceLock = null;
        public static CarDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDAO();
                    }
                }
                return instance;
            }
        }
        public IEnumerable<Cars> GetCars()
        {
            var cars = new List<Cars>();
            try
            {
                using var db = new MyStockContext();
                cars = db.Cars.ToList();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            return cars;
        }
        public Cars GetCarsByID(int id)
        {
            Cars car = null;
            try
            {
                using var db = new MyStockContext();
                car = db.Cars.SingleOrDefault(c => c.CarId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return car;
        }
        public void Add(Cars car)
        {
            Cars _car = GetCarsByID(car.CarId);
            try
            {
                if (_car == null)
                {
                    using var db = new MyStockContext();
                    db.Cars.Add(car);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("car already exsit");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(Cars car)
        {
            Cars _car = GetCarsByID(car.CarId);
            try
            {
                if (_car != null)
                {
                    using var db = new MyStockContext();
                    db.Cars.Update(car);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("car not exsit");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Delete(int id)
        {
            Cars _car = GetCarsByID(id);
            try
            {
                if (_car != null)
                {
                    using var db = new MyStockContext();
                    db.Cars.Remove(_car);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("car not exsit");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
