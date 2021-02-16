using Microsoft.AspNetCore.Mvc;
using PetsControl.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetsControl.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        // GET: api/<PetsController>
        [HttpGet("GetAll")]
        public IEnumerable<Pet> GetAll()
        {
            return new List<Pet>()
            {
                new Pet() { Name = "Fenrir", Race = "Ragdoll", BirthDate = DateTime.Now }
            };
        }

        // GET api/<PetsController>/5
        [HttpGet("{id}")]
        public Pet Get(int id)
        {
            return new Pet() { Name = "Fenrir", Race = "Ragdoll", BirthDate = DateTime.Now };
        }

        // POST api/<PetsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PetsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
