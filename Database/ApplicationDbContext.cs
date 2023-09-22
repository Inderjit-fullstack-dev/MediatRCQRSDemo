using MediatRCQRSDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatRCQRSDemo.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
