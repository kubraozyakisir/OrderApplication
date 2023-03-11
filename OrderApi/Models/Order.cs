using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderApi.Models
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }

        public int IdCustomer { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
        [MaxLength(50)]
        public string OrderStatus { get; set; }
        public int IdAddress { get; set; }
        // Foreign key property
        public int IdProduct { get; set; }
       
        public Product Product { get; set; }

        //CreatedDate has getdate() method
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        //updated has a trigger
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
