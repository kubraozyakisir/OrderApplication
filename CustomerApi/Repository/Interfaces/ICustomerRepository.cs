using CustomerApi.Models;

namespace CustomerApi.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customers> Add(Customers customer);
        List<Customers> GetAll();
        Customers GetCustomer(int id);
        Customers Update(Customers customer);
    }
}
