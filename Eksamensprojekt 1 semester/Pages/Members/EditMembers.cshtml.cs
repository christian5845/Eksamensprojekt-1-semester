using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Members;

public class EditMembersModel : PageModel
{
    #region Instancefields
    private IMemberRepository _memberRepository;
    #endregion

    #region properties
    [BindProperty]
    public Member Member { get; set; }
    #endregion

    #region Constructors
    public EditMembersModel(IMemberRepository memberRepository)
    {
        _memberRepository = memberRepository;
    }
    #endregion

    #region Methods
    public IActionResult OnGet(int id)
    {
        Member = _memberRepository.GetMember(id);
        if (Member == null)
        {
            return RedirectToPage("GetAllMembers");
        }
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _memberRepository.UpdateMember(Member);
        return RedirectToPage("GetAllMembers");
    }
    #endregion
}
