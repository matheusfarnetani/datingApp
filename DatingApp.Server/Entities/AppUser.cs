namespace DatingApp.Server.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public required string UserName { get; set; }

        // Not 100% secure :/
        // Improvement will come later (this version is simple)
        public required byte[] PasswordHash { get; set; }
        public required byte[] PasswordSalt { get; set; }
    }
}
