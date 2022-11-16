using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DCartAPI.Models.Carts
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? SessionId { get; set; }
        public DateTime? DateAdded { get; set; }
        public List<CartItem>? CartItems { get; set; }
        [Precision(18, 2)]
        public decimal? TotalPrice { get; set; }
        public string UserEmail { get; set; }
    }
}
