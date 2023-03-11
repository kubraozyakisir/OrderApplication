using CustomerApi.Models.SubModel;

namespace CustomerApi.Business.Interfaces
{
    public interface ICustomerBusiness
    {
        void Create(RequestCustomers request);
        void Delete(int IdCustomer);
        ResponseCustomers_Get Get(int id);
        List<ResponseCustomers_GetAll> GetAll();
        void Update(RequestCustomers request);
    }
}
