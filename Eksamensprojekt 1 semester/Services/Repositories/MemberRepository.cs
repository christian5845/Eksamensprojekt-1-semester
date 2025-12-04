using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Services.Interfaces;

namespace Eksamensprojekt_1_semester.Services.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private List<Member> _members;
        public MemberRepository() 
        {
            _members = MockBookings.GetMockMembers();
        }

        public List<Member> GetMembers() 
        { 
        return _members;
        }

        public void AddMember(Member member) 
        { 
        _members.Add(member);
        }
    }
}
