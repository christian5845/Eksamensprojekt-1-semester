using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Json;

namespace Eksamensprojekt_1_semester.Services.Repositories;

public class BoatDescriptionRepository : IBoatDescriptionRepository
{
    private List<BoatDescription> _boatDescriptions;
    private List<Boat> _boats;
    private JsonFileBoatDescriptionService _jsonBoatDescriptionService;
    private JsonFileBoatService _jsonBoatService;

    public BoatDescriptionRepository(JsonFileBoatDescriptionService jsonBoatDescriptionService,JsonFileBoatService jsonFileBoatService)
    {
        _jsonBoatDescriptionService = jsonBoatDescriptionService;
        _boatDescriptions = _jsonBoatDescriptionService.GetJsonBoatDescriptions().ToList();
        _boats = _jsonBoatService.GetJsonBoats().ToList();
    }

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
}
