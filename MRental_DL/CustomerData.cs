using MRental_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRental_DL
{
    public class CustomerData
    {
        List<Customer> customers = new List<Customer>();
        int nextCustomerCode = 1;

        public Customer RegisterCustomer(string name)
        {
            Customer newCustomer = new Customer
            { Code = nextCustomerCode++, Name = name };
            customers.Add(newCustomer);
            return newCustomer;
        }
    }
}
