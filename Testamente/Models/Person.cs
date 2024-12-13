namespace Testamente.Models
{
    public enum Gender
    {
        Male, Female, Other
    }

    public class Person
    {
        public string? Name { get; set; }
        public Gender Gender { get; set; } = Gender.Other;

        public List<Inheritor> Inheritors { get; set; } = new List<Inheritor>();
    }
}
