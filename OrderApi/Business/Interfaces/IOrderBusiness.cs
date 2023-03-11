using OrderApi.Models.SubModel;

namespace OrderApi.Business.Interfaces
{
    public interface IOrderBusiness
    {
        void Create(RequestOrders request);
        void Delete(int IdOrder);
        ResponseOrder_Get Get(int id);
        List<ResponseOrder_GetAll> GetAll();
        void Update(RequestOrders request);
    }
}
