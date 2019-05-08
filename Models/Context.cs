using Microsoft.EntityFrameworkCore;

namespace Final_Project_Homekit_2.Models
{
    public class HomekitDbContext : DbContext
    {
        public HomekitDbContext (DbContextOptions<HomekitDbContext> options)
            : base(options)
        {
        }

        public DbSet<Final_Project_Homekit_2.Models.Category> Category { get; set; }
        public DbSet<Final_Project_Homekit_2.Models.Brand> Brand {get; set;}
        public DbSet<Final_Project_Homekit_2.Models.Product> Product {get; set;}
    }
}