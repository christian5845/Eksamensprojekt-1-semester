using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Members
{
    public class GetAllMembersModel : PageModel
    {
        public List<Member> Members { get; private set; }

        private IMemberRepository _memberRepository;

        public GetAllMembersModel(IMemberRepository memberRepository)
        {
            _memberRepository =  memberRepository;
        }

        public void OnGet()
        {
            Members = _memberRepository.GetMembers();
        }
    }
}
