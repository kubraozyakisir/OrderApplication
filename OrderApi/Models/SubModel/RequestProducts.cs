//using Microsoft.AspNetCore.Mvc.DataAnnotations;  min(0) için gerekli olan bu kütüphane, .net core 6 ile uyumlu değil
using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models.SubModel
{
    public class RequestProducts : IValidatableObject
    {
    
        [Range(0, int.MaxValue)]
        public int IdOrder { get; set; }

        [Range(0, int.MaxValue)]
        public int IdCustomer { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
        [StringLength(50)]
        public string OrderStatus { get; set; }
        [Range(0, int.MaxValue)]
        public int IdAddress { get; set; }
        // Foreign key property
        [Range(0, int.MaxValue)]
        public int IdProduct { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            Validator.TryValidateProperty(IdOrder, new ValidationContext(this, null, null) { MemberName = "IdOrder" }, results);
            Validator.TryValidateProperty(IdCustomer, new ValidationContext(this, null, null) { MemberName = "IdCustomer" }, results);
            Validator.TryValidateProperty(Quantity, new ValidationContext(this, null, null) { MemberName = "Quantity" }, results);
            Validator.TryValidateProperty(Price, new ValidationContext(this, null, null) { MemberName = "Price" }, results);
            Validator.TryValidateProperty(OrderStatus, new ValidationContext(this, null, null) { MemberName = "OrderStatus" }, results);
            Validator.TryValidateProperty(IdAddress, new ValidationContext(this, null, null) { MemberName = "IdAddress" }, results);
            Validator.TryValidateProperty(IdProduct, new ValidationContext(this, null, null) { MemberName = "IdProduct" }, results);

            return results;
        }
    }
}