using Microsoft.EntityFrameworkCore;
using smnetcoremvc.Models;

namespace smnetcoremvc.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Projectimage> Projectimages { get; set; }
    }
}
