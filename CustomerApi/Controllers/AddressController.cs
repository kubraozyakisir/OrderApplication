using CustomerApi.Business.Interfaces;
using CustomerApi.Models.SubModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
         private readonly IAddressBusiness _business;
       
         public AddressController(IAddressBusiness business)
         {
             _business = business;
         }
       
         [HttpGet]
         [Route("[action]/{IdAddress}")]
         public ResponseAddresses_Get Get(int IdAddress) => _business.Get(IdAddress);
       
         [HttpGet]
         [Route("[action]")]
         public List<ResponseAddresses_GetAll> GetAll() => _business.GetAll();
       
         [HttpPost]
         [Route("[action]")]
         public void Create(RequestAddresses request) => _business.Create(request);
       
         [HttpPut]
         [Route("[action]")]
         public void Update(RequestAddresses request) => _business.Update(request);
     
         [HttpDelete]
         [Route("[action]/{IdAddress}")]
         public void Delete(int IdAddress) => _business.Delete(IdAddress);
    }
}
