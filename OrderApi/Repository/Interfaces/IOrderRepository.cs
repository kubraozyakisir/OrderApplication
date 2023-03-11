using OrderApi.Models.SubModel;

namespace OrderApi.Repository.Interfaces
{
    public interface IOrderRepository
    {
        ResponseOrder_Get Get(int IdOrder);
        List<ResponseOrder_GetAll> GetAll();
    }
}
