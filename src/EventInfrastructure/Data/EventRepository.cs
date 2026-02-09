using EventCore.Entities;
using EventCore.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventInfrastructure.Data;

public class EventRepository(EventDbContext db) : IEventRepository
{
    private readonly EventDbContext _db = db;

    public IEnumerable<Event> GetAll()
    {
        return _db.Events.Include(e => e.Registrations).ToList();
    }

    public void Add(Event e)
    {
        _db.Events.Add(e);
        _db.SaveChanges();
    }
}