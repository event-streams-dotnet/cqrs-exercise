using System;
using System.Diagnostics.CodeAnalysis;
using EventDriven.CQRS.Abstractions.Commands;

namespace CustomerService.Domain.CustomerAggregate.Commands
{
    // [ExcludeFromCodeCoverage]
    // public record UpdateCustomer(Customer Customer, Guid CustomerId, string ETag) : ICommand<CommandResult<Customer>>
    // {
    //     public UpdateCustomer(Customer customer) : this(customer, customer.Id, customer.ETag) { }
    // }
}