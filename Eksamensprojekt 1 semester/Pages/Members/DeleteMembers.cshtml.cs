using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Members
{
    public class DeleteMembersModel : PageModel
    {
        private IMemberRepository _memberRepository;

        public DeleteMembersModel(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        [BindProperty]
        public Member Member { get; set; }
        public IActionResult OnGet(int id)
        {
            Member = _memberRepository.GetMember(id);
            if (Member == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }

        public IActionResult OnPost()
        {
            Member deletedMember = _memberRepository.DeleteMember(Member.Id.Value);
            if (deletedMember == null)
                return RedirectToPage("/NotFound"); // Member findes ikke

            return RedirectToPage("GetAllMembers"); // Slettet succesfuldt
        }



    }
}
