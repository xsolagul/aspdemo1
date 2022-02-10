namespace WebApplication2.Models
{
    public class Product:IEntity
    {
        [Column("productId")]
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public DateTime manufactureDate { get; set; }
        public string pathPic { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
