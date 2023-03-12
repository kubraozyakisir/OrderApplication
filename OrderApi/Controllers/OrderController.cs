using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderApi.Business.Interfaces;
using OrderApi.Models;
using OrderApi.Models.SubModel;

namespace OrderApi.Controllers
{
    [Route("orderapi/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderBusiness _business;

        public OrderController(IOrderBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        [Route("[action]/{IdOrder}")]
        public ResponseOrders_Get Get(int IdOrder) => _business.Get(IdOrder);

        [HttpGet]
        [Route("[action]")]
        public List<ResponseOrders_GetAll> GetAll() => _business.GetAll();

        [HttpPost]
        [Route("[action]")]
        public void Create(RequestOrders request) => _business.Create(request);

        [HttpPut]
        [Route("[action]")]
        public void Update(RequestOrders request) => _business.Update(request);

        [HttpDelete]
        [Route("[action]/{IdOrder}")]
        public void Delete(int IdOrder) => _business.Delete(IdOrder);

    }
}
