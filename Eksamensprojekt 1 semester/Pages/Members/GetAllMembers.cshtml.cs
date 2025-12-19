using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Members;

public class GetAllMembersModel : PageModel
{
    #region Instancefields
    private IMemberRepository _memberRepository;
    #endregion

    #region Properties
    public List<Member> Members { get; private set; }

    [BindProperty]
    public string SearchString { get; set; }
    #endregion

    #region Constructors
    public GetAllMembersModel(IMemberRepository memberRepository)
    {
        _memberRepository =  memberRepository;
    }
    #endregion

    #region Methods
    public IActionResult OnPostNameSearch()
    {
        Members = _memberRepository.NameSearch(SearchString).ToList();
        return Page();
    }

    public void OnGet()
    {
        Members = _memberRepository.GetMembers();
    }
    #endregion
}
