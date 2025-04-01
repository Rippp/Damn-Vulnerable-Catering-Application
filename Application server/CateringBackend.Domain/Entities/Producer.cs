using System;

namespace CateringBackend.Domain.Entities
{
    public class Producer
    {
        public Guid Id  { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public static Producer Create(string email, string password)
        {
            return new()
            {
                Email = email,
                Password = password,
            };
        }
    }
}
