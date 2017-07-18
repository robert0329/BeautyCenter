using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BeautyCenterCore.Data
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
