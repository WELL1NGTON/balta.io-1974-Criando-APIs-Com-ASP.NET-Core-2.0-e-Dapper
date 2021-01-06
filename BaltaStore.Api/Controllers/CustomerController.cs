using System;
using System.Collections.Generic;
using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Outputs;
using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.Handlers;
using BaltaStore.Domain.StoreContext.Queries;
using BaltaStore.Domain.StoreContext.Repositories;
using BaltaStore.Domain.StoreContext.ValueObjects;
using BaltaStore.Shared.Commands;
using Microsoft.AspNetCore.Mvc;

namespace BaltaStore.Api.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _repository;
        private readonly CustomerHandler _handler;
        public CustomerController(ICustomerRepository repository, CustomerHandler handler)
        {
            _repository = repository;
            _handler = handler;
        }

        [HttpGet]
        [Route("customers")]
        public IEnumerable<ListCustomerQueryResult> Get()
        {
            return _repository.Get();
        }

        [HttpGet]
        [Route("customers/{id}")]
        public GetCustomerQueryResult GetById(Guid id)
        {
            return _repository.Get(id);
        }

        [HttpGet]
        [Route("customers/{id}/Orders")]
        public IEnumerable<ListCustomerOrderQueryResult> GetOrders(Guid id)
        {
            return _repository.GetOrders(id);
        }

        [HttpPost]
        [Route("customers")]
        public object Post([FromBody] CreateCustomerCommand command)
        {
            var result = (CreateCustomerCommandResult)_handler.Handle(command);
            if (_handler.Invalid)
                return BadRequest(new { Notifications = _handler.Notifications });

            return result;
        }

        // [HttpPut]
        // [Route("customers/{id}")]
        // public Customer Put(
        //     Guid id,
        //     [FromBody] CreateCustomerCommand command)
        // {
        //     var name = new Name(command.FirstName, command.LastName);
        //     var document = new Document(command.Document);
        //     var email = new Email(command.Email);
        //     var customer = new Customer(name, document, email, command.Phone);
        //     return customer;
        // }

        // [HttpDelete]
        // [Route("customers/{id}")]
        // public object Delete(Guid id)
        // {
        //     return new { message = "Cliente removido com sucesso!" };
        // }
    }
}