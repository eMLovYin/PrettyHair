﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHair
{
    public class CustomerRepository
    {
        List<Customer> customerList;

        public CustomerRepository()
        {
            customerList = new List<Customer>();

            customerList.Add(new Customer(0, "Tahir", "somewhere"));
            customerList.Add(new Customer(1, "Ayse", "somewhere"));
            customerList.Add(new Customer(2, "Sezer", "somewhere"));
            customerList.Add(new Customer(3, "Fatma", "somewhere"));
            customerList.Add(new Customer(4, "Aras-Ali", "somewhere"));
        }

        public List<Customer> RegisterCustomer()
        {
            return customerList;
        }

        public Customer FindCustomer(int id)
        {
            return customerList.Find(x => x.CustomerNumber == id);
        }

        public List<Customer> FindAllCustomers()
        {
            return customerList;
        }

        public void RegisterCustomer(Customer customer)
        {
            customerList.Add(customer);
        }
    }
}