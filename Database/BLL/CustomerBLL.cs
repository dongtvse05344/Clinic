﻿using Database.DAO;
using Database.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.BLL
{
    public class CustomerBLL
    {
        private readonly CustomerDAO _customerDAO;
        public CustomerBLL()
        {
            _customerDAO = new CustomerDAO();
        }

        public Customer GetByPhone(string phone)
        {
            if(string.IsNullOrEmpty(phone))
            {
                throw new Exception("Input is not valid");
            }
            return _customerDAO.GetByPhone(phone);
        }

        public void AddOrUpdate(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.Name)
                || string.IsNullOrEmpty(customer.Address)
                || string.IsNullOrEmpty(customer.Phone)
                )
            {
                throw new Exception("Input is not valid");
            }
            
            try
            {
                if(_customerDAO.GetById(customer.Id) ==null)
                {
                    _customerDAO.Add(customer);
                }
                else
                {
                    _customerDAO.Update(customer);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Customer> GetCustomers()
        {
            return _customerDAO.GetCustomers();
        }
        public List<Customer> GetCustomers(string nameSearch)
        {
            return _customerDAO.GetCustomers(nameSearch);
        }
        public Customer GetCustomer(int id)
        {
            return _customerDAO.GetCustomer(id);
        }

    }
}
