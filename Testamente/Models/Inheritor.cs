namespace Testamente.Models
{
    public enum InheritancePriority
    {
       First, Second, Third, Fourth
    }
    public enum Gender
    {
        Male, Female, Other
    }
    public class Inheritor
    {
        public string? Name { get; set; }
        public Gender Gender { get; set; } = Gender.Other;
        public InheritancePriority? InheritancePriority { get; set; }
        public string? Relation { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }


        public Inheritor(string? name, Gender gender, InheritancePriority? inheritancePriority, string? relation, int age, string? address)
        {
            Name = name;
            Gender = gender;
            InheritancePriority = inheritancePriority;
            Relation = relation;
            Age = age;
            Address = address;
        }
    }
}
