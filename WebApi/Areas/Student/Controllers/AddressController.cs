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
    public class AddressController : Controller
    {
        private readonly RegistrationContext _context;

        public AddressController(RegistrationContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Address> Get()
        {
            return _context.Address.ToList();
        }

        // GET api/values/5
        public IActionResult Get(int id)
        {
            var address = _context.Address.FirstOrDefault(t => t.AddressId == id);
            if (address == null)
            {
                return NotFound();
            }
            return new ObjectResult(address);
        }
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Address address)
        {
            if (address == null)
            {
                return BadRequest();
            }

            _context.Address.Add(address);
            _context.SaveChanges();
            return new ObjectResult(address);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Address address)
        {
            var addr = _context.Address.FirstOrDefault(t => t.AddressId == id);
            if (address == null || addr.AddressId != id)
            {
                return BadRequest();
            }

            addr.Address1 = address.Address1;
            addr.Address2 = address.Address2;
            addr.City = address.City;

            _context.Address.Update(addr);
            _context.SaveChanges();
            return new ObjectResult(addr);

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var address = _context.Address.FirstOrDefault(t => t.AddressId == id);
            if (address == null)
            {
                return NotFound();
            }

            _context.Address.Remove(address);
            return new NoContentResult();
        }
    }
}
