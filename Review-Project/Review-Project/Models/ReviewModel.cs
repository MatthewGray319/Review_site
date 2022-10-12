namespace Review_Project.Models
{
    public class ReviewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Content { get; set; }

        public virtual List<Product>? Products { get; set; }
        public int ProductID { get; set; }
    }
}
