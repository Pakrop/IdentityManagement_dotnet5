using Microsoft.AspNetCore.Identity;

namespace IdentityManagement_dotnet5.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
