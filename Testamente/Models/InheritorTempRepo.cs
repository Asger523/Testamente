namespace Testamente.Models
{
    public static class InheritorTempRepo
    {
        // Intet data må persistere, når brugeren forlader siden.

        /*   public string? Name { get; set; }
        public Gender Gender { get; set; } = Gender.Other;
        public InheritancePriority? InheritancePriority { get; set; }
        public string? Relation { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        */

        private static List<Inheritor> inheritors = new List<Inheritor>
        {
                 new Inheritor ("Torben Torbensen", Gender.Male, InheritancePriority.First, "Son", new DateOnly(1985,03,27), "Hurtigvej 44, 5000 Odense"),
                  new Inheritor ("Karstine Torbensen", Gender.Other, InheritancePriority.First, "Both", new DateOnly(1990,06,30), "Hurtigvej 50, 5000 Odense"),
        };

        public static void AddInheritor(Inheritor inheritor)
        {
            inheritors.Add(inheritor);
        }

        public static List<Inheritor> GetInheritors() => inheritors;

        // We could possibly have more Inheritors in our list with the same name
        // If so, this will always only return the first person, which can be a problem if
        // we want the second or subsequent people instead
        // TL;DR Fix later!
        public static Inheritor GetInheritorByName(string inheritorName) => inheritors.First(i => i.Name.Equals(inheritorName, StringComparison.OrdinalIgnoreCase));

        //public static Inheritor? GetInheritorByName(int id)
        //{
        //    var inheritor = inheritors.FirstOrDefault(i => i.Name == name); //Dan fucker det her
        //    if (inheritor != null)
        //    {
        //        return new Inheritor
        //        {
        //            Id = inheritor.Id,
        //            Name = inheritor.Name,
        //            City = inheritor.City,
        //            IsOnline = inheritor.IsOnline
        //        };
        //    }
        //    return null;
        //}

        // Vi søger på navne, det kan måske skabe problemer i forhold til, at 2 mennesker godt kan hedde det samme.
        public static void UpdateInheritor(string inheritorName, Inheritor inheritor)
        {
            if (inheritorName != inheritor.Name) return;

            var inheritorToUpdate = inheritors.FirstOrDefault(i => i.Name == inheritorName);
            if (inheritorToUpdate != null)
            {
                inheritorToUpdate.Name = inheritor.Name;
                inheritorToUpdate.Gender = inheritor.Gender;
                inheritorToUpdate.InheritancePriority = inheritor.InheritancePriority;
                inheritorToUpdate.Relation = inheritor.Relation;
                inheritorToUpdate.Birthdate = inheritor.Birthdate;
                inheritorToUpdate.Address = inheritor.Address;
            }
        }

        public static void DeleteInheritor(string inheritorName)
        {
            var inheritor = inheritors.FirstOrDefault(i => i.Name == inheritorName);
            if (inheritor != null)
                inheritors.Remove(inheritor);
        }

        //public static List<Inheritor> SearchServers(string serverFilter) => inheritors.Where(s => s.Name.Contains(serverFilter, StringComparison.OrdinalIgnoreCase)).ToList();

        //public static List<Inheritor> GetRandomServerList()
        //{
        //    List<Inheritor> result = new List<Inheritor>();
        //    for (int i = 0; i < new Random().Next(0, inheritors.Count); i++)
        //    {
        //        if (new Random().Next(0, 2) == 1)
        //            result.Add(inheritors[i]);
        //    }
        //    return result;
        //}
    }
}
