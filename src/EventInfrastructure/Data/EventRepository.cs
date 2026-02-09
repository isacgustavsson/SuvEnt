using EventCore.Entities;
using EventCore.Interfaces;

namespace EventInfrastructure.Data;

public class EventRepository(EventDbContext db) : IEventRepository
{
    private readonly EventDbContext _db = db;
    public void Add(Event e)
    {
        _db.Events.Add(e);
        _db.SaveChanges();
    }
}