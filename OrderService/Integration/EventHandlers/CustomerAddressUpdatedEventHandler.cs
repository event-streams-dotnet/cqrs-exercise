using System.Threading.Tasks;
using AutoMapper;
// using Common.Integration.Events;
using EventDriven.EventBus.Abstractions;
using Microsoft.Extensions.Logging;
using OrderService.Domain.OrderAggregate;
using OrderService.Repositories;

namespace OrderService.Integration.EventHandlers
{
    public class CustomerAddressUpdatedEventHandler // : IntegrationEventHandler<CustomerAddressUpdated>
    {
        private readonly ILogger<CustomerAddressUpdatedEventHandler> _logger;
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public CustomerAddressUpdatedEventHandler(IOrderRepository orderRepository,
                                                  IMapper mapper,
                                                  ILogger<CustomerAddressUpdatedEventHandler> logger)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _logger = logger;
        }

        // public override async Task HandleAsync(CustomerAddressUpdated @event)
        // {
        //     _logger.LogInformation("Handling CustomerAddressUpdated event");
        //     var orders = await _orderRepository.GetCustomerOrders(@event.CustomerId);
        //
        //     foreach (var order in orders)
        //     {
        //         var shippingAddress = _mapper.Map<Address>(@event.ShippingAddress);
        //         await _orderRepository.UpdateOrderAddress(order.Id, shippingAddress);
        //     }
        // }
    }
}