using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.MockData
{
    public class MockBookings
    {
        private static List<Member> _members = new List<Member>
    {
        new Member(1, "Anna", 19, "12 34 56 78", "anna@example.com"),
        new Member(2, "Oliver", 21, "87 65 43 21", "oliver@example.com"),
        new Member(3, "Louise", 24, "11 22 33 44", "louise@example.com")
    };
        public static List<Member> GetMockMembers() { return _members; }
    }
}
