using Libreria_DGGR.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Libreria_DGGR.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
