using AutoMapper;
using CustomerApi.Business.Interfaces;
using CustomerApi.Models;
using CustomerApi.Models.SubModel;
using CustomerApi.Repository.Interfaces;

namespace CustomerApi.Business
{
    public class AddressBusiness : IAddressBusiness
    {
        private readonly IAddressRepository _repository;
        private readonly IMapper _mapper;
        public readonly CustomerDbContext _db;
         public AddressBusiness(IAddressRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }
        public ResponseAddresses_Get Get(int id)
        {
            return _repository.Get(id);
        }
        public List<ResponseAddresses_GetAll> GetAll()
        {
            return _repository.GetAll();
        }
        public void Create(RequestAddresses request)
        {
            var result = _mapper.Map<Addresses>(request);
            if(result.IdAddress==0)
            {
                result.IdAddress = 0;
                _db.Add(result);
            }
        }
        public void Update(RequestAddresses request)
        {
            var result = _mapper.Map<Addresses>(request);
            _db.Update(result);
        }
        public void Delete(int IdAddress)
        {
            var result = _mapper.Map<Addresses>(IdAddress);
            _db.Remove(result);

        }
    }
}
