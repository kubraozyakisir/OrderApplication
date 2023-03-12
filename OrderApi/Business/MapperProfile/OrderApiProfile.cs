using AutoMapper;
using OrderApi.Models;
using OrderApi.Models.SubModel;

namespace OrderApi.Business.MapperProfile
{
    public class OrderApiProfile:Profile
    {
        public OrderApiProfile()
        {
            #region Order
            CreateMap<Orders, ResponseOrders_Get>();
            CreateMap<Orders, ResponseOrders_GetAll>();
            CreateMap<Orders, RequestOrders>();
            CreateMap<RequestOrders, Orders>();
            #endregion Order

            #region Product
            CreateMap<Products, ResponseProducts_Get>();
            CreateMap<Products, ResponseProducts_GetAll>();
            CreateMap<Products, RequestProducts>();
            CreateMap<RequestProducts, Products>();
            #endregion Product

        }
    }
}
