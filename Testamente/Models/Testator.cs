﻿namespace Testamente.Models
{
    
    public enum RelationshipStatus
    {
        Sammenboende,

        Gift,

        Ugift,

        Eneboende,

        IngenBørn,

        SammenboendeMedBørn

    }

    
    
    
    public class Testator : Person
    {
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        public RelationshipStatus RelationshipStatus { get; set; } 


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

        // For presentation/testing purposes
        public Testator (string? newName, List<Person> newInheritors, float newPercentage = 0f)
        {
            Name = newName;
            Inheritors = newInheritors;

            Percentage = newPercentage;
        }
    }
}
