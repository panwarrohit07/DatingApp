using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoDatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DemoDatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        // Get api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var _values = await _context.Values.ToListAsync();
            return Ok(_values);
        }

        // Get api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

        // Post api/value
        [HttpPost]
        public void Post([FromBody] string value)
        { }

        // Put api/value/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        { }

        // Delete api/value/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        { }
    }
}