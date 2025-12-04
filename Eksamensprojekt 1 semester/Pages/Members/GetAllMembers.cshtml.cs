using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Members
{
    public class GetAllMembersModel : PageModel
    {
        public List<Member> Members { get; private set; }

        public void OnGet()
        {
            Members = MockMembers.GetMockMembers();
        }
    }
}
