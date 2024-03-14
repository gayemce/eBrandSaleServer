using eBrandSaleServer.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace eBrandSaleServer.Domain.Models;
public sealed class AppUser : IdentityUser<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => string.Join(" ", FirstName, LastName);
    public UserRole UserRole { get; set; } = UserRole.Admin;
}
