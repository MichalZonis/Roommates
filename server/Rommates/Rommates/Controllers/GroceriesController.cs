﻿using Microsoft.AspNetCore.Mvc;
using Roommates.Logic;
using Roommates.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Roommates.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroceriesController : ControllerBase
    {
        [HttpPost("addItem")]
        public ActionResult<int> addItem([FromBody] Item newItem)
        {
            return ItemsLogic.addItem(newItem);

        }

        // GET: api/<GroceriesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<GroceriesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GroceriesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GroceriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GroceriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
