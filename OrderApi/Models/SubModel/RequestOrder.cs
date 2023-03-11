using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models.SubModel
{
    public class RequestOrder : IValidatableObject
    {
        [Min(0)]
        public int IdOrder { get; set; }

        [Min(0)]
        public int IdCustomer { get; set; }

        [Min(0)]
        public int Quantity { get; set; }
        [Min(0)]
        public double Price { get; set; }
        [StringLength(50)]
        public string OrderStatus { get; set; }
        [Min(0)]
        public int IdAddress { get; set; }
        // Foreign key property
        [Min(0)]
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