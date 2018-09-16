using System;
using System.Collections.Generic;
using WebStore.Domain.Entities;
using WebStore.Domain.Repositories;

namespace UnitTests.Repositories
{
    public class CustomerRepositoryMock : ICustomerRepository
    {
        public Customer Add(Customer entity)
        {
            return new Customer(Guid.NewGuid(), entity.Name, entity.Email, entity.Phone);
        }

        public void Delete(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public Customer GetByEmail(string email)
        {
            if (email == "james.bond@domain.com")
                return null;
            
            return new Customer(Guid.NewGuid(), "Random Name", email, "+1 1234 5678");
        }

        public Customer GetById(Guid id)
        {
            return new Customer(id, "James Bond", "james.bond@gmail.com", "+ 1234 5678");
        }

        public Customer GetByIdWithAddressesAndPaymentMethods(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> ListAll()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new System.NotImplementedException();
        }
    }
}