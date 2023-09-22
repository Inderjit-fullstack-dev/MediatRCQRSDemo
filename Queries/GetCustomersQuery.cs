using MediatR;
using MediatRCQRSDemo.Models;

namespace MediatRCQRSDemo.Queries
{
    public record GetCustomersQuery() : IRequest<List<Customer>>;
}
