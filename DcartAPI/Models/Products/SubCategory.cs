using System.ComponentModel.DataAnnotations;

namespace DCartAPI.Models.Products
{
    public class SubCategory
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public string? PosterImageUrl { get; set; }
        public MainCategory? MainCategory { get; set; }
        [Required(ErrorMessage = "SubCategory must have a parent")]
        public int MainCategoryId { get; set; }

        public List<Product>? Products { get; set; }

    }
}
