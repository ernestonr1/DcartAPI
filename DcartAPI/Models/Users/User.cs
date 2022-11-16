using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DCartAPI.Models.Users
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public DateTime DateAdded { get; set; } = DateTime.Now;
        public byte[]? ProfilePicture { get; set; }

        public Address? Address { get; set; }
        public int? AddressId { get; set; }

    }
}
