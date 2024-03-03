namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public string? ProfilePicture { get; set; }
        public Role Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


    }
}
