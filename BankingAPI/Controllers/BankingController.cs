using Banking.Application;
using Banking.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankingController : ControllerBase
    {
        private IBankingService _bankingService;

        public BankingController(IBankingService bankingService)
        {
            _bankingService = bankingService;

        }
        // GET: api/<BankingController>
        [HttpGet]
        public ActionResult CreateCustomerAccount(Customer customer)
        {
            _bankingService.CreateCustomerAccount(customer);

            return Ok();
        }

        // GET api/<BankingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BankingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BankingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BankingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
