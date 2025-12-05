using System.ComponentModel.DataAnnotations;

namespace Eksamensprojekt_1_semester.Models;

    public class Member
{
    [Display(Name = "Medlems ID")]
    [Required(ErrorMessage = "Der skal angives et ID til medlemmet")]
    [Range(1, 10000, ErrorMessage = "ID skal være mellem {1} og {2}")]
    public int? Id { get; set; }

    [Display(Name = "Navn")]
    [Required(ErrorMessage = "Medlemmet skal have et navn")]
    [StringLength(50, ErrorMessage = "Navnet må maks være {1} tegn")]
    public string? Name { get; set; }

    [Display(Name = "Alder")]
    [Required(ErrorMessage = "Der skal angives en alder")]
    [Range(0, 150, ErrorMessage = "Alder skal være mellem {1} og {2}")]
    public int? Age { get; set; }

    [Display(Name = "Telefonnummer")]
    [Required(ErrorMessage = "Der skal angives et telefonnummer")]
    [Phone(ErrorMessage = "Ugyldigt telefonnummer")]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Email")]
    [Required(ErrorMessage = "Der skal angives en email")]
    [EmailAddress(ErrorMessage = "Ugyldig email")]
    public string? Email { get; set; }

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
