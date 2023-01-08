using api_web.Models;
using api_web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace api_web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _Service;

        public StudentController(StudentService studentService)
        {
            _Service = studentService;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public ActionResult<List<Student>> Get()
        {
            return _Service.Get();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id:length(24)}")]
        public ActionResult<Student> Get(string id)
        {
            return _Service.Get(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public ActionResult<Student> Post([FromBody] Student value)
        {
            var Result = _Service.Create(value);
            return Result;
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id:length(24)}")]
        public void Put(string id, [FromBody] Student value)
        {
            _Service.Update(id, value);
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id:length(24)}")]
        public void Delete(string id)
        {
            _Service.Remove(id);
        }
    }
}
