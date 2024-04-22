namespace TestingLab.Data.Entities
{
    public class ActiveTestsEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime JoinedToTest { get; set; } = DateTime.Now;
        public UserEntity User { get; set; }
        public TestRequestEntity TestRequest { get; set; }

    }
}
// Tabela łącznikowa relacji user - test, bo user może robić wiele testów, a test może mieć wiele aktywnych użytkowników