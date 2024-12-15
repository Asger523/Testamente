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

        public Inheritor()
        {
        }

        // For presentation/testing purposes
        public Inheritor (string? name, float newPercentage = 0f) // Optional parameter, fordi den staar til sidst + faar en "standardvaerdi"
        {
            Name = name;
            Percentage = newPercentage;
        }

        // For presentation/testing purposes
        public Inheritor (string? name, List<Person> inheritorees, float newPercentage = 0f)
        {
            Name = name;
            Inheritors = inheritorees;
            Percentage = newPercentage;
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
