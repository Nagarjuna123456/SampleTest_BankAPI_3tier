using BankAPISample.Service.Models;
using BankAPISample.Service.SqlData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAPISample.Repository.Repository
{
    public class CustomerService : ICustomer
    {
        BankAPIContext dbcontext;

        public CustomerService(BankAPIContext bankAPIContext)
        {
            dbcontext = bankAPIContext;
        }
        public IEnumerable<CustomerModel> GetCustomers()
        {
            var clist = dbcontext.customers.ToList();
            return clist;
        }
    }
}
