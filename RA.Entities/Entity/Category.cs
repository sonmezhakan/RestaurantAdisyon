namespace RA.Entities.Entity
{
    public class Category : ChampaingEntity
    {
        public string CategoryName { get; set; }
        public string? Desription { get; set; }

        public AppUser CreatedUser { get; set; }
        public List<Product> Products { get; set; }
    }
}
