namespace Testamente.Models
{
    public enum Gender
    {
        Male, Female, Other
    }

    public class Person
    {
        public int Id { get; set; }

        public string Birthday { get; set; }
		public string? Name { get; set; }
        public Gender Gender { get; set; } = Gender.Other;
        public List<Person> Inheritors { get; set; } = new List<Person> ();

        public float Percentage { get; set; }
    }
}
