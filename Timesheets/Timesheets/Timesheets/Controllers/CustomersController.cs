using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Holders;
using Timesheets.Model;

namespace Timesheets.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private CustomersHolders _customers;

        public CustomersController(CustomersHolders customers)
        {
            _customers = customers;
        }

        [HttpGet("get")]
        public IActionResult GetCustomers()
        {
            return Ok(_customers.GetAll());
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_customers.GetById(id));
        }
        [HttpPost("register")]
        public IActionResult CreateNew([FromBody] clCustomers newCustomers)
        {
            return Ok(_customers.Create(newCustomers));
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateContract([FromRoute] int id, [FromBody] clCustomers newCustomers)
        {
            newCustomers.Id = id;
            return Ok(_customers.Update(newCustomers));
        }
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteById([FromRoute] int id)
        {
            return Ok(_customers.DeleteById(id));
        }

    }
}
