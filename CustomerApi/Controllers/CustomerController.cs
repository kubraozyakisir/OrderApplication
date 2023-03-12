using CustomerApi.Business.Interfaces;
using CustomerApi.Models;
using CustomerApi.Models.SubModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerBusiness _business;

        public CustomerController(ICustomerBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        [Route("[action]/{IdCustomer}")]
        public ResponseCustomers_Get Get(int IdCustomer) => _business.Get(IdCustomer);

        [HttpGet]
        [Route("[action]")]
        public List<ResponseCustomers_GetAll> GetAll() => _business.GetAll();

        [HttpPost]
        [Route("[action]")]
        public void Create(RequestCustomers request) => _business.Create(request);

        [HttpPut]
        [Route("[action]")]
        public void Update(RequestCustomers request) => _business.Update(request);

        [HttpDelete]
        [Route("[action]/{IdCustomer}")]
        public void Delete(int IdCustomer) => _business.Delete(IdCustomer);

    }
}
