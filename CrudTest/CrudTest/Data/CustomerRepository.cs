using CrudTest.Contracts;
using CrudTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudTest.Data
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        private CustomerContext context;

        public CustomerRepository(CustomerContext context)
        {
            this.context = context;
        }

        public IEnumerable<Customer> Get()
        {
            return context.Customers.ToList();
        }

        public void Add(Customer customer)
        {
            context.Customers.Add(customer);
        }

        public void Delete(int id)
        {
            Customer customer = context.Customers.Find(id);
            context.Customers.Remove(customer);
        }

        public void Edit(Customer customer)
        {
            context.Entry(customer).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}