using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoShop.Models;
using AutoShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoShop.Controllers
{
    public class HomeController : Controller
    {
        //#Step7 - create a private field for the Cars repository to enable it to talk to the Model
        private readonly ICarsRepository _carsRepository;

        //#Step8
        public HomeController(ICarsRepository carsRepository)
        {   
            // Without a Dependency injection created in the Startup file will use code below:
            // -> _carsRepository = new MockCarsRepository();

            //But because a Dependency injection is already created in the startup file, we will use:
            _carsRepository = carsRepository; //which preplaced by the MockCarsRepository

        }

        // //#Step9 - Create a Views Folder -> Home folder and add a .cshtml file (Razor MVC page)


        // GET: /<controller>/
        public IActionResult Index()
        {
            //Step10 - Use the viewbag... to create any variable to display in the index.cshtml page -- Except at (//@)
            //ViewBag.title = "Car Overview";
            //OR  at (//@)

                                        
            var cars = _carsRepository.GetAllCars().OrderBy(c => c.Name);

            //@ #Step17 - Initialize and assign values to the properties from HomeViewModel 
            var homeviewmodel = new HomeViewModel()
            {
                Title = "Welcome AutoShp Car Intl",
                GetCars = cars.ToList()
            };

            //# Step18 - Initialize and assign values to the properties from HomeViewModel 
            return View(homeviewmodel);


            //return View(cars);
        }
    }
}
