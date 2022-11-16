using DCartAPI.Models.Products.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DCartAPI.Models.Products
{
    public class Product : IProduct
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string? ProductName { get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal ProductPrice { get; set; }
     
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        [Required(ErrorMessage = "Quantity is required")]
        public int QuantityInStock { get; set; }

        [Display(Name = "Poster Image Url")]
        public string? PosterImageUrl { get; set; }

        public SubCategory? SubCategory { get; set; }
        [Required]
        public int SubCategoryId { get; set; }
        public bool IsFeatured { get; set; }


    }
}
