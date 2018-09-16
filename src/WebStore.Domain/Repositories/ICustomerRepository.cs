using System;
using WebStore.Domain.Entities;

namespace WebStore.Domain.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
         Customer GetByEmail(string email);
         Customer GetByIdWithAddressesAndPaymentMethods(Guid id);
    }
}