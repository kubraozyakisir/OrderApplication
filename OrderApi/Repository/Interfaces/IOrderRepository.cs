using OrderApi.Models.SubModel;

namespace OrderApi.Repository.Interfaces
{
    public interface IOrderRepository
    {
        ResponseOrders_Get Get(int IdOrder);
        List<ResponseOrders_GetAll> GetAll();
    }
}
