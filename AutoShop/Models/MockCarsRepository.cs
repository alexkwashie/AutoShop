using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//#Step4 - Create a - MockCarsRepository class linked to a ICarsRepository class in a Models folder
// -> And Add the following

namespace AutoShop.Models
{
    public class MockCarsRepository : ICarsRepository
    {   
        //List of cars
        private List<cars> _cars;

        //if the Cars list is empty run initialsCars method
        public MockCarsRepository()
        {
            if (_cars == null)
            {
                InitializeCars();
            }
        }

     

        private void InitializeCars()
        {
            _cars = new List<cars>
            {
            new cars { Id = 1, Name = "Range Rover Sports SVR", Price = 123000, ShortDescription = "2019 LandRover", LongDescription = "The Range Rover Sport is a car for all occasions, primarily because there’s no driving situation in which it doesn’t excel" },
            new cars { Id = 2, Name = "Bently Continental", Price = 102000, ShortDescription = "2019 GT Edition", LongDescription = "Efficaciously, primarily because there’s no driving situation in which it doesn’t excel" },
            new cars { Id = 3, Name = "Audi RS7", Price = 93000, ShortDescription = "2018 Audi", LongDescription = "Black Edtion, primarily because there’s no driving situation in which it doesn’t excel" },
            new cars { Id = 4, Name = "Mercedes G-Wagon G63s", Price = 223000, ShortDescription = "2011 G-Wagon Classic", LongDescription = "The German Heat, primarily because there’s no driving situation in which it doesn’t excel" },
            };
        }


        //Retrive list of cars
        public IEnumerable<cars> GetAllCars()
        {
            return _cars;
        }

        public cars GetCarById(int carId)
        {
            //Returns first instance of the Id or the default value if non is found
            return _cars.FirstOrDefault(c => c.Id == carId);
        }

    }
}
