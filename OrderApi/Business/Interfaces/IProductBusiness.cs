using OrderApi.Models.SubModel;

namespace OrderApi.Business.Interfaces
{
    public interface IProductBusiness
    {
        void Create(RequestProducts request);
        void Delete(int IdProduct);
        ResponseProducts_Get Get(int id);
        List<ResponseProducts_GetAll> GetAll();
        void Update(RequestProducts request);
    }
}
