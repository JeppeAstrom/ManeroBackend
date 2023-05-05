using Microsoft.AspNetCore.Identity;

namespace Manero_Backend.Models.Auth;

public class AppUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}