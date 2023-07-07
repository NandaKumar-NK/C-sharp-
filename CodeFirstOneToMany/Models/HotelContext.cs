using Microsoft.EntityFrameworkCore;

namespace CodeFirstOneToMany.Models
{
    public class HotelContext:DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Type> Types { get; set; }

        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=LAPTOP-KR3SF32I\\SQLEXPRESS;database=DBAPI;integrated security=true;trustservercertificate=true;");
        }
    }
}
