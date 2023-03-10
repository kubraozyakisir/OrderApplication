using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Models
{
    public class Addresses
    {
        public int IdAddress { get; set; }
        [MaxLength(100)]
        public string AddressLine { get; set; }
        [MaxLength(20)]
        public string City { get; set; }
        [MaxLength(20)]
        public string Country { get; set; }
        [MaxLength(20)]
        public string Code { get; set; }
        // Navigation property
        public ICollection<Customers> Customer { get; set; }
    }
}
