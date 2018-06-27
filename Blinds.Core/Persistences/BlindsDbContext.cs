using System.Data.Entity;
using Blinds.Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Blinds.Core.Persistences
{
    public class BlindsDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Brand> Brands { get; set; }

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