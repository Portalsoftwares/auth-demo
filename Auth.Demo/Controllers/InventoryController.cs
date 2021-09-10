using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Demo.Controllers
{
    // @"https://dotnetcorecentral.com/blog/asp-net-core-authorization/"
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class InventoryController : ControllerBase
    {
        // GET: api/Inventory
        [HttpGet]
        [Authorize(Roles = "Administrator, User")]
        //[Authorize(Roles = "Administrator")]
        //[Authorize(Roles = "User")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/Inventory
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        // [Authorize(Policy = "AdminAndPoweruser")]
       // [Authorize(Policy = "EmployeeMoreThan20Years")]
        public void Post([FromBody] Inventory value)
        {
        }
    }
}