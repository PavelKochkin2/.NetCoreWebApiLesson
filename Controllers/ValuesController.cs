using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"this", "is", "get", "method"};
        }

        //GET: api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"id = {id}";
        }
    }
}