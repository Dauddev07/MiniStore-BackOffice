using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Contracts;
using App.Core.Models;

namespace App.Core.Services
{
    public class InMemoryCustomerService : ICustomerService
    {
        private List<Customer> _customers = new List<Customer>();
        List<Customer> ICustomerService.GetAll()
        {
            return _customers.ToList();
        }
         Customer ICustomerService.GetById(string id)
        {
            return _customers.FirstOrDefault(c=>c.Id==id);
        }
        void ICustomerService.Add(Customer customer)
        {
            if (customer == null) 
                throw new ArgumentNullException("Customer object is null");
            _customers.Add(customer);
        }
         void ICustomerService.Update(Customer customer)
        {
            if (customer == null) 
                throw new ArgumentNullException("Customer object is null");
            var existing= _customers.FirstOrDefault(c=>c.Id == customer.Id);
            if (existing == null)
                throw new Exception($"Customer with {customer.Id} not found");

            existing.Name = customer.Name;
            existing.Phone = customer.Phone;
            existing.Email = customer.Email;
            existing.Address = customer.Address;

        }
         void ICustomerService.Delete(string id)
        {
            _customers.RemoveAll(c=>c.Id== id);
        }
         List<Customer> ICustomerService.Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return ((ICustomerService)this).GetAll();
            return _customers.Where(c=>c.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
