using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMicroService.Model
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }
    }
}
