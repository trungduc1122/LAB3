using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.Data_Access;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void Add(Cars car)=>CarDAO.Instance.Add(car);

        public void Delete(int id)=>CarDAO.Instance.Delete(id);

        public IEnumerable<Cars> GetCars()=>CarDAO.Instance.GetCars();

        public void Update(Cars car)=>CarDAO.Instance.Update(car);
    }
}
