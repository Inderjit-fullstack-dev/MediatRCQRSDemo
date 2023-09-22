using MediatRCQRSDemo.Models;

namespace MediatRCQRSDemo.Services
{
    public interface ICustomerService
    {
        Task<Customer> AddCustomer(Customer customer);
        Task<Customer> DeleteCustomer(int id);
        Task<Customer> GetCustomerById(int id);
        Task<List<Customer>> GetCustomers();
        Task<Customer> UpdateCustomer(int id, Customer customer);
    }
}