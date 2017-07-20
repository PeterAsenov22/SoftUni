public class Citizen:IPerson,IBirthable,IIdentifiable
{
    public string Name { get; private set; }

    public int Age { get; private set; }

    public string Birthdate { get; private set; }

    public string ID { get; private set; }

    public Citizen(string name, int age, string id, string birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.ID = id;
        this.Birthdate = birthdate;
    }   
}
