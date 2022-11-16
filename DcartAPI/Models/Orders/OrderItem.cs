using DCartAPI.Models.Carts;
using Microsoft.EntityFrameworkCore;

namespace DCartAPI.Models.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? PictureUrl { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateUppdated { get; set; }
        public int QuantityInCart { get; set; }
        public int SubCategoryId { get; set; }

        public Order? Cart { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
    }
}
