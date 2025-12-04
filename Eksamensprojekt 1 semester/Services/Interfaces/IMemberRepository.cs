using Eksamensprojekt_1_semester.Models;
namespace Eksamensprojekt_1_semester.Services.Interfaces
{
    public interface IMemberRepository
    {
        List<Member> GetMembers();

        void AddMember(Member member);
    }
}
