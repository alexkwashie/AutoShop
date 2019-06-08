using AutoShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.ViewModels
{
    public class HomeViewModel
    {
        //#Step15 - Add all data used in the application

        //#Step16 - Create a new instance in the HomeController to use propeties set here. Under (IActionResult Index())

        public string Title { get; set; }

        public List<cars> GetCars { get; set; }
        
    }
}
