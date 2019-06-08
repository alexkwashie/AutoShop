using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    //#Step3 - Create a - ICarsRepository class (interface) in a Models folder
    // -> create item Repository to get item by Id etc

    public interface ICarsRepository
    {
        IEnumerable<cars> GetAllCars();

        //Get a car by Id
        cars GetCarById(int carId);

    }
}
