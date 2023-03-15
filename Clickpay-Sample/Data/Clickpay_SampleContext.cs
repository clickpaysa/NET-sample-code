using System;
using Microsoft.EntityFrameworkCore;
using Clickpay_Sample.Models;

namespace Clickpay_Sample.Data
{
    public class Clickpay_SampleContext : DbContext
    {
        public Clickpay_SampleContext(DbContextOptions<Clickpay_SampleContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Transaction> Transaction { get; set; }
    }
}
