using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Cars> GetCars();
        public void Add(Cars car);
        public void Update(Cars car);
        public void Delete(int id);

    }
}
