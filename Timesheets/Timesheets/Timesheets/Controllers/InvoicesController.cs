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
    [Route("api/invoices")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private InvoicesHolders _invoices;

        public InvoicesController(InvoicesHolders invoices)
        {
            _invoices = invoices;
        }

        [HttpGet("get")]
        public IActionResult GetCustomers()
        {
            return Ok(_invoices);
        }

        [HttpPut("update")]
        public IActionResult UpdateContract([FromBody] clInvoices newInvoices)
        {
            return Ok(_invoices.Update(newInvoices));
        }


    }
}
