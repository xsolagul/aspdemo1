namespace WebApplication2.Models
{
    public class Brand:IEntity
    {
        [Column("brandId")]
        public int Id { get; set; }
        public string name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
