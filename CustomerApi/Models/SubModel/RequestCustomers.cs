using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Models.SubModel
{
    public class RequestCustomers
    {
        [Range(0, int.MaxValue)]
        public int IdCustomer { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Range(0, int.MaxValue)]
        public int IdAddress { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            Validator.TryValidateProperty(IdCustomer, new ValidationContext(this, null, null) { MemberName = "IdCustomer" }, results);
            Validator.TryValidateProperty(CustomerName, new ValidationContext(this, null, null) { MemberName = "CustomerName" }, results);
            Validator.TryValidateProperty(Email, new ValidationContext(this, null, null) { MemberName = "Email" }, results);
            Validator.TryValidateProperty(IdAddress, new ValidationContext(this, null, null) { MemberName = "IdAddress" }, results);

            return results;
        }
    }
}

