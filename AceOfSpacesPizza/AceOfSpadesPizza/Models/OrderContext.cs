using Microsoft.EntityFrameworkCore;

namespace AceOfSpadesPizza.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }

        public DbSet<Order> Order { get; set; }
    }
}
