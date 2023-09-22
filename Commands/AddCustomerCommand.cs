using MediatR;
using MediatRCQRSDemo.Models;

namespace MediatRCQRSDemo.Commands
{
    public record AddCustomerCommand(Customer Customer) : IRequest<Customer>;
}
