namespace Review_Project.Models
{
    public class ProductReview
    {
        public int Id { get; set; }
        public int ReviewId { get; set; }
        public virtual ReviewModel Review { get; set; }
        public int ProductId { get; set; }
        public virtual Product Products {get; set;}
    }
}
