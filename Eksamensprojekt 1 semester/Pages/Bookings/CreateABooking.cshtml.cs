using Eksamensprojekt_1_semester.MockData;
using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eksamensprojekt_1_semester.Pages.Bookings;

public class CreateABookingModel : PageModel
{
    private IBookABoatRepository _iBookABoatRepository;
    [BindProperty]
    public List<Member> MemberList { get; set; }

    [BindProperty]
    public Booking TheBooking { get; set; }
    [BindProperty]
    public Member Member { get; set; }
    [BindProperty]
    public Boat TheBookedBoat { get; set; }


    public CreateABookingModel(IBookABoatRepository iBookABoatRepository)
    {
        _iBookABoatRepository = iBookABoatRepository;
    }
    public IActionResult OnGet(int id)
    {
        MemberList = _iBookABoatRepository.GetMembers();
        TheBookedBoat = _iBookABoatRepository.GetBoat(id);
        if (TheBookedBoat == null)
            return RedirectToPage("/BookABoat");
        return Page();
    }

    public IActionResult OnPost()
    {
        MemberList = _iBookABoatRepository.GetMembers();
        string memberIDString = Request.Form["Member"];
        int memberIDInt = 0;
        Int32.TryParse(memberIDString, out memberIDInt);

        foreach (var m in MemberList)
        {
            if(memberIDInt == m.Id)
            {
                TheBooking.TheBookingMember = m;
            }
        }
        TheBooking.BookedBoat = TheBookedBoat;
        _iBookABoatRepository.AddABooking(TheBooking);
        return RedirectToPage("BookedBoats");
    }
}
