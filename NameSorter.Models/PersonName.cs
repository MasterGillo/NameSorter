namespace NameSorter.Models
{
    public class PersonName
    {
        public string LastName { get; set; }
        public string GivenNames { get; set; }

        public PersonName(string lastName, string givenNames)
        {
            LastName = lastName;
            GivenNames = givenNames;
        }

        public string FullName => GivenNames + " " + LastName;
    }
}
