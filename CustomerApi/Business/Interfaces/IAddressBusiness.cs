using CustomerApi.Models.SubModel;

namespace CustomerApi.Business.Interfaces
{
    public interface IAddressBusiness
    {
        void Create(RequestAddresses request);
        void Delete(int IdAddress);
        ResponseAddresses_Get Get(int id);
        List<ResponseAddresses_GetAll> GetAll();
        void Update(RequestAddresses request);
    }
}
