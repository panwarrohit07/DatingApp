using DemoDatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoDatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Value> Values { get; set; }

    }
}