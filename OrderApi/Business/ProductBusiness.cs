using AutoMapper;
using OrderApi.Business.Interfaces;
using OrderApi.Models.SubModel;
using OrderApi.Models;
using OrderApi.Repository.Interfaces;

namespace OrderApi.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;
        public readonly OrderDbContext _db;
        //buraya validationhelper eklenecek
        public ProductBusiness(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public ResponseProducts_Get Get(int id)
        {
            return _repository.Get(id);
        }
        public List<ResponseProducts_GetAll> GetAll()
        {
            return _repository.GetAll();
        }
        public void Create(RequestProducts request)
        {
            var result = _mapper.Map<Products>(request);
            _db.Add(result);

        }
        public void Update(RequestProducts request)
        {
            var result = _mapper.Map<Products>(request);
            _db.Update(result);
        }
        public void Delete(int IdProduct)
        {
            var result = _mapper.Map<Products>(IdProduct);
            _db.Remove(result);

        }
    }
}
