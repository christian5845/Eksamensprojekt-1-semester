using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Json;

namespace Eksamensprojekt_1_semester.Services.Repositories
{
  public class MemberRepository : IMemberRepository
  {
    private List<Member> _members;

    private JsonFileMemberService _jsonFileMemberService;

    public MemberRepository(JsonFileMemberService jsonFileMemberService)
    {
      _jsonFileMemberService = jsonFileMemberService;

      _members = _jsonFileMemberService
                  .GetJsonMembers()
                  .ToList();
    }

    public List<Member> GetMembers()
    {
      return _members;
    }

    public void AddMember(Member member)
    {
      _members.Add(member);
      _jsonFileMemberService.SaveJsonMembers(_members);
    }

    public IEnumerable<Member> NameSearch(string str)
    {
      List<Member> nameSearch = new List<Member>();

      foreach (Member member in _members)
      {
        if (string.IsNullOrEmpty(str) ||
            member.Name.ToLower().Contains(str.ToLower()))
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

        _jsonFileMemberService.SaveJsonMembers(_members);
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
      Member memberToDelete = null;

      foreach (Member member in _members)
      {
        if (member.Id == id)
        {
          memberToDelete = member;
          break;
        }
      }

      if (memberToDelete != null)
      {
        _members.Remove(memberToDelete);
        _jsonFileMemberService.SaveJsonMembers(_members);
      }

      return memberToDelete;
    }
  }
}
