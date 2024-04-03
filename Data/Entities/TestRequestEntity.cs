namespace TestingLab.Data.Entities;

public class TestRequestEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public UserEntity Author { get; set; }
    public DateTime CreatedAt { get; set; }
}
