using Microsoft.AspNetCore.Identity;

namespace WebApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [ProtectedPersonalData]
        public string FirstName { get; set; } = null!;

        [ProtectedPersonalData]
        public string LastName { get; set; } = null!;

        [ProtectedPersonalData]
        public string? Bio { get; set; }

        [ProtectedPersonalData]
        public string? ProfileImageUrl { get; set; } = "avatar.jpg";

        public int? AddressId { get; set; }
        public AddressEntity? Address { get; set; }
    }
}
