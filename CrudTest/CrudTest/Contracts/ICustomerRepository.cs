using CrudTest.Models;
using System;
using System.Collections.Generic;

namespace CrudTest.Contracts
{
    public interface ICustomerRepository : IDisposable
    {
        IEnumerable<Customer> Get();

        void Add(Customer customer);

        void Delete(int Id);

        void Edit(Customer customer);

        void Save();
    }
}