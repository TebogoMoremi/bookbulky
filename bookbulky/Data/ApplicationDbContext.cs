using bookbulky.Models;
using Microsoft.EntityFrameworkCore;

namespace bookbulky.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
             
        }
        public DbSet<Category>Categories { get; set; }
    }
}
