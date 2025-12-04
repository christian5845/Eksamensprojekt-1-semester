namespace Eksamensprojekt_1_semester.Models;

    public class Member
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Member() { }

    public Member(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}
