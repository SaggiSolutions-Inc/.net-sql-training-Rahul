using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomersWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        static CustomerBO context = new CustomerBO();
        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<CustomerModel> Get()
        {
            return context.GetAll();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public CustomerModel GetById(int id)
        {
            return context.GetById(id);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] CustomerModel c)
        {
            context.Add(c);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CustomerModel c)
        {
            context.Edit(c, id);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            context.Delete(id);
        }
    }
}
