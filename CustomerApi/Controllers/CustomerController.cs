using CustomerApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerDbContext _customerDbContext;
        public CustomerController(CustomerDbContext customerDbContext)
        {
            _customerDbContext = customerDbContext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAll()
        {
            return _customerDbContext.Customer;
        }
        [HttpGet("{IdCustomer:int}")]
        public  async Task<ActionResult<Customer>> GetCustomer(int IdCustomer)
        {
           var customer = await _customerDbContext.Customer.FindAsync(IdCustomer);
            return customer;
        }
        [HttpPost]
        public async Task<ActionResult<Customer>> Create(Customer customer)
        {
            await _customerDbContext.Customer.AddAsync(customer);
            await _customerDbContext.SaveChangesAsync();
                return Ok();
             
        }
        [HttpPut]
        public async Task<ActionResult<Customer>> Update(Customer customer)
        {
             _customerDbContext.Customer.Update(customer);
            await _customerDbContext.SaveChangesAsync();
                return Ok();

        }
        [HttpDelete("{IdCustomer:int}")]
        public async Task<ActionResult<Customer>> Delete(int IdCustomer)
        {
            var customer = await _customerDbContext.Customer.FindAsync(IdCustomer);
            _customerDbContext.Customer.Remove(customer);
            await _customerDbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
