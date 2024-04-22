using Microsoft.AspNetCore.Identity;

namespace TestingLab.Data.Entities;

public class UserEntity : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<TestRequestEntity>? TestRequests { get; set; }
    public  ICollection<TestReviewEntity>? TestReviews { get; set;}
    public ICollection<ActiveTestsEntity>? ActiveTests { get; set; }

}
