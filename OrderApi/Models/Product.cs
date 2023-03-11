using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [MaxLength(50)]
        public string ImageUrl { get; set; }
        [MaxLength(50)]
        public string ProductName { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
