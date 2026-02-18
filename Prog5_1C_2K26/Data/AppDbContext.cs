using Microsoft.EntityFrameworkCore;
using Prog5_1C_2K26.Models;

namespace Prog5_1C_2K26.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }
        public DbSet<CentroVacunacion> CentroVacunacion { get; set; } = default!;
    }
}
