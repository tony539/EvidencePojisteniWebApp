using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EvidencePojisteniWebApp.Models;

namespace EvidencePojisteniWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EvidencePojisteniWebApp.Models.Client> Client { get; set; } = default!;
    }
}
