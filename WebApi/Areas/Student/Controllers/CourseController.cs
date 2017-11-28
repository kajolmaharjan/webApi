using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Areas.Student.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Areas.Student.Controllers
{
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private readonly RegistrationContext _context;

        public CourseController(RegistrationContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _context.Course.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var course = _context.Course.FirstOrDefault(t => t.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            return new ObjectResult(course);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Course course)
        {
            if (course == null)
            {
                return BadRequest();
            }

            _context.Course.Add(course);
            _context.SaveChanges();

            return new ObjectResult(course);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Course course)
        {
            if (course == null || course.CourseId != id)
            {
                return BadRequest();
            }

            var item = _context.Course.FirstOrDefault(t => t.CourseId == id);

            item.CourseName = course.CourseName;
            item.StartDate = course.StartDate;
            item.EndDate = course.EndDate;

            _context.Course.Update(item);
            _context.SaveChanges();
            return new ObjectResult(item);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var course = _context.Course.FirstOrDefault(t => t.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }

            _context.Course.Remove(course);
            _context.SaveChanges();
            return new ObjectResult(course);
        }
    }
}
