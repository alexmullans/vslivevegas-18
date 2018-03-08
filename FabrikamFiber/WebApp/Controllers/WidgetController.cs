using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Widget")]
    public class WidgetController : Controller
    {
        // GET: api/Widget
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Widgets" };
        }

        // GET: api/Widget/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "Widget " + id;
        }

        // POST: api/Widget
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Widget/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
