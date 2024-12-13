namespace Testamente.Models
{
    public enum InheritancePriority
    {
       First, Second, Third, Fourth
    }
    
    public class Inheritor : Person
    {
        public InheritancePriority? InheritancePriority { get; set; }
        public string? Relation { get; set; }
        public DateOnly? Birthdate { get; set; }
        public string? Address { get; set; }
        public float Percentage { get; set; }

        public Inheritor()
        {
        }

        public Inheritor(string? name, Gender gender, InheritancePriority? inheritancePriority, string? relation, DateOnly? birthdate, string? address)
        {
            Name = name;
            Gender = gender;
            InheritancePriority = inheritancePriority;
            Relation = relation;
            Birthdate = birthdate;
            Address = address;
        }
    }
}
