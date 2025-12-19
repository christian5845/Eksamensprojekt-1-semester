using System.ComponentModel.DataAnnotations;

namespace Eksamensprojekt_1_semester.Models;

    public class Member
{
    #region properties
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
    #endregion

    #region constructors

    public Member() { }

    public Member(string name, int age, string phoneNumber, string email)
    {
        Name = name;
        Age = age;
        PhoneNumber = phoneNumber;
        Email = email;
    }
    #endregion
}
