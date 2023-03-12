using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderApi.Business.Interfaces;
using OrderApi.Models.SubModel;

namespace OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBusiness _business;

        public ProductController(IProductBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        [Route("[action]/{IdProduct}")]
        public ResponseProducts_Get Get(int IdProduct) => _business.Get(IdProduct);

        [HttpGet]
        [Route("[action]")]
        public List<ResponseProducts_GetAll> GetAll() => _business.GetAll();

        [HttpPost]
        [Route("[action]")]
        public void Create(RequestProducts request) => _business.Create(request);

        [HttpPut]
        [Route("[action]")]
        public void Update(RequestProducts request) => _business.Update(request);

        [HttpDelete]
        [Route("[action]/{IdProduct}")]
        public void Delete(int IdProduct) => _business.Delete(IdProduct);
    }
}
