using Microsoft.EntityFrameworkCore;

namespace EFcoremanytomanyMAIN
{
    public class DataContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarsColors> CarsColors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-N5N9E4H\\SQLEXPRESS;Database=EFmanytomany;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
