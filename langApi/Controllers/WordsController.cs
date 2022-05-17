using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace langApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        WordsDbContext _wrd;

        public WordsController(WordsDbContext context)
        {
            _wrd = context;
        }
        // GET: api/<WordsController>
        [HttpGet]
        public IEnumerable<Words> Get()
        {
            return _wrd.Words.ToList();
        }

        // GET api/<WordsController>/5
        [HttpGet("{id}")]
        public Words Get(int id)
        {
            return _wrd.Words.FirstOrDefault(c => c.Id == id);

        }

        // POST api/<WordsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WordsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WordsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
