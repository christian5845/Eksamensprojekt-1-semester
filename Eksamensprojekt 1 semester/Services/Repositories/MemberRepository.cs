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


        public IEnumerable<Member> NameSearch(string str)
        {
            List<Member> nameSearch = new List<Member>();
            foreach (Member member in _members)
            {
                if (string.IsNullOrEmpty(str) || member.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(member);
                }
            }

            return nameSearch;
        }
        public void UpdateMember(Member member)
        {
            if (member != null)
            {
                foreach (Member m in _members)
                {
                    if (m.Id == member.Id)
                    {
                        m.Name = member.Name;
                        m.Age = member.Age;
                        m.PhoneNumber = member.PhoneNumber;
                        m.Email = member.Email;
                    }
                }
            }
        }
        public Member GetMember(int id)
        {
            foreach (var m in _members)
            {
                if (m.Id == id)
                    return m;
            }
            return null; 
        }
        public Member DeleteMember(int id)
        {
            foreach(Member member in _members)
                { 
                if 
                    (member.Id == id) 
                { 
                    _members.Remove(member);
                    return member;
                } 
            }
            return null;
        }

    }
}
