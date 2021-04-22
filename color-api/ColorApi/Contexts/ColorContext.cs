using ColorApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ColorApi.Contexts
{
    public class ColorContext : DbContext 
    {
        public ColorContext(DbContextOptions<ColorContext> options) : base(options)
        {
            
        }

        public DbSet<Color> Colors { get; set; }
    }
}