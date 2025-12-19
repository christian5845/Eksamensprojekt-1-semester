using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.Services.Interfaces;
//Troels
public interface IMemberRepository
{
    List<Member> GetMembers();
    IEnumerable<Member> NameSearch(string str);
    void AddMember(Member member);
    void UpdateMember(Member member);
    Member GetMember(int id);
    Member DeleteMember(int id);
}
