﻿using System;
using System.Threading.Tasks;
using AutoMapper;
using CustomerService.Domain.CustomerAggregate.Commands;
using CustomerService.DTO.Write;
using CustomerService.Helpers;
using EventDriven.CQRS.Abstractions.Commands;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerCommandController : ControllerBase
    {
        private readonly ICommandBroker _commandBroker;
        private readonly IMapper _mapper;

        public CustomerCommandController(ICommandBroker commandBroker, IMapper mapper)
        {
            _commandBroker = commandBroker;
            _mapper = mapper;
        }

        // // POST api/customer
        // [HttpPost]
        // public async Task<IActionResult> Create([FromBody] Customer customerDto)
        // {
        //     var customerIn = _mapper.Map<Domain.CustomerAggregate.Customer>(customerDto);
        //     var result = await _commandBroker.InvokeAsync<CreateCustomer, CommandResult<Domain.CustomerAggregate.Customer>>(new CreateCustomer(customerIn));
        //
        //     if (result.Outcome != CommandOutcome.Accepted)
        //         return result.ToActionResult();
        //
        //     var customerOut = _mapper.Map<Customer>(result.Entity);
        //     return new CreatedResult($"api/customer/{customerOut.Id}", customerOut);
        // }
        //
        // // PUT api/customer
        // [HttpPut]
        // public async Task<IActionResult> Update([FromBody] Customer customerDto)
        // {
        //     var customerIn = _mapper.Map<Domain.CustomerAggregate.Customer>(customerDto);
        //     var result = await _commandBroker.InvokeAsync<UpdateCustomer, CommandResult<Domain.CustomerAggregate.Customer>>(new UpdateCustomer(customerIn));
        //
        //     if (result.Outcome != CommandOutcome.Accepted)
        //         return result.ToActionResult();
        //
        //     var customerOut = _mapper.Map<Customer>(result.Entity);
        //     return result.ToActionResult(customerOut);
        // }
        //
        // // DELETE api/customer/id
        // [HttpDelete]
        // [Route("{id}")]
        // public async Task<IActionResult> Remove([FromRoute] Guid id)
        // {
        //     var result = await _commandBroker.InvokeAsync<RemoveCustomer, CommandResult>(new RemoveCustomer(id));
        //     return result.Outcome != CommandOutcome.Accepted ? result.ToActionResult() : new NoContentResult();
        // }
    }
}