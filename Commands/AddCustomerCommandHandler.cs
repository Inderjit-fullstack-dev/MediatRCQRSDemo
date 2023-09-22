using MediatR;
using MediatRCQRSDemo.Models;
using MediatRCQRSDemo.Services;

namespace MediatRCQRSDemo.Commands
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, Customer>
    {
        private readonly ICustomerService _customerService;

        public AddCustomerCommandHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<Customer> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customerService.AddCustomer(request.Customer);
        }
    }
}
