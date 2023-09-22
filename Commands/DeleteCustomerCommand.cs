using MediatR;
using MediatRCQRSDemo.Models;

namespace MediatRCQRSDemo.Commands
{
    public record DeleteCustomerCommand(int id) : IRequest<Customer>;
}
