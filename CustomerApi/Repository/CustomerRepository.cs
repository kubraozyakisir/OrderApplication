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
        public List<Customers> GetAll() => db.Customers.ToList();
        public Customers Update(Customers customer)
        {
            db.Customers.Update(customer);
            db.SaveChanges();
            return db.Customers.Where(x => x.IdCustomer == customer.IdCustomer).FirstOrDefault();
        }
        public List<Customers> Add(Customers customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return db.Customers.ToList();
        }
        public Customers GetCustomer(int id)
        {
            return db.Customers.Where(x => x.IdCustomer == id).FirstOrDefault();
        }

    }
}
