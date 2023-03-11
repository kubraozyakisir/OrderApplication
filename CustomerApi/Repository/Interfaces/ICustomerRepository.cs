using CustomerApi.Models.SubModel;

namespace CustomerApi.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        ResponseCustomers_Get Get(int IdCustomer);
        List<ResponseCustomers_GetAll> GetAll();
    }
}
