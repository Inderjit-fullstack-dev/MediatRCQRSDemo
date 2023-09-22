using MediatR;
using MediatRCQRSDemo.Models;
using MediatRCQRSDemo.Services;

namespace MediatRCQRSDemo.Commands
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, Customer>
    {
        private readonly ICustomerService _customerService;

        public DeleteCustomerCommandHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<Customer> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customerService.DeleteCustomer(request.id);
        }
    }
}
