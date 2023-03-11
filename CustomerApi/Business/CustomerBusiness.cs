using AutoMapper;
using CustomerApi.Models.SubModel;
using CustomerApi.Models;
using CustomerApi.Repository.Interfaces;
using CustomerApi.Business.Interfaces;

namespace CustomerApi.Business
{
    public class CustomerBusiness : ICustomerBusiness
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;
        public readonly CustomerDbContext _db;
        //buraya validationhelper eklenecek
        public CustomerBusiness(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public ResponseCustomers_Get Get(int id)
        {
            return _repository.Get(id);
        }
        public List<ResponseCustomers_GetAll> GetAll()
        {
            return _repository.GetAll();
        }
        public void Create(RequestCustomers request)
        {
            var result = _mapper.Map<Customers>(request);
            _db.Add(result);

        }
        public void Update(RequestCustomers request)
        {
            var result = _mapper.Map<Customers>(request);
            _db.Update(result);
        }
        public void Delete(int IdCustomer)
        {
            var result = _mapper.Map<Customers>(IdCustomer);
            _db.Remove(result);

        }
    }
}
