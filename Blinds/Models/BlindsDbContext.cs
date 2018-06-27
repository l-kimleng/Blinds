using Microsoft.AspNet.Identity.EntityFramework;

namespace Blinds.Models
{
    public class BlindsDbContext : IdentityDbContext<ApplicationUser>
    {
        public BlindsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static BlindsDbContext Create()
        {
            return new BlindsDbContext();
        }
    }
}