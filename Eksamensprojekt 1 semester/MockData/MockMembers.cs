using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.MockData
{
    public class MockMembers
    {
        private static List<Member> _members = new List<Member>
    {
        new Member(1, "Anna", 19),
        new Member(2, "Oliver", 21),
        new Member(3, "louise", 24)
    };
        public static List<Member> GetMockMembers() { return _members; }
    }
}
