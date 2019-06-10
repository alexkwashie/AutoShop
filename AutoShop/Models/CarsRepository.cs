using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class CarsRepository:ICarsRepository
    {
        //Creat access to the AppDbContext
        private readonly AppDbContext _appDbContext;

        public CarsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext; 
        }

        public IEnumerable<cars> GetAllCars()
        {
            return _appDbContext.Cars;
        }

        public cars GetCarById(int carId)
        {
            return _appDbContext.Cars.FirstOrDefault(c => c.Id == carId);
        }
    }
}
