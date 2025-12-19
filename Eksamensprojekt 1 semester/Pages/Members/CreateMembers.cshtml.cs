using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Members;

public class CreateMembersModel : PageModel
{
    #region Instancefields
    private IMemberRepository _memberRepository;
    #endregion

    #region Properties
    [BindProperty]
    public Member Member { get; set; }
    #endregion

    #region
    public CreateMembersModel(IMemberRepository memberRepository)
    {
        _memberRepository = memberRepository;
    }
    #endregion

    #region Methods
    public IActionResult OnGet()
    {
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _memberRepository.AddMember(Member);
        return RedirectToPage("GetAllMembers");
    }
    #endregion
}
