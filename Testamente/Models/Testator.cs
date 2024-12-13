namespace Testamente.Models
{
    public class Testator : Person
    {
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public Testator ()
        {

        }

        public Testator (string? newName)
        {
            Name = newName;
        }

        public Testator (string? phoneNumber, string? email)
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
