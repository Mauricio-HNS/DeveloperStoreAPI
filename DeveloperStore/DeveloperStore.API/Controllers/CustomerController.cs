using Microsoft.AspNetCore.Mvc;
using DeveloperStore.API.Models;
using DeveloperStore.API.Services;
using System.Collections.Generic;

namespace DeveloperStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // Endpoint para obter todos os clientes
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            return Ok(_customerService.GetAllCustomers());
        }

        // Endpoint para obter um cliente por ID
        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        // Endpoint para criar um novo cliente
        [HttpPost]
        public ActionResult<Customer> CreateCustomer(Customer customer)
        {
            var createdCustomer = _customerService.CreateCustomer(customer);
            return CreatedAtAction(nameof(GetCustomerById), new { id = createdCustomer.CustomerId }, createdCustomer);
        }

        // Endpoint para atualizar um cliente existente
        [HttpPut("{id}")]
        public ActionResult<Customer> UpdateCustomer(int id, Customer customer)
        {
            // Garantir que o ID no corpo da requisição seja igual ao ID na URL
            if (id != Convert.ToInt32(customer.CustomerId))
            {
                return BadRequest();
            }

            var updatedCustomer = _customerService.UpdateCustomer(customer);
            return Ok(updatedCustomer);
        }

        // Endpoint para excluir um cliente
        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            _customerService.DeleteCustomer(id);
            return NoContent();
        }
    }
}
