using System.ComponentModel.DataAnnotations;

namespace CustomerApi.Models.SubModel
{
    public class ResponseCustomers
    {
        public int IdCustomer { get; set; }
       
        public string CustomerName { get; set; }
 
        public string Email { get; set; }
  
        public int IdAddress { get; set; }
        public DateTime CreatedDate { get; set; }
   
        public DateTime UpdatedDate { get; set; }
    }
    public class ResponseCustomers_Get
    {
         public int IdCustomer { get; set; }

        public string CustomerName { get; set; }

        public string Email { get; set; }

        public string AddressLine { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

    }
    public class ResponseCustomers_GetAll
    {
        [Key]
        public int IdCustomer { get; set; }

        public string CustomerName { get; set; }

        public string Email { get; set; }

        public string AddressLine { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
