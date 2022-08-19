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
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private EmployeesHolders _employees;

        public EmployeesController(EmployeesHolders employees)
        {
            _employees = employees;
        }

        [HttpGet("get")]
        public IActionResult GetCustomers()
        {
            return Ok(_employees.GetAll());
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_employees.GetById(id));
        }
        [HttpPost("register")]
        public IActionResult CreateNew([FromBody] clEmployees newEmployees)
        {
            return Ok(_employees.Create(newEmployees));
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateContract([FromRoute] int id, [FromBody] clEmployees newEmployees)
        {
            newEmployees.Id = id;
            return Ok(_employees.Update(newEmployees));
        }
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteById([FromRoute] int id)
        {
            return Ok(_employees.DeleteById(id));
        }

    }
}
