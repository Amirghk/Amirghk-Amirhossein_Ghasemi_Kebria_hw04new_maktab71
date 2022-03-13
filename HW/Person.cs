public class Person
{
    public string firstName;
    public string lastName;
    public int height;
    public string phoneNumber;
    public string fatherName;
    public int weight;
    public DateTime birthDate;
    public string address;
    public string id;
    public Person(string name, string lastName, int height, string phoneNumber, string fatherName, int weight, DateTime birthdate, string address, string id)
    {
        this.firstName = name;
        this.lastName = lastName;
        this.height = height;
        this.phoneNumber = phoneNumber;
        this.fatherName = fatherName;
        this.weight = weight;
        this.birthDate = birthdate;
        this.address = address;
        this.id = id;
    }

    public override string ToString()
    {
        return $"{firstName}--{lastName}--{id}";
    }
}