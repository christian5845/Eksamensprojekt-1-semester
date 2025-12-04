namespace Eksamensprojekt_1_semester.Models;

    public class Member
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Member() { }

    public Member(int id, string name, int age, string phoneNumber, string email)
    {
        Id = id;
        Name = name;
        Age = age;
        PhoneNumber = phoneNumber;
        Email = email;
    }
}
