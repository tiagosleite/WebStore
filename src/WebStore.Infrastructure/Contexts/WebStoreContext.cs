using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entities;

namespace WebStore.Infrastructure.Contexts
{
    public class WebStoreContext : DbContext
    {
        public WebStoreContext(DbContextOptions<WebStoreContext> options)
            : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
    }
}