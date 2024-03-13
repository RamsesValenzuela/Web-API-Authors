using Microsoft.EntityFrameworkCore;
using Web_API_Authors.Entities;

namespace Web_API_Authors
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Author> Authors  { get; set; }

    }

}
