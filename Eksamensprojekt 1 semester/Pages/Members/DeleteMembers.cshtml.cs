using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Members;

public class DeleteMembersModel : PageModel
{
    #region Instancefields
    private IMemberRepository _memberRepository;
    #endregion

    #region Properties
    [BindProperty]
    public Member Member { get; set; }
    #endregion

    #region Constructors
    public DeleteMembersModel(IMemberRepository memberRepository)
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
        Member deletedMember = _memberRepository.DeleteMember(Member.Id.Value);
        if (deletedMember == null)
            return RedirectToPage("GetAllMembers"); // Member findes ikke

        return RedirectToPage("GetAllMembers"); // Slettet succesfuldt
    }
    #endregion
}
