namespace MapperlyTest.Entities
{
    internal record AdminEntity : BaseEntity
    {
        public string? Token { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string[]? Groups { get; set; }
    }
}
