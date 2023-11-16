using BookAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Database
{
    public class MyContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = .; Initial Catalog =BookDb; User Id = Narmatha; Password = 123456; TrustServerCertificate = true");

        }
    }
}
