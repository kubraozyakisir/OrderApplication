using CustomerApi.Models;
using CustomerApi.Repository.Interfaces;

namespace CustomerApi.Repository
{
    public class CustomerRepository:ICustomerRepository
    {

        private readonly CustomerDbContext db;

        public CustomerRepository(CustomerDbContext db)
        {
            this.db = db;
        }
        public List<Customer> GetAll() => db.Customer.ToList();
        public Customer Update(Customer customer)
        {
            db.Customer.Update(customer);
            db.SaveChanges();
            return db.Customer.Where(x => x.IdCustomer == customer.IdCustomer).FirstOrDefault();
        }
        public List<Customer> Add(Customer customer)
        {
            db.Customer.Add(customer);
            db.SaveChanges();
            return db.Customer.ToList();
        }
        public Customer GetCustomer(int id)
        {
            return db.Customer.Where(x => x.IdCustomer == id).FirstOrDefault();
        }

    }
}
