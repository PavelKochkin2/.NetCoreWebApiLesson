using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ApiLesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "this", "is", "get", "method" };
        }

        //GET: api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id , string query)
        {
            return Ok(new Value() {Id = id, Name = "Name" + id});
        }

        //POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Value value)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            return CreatedAtAction("Get", new {id = value.Id}, value);
        }

        //PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        //DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class Value
    {
        public int Id { get; set; }
        [MinLength(3)]
        public string Name { get; set; }
    }
}