namespace Testamente.Models
{
    public class Testator
    {
        public string? Name { get; set; }
        public Gender Gender { get; set; } = Gender.Other;
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
