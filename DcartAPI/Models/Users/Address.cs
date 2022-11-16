using System.ComponentModel.DataAnnotations.Schema;

namespace DCartAPI.Models.Users
{
    public class Address
    {

        public Guid Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public User? User { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }


    }
}
