namespace OrderApi.Models.SubModel
{
    public class ResponseOrders
    {
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
        public string OrderStatus { get; set; }
        public int IdAddress { get; set; }
        public int IdProduct { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class ResponseOrders_Get
    {
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
        public string OrderStatus { get; set; }
        public int IdAddress { get; set; }
        public int IdProduct { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

    public class ResponseOrders_GetAll
    {
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
        public string OrderStatus { get; set; }
        public int IdAddress { get; set; }
        public int IdProduct { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

}


 