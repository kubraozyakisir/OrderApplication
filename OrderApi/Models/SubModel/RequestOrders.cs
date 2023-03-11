using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models.SubModel
{
    public class RequestOrders : IValidatableObject
    {
        [Min(0)]
        public int IdProduct { get; set; }

        [StringLength(50)]
        public string ImageUrl { get; set; }
        [StringLength(50)]
        public string ProductName { get; set; }
      

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            Validator.TryValidateProperty(IdProduct, new ValidationContext(this, null, null) { MemberName = "IdProduct" }, results);
            Validator.TryValidateProperty(ImageUrl, new ValidationContext(this, null, null) { MemberName = "ImageUrl" }, results);
            Validator.TryValidateProperty(ProductName, new ValidationContext(this, null, null) { MemberName = "ProductName" }, results);            return results;
        }
    }
}