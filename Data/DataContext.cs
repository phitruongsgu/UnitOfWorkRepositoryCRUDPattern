using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UnitofWorkRepositoryCRUDPattern.Models;

namespace UnitofWorkRepositoryCRUDPattern.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<City> Cities { get; set; }

    }
}
