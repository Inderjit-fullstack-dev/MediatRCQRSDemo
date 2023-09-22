using MediatR;
using MediatRCQRSDemo.Models;
using MediatRCQRSDemo.Services;

namespace MediatRCQRSDemo.Queries
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, List<Customer>>
    {
        private readonly ICustomerService _customerService;

        public GetCustomersQueryHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public async Task<List<Customer>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            return await _customerService.GetCustomers();
        }
    }
}
