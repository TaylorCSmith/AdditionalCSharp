using SportsStore.Domain.Entities;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
    // a context associates the model with the database
    public class EFDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
