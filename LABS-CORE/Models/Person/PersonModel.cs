namespace LABS_CORE.Models.Person;

public class PersonModel
{

    public PersonModel()
    {
        
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public GenderEnum Gender { get; set; }
    public string City { get; set; }

    public List<PersonModel> GetPersons()
    {
        return new List<PersonModel>()
        {
            new PersonModel()
            {
                Id = 1,
                Name = "John",
                Gender = GenderEnum.Male,
                City = "New York",
            },
            new PersonModel()
            {
                Id = 2,
                Name = "weronika",
                Gender = GenderEnum.Female,
                City = "Rzeszow",
            },
            new PersonModel()
            {
                Id = 3,
                Name = "Mati",
                Gender = GenderEnum.Other,
                City = "Rzeszow",
            },
        };
    }
}