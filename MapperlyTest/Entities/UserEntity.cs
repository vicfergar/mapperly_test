namespace MapperlyTest.Entities
{
    internal record UserEntity : BaseEntity
    {
        public string? AuthenticationToken { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
