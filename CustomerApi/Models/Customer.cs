using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerApi.Models
{
    public class Customer
    {
        [Key]
        public int IdCustomer { get; set; }
        [MaxLength(50)]
        public string CustomerName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        // Foreign key property
        public int IdAddress { get; set; }
        public Address Address { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        

    }
}
