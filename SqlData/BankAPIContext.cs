using BankAPISample.Service.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankAPISample.Service.SqlData
{
    public class BankAPIContext:DbContext
    {
        public BankAPIContext(DbContextOptions<BankAPIContext> options) : base(options)
        {

        }

        public DbSet<CustomerModel> customers { get; set; }
    }
}
