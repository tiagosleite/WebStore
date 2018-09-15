using System.Linq;
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
    }
}