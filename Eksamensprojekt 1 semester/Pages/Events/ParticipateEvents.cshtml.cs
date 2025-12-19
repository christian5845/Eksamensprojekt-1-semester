using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Models;

namespace Eksamensprojekt_1_semester.Pages.Events;

public class ParticipateEventsModel : PageModel
{
    #region Instancefields
    private IEventRepository _eventRepository;
    private  IMemberRepository _memberRepository;
    private  IEventParticipationRepository _participationRepository;
    #endregion

    #region Properties
    public Event Event { get; set; }
    public List<Member> Members { get; set; }

    [BindProperty]
    public int EventId { get; set; }

    [BindProperty]
    public int MemberId { get; set; }
    #endregion

    #region Constructors
    public ParticipateEventsModel(
        IEventRepository eventRepository,
        IMemberRepository memberRepository,
        IEventParticipationRepository participationRepository)
    {
        _eventRepository = eventRepository;
        _memberRepository = memberRepository;
        _participationRepository = participationRepository;
    }
    #endregion

    #region Methods
    public IActionResult OnGet(int id)
    {
        Event = _eventRepository.GetEvent(id);
        Members = _memberRepository.GetMembers();
        EventId = id;
        return Page();
    }

    public IActionResult OnPost()
    {
        _participationRepository.AddParticipant(EventId, MemberId);
        return RedirectToPage("GetAllEvents");
    }
    #endregion
}
