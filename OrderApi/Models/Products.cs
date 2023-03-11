using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models
{
    public class Products
    {
        [Key]
        public int IdProduct { get; set; }

        [MaxLength(50)]
        public string ImageUrl { get; set; }
        [MaxLength(50)]
        public string ProductName { get; set; }
        public ICollection<Orders> Order { get; set; }
    }
}
