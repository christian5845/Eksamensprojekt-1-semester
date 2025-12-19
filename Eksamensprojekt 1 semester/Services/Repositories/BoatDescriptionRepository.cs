using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Json;

namespace Eksamensprojekt_1_semester.Services.Repositories;
//Rasmus
public class BoatDescriptionRepository : IBoatDescriptionRepository
{
    #region Instancefields
    private List<BoatDescription> _boatDescriptions;
    private List<Boat> _boats;
    private JsonFileBoatDescriptionService _jsonBoatDescriptionService;
    private JsonFileBoatService _jsonBoatService;
    #endregion

    #region Constructors
    public BoatDescriptionRepository(JsonFileBoatDescriptionService jsonBoatDescriptionService,JsonFileBoatService jsonFileBoatService)
    {
        _jsonBoatDescriptionService = jsonBoatDescriptionService;
        _jsonBoatService = jsonFileBoatService;
        _boatDescriptions = _jsonBoatDescriptionService.GetJsonBoatDescriptions().ToList();
        _boats = _jsonBoatService.GetJsonBoats().ToList();
    }
    #endregion

    #region Methods
    public void AddBoatDescription(string type)
    {
        BoatDescription boatDescription = new BoatDescription(type);
        _boatDescriptions.Add(boatDescription);
        _jsonBoatDescriptionService.SaveJsonBoatDescriptions(_boatDescriptions);
    }

    public void EditBoatDescription(BoatDescription boatDescription)
    {
        if(boatDescription!=null)
        {
            foreach(var bd in _boatDescriptions)
            {
                if(boatDescription.Type==bd.Type)
                {
                    bd.Description = boatDescription.Description;
                }
            }
            _jsonBoatDescriptionService.SaveJsonBoatDescriptions(_boatDescriptions);
        }
    }

    public Boat GetBoat(int id)
    {
        foreach(var boat in _boats)
        {
            if(boat.Id == id)
            {
                return boat;
            }
        }
        return null;
    }

    public BoatDescription GetBoatDescription(string boatType)
    {
        foreach(var boatdescription in _boatDescriptions)
        if(boatType == boatdescription.Type)
            {
                return boatdescription;
            }
        return null;
    }

    public List<BoatDescription> GetBoatDescriptions()
    {
        return _boatDescriptions;
    }

    public List<Boat> GetBoats()
    {
        return _boats;    
    }
    #endregion
}
