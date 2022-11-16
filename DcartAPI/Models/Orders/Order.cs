using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DCartAPI.Models.Orders
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public Guid UserId { get; set; }

        public string? State { get; set; }
        //public Payment payment {get; set;}
        public string? CustomerFirstName { get; set; }
        public string? CustomerLastName { get; set; }
        public int? PaymentId { get; set; }
        //public Address? Address { get; set; }
        public int? AddressId { get; set; }
        public DateTime? DateAdded { get; set; }
        public string? Comment { get; set; }

        public List<OrderItem>? OrderItem { get; set; }
        [Precision(18, 2)]
        public decimal TotalAmount { get; set; }



    }
}
