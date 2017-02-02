using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc111.Controllers
{
    [Route("api/[controller]/[action]")]
    public class EchoController : Controller
    {
        [HttpGet("{email}")]
        public string GetInRoute(string email)
        {
            return $"GetInRoute: [{email}]";
        }

        [HttpGet]
        public string GetInQuery(string email)
        {
            return $"GetInQuery: [{email}]";
        }
    }
}
