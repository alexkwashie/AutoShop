using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    // DbContext code enables the creation of a database
    //and acts as a agent between the your code and the database

    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        //Allow EF core to create and manage cars database
        public DbSet<cars> Cars { get; set; }
    }
}
