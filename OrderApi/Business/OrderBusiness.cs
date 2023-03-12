using AutoMapper;
using OrderApi.Business.Interfaces;
using OrderApi.Models;
using OrderApi.Models.SubModel;
using OrderApi.Repository.Interfaces;

namespace OrderApi.Business
{
    public class OrderBusiness : IOrderBusiness
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;
        public readonly OrderDbContext _db;
        //buraya validationhelper eklenecek
        public OrderBusiness(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public ResponseOrders_Get Get(int id)
        {
            return _repository.Get(id);
        }
        public List<ResponseOrders_GetAll> GetAll()
        {
            return _repository.GetAll();
        }
        public void Create(RequestOrders request)
        {
            var result = _mapper.Map<Orders>(request);
            result.CreatedDate= DateTime.Now;
            _db.Add(result);

        }
        public void Update(RequestOrders request)
        {
            var result = _mapper.Map<Orders>(request);
            result.UpdatedDate = DateTime.Now;
            _db.Update(result);
        }
        public void Delete(int IdOrder)
        {
            var result = _mapper.Map<Orders>(IdOrder);
            _db.Remove(result);

        }
    }
}
