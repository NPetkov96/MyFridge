using Microsoft.AspNetCore.Identity;

namespace MyFridge.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public List<UserProduct> UserProducts { get; set; } = new List<UserProduct>();

    }
}
