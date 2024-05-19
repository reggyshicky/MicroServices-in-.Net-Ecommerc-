using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }


    }
}
