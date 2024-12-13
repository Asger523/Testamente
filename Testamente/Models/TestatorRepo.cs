namespace Testamente.Models
{
    public static class TestatorRepo
    {
        // Yoinked direkte fra InheritorTempRepo 10-12-2024

        private static List<Testator> testators = new List<Testator> ()
        {
            new Testator ("Testator")
        };

        public static void AddTestator (Testator testator)
        {
            testators.Add (testator);
        }

        public static List<Testator> GetTestators () => testators;

        // We could possibly have more Testators in our list with the same name
        // If so, this will always only return the first person, which can be a problem if
        // we want the second or subsequent people instead
        // TL;DR Fix later!
        public static Testator GetTestatorByName (string testatorName) => testators.First (i => i.Name.Equals (testatorName, StringComparison.OrdinalIgnoreCase));

        // Vi søger på navne, det kan måske skabe problemer i forhold til, at 2 mennesker godt kan hedde det samme.
        public static void UpdateTestator (string testatorName, Testator testator)
        {
            if (testatorName != testator.Name) return;

            var testatorToUpdate = testators.FirstOrDefault (i => i.Name == testatorName);
            if (testatorToUpdate != null) {
                testatorToUpdate.Name = testator.Name;
                testatorToUpdate.Gender = testator.Gender;
                testatorToUpdate.PhoneNumber = testator.PhoneNumber;
                testatorToUpdate.Email = testator.Email;
               
            }
        }

        public static void DeleteTestator(string testatorName)
        {
            var testator = testators.FirstOrDefault (i => i.Name == testatorName);
            if (testator != null)
                testators.Remove (testator);
        }
    }
}
