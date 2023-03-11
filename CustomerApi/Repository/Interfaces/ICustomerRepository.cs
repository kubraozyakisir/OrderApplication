using CustomerApi.Models;

namespace CustomerApi.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> Add(Customer customer);
        List<Customer> GetAll();
        Customer GetCustomer(int id);
        Customer Update(Customer customer);
    }
}
