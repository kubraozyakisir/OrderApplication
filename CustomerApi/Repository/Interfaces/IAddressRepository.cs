using CustomerApi.Models.SubModel;

namespace CustomerApi.Repository.Interfaces
{
    public interface IAddressRepository
    {
        ResponseAddresses_Get Get(int IdAddress);
        List<ResponseAddresses_GetAll> GetAll();
    }
}
