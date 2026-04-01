using System;
using System.Collections.Generic;
using System.Text;
using App.Core.Models;

namespace App.Core.Contracts
{
    public interface ICustomerService
    {
         List<Customer> GetAll();
         Customer GetById(string id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(string id);
        List<Customer> Search(string query);

    }
}
