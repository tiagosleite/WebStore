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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var navigationCustomerAddresses = modelBuilder.Entity<Customer>()
                .Metadata.FindNavigation(nameof(Customer.Addresses));
            
            navigationCustomerAddresses.SetPropertyAccessMode(PropertyAccessMode.Field);

            var navigationCustomerPaymentMethods = modelBuilder.Entity<Customer>()
                .Metadata.FindNavigation(nameof(Customer.PaymentMethods));
            
            navigationCustomerPaymentMethods.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}