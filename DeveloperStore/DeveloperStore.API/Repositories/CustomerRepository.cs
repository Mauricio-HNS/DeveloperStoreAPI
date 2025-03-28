﻿using DeveloperStore.API.Models;
using DeveloperStore.API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperStore.API.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DeveloperStoreDbContext _context;

        public CustomerRepository(DeveloperStoreDbContext context)
        {
            _context = context;
        }

        public Customer CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        //public IEnumerable<Customer> GetAllCustomers()
        //{
        //    return _context.Customers.ToList();
        //}

        //public Customer GetCustomerById(int id)
        //{
        //    return _context.Customers.FirstOrDefault(c => c.CustomerId == id);
        //}

        //public Customer CreateCustomer(Customer customer)
        //{
        //    _context.Customers.Add(customer);
        //    _context.SaveChanges();
        //    return customer;
        //}

        //public Customer UpdateCustomer(Customer customer)
        //{
        //    _context.Customers.Update(customer);
        //    _context.SaveChanges();
        //    return customer;
        //}

        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}

