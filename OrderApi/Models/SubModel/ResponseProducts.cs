namespace OrderApi.Models.SubModel
{
    public class ResponseProducts
    {
        public int IdProduct { get; set; }
        public string ImageUrl { get; set; }
    
        public string ProductName { get; set; }
    }

    public class ResponseProducts_Get
    {
        public int IdProduct { get; set; }
        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
    }

    public class ResponseProducts_GetAll
    {
        public int IdProduct { get; set; }
        public string ImageUrl { get; set; }
         public string ProductName { get; set; }
    }
}
