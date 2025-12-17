using Eksamensprojekt_1_semester.Models;
using Eksamensprojekt_1_semester.Services.Interfaces;
using Eksamensprojekt_1_semester.Services.Json;

namespace Eksamensprojekt_1_semester.Services.Repositories;

// Implementering af IBoatRepository interfacet.
public class BoatRepository : IBoatRepository
{
    // Liste til at gemme bådene midlertidigt.
    private List<Boat> _boats;

    // Dependency Injection af JsonFileBoatService og IIDLogRepository.
    private JsonFileBoatService JsonFileBoatService;
    private IIDLogRepository _iIDLogRepository;

    // Constructor til at initialisere repository'et med data fra JSON-filen.
    public BoatRepository(JsonFileBoatService jsonFileBoatService,IIDLogRepository iIDLogRepository)
    {
        JsonFileBoatService = jsonFileBoatService;
        _iIDLogRepository = iIDLogRepository;
        _boats = JsonFileBoatService.GetJsonBoats().ToList();

    }

    // Metode til at hente alle både.
    public List<Boat> GetBoats()
    {
        return _boats;
    }

    // Metode til at tilføje en ny båd.
    public void AddBoat(Boat boat)
    {
        boat.Id = _iIDLogRepository.GetNewBoatID();
        _boats.Add(boat);
        JsonFileBoatService.SaveJsonBoats(_boats);
    }

    // Metode til at hente en båd baseret på dens ID.
    public Boat GetBoat(int id)
    {
        foreach (Boat boat in _boats)
        {
            if (boat.Id == id)
                return boat;
        }

        return null;
    }

    // Metode til at opdatere en eksisterende båd.
    public void UpdateBoat(Boat boat)
    {
        if (boat != null)
        {
            foreach (Boat b in _boats)
            {
                if (b.Id == boat.Id)
                {
                    b.Type = boat.Type;
                    b.Size = boat.Size;
                    b.PricePerDay = boat.PricePerDay;
                }
            }
            JsonFileBoatService.SaveJsonBoats(_boats);
        }
    }

    // Metode til at slette en båd baseret på dens ID.
    public Boat DeleteBoat (int? boatId)
    {
        Boat boatToBeDeleted = null;
        foreach (Boat boat in _boats)
        {
            if (boat.Id == boatId)
            {
                boatToBeDeleted = boat;
                break;
            }
        }

        if (boatToBeDeleted != null)
        {
            _boats.Remove(boatToBeDeleted);
            JsonFileBoatService.SaveJsonBoats(_boats);
        }

        return boatToBeDeleted;
    }

    // Metode til at søge både baseret på deres type.
    public IEnumerable<Boat> GetBoatByType(string type)
    {
        List<Boat> typeSearch = new List<Boat>();
        foreach (Boat boat in _boats)
        {
            if (string.IsNullOrEmpty(type) || boat.Type.ToLower().Contains(type.ToLower()))
            {
                typeSearch.Add(boat);
            }
        }
        return typeSearch;
    }

    // Metode til at filtrere både baseret på prisinterval.
    public IEnumerable<Boat> PriceFilter(double maxPrice, double minPrice = 0)
    {
        List<Boat> filterList = new List<Boat>();
        foreach (Boat boat in _boats)
        {
            if ((minPrice == 0 && boat.PricePerDay <= maxPrice) ||
                (maxPrice == 0 && boat.PricePerDay >= minPrice) ||
                (boat.PricePerDay >= minPrice && boat.PricePerDay <= maxPrice))
            {
                filterList.Add(boat);
            }
        }

        return filterList;
    }
}
