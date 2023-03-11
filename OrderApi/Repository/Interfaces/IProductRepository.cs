using OrderApi.Models.SubModel;

namespace OrderApi.Repository.Interfaces
{
    public interface IProductRepository
    {
        ResponseProducts_Get Get(int IdProduct);
        List<ResponseProducts_GetAll> GetAll();
    }
}
