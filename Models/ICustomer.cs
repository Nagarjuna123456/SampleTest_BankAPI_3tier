using System;
using System.Collections.Generic;
using System.Text;

namespace BankAPISample.Service.Models
{
   public  interface ICustomer
    {
        IEnumerable<CustomerModel> GetCustomers();
    }
}
