using ChessShop.Models;
using Microsoft.EntityFrameworkCore;

namespace ChessShop.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options) 
        {
            
        }

        public DbSet<Category> Category { get; set; }
    }
}
