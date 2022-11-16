using System.ComponentModel.DataAnnotations;

namespace DCartAPI.Models.Products
{
    public class MainCategory
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public string? PosterImageUrl { get; set; }
        public List<SubCategory>? SubCategories { get; set; }
    }
}
