using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Entities;
using WebStore.Domain.Repositories;
using WebStore.Infrastructure.Contexts;

namespace WebStore.Infrastructure.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(WebStoreContext context)
            : base(context) { }

        public Customer GetByEmail(string email)
        {
            return _context.Set<Customer>().FirstOrDefault(c => c.Email == email);
        }

        public Customer GetByIdWithAddressesAndPaymentMethods(Guid id)
        {
            return _context.Set<Customer>()
                .Include(c => c.Addresses)
                .Include(c => c.PaymentMethods)
                .FirstOrDefault(c => c.Id == id);
        }
    }
}