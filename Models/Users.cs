using Microsoft.AspNetCore.Identity;

namespace VPIS.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
