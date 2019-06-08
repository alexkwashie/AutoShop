using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models

{   //#Step3 - Create item entry titles
    public class cars
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public int Price { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public int IsCarOfTheWeek { get; set; }
                
    }
}
