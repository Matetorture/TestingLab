using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestingLab.Data.Entities;

namespace TestingLab.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        DbSet<UserEntity>? UserEntities { get; set; }
        DbSet<TestRequestEntity>? TestRequestEntities { get; set; }
        DbSet<TestReviewEntity>? TestReviewEntities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
