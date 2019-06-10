using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            //Use this Seed method to initialize the databse with data if there is no data.
            if (!context.Cars.Any()) //if there is no data?
            {
                context.AddRange( //Add the following data

                    new cars { Name = "Range Rover Sports SVR", Price = 123000, ShortDescription = "2019 LandRover", LongDescription = "The Range Rover Sport is a car for all occasions, primarily because there’s no driving situation in which it doesn’t excel" },
                    new cars { Name = "Bently Continental", Price = 102000, ShortDescription = "2019 GT Edition", LongDescription = "Efficaciously, primarily because there’s no driving situation in which it doesn’t excel" },
                    new cars { Name = "Audi RS7", Price = 93000, ShortDescription = "2018 Audi", LongDescription = "Black Edtion, primarily because there’s no driving situation in which it doesn’t excel" },
                    new cars { Name = "Mercedes G-Wagon G63s", Price = 223000, ShortDescription = "2011 G-Wagon Classic", LongDescription = "The German Heat, primarily because there’s no driving situation in which it doesn’t excel" }
                    
                    );

                context.SaveChanges();
            }
        }
    }
}
