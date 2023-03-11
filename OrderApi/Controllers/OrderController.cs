﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderApi.Business.Interfaces;
using OrderApi.Models;
using OrderApi.Models.SubModel;

namespace OrderApi.Controllers
{
    [Route("api/[controller]")]
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
        public ResponseOrder_Get Get(int IdOrder) => _business.Get(IdOrder);

        [HttpGet]
        [Route("[action]")]
        public List<ResponseOrder_GetAll> GetAll() => _business.GetAll();

        [HttpPost]
        [Route("[action]")]
        public void Create(RequestOrder request) => _business.Create(request);

        [HttpPost]
        [Route("[action]")]
        public void Update(RequestOrder request) => _business.Update(request);

        [HttpPost]
        [Route("[action]/{IdOrder}")]
        public void Delete(int IdOrder) => _business.Delete(IdOrder);

    }
}
