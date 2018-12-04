public class Citizen : IIdentifiable, IBirthable
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Birthdate = birthdate;
        this.Id = id;
    }

    public string Birthdate { get; private set; }

    public string Id { get; private set; }
}

