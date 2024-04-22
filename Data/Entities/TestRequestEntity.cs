namespace TestingLab.Data.Entities;

public class TestRequestEntity
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? UserId { get; set; } 
    public UserEntity Author { get; set; }
    public ICollection<ActiveTestsEntity>? ActiveTesters { get; set; } 
    public ICollection<TestReviewEntity>? TestReviewEntity { get; set; }
    public DateTime CreatedAt { get; set; }
}
