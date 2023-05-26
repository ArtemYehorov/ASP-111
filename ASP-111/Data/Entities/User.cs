namespace ASP_111.Data.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? ConfirmCode { get; set; }
        public string Login { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string? Avatar { get; set; } = null!;
        public DateTime CreatedDt { get; set; }
        public DateTime? DeletedDt { get; set; }
    }
}

