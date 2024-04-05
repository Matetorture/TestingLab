namespace TestingLab.Data.Entities;

public class TestRequestEntity
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? UserId { get; set; } // userId jest stringiem i trzeba utworzyc nowe pole zeby nie bylo niezgodnosci typow
    public UserEntity? UserEntity { get; set; } /// Nazywajmy te pola tak samo, żeby było bardziej przejrzyscie 
    public ICollection<TestReviewEntity>? TestReviewEntity { get; set; }
    public DateTime CreatedAt { get; set; }
}
