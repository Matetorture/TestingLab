namespace TestingLab.Data.Entities;

public class TestReviewEntity
{
    public int Id { get; set; }
    public TestRequestEntity? TestRequestEntity { get; set; }
    public UserEntity? UserEntity { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}
