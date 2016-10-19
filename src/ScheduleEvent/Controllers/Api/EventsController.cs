using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScheduleEvent.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ScheduleEvent.Controllers.Api
{
    [Route("api/events")]
    public class EventsController : Controller
    {
        private readonly IScheduleRepository _repository;

        public EventsController(IScheduleRepository repository)
        {
            _repository = repository;
        }

        // GET: api/values
        [HttpGet("")]
        public async Task<IEnumerable<Event>> GetAll()
        {
            return await _repository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}",Name = "GetEvent")]
        public async Task<IActionResult> GetById(int id)
        {
            var item =await _repository.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
