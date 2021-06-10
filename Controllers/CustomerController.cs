using BankAPISample.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer customerservice;
        public CustomerController (ICustomer customer)
        {
            customerservice = customer;

        }
        [HttpGet]
        [Route("api/customer/getcustomers")]
        public IEnumerable<CustomerModel> GetCustomers()
        {
            return customerservice.GetCustomers();
        }
    }
}
