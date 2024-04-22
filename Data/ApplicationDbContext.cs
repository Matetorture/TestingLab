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
        DbSet<TestReviewEntity>? ActiveTestsEntity { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserEntity>().HasMany(n => n.TestRequests).WithOne(n => n.Author).HasForeignKey(n => n.UserId);
            builder.Entity<UserEntity>().HasMany(n => n.TestReviews).WithOne(n => n.UserEntity).HasForeignKey(n => n.UserId);
            builder.Entity<UserEntity>().HasMany(n => n.ActiveTests).WithOne(n => n.User).HasForeignKey(n => n.UserId);
            builder.Entity<TestRequestEntity>().HasMany(n => n.TestReviewEntity).WithOne(n => n.TestRequestEntity).HasForeignKey(n => n.Id);
            builder.Entity<TestRequestEntity>().HasMany(n => n.ActiveTesters).WithOne(n => n.TestRequest).HasForeignKey(n => n.Id);
        }
        /// dodane klucze przy tworzeniu bazy danych
    }
}
