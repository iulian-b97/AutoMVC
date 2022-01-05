namespace IdentityManagement.Application.Features.User.Commands.Register
{
    public class UserRegistrationDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
    }
}
