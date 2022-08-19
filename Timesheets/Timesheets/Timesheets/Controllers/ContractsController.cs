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
    [Route("api/contracts")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        private  ContractsHolders _contracts;

        public ContractsController(ContractsHolders contracts)
        {
            _contracts = contracts;
        }

        [HttpGet("get")]
        public IActionResult GetContracts()
        {
            return Ok(_contracts.GetAll());
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(_contracts.GetById(id));
        }
        [HttpPost("register")]
        public IActionResult CreateNew([FromBody] clContracts newContract)
        {
            return Ok(_contracts.Create(newContract));
        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateContract([FromRoute] int id, [FromBody] clContracts newContract)
        {
            newContract.Id = id;
            return Ok(_contracts.Update(newContract));
        }
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteById([FromRoute] int id)
        {
            return Ok(_contracts.DeleteById(id));
        }

    }
}
