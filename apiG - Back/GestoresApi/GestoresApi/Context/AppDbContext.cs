using GestoresApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GestoresApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Gestores_Bd> gestores_bd { get; set; }

    }
}
