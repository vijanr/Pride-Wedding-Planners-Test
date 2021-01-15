using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PrideWeddingPlanners.Models
{
    public class WeddingDBContext : DbContext
    {
        public WeddingDBContext(DbContextOptions<WeddingDBContext> options)
:       base(options)
        {

        }
       
        public DbSet<Admin> AdminTable { get; set; }
        public DbSet<Client> ClientTable { get; set; }
        public DbSet<Client_Account> ClientAccountTable { get; set; }
        public DbSet<Packages> PackagesTable { get; set; }
        public DbSet<Payments> PaymentsTable { get; set; }
        public DbSet<Vendor> VendorTable { get; set; }
        public DbSet<Vendor_Account> VendorAccountTable { get; set; }
    }
       
}
