using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Models.SubModel
{
    public class ResponseAddresses
    {
        public int IdAddress { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
    }
    public class ResponseAddresses_Get
    {
        public int IdAddress { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
    }
    public class ResponseAddresses_GetAll
    {
    
        public int IdAddress { get; set; }

        public string AddressLine { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
    }

}
