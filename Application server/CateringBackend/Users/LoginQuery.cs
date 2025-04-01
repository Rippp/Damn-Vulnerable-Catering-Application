namespace CateringBackend.Users
{
    public record LoginQuery
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
