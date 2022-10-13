namespace Review_Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public virtual List<Review>? Reviews { get; set; }
        public string Description { get; set; }
    }

    public class Review
    {
    }
}
