using MediatRCQRSDemo.Database;
using MediatRCQRSDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatRCQRSDemo.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return customer;
        }

        public async Task<Customer> UpdateCustomer(int id, Customer customer)
        {
            var customerInDb = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);

            if (customerInDb == null)
                throw new Exception("Customer not found");

            customerInDb.FullName = customer.FullName;
            customerInDb.Address = customer.Address;
            customerInDb.Mobile = customer.Mobile;

            await _context.SaveChangesAsync();

            return customerInDb;
        }


        public async Task<Customer> DeleteCustomer(int id)
        {
            var customerInDb = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);

            if (customerInDb == null)
                throw new Exception("Customer not found");


            _context.Customers.Remove(customerInDb);

            await _context.SaveChangesAsync();
            return customerInDb;
        }
    }
}
