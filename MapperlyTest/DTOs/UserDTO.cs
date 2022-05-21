namespace MapperlyTest.DTOs
{
    public record UserDTO
    {
        public string? Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public RoleDTO[] Roles { get; set; }
    }
}
