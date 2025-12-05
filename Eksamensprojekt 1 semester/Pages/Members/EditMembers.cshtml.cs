using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Members
{
    public class EditMembersModel : PageModel
    {
        private IMemberRepository _memberRepository;

        [BindProperty]
        public Member Member { get; set; }
        public EditMembersModel(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public IActionResult OnGet(int id)
        {
            Member = _memberRepository.GetMember(id);
            if (Member == null)
                return RedirectToPage("/NotFound");

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


    }
}
