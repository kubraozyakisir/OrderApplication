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
        public ActionResult<IEnumerable<Customers>> GetAll()
        {
            return _customerDbContext.Customers;
        }
        [HttpGet("{IdCustomer:int}")]
        public  async Task<ActionResult<Customers>> GetCustomer(int IdCustomer)
        {
           var customer = await _customerDbContext.Customers.FindAsync(IdCustomer);
            return customer;
        }
        [HttpPost]
        public async Task<ActionResult<Customers>> Create(Customers customer)
        {
            await _customerDbContext.Customers.AddAsync(customer);
            await _customerDbContext.SaveChangesAsync();
                return Ok();
             
        }
        [HttpPut]
        public async Task<ActionResult<Customers>> Update(Customers customer)
        {
             _customerDbContext.Customers.Update(customer);
            await _customerDbContext.SaveChangesAsync();
                return Ok();

        }
        [HttpDelete("{IdCustomer:int}")]
        public async Task<ActionResult<Customers>> Delete(int IdCustomer)
        {
            var customer = await _customerDbContext.Customers.FindAsync(IdCustomer);
            _customerDbContext.Customers.Remove(customer);
            await _customerDbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
