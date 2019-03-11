using Database.DAO;
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
            return _customerDAO.GetByPhone(phone);
        }

        public void AddOrUpdate(Customer customer)
        {
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
    }
}
