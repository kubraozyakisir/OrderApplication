using OrderApi.Models.SubModel;

namespace OrderApi.Business.Interfaces
{
    public interface IOrderBusiness
    {
        void Create(RequestOrders request);
        void Delete(int IdOrder);
        ResponseOrders_Get Get(int id);
        List<ResponseOrders_GetAll> GetAll();
        void Update(RequestOrders request);
    }
}
