using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Models.SubModel
{
    public class RequestAddresses : IValidatableObject
    {
        [Range(0, int.MaxValue)]
        public int IdAddress { get; set; }

        [StringLength(100)]
        public string AddressLine { get; set; }
        [StringLength(20)]
        public string City { get; set; }
        [StringLength(20)]
        public string Country { get; set; }
        [StringLength(20)]
        public string Code { get; set; }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            Validator.TryValidateProperty(IdAddress, new ValidationContext(this, null, null) { MemberName = "IdAddress" }, results);
            Validator.TryValidateProperty(AddressLine, new ValidationContext(this, null, null) { MemberName = "AddressLine" }, results);
            Validator.TryValidateProperty(City, new ValidationContext(this, null, null) { MemberName = "City" }, results);
            Validator.TryValidateProperty(Country, new ValidationContext(this, null, null) { MemberName = "Country" }, results);
            Validator.TryValidateProperty(Code, new ValidationContext(this, null, null) { MemberName = "Code" }, results);
            
            return results;
        }
    }
}