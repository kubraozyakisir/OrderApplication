namespace OrderApi.Models.SubModel
{
    public class ResponseOrder
    {
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public string Quantity { get; set; }
        public double Price { get; set; }
        public string OrderStatus { get; set; }
        public int IdAddress { get; set; }
        public int IdProduct { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class ResponseOrder_Get
    {
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public string Quantity { get; set; }
        public double Price { get; set; }
        public string OrderStatus { get; set; }
        public int IdAddress { get; set; }
        public int IdProduct { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class ResponseOrder_GetAll
    {
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public string Quantity { get; set; }
        public double Price { get; set; }
        public string OrderStatus { get; set; }
        public int IdAddress { get; set; }
        public int IdProduct { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

}


 