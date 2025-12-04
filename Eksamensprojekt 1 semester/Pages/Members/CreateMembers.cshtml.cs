using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Members
{
    public class CreateMembersModel : PageModel
    {
        private IMemberRepository _memberRepository;

        [BindProperty]
        public Member Member { get; set; }
        public CreateMembersModel(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }
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

    }
}
